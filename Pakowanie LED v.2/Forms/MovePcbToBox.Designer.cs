namespace Pakowanie_LED_v._2.Forms
{
    partial class MovePcbToBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbSerialNumber = new System.Windows.Forms.TextBox();
            this.tbNewBox = new System.Windows.Forms.TextBox();
            this.tbCurrentBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbSerialNumber
            // 
            this.tbSerialNumber.Enabled = false;
            this.tbSerialNumber.Location = new System.Drawing.Point(162, 82);
            this.tbSerialNumber.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbSerialNumber.Name = "tbSerialNumber";
            this.tbSerialNumber.Size = new System.Drawing.Size(338, 29);
            this.tbSerialNumber.TabIndex = 11;
            this.tbSerialNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSerialNumber_KeyPress);
            // 
            // tbNewBox
            // 
            this.tbNewBox.Enabled = false;
            this.tbNewBox.Location = new System.Drawing.Point(162, 44);
            this.tbNewBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbNewBox.Name = "tbNewBox";
            this.tbNewBox.Size = new System.Drawing.Size(338, 29);
            this.tbNewBox.TabIndex = 10;
            this.tbNewBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNewBox_KeyPress);
            // 
            // tbCurrentBox
            // 
            this.tbCurrentBox.Location = new System.Drawing.Point(162, 6);
            this.tbCurrentBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbCurrentBox.Name = "tbCurrentBox";
            this.tbCurrentBox.Size = new System.Drawing.Size(338, 29);
            this.tbCurrentBox.TabIndex = 9;
            this.tbCurrentBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCurrentBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "kod QR wyrobu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nowy karton";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Aktualny karton";
            // 
            // MovePcbToBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.ClientSize = new System.Drawing.Size(514, 131);
            this.Controls.Add(this.tbSerialNumber);
            this.Controls.Add(this.tbNewBox);
            this.Controls.Add(this.tbCurrentBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "MovePcbToBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Przenieś";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSerialNumber;
        private System.Windows.Forms.TextBox tbNewBox;
        private System.Windows.Forms.TextBox tbCurrentBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}