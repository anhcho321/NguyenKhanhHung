namespace WindowsFormsApp16
{
    partial class FrmMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bntOpen = new System.Windows.Forms.Button();
            this.bntSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbShapeMode = new System.Windows.Forms.ComboBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnPolygon = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnEllipse = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbDashMode = new System.Windows.Forms.ComboBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.lblWidth = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trkLineWidth = new System.Windows.Forms.TrackBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUngroup = new System.Windows.Forms.Button();
            this.btnGroup = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.cI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cBegin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cEnd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cColor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cDashStyle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cLineWidth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cSelect = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clbShape = new System.Windows.Forms.CheckedListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.psfMain = new WindowsFormsApp16.PaintSurface();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkLineWidth)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bntOpen);
            this.panel1.Controls.Add(this.bntSave);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.cmbShapeMode);
            this.panel1.Controls.Add(this.btnSelect);
            this.panel1.Controls.Add(this.btnPolygon);
            this.panel1.Controls.Add(this.btnCircle);
            this.panel1.Controls.Add(this.btnSquare);
            this.panel1.Controls.Add(this.btnEllipse);
            this.panel1.Controls.Add(this.btnRectangle);
            this.panel1.Controls.Add(this.btnLine);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1306, 79);
            this.panel1.TabIndex = 0;
            // 
            // bntOpen
            // 
            this.bntOpen.BackColor = System.Drawing.Color.Transparent;
            this.bntOpen.FlatAppearance.BorderSize = 0;
            this.bntOpen.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.bntOpen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.bntOpen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.bntOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntOpen.Location = new System.Drawing.Point(203, 50);
            this.bntOpen.Name = "bntOpen";
            this.bntOpen.Size = new System.Drawing.Size(52, 23);
            this.bntOpen.TabIndex = 6;
            this.bntOpen.Text = "Open";
            this.bntOpen.UseVisualStyleBackColor = false;
            this.bntOpen.Click += new System.EventHandler(this.bntOpen_Click);
            // 
            // bntSave
            // 
            this.bntSave.BackColor = System.Drawing.Color.Transparent;
            this.bntSave.FlatAppearance.BorderSize = 0;
            this.bntSave.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.bntSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.bntSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.bntSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntSave.Location = new System.Drawing.Point(150, 50);
            this.bntSave.Name = "bntSave";
            this.bntSave.Size = new System.Drawing.Size(47, 23);
            this.bntSave.TabIndex = 5;
            this.bntSave.Text = "Save";
            this.bntSave.UseVisualStyleBackColor = false;
            this.bntSave.Click += new System.EventHandler(this.bntSave_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(566, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 20);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add text";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbShapeMode
            // 
            this.cmbShapeMode.FormattingEnabled = true;
            this.cmbShapeMode.Items.AddRange(new object[] {
            "No fill shape",
            "Fill shape"});
            this.cmbShapeMode.Location = new System.Drawing.Point(10, 32);
            this.cmbShapeMode.Name = "cmbShapeMode";
            this.cmbShapeMode.Size = new System.Drawing.Size(134, 21);
            this.cmbShapeMode.TabIndex = 3;
            this.cmbShapeMode.SelectedIndexChanged += new System.EventHandler(this.CmbShapeMode_SelectedIndexChanged);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.Transparent;
            this.btnSelect.FlatAppearance.BorderSize = 0;
            this.btnSelect.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnSelect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Location = new System.Drawing.Point(515, 29);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(45, 20);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "Chọn";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // btnPolygon
            // 
            this.btnPolygon.BackColor = System.Drawing.Color.Transparent;
            this.btnPolygon.FlatAppearance.BorderSize = 0;
            this.btnPolygon.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnPolygon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnPolygon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnPolygon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPolygon.Location = new System.Drawing.Point(455, 29);
            this.btnPolygon.Name = "btnPolygon";
            this.btnPolygon.Size = new System.Drawing.Size(54, 20);
            this.btnPolygon.TabIndex = 2;
            this.btnPolygon.Text = "Đa giác";
            this.btnPolygon.UseVisualStyleBackColor = false;
            this.btnPolygon.Click += new System.EventHandler(this.BtnPolygon_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.BackColor = System.Drawing.Color.Transparent;
            this.btnCircle.FlatAppearance.BorderSize = 0;
            this.btnCircle.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnCircle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnCircle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnCircle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCircle.Location = new System.Drawing.Point(382, 29);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(67, 20);
            this.btnCircle.TabIndex = 2;
            this.btnCircle.Text = "Hình tròn";
            this.btnCircle.UseVisualStyleBackColor = false;
            this.btnCircle.Click += new System.EventHandler(this.BtnCircle_Click);
            // 
            // btnSquare
            // 
            this.btnSquare.BackColor = System.Drawing.Color.Transparent;
            this.btnSquare.FlatAppearance.BorderSize = 0;
            this.btnSquare.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnSquare.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnSquare.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnSquare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSquare.Location = new System.Drawing.Point(304, 29);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(72, 20);
            this.btnSquare.TabIndex = 2;
            this.btnSquare.Text = "Hình vuông";
            this.btnSquare.UseVisualStyleBackColor = false;
            this.btnSquare.Click += new System.EventHandler(this.BtnSquare_Click);
            // 
            // btnEllipse
            // 
            this.btnEllipse.BackColor = System.Drawing.Color.Transparent;
            this.btnEllipse.FlatAppearance.BorderSize = 0;
            this.btnEllipse.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnEllipse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnEllipse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnEllipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEllipse.Location = new System.Drawing.Point(260, 29);
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(38, 20);
            this.btnEllipse.TabIndex = 2;
            this.btnEllipse.Text = "Ê-líp";
            this.btnEllipse.UseVisualStyleBackColor = false;
            this.btnEllipse.Click += new System.EventHandler(this.BtnEllipse_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.BackColor = System.Drawing.Color.Transparent;
            this.btnRectangle.FlatAppearance.BorderSize = 0;
            this.btnRectangle.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnRectangle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnRectangle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRectangle.Location = new System.Drawing.Point(181, 29);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(84, 20);
            this.btnRectangle.TabIndex = 2;
            this.btnRectangle.Text = "Hình chữ nhật";
            this.btnRectangle.UseVisualStyleBackColor = false;
            this.btnRectangle.Click += new System.EventHandler(this.BtnRectangle_Click);
            // 
            // btnLine
            // 
            this.btnLine.BackColor = System.Drawing.Color.Transparent;
            this.btnLine.FlatAppearance.BorderSize = 0;
            this.btnLine.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnLine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnLine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLine.Location = new System.Drawing.Point(150, 29);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(37, 20);
            this.btnLine.TabIndex = 2;
            this.btnLine.Text = "Vẽ";
            this.btnLine.UseVisualStyleBackColor = false;
            this.btnLine.Click += new System.EventHandler(this.BtnLine_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbDashMode);
            this.panel2.Controls.Add(this.btnColor);
            this.panel2.Controls.Add(this.lblWidth);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.trkLineWidth);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(716, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(590, 55);
            this.panel2.TabIndex = 0;
            // 
            // cmbDashMode
            // 
            this.cmbDashMode.FormattingEnabled = true;
            this.cmbDashMode.Items.AddRange(new object[] {
            "Solid",
            "Dash",
            "Dot",
            "Dash Dot",
            "Dash Dot Dot"});
            this.cmbDashMode.Location = new System.Drawing.Point(146, 14);
            this.cmbDashMode.Name = "cmbDashMode";
            this.cmbDashMode.Size = new System.Drawing.Size(99, 21);
            this.cmbDashMode.TabIndex = 5;
            this.cmbDashMode.SelectedIndexChanged += new System.EventHandler(this.CmbDashMode_SelectedIndexChanged);
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnColor.Location = new System.Drawing.Point(38, 10);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(36, 34);
            this.btnColor.TabIndex = 4;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(461, 14);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(41, 13);
            this.lblWidth.TabIndex = 3;
            this.lblWidth.Text = "Default";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Độ dày nét vẽ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loại nét vẽ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Màu";
            // 
            // trkLineWidth
            // 
            this.trkLineWidth.Location = new System.Drawing.Point(331, 7);
            this.trkLineWidth.Name = "trkLineWidth";
            this.trkLineWidth.Size = new System.Drawing.Size(122, 45);
            this.trkLineWidth.TabIndex = 1;
            this.trkLineWidth.Scroll += new System.EventHandler(this.TrkLineWidth_Scroll);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1306, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem1});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.saveToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem1.Text = "Save";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Silver;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGray;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(1114, 85);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnUngroup
            // 
            this.btnUngroup.BackColor = System.Drawing.Color.Silver;
            this.btnUngroup.FlatAppearance.BorderSize = 0;
            this.btnUngroup.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGray;
            this.btnUngroup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnUngroup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnUngroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUngroup.Location = new System.Drawing.Point(1033, 85);
            this.btnUngroup.Name = "btnUngroup";
            this.btnUngroup.Size = new System.Drawing.Size(75, 23);
            this.btnUngroup.TabIndex = 0;
            this.btnUngroup.Text = "Bỏ gộp";
            this.btnUngroup.UseVisualStyleBackColor = false;
            this.btnUngroup.Click += new System.EventHandler(this.BtnUngroup_Click);
            // 
            // btnGroup
            // 
            this.btnGroup.BackColor = System.Drawing.Color.Silver;
            this.btnGroup.FlatAppearance.BorderSize = 0;
            this.btnGroup.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGray;
            this.btnGroup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnGroup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGroup.Location = new System.Drawing.Point(952, 85);
            this.btnGroup.Name = "btnGroup";
            this.btnGroup.Size = new System.Drawing.Size(75, 23);
            this.btnGroup.TabIndex = 0;
            this.btnGroup.Text = "Gộp hình";
            this.btnGroup.UseVisualStyleBackColor = false;
            this.btnGroup.Click += new System.EventHandler(this.BtnGroup_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cI,
            this.CName,
            this.cBegin,
            this.cEnd,
            this.cColor,
            this.cDashStyle,
            this.cLineWidth,
            this.cSelect});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(909, 232);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(387, 189);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // cI
            // 
            this.cI.Text = "ID";
            // 
            // CName
            // 
            this.CName.Text = "Ten hinh";
            this.CName.Width = 98;
            // 
            // cBegin
            // 
            this.cBegin.Text = "Begin";
            this.cBegin.Width = 81;
            // 
            // cEnd
            // 
            this.cEnd.Text = "End";
            // 
            // cColor
            // 
            this.cColor.Text = "Color";
            // 
            // cDashStyle
            // 
            this.cDashStyle.Text = "DashStyle";
            // 
            // cLineWidth
            // 
            this.cLineWidth.Text = "LineWidth";
            // 
            // cSelect
            // 
            this.cSelect.Text = "IsSelect";
            // 
            // clbShape
            // 
            this.clbShape.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clbShape.BackColor = System.Drawing.SystemColors.MenuBar;
            this.clbShape.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbShape.CheckOnClick = true;
            this.clbShape.FormattingEnabled = true;
            this.clbShape.Location = new System.Drawing.Point(909, 119);
            this.clbShape.Margin = new System.Windows.Forms.Padding(0);
            this.clbShape.Name = "clbShape";
            this.clbShape.Size = new System.Drawing.Size(397, 255);
            this.clbShape.TabIndex = 1;
            this.clbShape.SelectedIndexChanged += new System.EventHandler(this.ClbShape_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(908, 456);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(388, 150);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(1219, 398);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(1219, 583);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 5;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(1154, 427);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(35, 20);
            this.txtID.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1143, 398);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // psfMain
            // 
            this.psfMain.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.psfMain.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.psfMain.Location = new System.Drawing.Point(0, 79);
            this.psfMain.Name = "psfMain";
            this.psfMain.Size = new System.Drawing.Size(906, 530);
            this.psfMain.TabIndex = 2;
            this.psfMain.Paint += new System.Windows.Forms.PaintEventHandler(this.PsfMain_Paint);
            this.psfMain.DoubleClick += new System.EventHandler(this.PsfMain_DoubleClick);
            this.psfMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PsfMain_MouseDown);
            this.psfMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PsfMain_MouseMove);
            this.psfMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PsfMain_MouseUp);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 609);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnUngroup);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.clbShape);
            this.Controls.Add(this.psfMain);
            this.Controls.Add(this.btnGroup);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(972, 593);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vẽ Sơ Đồ Tư Duy";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMain_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmMain_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkLineWidth)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckedListBox clbShape;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnPolygon;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnEllipse;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.TrackBar trkLineWidth;
        private System.Windows.Forms.Button btnGroup;
        private System.Windows.Forms.Button btnUngroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.ComboBox cmbShapeMode;
        private PaintSurface psfMain;
        private System.Windows.Forms.ComboBox cmbDashMode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button bntSave;
        private System.Windows.Forms.Button bntOpen;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader cI;
        private System.Windows.Forms.ColumnHeader CName;
        private System.Windows.Forms.ColumnHeader cBegin;
        private System.Windows.Forms.ColumnHeader cEnd;
        private System.Windows.Forms.ColumnHeader cColor;
        private System.Windows.Forms.ColumnHeader cDashStyle;
        private System.Windows.Forms.ColumnHeader cLineWidth;
        private System.Windows.Forms.ColumnHeader cSelect;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button button2;
    }
}

