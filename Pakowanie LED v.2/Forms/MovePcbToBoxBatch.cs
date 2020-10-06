using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pakowanie_LED_v._2.Forms
{
    public partial class MovePcbToBoxBatch : Form
    {
        List<PcbBoxingStruct> PcbList = new List<PcbBoxingStruct>();
        public string newBoxId = "";
        private class PcbBoxingStruct
        {
            public string SerialNo { get; set; }
            public string BoxId { get; set; }
            public string GraffitiLp100 { get; set; }
            public int QtyInLp100 { get; set; }
            public int NoInLp100 { get; set; }
            public string Lp100NoToDisplay
            {
                get
                {
                    if (QtyInLp100 == 0) return "";
                    return $"{NoInLp100}/{QtyInLp100}"; ;
                }
            }
        }
        public MovePcbToBoxBatch()
        {
            InitializeComponent();
        }

        private void MovePcbToBoxBatch_Load(object sender, EventArgs e)
        {

        }

        private void tbPcbSerialNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                e.Handled = true;
                string serialNo = tbPcbSerialNo.Text;
                tbPcbSerialNo.Text = "";
                if (PcbList.Where(p=>p.SerialNo == serialNo).Any())
                {
                    MessageBox.Show("Ten wyrób został już dodany.");
                    return;
                }

                PcbList.Add(new PcbBoxingStruct
                {
                    SerialNo = serialNo
                });

                BackgroundWorker bw = new BackgroundWorker();

                MST.MES.OrderStructureByOrderNo.BoxingInfo pcbBoxingData = new MST.MES.OrderStructureByOrderNo.BoxingInfo
                {
                    serialNo = serialNo
                };
                bw.DoWork += new DoWorkEventHandler((sender1, e1) => Bw_DoWork(sender1, e1, pcbBoxingData));
                bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler((e2, sender2) => Bw_RunWorkerCompleted(e2, sender2, pcbBoxingData));
                bw.RunWorkerAsync();
                objectListView1.SetObjects(PcbList);
            }
        }

        private void Bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e, MST.MES.OrderStructureByOrderNo.BoxingInfo pcbBoxingData) 
        {
            objectListView1.SetObjects(PcbList);
        }

        private void Bw_DoWork(object sender, DoWorkEventArgs e, MST.MES.OrderStructureByOrderNo.BoxingInfo pcbBoxingData)
        {
            var mesData = SqlBoxingConnection.GetBoxingForPcb(pcbBoxingData.serialNo);
            if(mesData != null)
            {
                pcbBoxingData = mesData;
                var lp100Qty = 0;
                if (!string.IsNullOrWhiteSpace(pcbBoxingData.movedByLp100))
                {
                    lp100Qty = SqlBoxingConnection.HowManyModulesMovedAsLp100(mesData.movedByLp100);
                }
                var listMatchingPcb = PcbList.Where(p => p.SerialNo == pcbBoxingData.serialNo).First();
                listMatchingPcb.BoxId = pcbBoxingData.boxId;
                listMatchingPcb.GraffitiLp100 = pcbBoxingData.movedByLp100.Replace("K:", "");
                listMatchingPcb.QtyInLp100 = lp100Qty;

                var lp100MatchingPcb = PcbList.Where(p => p.GraffitiLp100 == pcbBoxingData.movedByLp100).Count();
                listMatchingPcb.NoInLp100 = lp100MatchingPcb;
            }
            
        }

        private void bMove_Click(object sender, EventArgs e)
        {
            var grouppedByLp100 = PcbList.Where(p => !string.IsNullOrWhiteSpace(p.GraffitiLp100)).GroupBy(p => p.GraffitiLp100);
            foreach (var lp100 in grouppedByLp100)
            {
                if(lp100.Count() != lp100.First().QtyInLp100)
                {
                    MessageBox.Show($"Pod Graffiti ID {lp100.Key} znajduje się {lp100.First().QtyInLp100}szt. wyrobów. Można przesunąć wszystkie naraz lub odłączyć wymaganą ilość");
                    return;
                }
            }
            if (string.IsNullOrWhiteSpace(tbNewBoxQr.Text))
            {
                MessageBox.Show("Podaj kod QR nowego kartonu.");
                return;
            }
            foreach (var pcb in PcbList)
            {
                SqlBoxingConnection.UpdateBoxIdForSerial(pcb.SerialNo, tbNewBoxQr.Text);
            }
            newBoxId = tbNewBoxQr.Text;
            this.DialogResult = DialogResult.OK;
        }
    }
}
