using BrightIdeasSoftware;
using MST.MES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Pakowanie_LED_v._2.DataStorage.VisualInspectionResults;

namespace Pakowanie_LED_v._2.DataStorage
{
    public class CurrentBoxData
    {
        public static ObjectListView olvBoxingList;
        public static Label lQtyInBox;
        public class CurrentBoxDataStruct
        {
            public MST.MES.OrderStructureByOrderNo.TestRecord TestResult { get; set; }
            public  VisualInspectionResults.VisualInspectionStruct VisualInspectionResult { get; set; }
            public  MST.MES.OrderStructureByOrderNo.BoxingInfo BoxingData { get; set; }
            public  int moduleNo { get; set; }
            public  string ModuleSerialNo { get { return BoxingData.serialNo; } }
            public  DateTime BoxingDate { get { return BoxingData.boxingDate; } }
            public  bool ReworkApproved
            {
                get
                {
                    try
                    {
                        if (TestResult.testTime > VisualInspectionResult.reworkDatetime & VisualInspectionResult.CurrentOverallState & TestResult.testResultOk) return true;
                        else return false;
                    }
                    catch
                    {
                        return false;
                    }
                }
            }
            public  string TestResultString
            {
                get
                {
                    if(!string.IsNullOrWhiteSpace(TestResult.serialNo))
                    {
                        return TestResult.testResultOk ? "OK" : "NG"+TestResult.ngTyppe;
                    }
                    return "Brak testu";
                }
            }
            public  string ViResultString
            {
                get
                {
                    
                    if(VisualInspectionResult.viInspectionResult != null)
                    {
                        if (VisualInspectionResult.CurrentOverallState) return "OK (N)";
                        return VisualInspectionResult.viInspectionResult;
                    }
                    return "OK";//no record in db = OK
                }
            }
            public  string Status
            {
                get
                {
                    return "s";
                }
            }
        }
        public static List<CurrentBoxDataStruct> CurrentBoxingList { get; set; }
        public static string CurrentBoxId { get; set; }
        public static string CurrentBoxOrderNo
        {
            get
            {
                return CurrentBoxId.Split('_')[1];
            }
        }
        public static string CurrentBox10Nc
        {
            get
            {
                return CurrentBoxId.Split('_')[0].Replace("K:", "");
            }
        }
        public static bool AllModulesInBoxTestsOK
        {
            get
            {
                var testNG = CurrentBoxingList.Select(x => x.TestResult.testResultOk).Where(t => !t).Any();
                var viNG = CurrentBoxingList.Select(x => x.ViResultString).Where(v => !v.StartsWith("OK")).Any();
                if (testNG || viNG) return false;
                return true;
            }
        }
        
        public static void AddModuleToBox(string moduleSerialNo)
        {
            var serialSplitted = moduleSerialNo.Split('_');
            if (serialSplitted.Length != 3)
            {
                MessageBox.Show($"Nie poprawny kod QR {moduleSerialNo}");
                return;
            }

            var pcbOrderNo = serialSplitted[1];
            var boxOrderNo = CurrentBoxId.Split('_')[1];

            CurrentBoxDataStruct newItem = new CurrentBoxDataStruct
            {
                BoxingData = new OrderStructureByOrderNo.BoxingInfo
                {
                    boxId = CurrentBoxId,
                    serialNo = moduleSerialNo,
                    boxingDate = DateTime.Now,
                    orderNoPcb = pcbOrderNo,
                    orderNoBox = boxOrderNo
                    },
                TestResult = new OrderStructureByOrderNo.TestRecord(),
                VisualInspectionResult = new VisualInspectionStruct(),
                moduleNo = CurrentBoxingList.Count + 1,
            };
            CurrentBoxingList.Add(newItem);
            MST.MES.SqlOperations.Boxing.InsertNewPcbToBoxSqlTable(moduleSerialNo, CurrentBoxId, DateTime.Now);
            BackgroundWorker bw = new BackgroundWorker();
            //myTimer.Elapsed += new ElapsedEventHandler((sender, e) => PlayMusicEvent(sender, e, musicNote));

            bw.DoWork += new DoWorkEventHandler((sender, e) => Bw_DoWork(sender, e, newItem));
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler((sender, e) => Bw_RunWorkerCompleted(sender, e, newItem));
            bw.RunWorkerAsync();
        }
        private static void Bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e, CurrentBoxDataStruct newItem)
        {
            olvBoxingList.RefreshObject(newItem);
            lQtyInBox.Text = CurrentBoxingList.Count().ToString();
        }

        private static void Bw_DoWork(object sender, DoWorkEventArgs e, CurrentBoxDataStruct newItem)
        {
            newItem.TestResult = TestResults.GetTestRecordsForPcbs(new string[] { newItem.ModuleSerialNo })[newItem.ModuleSerialNo];
            newItem.VisualInspectionResult = VisualInspectionResults.GetViRecordsForPcbs(new string[] { newItem.ModuleSerialNo })[newItem.ModuleSerialNo];
        }

        private  static void LoadBox(string boxSerialNo)
        {
            var pckData = MST.MES.SqlDataReaderMethods.Boxing.GetBoxingForBoxId(boxSerialNo);
            var pcbSerials = pckData.Select(b => b.serialNo).ToArray();
            
            if (pcbSerials.Any())
            {
                foreach (var pcbEntry in pckData.OrderBy(b=>b.boxingDate))
                {
                    CurrentBoxingList.Add(new CurrentBoxDataStruct
                    {
                        BoxingData = pcbEntry,
                        TestResult = new OrderStructureByOrderNo.TestRecord(),
                        VisualInspectionResult = new VisualInspectionStruct(),
                        moduleNo = CurrentBoxingList.Count + 1
                    });
                }

                AddTestAndInspectionToBox(pcbSerials);
            }
        }

        internal static void RemovePcbFromBox(string qrCode)
        {
            var matchingPcb = CurrentBoxingList.Where(x => x.ModuleSerialNo == qrCode);
            if (!matchingPcb.Any())
            {
                MessageBox.Show("Brak podanego kodu w kartonie.");
                return;
            }
            MST.MES.SqlOperations.Boxing.DeletePcbFromBoxSqlTable(qrCode);
            olvBoxingList.SetObjects(CurrentBoxingList);
        }

        private static void AddTestAndInspectionToBox(string[] pcbs)
        {
            Dictionary<string, OrderStructureByOrderNo.TestRecord> testResults = new Dictionary<string, OrderStructureByOrderNo.TestRecord>();
            Dictionary<string, VisualInspectionStruct> viResults = new Dictionary<string, VisualInspectionStruct>();
            //List<Task> taskList = new List<Task>();
            //taskList.Add(Task.Run(() => testResults = TestResults.GetTestRecordsForPcbs(pcbs)));
            //taskList.Add(Task.Run(() => viResults = VisualInspectionResults.GetViRecordsForPcbs(pcbs)));
            //Task.WhenAll(taskList.ToArray()).ConfigureAwait(true);

            testResults = TestResults.GetTestRecordsForPcbs(pcbs);
            viResults = VisualInspectionResults.GetViRecordsForPcbs(pcbs);
            foreach (var pcb in pcbs)
            {
                var curBoxPcb = CurrentBoxingList.Where(x => x.ModuleSerialNo == pcb).First();

                curBoxPcb.TestResult = testResults[pcb];
                curBoxPcb.VisualInspectionResult = viResults[pcb];
            }
        }

        public static void SetUpNewBox(string boxSerialNo)
        {
            CurrentBoxId = boxSerialNo;
            CurrentBoxingList = new List<CurrentBoxDataStruct>();
            LoadBox(boxSerialNo);
            lQtyInBox.Text = CurrentBoxingList.Count().ToString(); 
        }
        
    }
}
