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
    public partial class MovePcbToBox : Form
    {
        public MovePcbToBox()
        {
            InitializeComponent();
        }

        private void tbCurrentBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                tbNewBox.Enabled = true;
                this.ActiveControl = tbNewBox;
                e.Handled = true;
            }
        }

        private void tbNewBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                tbSerialNumber.Enabled = true;
                this.ActiveControl = tbSerialNumber;
                e.Handled = true;
            }
        }

        private void tbSerialNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                var boxingInfo = SqlBoxingConnection.GetBoxingForPcb(tbSerialNumber.Text);
                if (boxingInfo == null)
                {
                    MessageBox.Show("Brak danych dla podanego wyrobu");
                    return;
                }
                if (boxingInfo.boxId != tbCurrentBox.Text)
                {
                    MessageBox.Show("Podany numer kartonu nie zgadza się z numerem zapisanym w bazie danych");
                    return;
                }
                if(boxingInfo.moveToWarehouseDate != null)
                {
                    var count = SqlBoxingConnection.HowManyModulesMovedAsLp100(boxingInfo.movedByLp100);
                    if (count > 1)
                    {
                        MessageBox.Show("Wyrób znajduje się w kartonie, który został przesunięty systemowo." + Environment.NewLine 
                            +$"Pod tym numerem kartonu tym znajduje się: {count}szt. wyrobów."
                            + "Oddziel wyroby od kartonu albo użyj opcji przenieś karton aby przenieść cały karton.");
                        return;
                    }
                }
                MST.MES.SqlOperations.Boxing.UpdateBoxIdForSerial(tbSerialNumber.Text, tbNewBox.Text);
                e.Handled = true;
                
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
