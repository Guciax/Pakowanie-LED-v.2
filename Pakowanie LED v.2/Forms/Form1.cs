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
            CurrentOrderBoxing.dgvBoxesList = dgvBoxesList;
            CurrentBoxingUser.lCurrentUser = lCurrentUser;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (StartUp.SwitchToLocalFile())
            {
                this.Close();
            }
            this.ActiveControl = tbScanQr;
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            string version = fvi.FileVersion;
            this.Text += version;
# if DEBUG
            bDebug.Visible = true;
# endif
        }
        private void LoadBox(string boxId)
        {
            if (string.IsNullOrWhiteSpace(boxId)) return;
            CurrentBoxData.SetUpNewBox(boxId);
            olvCurrentBox.SetObjects(CurrentBoxData.CurrentBoxingList);
            CurrentOrderBoxing.ReloadBoxes();
            lBoxNo.Text = CurrentBoxData.CurrentBoxId;
        }
        private void tbScanQr_Leave(object sender, EventArgs e)
        {
            this.ActiveControl = tbScanQr;
        }
        private void bNewBox_Click(object sender, EventArgs e)
        {
            if (CurrentBoxingUser.UserData == null) return;

            using (Forms.ScanQr scanForm = new Forms.ScanQr())
            {
                if (scanForm.ShowDialog() == DialogResult.OK)
                {
                    LoadBox(scanForm.qrCode);
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
                if (CurrentBoxingUser.UserData == null) return;
                var splittedSerial = serialNo.Split('_');
                if (splittedSerial.Length != 3)
                {
                    MessageBox.Show($"Nieprawidłowy kod QR {serialNo}");
                    return;
                }
                string pcb10Nc = splittedSerial[0];
                string pcbOrderNo = splittedSerial[1];

                if (pcb10Nc != CurrentBoxData.CurrentBox10Nc)
                {
                    MessageBox.Show("Nieprawidłowy numer 12NC !!!" + Environment.NewLine
                        + $"12NC opakowania: {CurrentBoxData.CurrentBox10Nc}" + Environment.NewLine
                        + $"12NC kodu QR: {pcb10Nc}");
                    return;
                }
                var boxingData = SqlBoxingConnection.GetBoxingForPcb(serialNo);
                if(boxingData == null)
                {
                    CurrentBoxData.AddModuleToBox(serialNo, CurrentBoxingUser.UserData.Name);
                    olvCurrentBox.SetObjects(CurrentBoxData.CurrentBoxingList);
                    CurrentOrderBoxing.ReloadBoxes();
                }
                else
                {
                    MessageBox.Show($"Ten wyrób znajduje się w innym kartonie." + Environment.NewLine
                        + $"ID kartonu: {boxingData.boxId}" + Environment.NewLine
                        + $"Data pakowania: {boxingData.boxingDate}");
                }
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
            if (item.TestResultString.StartsWith("OK") & item.ViResultString.StartsWith("OK"))
            {
                if (item.moduleNo % 2 == 0)
                {
                    e.Item.BackColor = MST.MES.Colors.MaterialColorPalettes.Green().light;
                }
                else
                {
                    e.Item.BackColor = MST.MES.Colors.MaterialColorPalettes.Green().ultraLight;
                }
                    
                
            }
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
            if (CurrentBoxData.CurrentBoxingList == null) return;
            var viNg = CurrentBoxData.CurrentBoxingList.Where(i => !i.VisualInspectionResult.CurrentOverallState).ToList();
            var testNg = CurrentBoxingList.Where(i => i.TestResultString!="OK").ToList();

            if (!viNg.Any() & !testNg.Any())
            {
                tNgFlashPanel.Enabled = false;
                pNgFlashPanel.BackColor = Color.White;
                pNgFlashPanel.ForeColor = Color.Black;
                lTestStatus.Text = "Status testu: OK";
                lViStatus.Text = "Status kontroli wzrokowej: OK";
                return;
            }

            if (viNg.Any())
            {
                lViStatus.Text = "Status kontroli wzrokowej: NG";
            }
            if (testNg.Any())
            {
                lTestStatus.Text = "Status kontroli wzrokowej: NG";
            }
            tNgFlashPanel.Enabled = true;

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
                var viResult = viNgList.Where(x => x.ModuleSerialNo == viResultEntry.Key).First();
                viResult.VisualInspectionResult = viResultEntry.Value;
            }
        }
        private void bRemoveModule_Click(object sender, EventArgs e)
        {
            if (CurrentBoxingUser.UserData == null) return;
            using (ScanQr scanForm = new ScanQr())
            {
                if (scanForm.ShowDialog() == DialogResult.OK)
                {
                    var boxInfo = SqlBoxingConnection.GetBoxingForPcb(scanForm.qrCode);
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
                    if(boxInfo.boxId!= CurrentBoxData.CurrentBoxId)
                    {
                        MessageBox.Show("Wyrób nie należy do aktualnie wczutanego kartonu." + Environment.NewLine
                            + $"Skanowanu kod QR: {scanForm.qrCode}" + Environment.NewLine
                            + $"Aktualny karton: {CurrentBoxData.CurrentBoxId}" + Environment.NewLine
                            + $"Karton zeskanowanego wyrobu: {boxInfo.boxId}");
                        return;
                    }
                    CurrentBoxData.RemovePcbFromBox(scanForm.qrCode);
                }
            }
        }
        private void bMoveModule_Click(object sender, EventArgs e)
        {
            if (CurrentBoxingUser.UserData == null) return;

            using (MovePcbToBoxBatch scanForm = new MovePcbToBoxBatch())
            {
                if (scanForm.ShowDialog() == DialogResult.OK)
                {
                    LoadBox(scanForm.newBoxId);
                }
            }
        }
        private void bRemoveBox_Click(object sender, EventArgs e)
        {
            if (CurrentBoxingUser.UserData == null) return;

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
                LoadBox(CurrentBoxId);
            }
        }
        private void bMoveBox_Click(object sender, EventArgs e)
        {
            if (CurrentUser.UserData == null) return;

            using (ChangeBoxId changeBoxForm = new ChangeBoxId())
            {
                if (changeBoxForm.ShowDialog() == DialogResult.OK)
                {
                    LoadBox(changeBoxForm.newBoxId);
                }
            }
        }
        private void olvCurrentBox_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e)
        {
            e.Item.Font = new Font(e.Item.Font, FontStyle.Underline);
            
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SqlBoxingConnection.CloseConnection();
        }
        private void tNgFlashPanel_Tick(object sender, EventArgs e)
        {
            if(pNgFlashPanel.BackColor == Color.White)
            {
                pNgFlashPanel.BackColor = Color.Red;
                pNgFlashPanel.ForeColor = Color.White;
            }
            else
            {
                pNgFlashPanel.BackColor = Color.White;
                pNgFlashPanel.ForeColor = Color.Black;
            }
        }
        private void olvCurrentBox_CellClick(object sender, CellClickEventArgs e)
        {
            CurrentBoxDataStruct item = (CurrentBoxDataStruct)e.Model;
            if (e.ColumnIndex != 1) return;
            if (item == null) return;
            using(ShowNgInfo infoForm = new ShowNgInfo(item))
            {
                ;
                infoForm.ShowDialog();
            }
            //'K:1010117345_2005260_005'
        }
        private void olvCurrentBox_CellOver(object sender, CellOverEventArgs e)
        {
            if (e.SubItem == null) return;
            if (e.SubItem.Text.Contains("_"))
            {
                e.SubItem.Font = new Font(e.SubItem.Font, FontStyle.Underline);
            }
        }
        private void bRefresh_Click(object sender, EventArgs e)
        {
            LoadBox(CurrentBoxId);
        }
        private void bDebug_Click(object sender, EventArgs e)
        {
            string[] serial = new string[] { "1010120106_1621427_03625", "1010120106_1621427_03612", "1010120106_1621427_03614", "1010120106_1621427_03604", "1010120106_1621427_03644", "1010120106_1621427_04210", "1010120106_1621427_04223" };
            var res = TestResults.GetTestRecordsForPcbs(serial);
        }
        private void bLogoutUser_Click(object sender, EventArgs e)
        {
            CurrentBoxingUser.LogoutUser();
        }
    }
}