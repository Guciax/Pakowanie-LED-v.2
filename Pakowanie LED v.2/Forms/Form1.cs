using BrightIdeasSoftware;
using Pakowanie_LED_v._2.DataStorage;
using Pakowanie_LED_v._2.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Pakowanie_LED_v._2.DataStorage.CurrentBoxData;

namespace Pakowanie_LED_v._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CurrentOrderBoxing.lOtherBoxesInfo = lOtherBoxesInfo;
            CurrentBoxData.lQtyInBox = lQtyInBox;
            CurrentBoxData.olvBoxingList = olvCurrentBox;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = tbScanQr;
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            string version = fvi.FileVersion;
            this.Text += version;
        }
        private void tbScanQr_Leave(object sender, EventArgs e)
        {
            this.ActiveControl = tbScanQr;
        }
        private void bNewBox_Click(object sender, EventArgs e)
        {
            using (Forms.ScanQr scanForm = new Forms.ScanQr())
            {
                if (scanForm.ShowDialog() == DialogResult.OK)
                {
                    CurrentBoxData.SetUpNewBox(scanForm.qrCode);
                    olvCurrentBox.SetObjects(CurrentBoxData.CurrentBoxingList);
                    CurrentOrderBoxing.ReloadBoxes();
                    lBoxNo.Text = CurrentBoxData.CurrentBoxId;
                }
            }
        }
        private void tbScanQr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                string serialNo = tbScanQr.Text;
                tbScanQr.Text = "";
                var splittedSerial = serialNo.Split('_');
                if (splittedSerial.Length != 3)
                {
                    MessageBox.Show($"Nie prawidłowy kod QR {serialNo}");
                    return;
                }
                string pcb10Nc = splittedSerial[0];
                string pcbOrderNo = splittedSerial[1];

                if (pcb10Nc != CurrentBoxData.CurrentBox10Nc)
                {
                    MessageBox.Show("Nie prawidłowy numer 12NC !!!" + Environment.NewLine
                        + $"12NC opakowania: {CurrentBoxData.CurrentBox10Nc}" + Environment.NewLine
                        + $"12NC kodu QR: {pcb10Nc}");
                    return;
                }

                CurrentBoxData.AddModuleToBox(serialNo);
                olvCurrentBox.SetObjects(CurrentBoxData.CurrentBoxingList);
                CurrentOrderBoxing.ReloadBoxes();
            }
        }
        private void objectListView1_BeforeSorting(object sender, BrightIdeasSoftware.BeforeSortingEventArgs e)
        {
            var s = new OLVColumn();
            s.AspectGetter = (o) => ((CurrentBoxData.CurrentBoxDataStruct)o).moduleNo;

            olvCurrentBox.ListViewItemSorter = new ColumnComparer(
                        s, SortOrder.Descending, e.ColumnToSort, e.SortOrder);
            e.Handled = true;
        }
        private void olvCurrentBox_FormatRow(object sender, FormatRowEventArgs e)
        {
            CurrentBoxDataStruct item = (CurrentBoxDataStruct)e.Model;
            if (!item.TestResultString.StartsWith("OK"))
            {
                e.Item.BackColor = Color.Red;
                e.Item.ForeColor = Color.White;
            }
            if (!item.ViResultString.StartsWith("OK"))
            {
                e.Item.BackColor = Color.Red;
                e.Item.ForeColor = Color.White;
            }
        }
        private void tCheckNg_Tick(object sender, EventArgs e)
        {
            var viNg = CurrentBoxData.CurrentBoxingList.Where(i => !i.VisualInspectionResult.CurrentOverallState).ToList();
            var testNg = CurrentBoxingList.Where(i => !i.TestResult.testResultOk).ToList();

            BackgroundWorker bw = new BackgroundWorker();
            bw.DoWork += new DoWorkEventHandler((sender1, e1) => Bw_DoWork(sender1, e1, viNg, testNg));
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler((sender2, e2) => Bw_RunWorkerCompleted(sender2, e2, viNg, testNg));
            bw.RunWorkerAsync();
        }
        private void Bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e, List<CurrentBoxDataStruct> viNg, List<CurrentBoxDataStruct> testNg)
        {
            olvBoxingList.SetObjects(CurrentBoxingList);
        }
        private void Bw_DoWork(object sender, DoWorkEventArgs e, List<CurrentBoxDataStruct> viNgList, List<CurrentBoxDataStruct> testNgList)
        {
            var testResults = TestResults.GetTestRecordsForPcbs(testNgList.Select(x => x.ModuleSerialNo).ToArray());
            var viResults = VisualInspectionResults.GetViRecordsForPcbs(viNgList.Select(x => x.ModuleSerialNo).ToArray());

            foreach (var testResultEntry in testResults)
            {
                var testNg = testNgList.Where(x => x.ModuleSerialNo == testResultEntry.Key).First();
                testNg.TestResult = testResultEntry.Value;
            }

            foreach (var viResultEntry in viResults)
            {
                var viResult = testNgList.Where(x => x.ModuleSerialNo == viResultEntry.Key).First();
                viResult.VisualInspectionResult = viResultEntry.Value;
            }
        }
        private void bRemoveModule_Click(object sender, EventArgs e)
        {
            using (ScanQr scanForm = new ScanQr())
            {
                if (scanForm.ShowDialog() == DialogResult.OK)
                {
                    var boxInfo = MST.MES.SqlDataReaderMethods.Boxing.GetBoxingForSerialNo(scanForm.qrCode);
                    if (boxInfo == null)
                    {
                        MessageBox.Show("Brak kodu w bazie danych");
                        return;
                    }
                    if (boxInfo.moveToWarehouseDate != null)
                    {
                        MessageBox.Show("Ten wyrób został przesunięty na magazyn, nie można go usunąć z bazy danych." + Environment.NewLine
                            + "Aby przesnieść go do innego kartonu użyj funkcji przenieś");
                        return;
                    }
                    CurrentBoxData.RemovePcbFromBox(scanForm.qrCode);
                }
            }
        }
        private void bMoveModule_Click(object sender, EventArgs e)
        {
            using (MovePcbToBox scanForm = new MovePcbToBox())
            {
                if (scanForm.ShowDialog() == DialogResult.OK)
                {
                    olvBoxingList.SetObjects(CurrentBoxingList);
                }
            }
        }
        private void bRemoveBox_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("UWAGA!!!" + Environment.NewLine + "Spowoduje to usunięcie całego kartonu i wszystkich paneli." + Environment.NewLine + Environment.NewLine + "Czy na pewno chcesz kontynuować", "Usunięcie kartonu", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var boxData = MST.MES.SqlDataReaderMethods.Boxing.GetBoxingForBoxId(CurrentBoxId);
                if (boxData.Where(m => m.moveToWarehouseDate != null).Any())
                {
                    MessageBox.Show("Ten karton zawiera wyroby przesunięte na magazyn. Nie można usunąc kartonu");
                    return;
                }
                MST.MES.SqlOperations.Boxing.DeleteBox(CurrentBoxId);
                CurrentBoxData.SetUpNewBox(CurrentBoxId);
            }
        }
        private void bMoveBox_Click(object sender, EventArgs e)
        {
            using (ChangeBoxId changeBoxForm = new ChangeBoxId())
            {
                if (changeBoxForm.ShowDialog() == DialogResult.OK)
                {
                    CurrentBoxData.SetUpNewBox(changeBoxForm.newBoxId);
                }
            }
        }

        private void olvCurrentBox_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void olvCurrentBox_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e)
        {
            e.Item.SubItems[3].Font = new Font(e.Item.SubItems[3].Font, FontStyle.Underline);
        }
    }
}
    

