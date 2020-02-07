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
    public partial class ChangeBoxId : Form
    {
        public string newBoxId;
        public ChangeBoxId()
        {
            InitializeComponent();
        }

        private void tbCurrentBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                e.Handled = true;
                tbNewBox.Enabled = true;
                this.ActiveControl = tbNewBox;
            }
        }

        private void tbNewBox_KeyPress(object sender, KeyPressEventArgs e)
        {

                e.Handled = true;
            if (e.KeyChar == (char)13)
            {
                var oldBox = MST.MES.SqlDataReaderMethods.Boxing.GetBoxingForBoxId(tbCurrentBox.Text);
                List<MST.MES.OrderStructureByOrderNo.BoxingInfo> newBox = MST.MES.SqlDataReaderMethods.Boxing.GetBoxingForBoxId(tbNewBox.Text);

                if (!oldBox.Any())
                {
                    MessageBox.Show($"Brak danych o kartonie nr {tbCurrentBox.Text}");
                    return;
                }

                string old12Nc = oldBox.First().serialNo.Split('_')[0];
                string new12Nc = "";

                if (!newBox.Any())
                {
                    newBox = new List<MST.MES.OrderStructureByOrderNo.BoxingInfo>();
                    new12Nc = old12Nc;
                }
                else
                {
                    new12Nc = newBox.First().serialNo.Split('_')[0]; ;
                }


                if (old12Nc != new12Nc)
                {
                    MessageBox.Show("Kartony zawierają różne 12NC wyrobu:" + Environment.NewLine +
                        old12Nc + Environment.NewLine +
                        new12Nc + Environment.NewLine +
                        "Nie można przenieść wyrobów");
                    return;
                }

                string dialogText = "Aktualny karton: " + Environment.NewLine +
                    old12Nc + Environment.NewLine +
                    $"Ilość: {oldBox.Count}szt." + Environment.NewLine +
                    "Nowy karton: " + Environment.NewLine +
                    new12Nc + Environment.NewLine +
                    $"Ilość: {newBox.Count}szt." + Environment.NewLine +
                    $"Po połączeniu w nocym kartonie będzie {oldBox.Count + newBox.Count}szt." + Environment.NewLine +
                    "Czy chcesz kontynuować?";

                DialogResult dialogResult = MessageBox.Show(dialogText, "Info", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MST.MES.SqlOperations.Boxing.UpdateBoxIdForBoxId(tbCurrentBox.Text, tbNewBox.Text);
                    var movedByLp100Collection = oldBox.Where(b => !string.IsNullOrWhiteSpace(b.movedByLp100)).Select(b => b.movedByLp100).Distinct().ToArray();
                    Graffiti.MST.PackingTools.SetBoxIdForLp100(tbNewBox.Text, movedByLp100Collection);
                    newBoxId = tbNewBox.Text;
                    this.DialogResult = DialogResult.OK;
                }


            }
            
        }
    }
}
