using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Pakowanie_LED_v._2.DataStorage.CurrentBoxData;

namespace Pakowanie_LED_v._2.Forms
{
    public partial class ShowNgInfo : Form
    {
        private readonly CurrentBoxDataStruct pcbData;
        MST.MES.OrderStructureByOrderNo.Kitting kittingData;

        string registrDate = "-";
        string registrOperatorName = "-";
        string viResult = "OK";
        string ngReason = "-";

        string reworkResult = "-";
        string reworkDate = "-";
        string oqaResult = "-";
        string viPostReworkResult = "-";
        string testDate = "Brak";
        string testResult = "Brak";

        Image[] ngImages = new Image[] { };
        Image[] reworkImages = new Image[] { };

        public ShowNgInfo(CurrentBoxDataStruct pcbData)
        {
            InitializeComponent();
            this.pcbData = pcbData;
        }

        private void ShowNgInfo_Load(object sender, EventArgs e)
        {
            this.Text += $"  - {pcbData.BoxingData.serialNo}";
            if (pcbData.ViResultString == null) return;
            if (pcbData.VisualInspectionResult == null) return;

            foreach (var ngEntry in pcbData.VisualInspectionResult.InspectionRecords)
            {
                registrDate = ngEntry.ngRegistrationDate.ToString("HH:mm:ss dd-MM-yyyy");
                registrOperatorName = ngEntry.viOperator;
                ngReason = ngEntry.ngReason;


                if (ngEntry.reworkDatetime.HasValue)
                {
                    reworkResult = ngEntry.reworkOK.Value ? "OK" : "NG";
                    reworkDate = ngEntry.reworkDatetime.Value.ToString("HH:mm:ss dd-MM-yyyy");
                }
                if (ngEntry.oqaInspectionOk.HasValue) { oqaResult = ngEntry.oqaInspectionOk.Value ? "OK" : "NG"; }
                if (ngEntry.postReworkViOK.HasValue) { viPostReworkResult = ngEntry.postReworkViOK.Value ? "OK" : "NG"; }
                if (pcbData.TestResult != null)
                {
                    testResult = pcbData.TestResult.TestResultOK ? "OK" : "NG";
                    testDate = pcbData.TestResult.FuncTestTime.Value.ToString("HH:mm:ss dd-MM-yyyy");
                }
                dataGridView1.Rows.Add(
                registrDate,
                registrOperatorName,
                ngReason,
                viResult,
                reworkResult,
                reworkDate,
                oqaResult,
                viPostReworkResult,
                testResult,
                testDate
                );
            }

            

            //BackgroundWorker bw = new BackgroundWorker();
            //bw.DoWork += Bw_DoWork;
            //bw.RunWorkerCompleted += Bw_RunWorkerCompleted;
            //bw.RunWorkerAsync();
            
        }

        private void Bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //dataGridView1.Rows.Add(
            //    registrDate,
            //    registrOperatorName,
            //    ngReason,
            //    viResult,
            //    reworkResult,
            //    reworkDate,
            //    oqaResult,
            //    viPostReworkResult,
            //    testResult,
            //    testDate
            //    );

            //if (ngImages.Any())
            //{
            //    pbNg.Image = ngImages[0];
            //}
            //if (reworkImages.Any())
            //{
            //    pbRework.Image = reworkImages[0];
            //}
        }

        private void Bw_DoWork(object sender, DoWorkEventArgs e)
        {
            //kittingData = MST.MES.SqlDataReaderMethods.Kitting.GetOneOrderByDataReader(pcbData.BoxingData.orderNoPcb);
            //ngImages = MST.MES.ImagesTools.TryGetNgImageForPcbSerialNo(kittingData.orderNo, kittingData.kittingDate.ToString("dd-MM-yyyy"), pcbData.BoxingData.serialNo);
            //reworkImages = new Image[] { };
            //if (pcbData.VisualInspectionResult.reworkDatetime.HasValue)
            //{
            //    reworkImages = MST.MES.ImagesTools.TryGetReworkImageForPcbSerialNo(pcbData.VisualInspectionResult.reworkDatetime.Value, pcbData.BoxingData.serialNo);
            //}
        }
    }
}
