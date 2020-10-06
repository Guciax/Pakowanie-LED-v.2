namespace Pakowanie_LED_v._2.Forms
{
    partial class MovePcbToBoxBatch
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
            this.tbPcbSerialNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNewBoxQr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bMove = new System.Windows.Forms.Button();
            this.objectListView1 = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPcbSerialNo
            // 
            this.tbPcbSerialNo.Location = new System.Drawing.Point(16, 31);
            this.tbPcbSerialNo.Name = "tbPcbSerialNo";
            this.tbPcbSerialNo.Size = new System.Drawing.Size(567, 20);
            this.tbPcbSerialNo.TabIndex = 0;
            this.tbPcbSerialNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPcbSerialNo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dodaj wyroby do przesunięcia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kod QR nowego kartonu:";
            // 
            // tbNewBoxQr
            // 
            this.tbNewBoxQr.Location = new System.Drawing.Point(12, 396);
            this.tbNewBoxQr.Name = "tbNewBoxQr";
            this.tbNewBoxQr.Size = new System.Drawing.Size(571, 20);
            this.tbNewBoxQr.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(349, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "---------------------------------------------------------------------------------" +
    "---------------------------------";
            // 
            // bMove
            // 
            this.bMove.Location = new System.Drawing.Point(12, 427);
            this.bMove.Name = "bMove";
            this.bMove.Size = new System.Drawing.Size(571, 23);
            this.bMove.TabIndex = 6;
            this.bMove.Text = "Przenieś";
            this.bMove.UseVisualStyleBackColor = true;
            this.bMove.Click += new System.EventHandler(this.bMove_Click);
            // 
            // objectListView1
            // 
            this.objectListView1.AllColumns.Add(this.olvColumn1);
            this.objectListView1.AllColumns.Add(this.olvColumn2);
            this.objectListView1.AllColumns.Add(this.olvColumn3);
            this.objectListView1.AllColumns.Add(this.olvColumn4);
            this.objectListView1.CellEditUseWholeCell = false;
            this.objectListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn2,
            this.olvColumn3,
            this.olvColumn4});
            this.objectListView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListView1.Location = new System.Drawing.Point(16, 57);
            this.objectListView1.Name = "objectListView1";
            this.objectListView1.ShowGroups = false;
            this.objectListView1.Size = new System.Drawing.Size(567, 301);
            this.objectListView1.TabIndex = 7;
            this.objectListView1.UseCompatibleStateImageBehavior = false;
            this.objectListView1.View = System.Windows.Forms.View.Details;
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "SerialNo";
            this.olvColumn1.Text = "PCB QR";
            this.olvColumn1.Width = 160;
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "BoxId";
            this.olvColumn2.Text = "Akt. karton";
            this.olvColumn2.Width = 160;
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "GraffitiLp100";
            this.olvColumn3.Text = "Graffiti ID";
            this.olvColumn3.Width = 160;
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "Lp100NoToDisplay";
            this.olvColumn4.Text = "Ilość po ID";
            this.olvColumn4.Width = 80;
            // 
            // MovePcbToBoxBatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.ClientSize = new System.Drawing.Size(613, 462);
            this.Controls.Add(this.objectListView1);
            this.Controls.Add(this.bMove);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNewBoxQr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPcbSerialNo);
            this.Name = "MovePcbToBoxBatch";
            this.Text = "MovePcbToBoxBatch";
            this.Load += new System.EventHandler(this.MovePcbToBoxBatch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPcbSerialNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNewBoxQr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bMove;
        private BrightIdeasSoftware.ObjectListView objectListView1;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
    }
}