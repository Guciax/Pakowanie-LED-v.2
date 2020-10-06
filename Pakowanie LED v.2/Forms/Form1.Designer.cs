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
            this.dgvBoxesList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOtherBoxesInfo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lQtyInBox = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pNgFlashPanel = new System.Windows.Forms.Panel();
            this.lViStatus = new System.Windows.Forms.Label();
            this.lTestStatus = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.bMoveBox = new System.Windows.Forms.Button();
            this.bRemoveBox = new System.Windows.Forms.Button();
            this.bMoveModule = new System.Windows.Forms.Button();
            this.bRemoveModule = new System.Windows.Forms.Button();
            this.bNewBox = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lCurrentUser = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.bLogoutUser = new System.Windows.Forms.Button();
            this.bRefresh = new System.Windows.Forms.Button();
            this.bDebug = new System.Windows.Forms.Button();
            this.lBoxNo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbScanQr = new System.Windows.Forms.TextBox();
            this.tCheckNg = new System.Windows.Forms.Timer(this.components);
            this.tNgFlashPanel = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvCurrentBox)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoxesList)).BeginInit();
            this.pNgFlashPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1205, 645);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.olvCurrentBox);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1199, 539);
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
            this.olvCurrentBox.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.olvCurrentBox.HeaderWordWrap = true;
            this.olvCurrentBox.Location = new System.Drawing.Point(0, 0);
            this.olvCurrentBox.Margin = new System.Windows.Forms.Padding(1);
            this.olvCurrentBox.Name = "olvCurrentBox";
            this.olvCurrentBox.ShowGroups = false;
            this.olvCurrentBox.Size = new System.Drawing.Size(862, 539);
            this.olvCurrentBox.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.olvCurrentBox.TabIndex = 0;
            this.olvCurrentBox.UseCellFormatEvents = true;
            this.olvCurrentBox.UseCompatibleStateImageBehavior = false;
            this.olvCurrentBox.View = System.Windows.Forms.View.Details;
            this.olvCurrentBox.BeforeSorting += new System.EventHandler<BrightIdeasSoftware.BeforeSortingEventArgs>(this.objectListView1_BeforeSorting);
            this.olvCurrentBox.CellClick += new System.EventHandler<BrightIdeasSoftware.CellClickEventArgs>(this.olvCurrentBox_CellClick);
            this.olvCurrentBox.CellOver += new System.EventHandler<BrightIdeasSoftware.CellOverEventArgs>(this.olvCurrentBox_CellOver);
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
            this.olvColumn4.Width = 100;
            // 
            // olvColumn5
            // 
            this.olvColumn5.AspectName = "ViResultString\n";
            this.olvColumn5.Text = "Kontrola wzrokowa";
            this.olvColumn5.Width = 79;
            this.olvColumn5.WordWrap = true;
            // 
            // olvColumn6
            // 
            this.olvColumn6.AspectName = "Status";
            this.olvColumn6.FillsFreeSpace = true;
            this.olvColumn6.Text = "Status";
            this.olvColumn6.Width = 500;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dgvBoxesList);
            this.panel2.Controls.Add(this.lOtherBoxesInfo);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lQtyInBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pNgFlashPanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel2.Location = new System.Drawing.Point(862, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(337, 539);
            this.panel2.TabIndex = 1;
            // 
            // dgvBoxesList
            // 
            this.dgvBoxesList.AllowUserToAddRows = false;
            this.dgvBoxesList.AllowUserToDeleteRows = false;
            this.dgvBoxesList.AllowUserToResizeColumns = false;
            this.dgvBoxesList.AllowUserToResizeRows = false;
            this.dgvBoxesList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvBoxesList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.dgvBoxesList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBoxesList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBoxesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBoxesList.ColumnHeadersVisible = false;
            this.dgvBoxesList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column2});
            this.dgvBoxesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBoxesList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.dgvBoxesList.Location = new System.Drawing.Point(0, 186);
            this.dgvBoxesList.Name = "dgvBoxesList";
            this.dgvBoxesList.ReadOnly = true;
            this.dgvBoxesList.RowHeadersVisible = false;
            this.dgvBoxesList.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.dgvBoxesList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvBoxesList.Size = new System.Drawing.Size(335, 281);
            this.dgvBoxesList.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 5;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 5;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 5;
            // 
            // lOtherBoxesInfo
            // 
            this.lOtherBoxesInfo.AutoSize = true;
            this.lOtherBoxesInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lOtherBoxesInfo.Location = new System.Drawing.Point(0, 467);
            this.lOtherBoxesInfo.Name = "lOtherBoxesInfo";
            this.lOtherBoxesInfo.Size = new System.Drawing.Size(68, 20);
            this.lOtherBoxesInfo.TabIndex = 3;
            this.lOtherBoxesInfo.Text = "Łącznie:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(0, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kartony z tego zlecenia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(0, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "----------------------------------------------------";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lQtyInBox
            // 
            this.lQtyInBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.lQtyInBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 88F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lQtyInBox.Location = new System.Drawing.Point(0, 20);
            this.lQtyInBox.Name = "lQtyInBox";
            this.lQtyInBox.Size = new System.Drawing.Size(335, 126);
            this.lQtyInBox.TabIndex = 1;
            this.lQtyInBox.Text = "999";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ilość w kartonie:";
            // 
            // pNgFlashPanel
            // 
            this.pNgFlashPanel.BackColor = System.Drawing.Color.White;
            this.pNgFlashPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pNgFlashPanel.Controls.Add(this.lViStatus);
            this.pNgFlashPanel.Controls.Add(this.lTestStatus);
            this.pNgFlashPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pNgFlashPanel.Location = new System.Drawing.Point(0, 487);
            this.pNgFlashPanel.Name = "pNgFlashPanel";
            this.pNgFlashPanel.Size = new System.Drawing.Size(335, 50);
            this.pNgFlashPanel.TabIndex = 5;
            // 
            // lViStatus
            // 
            this.lViStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.lViStatus.Location = new System.Drawing.Point(0, 23);
            this.lViStatus.Name = "lViStatus";
            this.lViStatus.Size = new System.Drawing.Size(333, 23);
            this.lViStatus.TabIndex = 2;
            this.lViStatus.Text = "Status kontroli wzrokowej: OK";
            // 
            // lTestStatus
            // 
            this.lTestStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.lTestStatus.Location = new System.Drawing.Point(0, 0);
            this.lTestStatus.Name = "lTestStatus";
            this.lTestStatus.Size = new System.Drawing.Size(333, 23);
            this.lTestStatus.TabIndex = 1;
            this.lTestStatus.Text = "Status test: OK";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 342F));
            this.tableLayoutPanel2.Controls.Add(this.panel5, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.bNewBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1, 1);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1203, 98);
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
            this.panel5.Location = new System.Drawing.Point(862, 1);
            this.panel5.Margin = new System.Windows.Forms.Padding(1);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(2);
            this.panel5.Size = new System.Drawing.Size(340, 96);
            this.panel5.TabIndex = 3;
            // 
            // bMoveBox
            // 
            this.bMoveBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.bMoveBox.Location = new System.Drawing.Point(2, 71);
            this.bMoveBox.Name = "bMoveBox";
            this.bMoveBox.Size = new System.Drawing.Size(336, 23);
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
            this.bRemoveBox.Size = new System.Drawing.Size(336, 23);
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
            this.bMoveModule.Size = new System.Drawing.Size(336, 23);
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
            this.bRemoveModule.Size = new System.Drawing.Size(336, 23);
            this.bRemoveModule.TabIndex = 0;
            this.bRemoveModule.Text = "Usuń wyrób";
            this.bRemoveModule.UseVisualStyleBackColor = true;
            this.bRemoveModule.Click += new System.EventHandler(this.bRemoveModule_Click);
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
            this.panel3.Controls.Add(this.lCurrentUser);
            this.panel3.Controls.Add(this.tableLayoutPanel3);
            this.panel3.Controls.Add(this.bDebug);
            this.panel3.Controls.Add(this.lBoxNo);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.tbScanQr);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(104, 1);
            this.panel3.Margin = new System.Windows.Forms.Padding(1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(756, 96);
            this.panel3.TabIndex = 1;
            // 
            // lCurrentUser
            // 
            this.lCurrentUser.AutoSize = true;
            this.lCurrentUser.Dock = System.Windows.Forms.DockStyle.Right;
            this.lCurrentUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lCurrentUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lCurrentUser.Location = new System.Drawing.Point(471, 7);
            this.lCurrentUser.Name = "lCurrentUser";
            this.lCurrentUser.Size = new System.Drawing.Size(204, 20);
            this.lCurrentUser.TabIndex = 5;
            this.lCurrentUser.Text = "Operator pakowania: BRAK";
            this.lCurrentUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.bLogoutUser, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.bRefresh, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(675, 7);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(81, 89);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // bLogoutUser
            // 
            this.bLogoutUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bLogoutUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bLogoutUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLogoutUser.Location = new System.Drawing.Point(3, 3);
            this.bLogoutUser.Name = "bLogoutUser";
            this.bLogoutUser.Size = new System.Drawing.Size(75, 23);
            this.bLogoutUser.TabIndex = 5;
            this.bLogoutUser.Text = "Wyloguj";
            this.bLogoutUser.UseVisualStyleBackColor = false;
            this.bLogoutUser.Click += new System.EventHandler(this.bLogoutUser_Click);
            // 
            // bRefresh
            // 
            this.bRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bRefresh.Location = new System.Drawing.Point(3, 32);
            this.bRefresh.Name = "bRefresh";
            this.bRefresh.Size = new System.Drawing.Size(75, 54);
            this.bRefresh.TabIndex = 2;
            this.bRefresh.Text = "Odśwież";
            this.bRefresh.UseVisualStyleBackColor = true;
            this.bRefresh.Click += new System.EventHandler(this.bRefresh_Click);
            // 
            // bDebug
            // 
            this.bDebug.Location = new System.Drawing.Point(597, 70);
            this.bDebug.Name = "bDebug";
            this.bDebug.Size = new System.Drawing.Size(75, 23);
            this.bDebug.TabIndex = 3;
            this.bDebug.Text = "debug";
            this.bDebug.UseVisualStyleBackColor = true;
            this.bDebug.Visible = false;
            this.bDebug.Click += new System.EventHandler(this.bDebug_Click);
            // 
            // lBoxNo
            // 
            this.lBoxNo.AutoSize = true;
            this.lBoxNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lBoxNo.Location = new System.Drawing.Point(3, 42);
            this.lBoxNo.Name = "lBoxNo";
            this.lBoxNo.Size = new System.Drawing.Size(56, 44);
            this.lBoxNo.TabIndex = 1;
            this.lBoxNo.Text = "K:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Karton numer:";
            // 
            // tbScanQr
            // 
            this.tbScanQr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.tbScanQr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbScanQr.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbScanQr.Font = new System.Drawing.Font("Microsoft Sans Serif", 4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbScanQr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.tbScanQr.Location = new System.Drawing.Point(0, 0);
            this.tbScanQr.Name = "tbScanQr";
            this.tbScanQr.Size = new System.Drawing.Size(756, 7);
            this.tbScanQr.TabIndex = 0;
            this.tbScanQr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbScanQr_KeyPress);
            this.tbScanQr.Leave += new System.EventHandler(this.tbScanQr_Leave);
            // 
            // tCheckNg
            // 
            this.tCheckNg.Enabled = true;
            this.tCheckNg.Interval = 15000;
            this.tCheckNg.Tick += new System.EventHandler(this.tCheckNg_Tick);
            // 
            // tNgFlashPanel
            // 
            this.tNgFlashPanel.Interval = 500;
            this.tNgFlashPanel.Tick += new System.EventHandler(this.tNgFlashPanel_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 645);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Pakowanie Driver";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvCurrentBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoxesList)).EndInit();
            this.pNgFlashPanel.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
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
        private System.Windows.Forms.Panel pNgFlashPanel;
        private System.Windows.Forms.Label lViStatus;
        private System.Windows.Forms.Label lTestStatus;
        private System.Windows.Forms.Timer tNgFlashPanel;
        private System.Windows.Forms.Button bRefresh;
        private System.Windows.Forms.Button bDebug;
        private System.Windows.Forms.DataGridView dgvBoxesList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label lCurrentUser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button bLogoutUser;
    }
}

