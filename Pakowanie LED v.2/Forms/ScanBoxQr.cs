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
    public partial class ScanQr : Form
    {
        public string qrCode;
        public ScanQr()
        {
            InitializeComponent();
        }

        private void tbBoxQrCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                qrCode = tbBoxQrCode.Text;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void ScanBoxQr_Load(object sender, EventArgs e)
        {

        }
    }
}
