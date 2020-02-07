namespace Pakowanie_LED_v._2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.olvCurrentBox = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn5 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn6 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lOtherBoxesInfo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lQtyInBox = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.bMoveBox = new System.Windows.Forms.Button();
            this.bRemoveBox = new System.Windows.Forms.Button();
            this.bMoveModule = new System.Windows.Forms.Button();
            this.bRemoveModule = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbScanQr = new System.Windows.Forms.TextBox();
            this.bNewBox = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lBoxNo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tCheckNg = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvCurrentBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1108, 645);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.olvCurrentBox);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1102, 539);
            this.panel1.TabIndex = 1;
            // 
            // olvCurrentBox
            // 
            this.olvCurrentBox.AllColumns.Add(this.olvColumn1);
            this.olvCurrentBox.AllColumns.Add(this.olvColumn2);
            this.olvCurrentBox.AllColumns.Add(this.olvColumn3);
            this.olvCurrentBox.AllColumns.Add(this.olvColumn4);
            this.olvCurrentBox.AllColumns.Add(this.olvColumn5);
            this.olvCurrentBox.AllColumns.Add(this.olvColumn6);
            this.olvCurrentBox.CellEditUseWholeCell = false;
            this.olvCurrentBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn2,
            this.olvColumn3,
            this.olvColumn4,
            this.olvColumn5,
            this.olvColumn6});
            this.olvCurrentBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvCurrentBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvCurrentBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.olvCurrentBox.Location = new System.Drawing.Point(0, 0);
            this.olvCurrentBox.Margin = new System.Windows.Forms.Padding(1);
            this.olvCurrentBox.Name = "olvCurrentBox";
            this.olvCurrentBox.ShowGroups = false;
            this.olvCurrentBox.Size = new System.Drawing.Size(793, 539);
            this.olvCurrentBox.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.olvCurrentBox.TabIndex = 0;
            this.olvCurrentBox.UseCompatibleStateImageBehavior = false;
            this.olvCurrentBox.View = System.Windows.Forms.View.Details;
            this.olvCurrentBox.BeforeSorting += new System.EventHandler<BrightIdeasSoftware.BeforeSortingEventArgs>(this.objectListView1_BeforeSorting);
            this.olvCurrentBox.FormatRow += new System.EventHandler<BrightIdeasSoftware.FormatRowEventArgs>(this.olvCurrentBox_FormatRow);
            this.olvCurrentBox.ItemMouseHover += new System.Windows.Forms.ListViewItemMouseHoverEventHandler(this.olvCurrentBox_ItemMouseHover);
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "moduleNo";
            this.olvColumn1.Text = "#";
            this.olvColumn1.Width = 40;
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "ModuleSerialNo";
            this.olvColumn2.Hyperlink = true;
            this.olvColumn2.Text = "Moduł LED kod QR";
            this.olvColumn2.Width = 215;
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "BoxingDate";
            this.olvColumn3.Text = "Data pakowania";
            this.olvColumn3.Width = 180;
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "TestResultString";
            this.olvColumn4.Text = "Test";
            // 
            // olvColumn5
            // 
            this.olvColumn5.AspectName = "ViResultString\n";
            this.olvColumn5.Text = "Kontrola wzrokowa";
            // 
            // olvColumn6
            // 
            this.olvColumn6.AspectName = "Status";
            this.olvColumn6.Text = "Status";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panel2.Controls.Add(this.lOtherBoxesInfo);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lQtyInBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel2.Location = new System.Drawing.Point(793, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(309, 539);
            this.panel2.TabIndex = 1;
            // 
            // lOtherBoxesInfo
            // 
            this.lOtherBoxesInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lOtherBoxesInfo.Location = new System.Drawing.Point(0, 195);
            this.lOtherBoxesInfo.Name = "lOtherBoxesInfo";
            this.lOtherBoxesInfo.Size = new System.Drawing.Size(309, 344);
            this.lOtherBoxesInfo.TabIndex = 3;
            this.lOtherBoxesInfo.Text = "...";
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(309, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kartony z tego zlecenia:";
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(0, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(309, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "----------------------------------------------------";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lQtyInBox
            // 
            this.lQtyInBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.lQtyInBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 88F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lQtyInBox.Location = new System.Drawing.Point(0, 23);
            this.lQtyInBox.Name = "lQtyInBox";
            this.lQtyInBox.Size = new System.Drawing.Size(309, 126);
            this.lQtyInBox.TabIndex = 1;
            this.lQtyInBox.Text = "999";
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ilość w kartonie:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 243F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 255F));
            this.tableLayoutPanel2.Controls.Add(this.panel5, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.bNewBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1, 1);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1106, 98);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panel5.Controls.Add(this.bMoveBox);
            this.panel5.Controls.Add(this.bRemoveBox);
            this.panel5.Controls.Add(this.bMoveModule);
            this.panel5.Controls.Add(this.bRemoveModule);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(852, 1);
            this.panel5.Margin = new System.Windows.Forms.Padding(1);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(2);
            this.panel5.Size = new System.Drawing.Size(253, 96);
            this.panel5.TabIndex = 3;
            // 
            // bMoveBox
            // 
            this.bMoveBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.bMoveBox.Location = new System.Drawing.Point(2, 71);
            this.bMoveBox.Name = "bMoveBox";
            this.bMoveBox.Size = new System.Drawing.Size(249, 23);
            this.bMoveBox.TabIndex = 3;
            this.bMoveBox.Text = "Przesnieś karton";
            this.bMoveBox.UseVisualStyleBackColor = true;
            this.bMoveBox.Click += new System.EventHandler(this.bMoveBox_Click);
            // 
            // bRemoveBox
            // 
            this.bRemoveBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.bRemoveBox.Location = new System.Drawing.Point(2, 48);
            this.bRemoveBox.Name = "bRemoveBox";
            this.bRemoveBox.Size = new System.Drawing.Size(249, 23);
            this.bRemoveBox.TabIndex = 2;
            this.bRemoveBox.Text = "Usuń karton";
            this.bRemoveBox.UseVisualStyleBackColor = true;
            this.bRemoveBox.Click += new System.EventHandler(this.bRemoveBox_Click);
            // 
            // bMoveModule
            // 
            this.bMoveModule.Dock = System.Windows.Forms.DockStyle.Top;
            this.bMoveModule.Location = new System.Drawing.Point(2, 25);
            this.bMoveModule.Name = "bMoveModule";
            this.bMoveModule.Size = new System.Drawing.Size(249, 23);
            this.bMoveModule.TabIndex = 1;
            this.bMoveModule.Text = "Przesnieś wyrób";
            this.bMoveModule.UseVisualStyleBackColor = true;
            this.bMoveModule.Click += new System.EventHandler(this.bMoveModule_Click);
            // 
            // bRemoveModule
            // 
            this.bRemoveModule.Dock = System.Windows.Forms.DockStyle.Top;
            this.bRemoveModule.Location = new System.Drawing.Point(2, 2);
            this.bRemoveModule.Name = "bRemoveModule";
            this.bRemoveModule.Size = new System.Drawing.Size(249, 23);
            this.bRemoveModule.TabIndex = 0;
            this.bRemoveModule.Text = "Usuń wyrób";
            this.bRemoveModule.UseVisualStyleBackColor = true;
            this.bRemoveModule.Click += new System.EventHandler(this.bRemoveModule_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panel4.Controls.Add(this.tbScanQr);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(609, 1);
            this.panel4.Margin = new System.Windows.Forms.Padding(1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(241, 96);
            this.panel4.TabIndex = 2;
            // 
            // tbScanQr
            // 
            this.tbScanQr.Location = new System.Drawing.Point(10, 10);
            this.tbScanQr.Name = "tbScanQr";
            this.tbScanQr.Size = new System.Drawing.Size(228, 20);
            this.tbScanQr.TabIndex = 0;
            this.tbScanQr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbScanQr_KeyPress);
            this.tbScanQr.Leave += new System.EventHandler(this.tbScanQr_Leave);
            // 
            // bNewBox
            // 
            this.bNewBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bNewBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNewBox.Location = new System.Drawing.Point(1, 1);
            this.bNewBox.Margin = new System.Windows.Forms.Padding(1);
            this.bNewBox.Name = "bNewBox";
            this.bNewBox.Size = new System.Drawing.Size(101, 96);
            this.bNewBox.TabIndex = 0;
            this.bNewBox.Text = "Nowy karton\r\n------------------------\r\nWczytaj karton\r\n";
            this.bNewBox.UseVisualStyleBackColor = true;
            this.bNewBox.Click += new System.EventHandler(this.bNewBox_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panel3.Controls.Add(this.lBoxNo);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(104, 1);
            this.panel3.Margin = new System.Windows.Forms.Padding(1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(503, 96);
            this.panel3.TabIndex = 1;
            // 
            // lBoxNo
            // 
            this.lBoxNo.AutoSize = true;
            this.lBoxNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lBoxNo.Location = new System.Drawing.Point(10, 39);
            this.lBoxNo.Name = "lBoxNo";
            this.lBoxNo.Size = new System.Drawing.Size(40, 31);
            this.lBoxNo.TabIndex = 1;
            this.lBoxNo.Text = "K:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Karton numer:";
            // 
            // tCheckNg
            // 
            this.tCheckNg.Interval = 15000;
            this.tCheckNg.Tick += new System.EventHandler(this.tCheckNg_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 645);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Pakowanie LED MST v.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvCurrentBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private BrightIdeasSoftware.ObjectListView olvCurrentBox;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
        private BrightIdeasSoftware.OLVColumn olvColumn5;
        private BrightIdeasSoftware.OLVColumn olvColumn6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tbScanQr;
        private System.Windows.Forms.Button bNewBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lBoxNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lOtherBoxesInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lQtyInBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bMoveBox;
        private System.Windows.Forms.Button bRemoveBox;
        private System.Windows.Forms.Button bMoveModule;
        private System.Windows.Forms.Button bRemoveModule;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer tCheckNg;
    }
}

