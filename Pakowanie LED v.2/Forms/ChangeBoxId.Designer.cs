namespace Pakowanie_LED_v._2.Forms
{
    partial class ChangeBoxId
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
            this.tbNewBox = new System.Windows.Forms.TextBox();
            this.tbCurrentBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbNewBox
            // 
            this.tbNewBox.Enabled = false;
            this.tbNewBox.Location = new System.Drawing.Point(144, 46);
            this.tbNewBox.Margin = new System.Windows.Forms.Padding(9, 11, 9, 11);
            this.tbNewBox.Name = "tbNewBox";
            this.tbNewBox.Size = new System.Drawing.Size(276, 29);
            this.tbNewBox.TabIndex = 14;
            this.tbNewBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNewBox_KeyPress);
            // 
            // tbCurrentBox
            // 
            this.tbCurrentBox.Location = new System.Drawing.Point(144, 10);
            this.tbCurrentBox.Margin = new System.Windows.Forms.Padding(9, 11, 9, 11);
            this.tbCurrentBox.Name = "tbCurrentBox";
            this.tbCurrentBox.Size = new System.Drawing.Size(276, 29);
            this.tbCurrentBox.TabIndex = 13;
            this.tbCurrentBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCurrentBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(18, 0, 18, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nowy karton";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(18, 0, 18, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Aktualny karton";
            // 
            // ChangeBoxId
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.ClientSize = new System.Drawing.Size(451, 86);
            this.Controls.Add(this.tbNewBox);
            this.Controls.Add(this.tbCurrentBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ChangeBoxId";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Przenieś karton";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNewBox;
        private System.Windows.Forms.TextBox tbCurrentBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}