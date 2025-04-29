namespace Quiz_Appli
{
    partial class frmAdminStudentManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminStudentManagement));
            this.pnlDesktop = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlDraftQuizzes = new Guna.UI2.WinForms.Guna2Panel();
            this.ADDSTD = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2TileButton1 = new Guna.UI2.WinForms.Guna2TileButton();
            this.REMOVESTD = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Student_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTitleBar = new Guna.UI2.WinForms.Guna2Panel();
            this.btnZooming = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnSettings = new FontAwesome.Sharp.IconButton();
            this.btnResults = new FontAwesome.Sharp.IconButton();
            this.btnQuizManagement = new FontAwesome.Sharp.IconButton();
            this.btnStudentManagement = new FontAwesome.Sharp.IconButton();
            this.btnTeacherManagement = new FontAwesome.Sharp.IconButton();
            this.btnDashboard = new FontAwesome.Sharp.IconButton();
            this.pnlLogoBox = new System.Windows.Forms.Panel();
            this.btnMenu = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pcbLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2TileButton2 = new Guna.UI2.WinForms.Guna2TileButton();
            this.pnlDesktop.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlDraftQuizzes.SuspendLayout();
            this.ADDSTD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.REMOVESTD)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.pnlTitleBar.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlLogoBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDesktop
            // 
            this.pnlDesktop.BackColor = System.Drawing.Color.White;
            this.pnlDesktop.Controls.Add(this.tableLayoutPanel1);
            this.pnlDesktop.Controls.Add(this.REMOVESTD);
            this.pnlDesktop.Controls.Add(this.guna2Panel1);
            this.pnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDesktop.Location = new System.Drawing.Point(353, 74);
            this.pnlDesktop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlDesktop.Name = "pnlDesktop";
            this.pnlDesktop.Size = new System.Drawing.Size(1159, 616);
            this.pnlDesktop.TabIndex = 17;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.pnlDraftQuizzes, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ADDSTD, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 39);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1159, 72);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // pnlDraftQuizzes
            // 
            this.pnlDraftQuizzes.BackColor = System.Drawing.Color.Transparent;
            this.pnlDraftQuizzes.BorderColor = System.Drawing.Color.Black;
            this.pnlDraftQuizzes.BorderRadius = 5;
            this.pnlDraftQuizzes.BorderThickness = 1;
            this.pnlDraftQuizzes.Controls.Add(this.guna2TileButton2);
            this.pnlDraftQuizzes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDraftQuizzes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pnlDraftQuizzes.Location = new System.Drawing.Point(579, 0);
            this.pnlDraftQuizzes.Margin = new System.Windows.Forms.Padding(0, 0, 13, 12);
            this.pnlDraftQuizzes.Name = "pnlDraftQuizzes";
            this.pnlDraftQuizzes.Size = new System.Drawing.Size(567, 60);
            this.pnlDraftQuizzes.TabIndex = 1;
            // 
            // ADDSTD
            // 
            this.ADDSTD.BackColor = System.Drawing.Color.Transparent;
            this.ADDSTD.BorderColor = System.Drawing.Color.Black;
            this.ADDSTD.BorderRadius = 5;
            this.ADDSTD.BorderThickness = 1;
            this.ADDSTD.Controls.Add(this.guna2TileButton1);
            this.ADDSTD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ADDSTD.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ADDSTD.Location = new System.Drawing.Point(0, 0);
            this.ADDSTD.Margin = new System.Windows.Forms.Padding(0, 0, 13, 12);
            this.ADDSTD.Name = "ADDSTD";
            this.ADDSTD.Size = new System.Drawing.Size(566, 60);
            this.ADDSTD.TabIndex = 0;
            // 
            // guna2TileButton1
            // 
            this.guna2TileButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2TileButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2TileButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2TileButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2TileButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.guna2TileButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TileButton1.ForeColor = System.Drawing.Color.White;
            this.guna2TileButton1.Location = new System.Drawing.Point(161, 6);
            this.guna2TileButton1.Name = "guna2TileButton1";
            this.guna2TileButton1.Size = new System.Drawing.Size(168, 50);
            this.guna2TileButton1.TabIndex = 0;
            this.guna2TileButton1.Text = "ADD NEW STUDENT";
            // 
            // REMOVESTD
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.REMOVESTD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.REMOVESTD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.REMOVESTD.ColumnHeadersHeight = 18;
            this.REMOVESTD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.REMOVESTD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Student_id,
            this.FirstName,
            this.MiddleName,
            this.LastName,
            this.Status,
            this.password,
            this.username});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.REMOVESTD.DefaultCellStyle = dataGridViewCellStyle3;
            this.REMOVESTD.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.REMOVESTD.Location = new System.Drawing.Point(0, 130);
            this.REMOVESTD.Name = "REMOVESTD";
            this.REMOVESTD.RowHeadersVisible = false;
            this.REMOVESTD.RowHeadersWidth = 51;
            this.REMOVESTD.RowTemplate.Height = 24;
            this.REMOVESTD.Size = new System.Drawing.Size(1159, 399);
            this.REMOVESTD.TabIndex = 5;
            this.REMOVESTD.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.REMOVESTD.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.REMOVESTD.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.REMOVESTD.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.REMOVESTD.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.REMOVESTD.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.REMOVESTD.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.REMOVESTD.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.REMOVESTD.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.REMOVESTD.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.REMOVESTD.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.REMOVESTD.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.REMOVESTD.ThemeStyle.HeaderStyle.Height = 18;
            this.REMOVESTD.ThemeStyle.ReadOnly = false;
            this.REMOVESTD.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.REMOVESTD.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.REMOVESTD.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.REMOVESTD.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.REMOVESTD.ThemeStyle.RowsStyle.Height = 24;
            this.REMOVESTD.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.REMOVESTD.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Student_id
            // 
            this.Student_id.HeaderText = "Student_id";
            this.Student_id.MinimumWidth = 6;
            this.Student_id.Name = "Student_id";
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            // 
            // MiddleName
            // 
            this.MiddleName.HeaderText = "MiddleName";
            this.MiddleName.MinimumWidth = 6;
            this.MiddleName.Name = "MiddleName";
            // 
            // LastName
            // 
            this.LastName.HeaderText = "LastName";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            // 
            // password
            // 
            this.password.HeaderText = "password";
            this.password.MinimumWidth = 6;
            this.password.Name = "password";
            // 
            // username
            // 
            this.username.HeaderText = "username";
            this.username.MinimumWidth = 6;
            this.username.Name = "username";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1159, 39);
            this.guna2Panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "Student Information";
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.Purple;
            this.pnlTitleBar.Controls.Add(this.btnZooming);
            this.pnlTitleBar.Controls.Add(this.btnMinimize);
            this.pnlTitleBar.Controls.Add(this.btnClose);
            this.pnlTitleBar.Controls.Add(this.lblTitle);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(353, 0);
            this.pnlTitleBar.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(1159, 74);
            this.pnlTitleBar.TabIndex = 16;
            this.pnlTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseDown);
            // 
            // btnZooming
            // 
            this.btnZooming.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZooming.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnZooming.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnZooming.CheckedState.ImageSize = new System.Drawing.Size(15, 15);
            this.btnZooming.HoverState.ImageSize = new System.Drawing.Size(15, 15);
            this.btnZooming.Image = ((System.Drawing.Image)(resources.GetObject("btnZooming.Image")));
            this.btnZooming.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnZooming.ImageRotate = 0F;
            this.btnZooming.ImageSize = new System.Drawing.Size(15, 15);
            this.btnZooming.Location = new System.Drawing.Point(1039, 0);
            this.btnZooming.Margin = new System.Windows.Forms.Padding(4);
            this.btnZooming.Name = "btnZooming";
            this.btnZooming.Size = new System.Drawing.Size(60, 31);
            this.btnZooming.TabIndex = 5;
            this.btnZooming.CheckedChanged += new System.EventHandler(this.btnZooming_CheckedChanged);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnMinimize.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnMinimize.HoverState.ImageSize = new System.Drawing.Size(15, 15);
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnMinimize.ImageRotate = 0F;
            this.btnMinimize.ImageSize = new System.Drawing.Size(15, 15);
            this.btnMinimize.Location = new System.Drawing.Point(979, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.btnMinimize.PressedState.ImageSize = new System.Drawing.Size(15, 15);
            this.btnMinimize.Size = new System.Drawing.Size(60, 31);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Crimson;
            this.btnClose.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.btnClose.HoverState.ImageSize = new System.Drawing.Size(15, 15);
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnClose.ImageRotate = 0F;
            this.btnClose.ImageSize = new System.Drawing.Size(15, 15);
            this.btnClose.Location = new System.Drawing.Point(1099, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            this.btnClose.PressedState.ImageSize = new System.Drawing.Size(15, 15);
            this.btnClose.Size = new System.Drawing.Size(60, 31);
            this.btnClose.TabIndex = 2;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(24, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(341, 39);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Student Management";
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pnlMenu.Controls.Add(this.btnSettings);
            this.pnlMenu.Controls.Add(this.btnResults);
            this.pnlMenu.Controls.Add(this.btnQuizManagement);
            this.pnlMenu.Controls.Add(this.btnStudentManagement);
            this.pnlMenu.Controls.Add(this.btnTeacherManagement);
            this.pnlMenu.Controls.Add(this.btnDashboard);
            this.pnlMenu.Controls.Add(this.pnlLogoBox);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(353, 690);
            this.pnlMenu.TabIndex = 15;
            // 
            // btnSettings
            // 
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.IconChar = FontAwesome.Sharp.IconChar.Gears;
            this.btnSettings.IconColor = System.Drawing.Color.White;
            this.btnSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSettings.IconSize = 40;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(0, 433);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(353, 62);
            this.btnSettings.TabIndex = 13;
            this.btnSettings.Tag = "Settings";
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnResults
            // 
            this.btnResults.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResults.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnResults.FlatAppearance.BorderSize = 0;
            this.btnResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResults.ForeColor = System.Drawing.Color.White;
            this.btnResults.IconChar = FontAwesome.Sharp.IconChar.ChartSimple;
            this.btnResults.IconColor = System.Drawing.Color.White;
            this.btnResults.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnResults.IconSize = 40;
            this.btnResults.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResults.Location = new System.Drawing.Point(0, 371);
            this.btnResults.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnResults.Name = "btnResults";
            this.btnResults.Size = new System.Drawing.Size(353, 62);
            this.btnResults.TabIndex = 12;
            this.btnResults.Tag = "Results";
            this.btnResults.Text = "Results";
            this.btnResults.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnResults.UseVisualStyleBackColor = true;
            this.btnResults.Click += new System.EventHandler(this.btnResults_Click);
            // 
            // btnQuizManagement
            // 
            this.btnQuizManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuizManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuizManagement.FlatAppearance.BorderSize = 0;
            this.btnQuizManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuizManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuizManagement.ForeColor = System.Drawing.Color.White;
            this.btnQuizManagement.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnQuizManagement.IconColor = System.Drawing.Color.White;
            this.btnQuizManagement.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQuizManagement.IconSize = 40;
            this.btnQuizManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuizManagement.Location = new System.Drawing.Point(0, 309);
            this.btnQuizManagement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuizManagement.Name = "btnQuizManagement";
            this.btnQuizManagement.Size = new System.Drawing.Size(353, 62);
            this.btnQuizManagement.TabIndex = 11;
            this.btnQuizManagement.Tag = "Quiz Management";
            this.btnQuizManagement.Text = "Quiz Management";
            this.btnQuizManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuizManagement.UseVisualStyleBackColor = true;
            this.btnQuizManagement.Click += new System.EventHandler(this.btnQuizManagement_Click);
            // 
            // btnStudentManagement
            // 
            this.btnStudentManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudentManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudentManagement.FlatAppearance.BorderSize = 0;
            this.btnStudentManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentManagement.ForeColor = System.Drawing.Color.White;
            this.btnStudentManagement.IconChar = FontAwesome.Sharp.IconChar.UserGraduate;
            this.btnStudentManagement.IconColor = System.Drawing.Color.White;
            this.btnStudentManagement.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStudentManagement.IconSize = 40;
            this.btnStudentManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudentManagement.Location = new System.Drawing.Point(0, 247);
            this.btnStudentManagement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStudentManagement.Name = "btnStudentManagement";
            this.btnStudentManagement.Size = new System.Drawing.Size(353, 62);
            this.btnStudentManagement.TabIndex = 10;
            this.btnStudentManagement.Tag = "Student Management";
            this.btnStudentManagement.Text = "Student Management";
            this.btnStudentManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStudentManagement.UseVisualStyleBackColor = true;
            // 
            // btnTeacherManagement
            // 
            this.btnTeacherManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTeacherManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTeacherManagement.FlatAppearance.BorderSize = 0;
            this.btnTeacherManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeacherManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeacherManagement.ForeColor = System.Drawing.Color.White;
            this.btnTeacherManagement.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.btnTeacherManagement.IconColor = System.Drawing.Color.White;
            this.btnTeacherManagement.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTeacherManagement.IconSize = 40;
            this.btnTeacherManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeacherManagement.Location = new System.Drawing.Point(0, 185);
            this.btnTeacherManagement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTeacherManagement.Name = "btnTeacherManagement";
            this.btnTeacherManagement.Size = new System.Drawing.Size(353, 62);
            this.btnTeacherManagement.TabIndex = 9;
            this.btnTeacherManagement.Tag = "Teacher Management";
            this.btnTeacherManagement.Text = "Teacher Management";
            this.btnTeacherManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTeacherManagement.UseVisualStyleBackColor = true;
            this.btnTeacherManagement.Click += new System.EventHandler(this.btnTeacherManagement_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.BarsProgress;
            this.btnDashboard.IconColor = System.Drawing.Color.White;
            this.btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDashboard.IconSize = 40;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 123);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(353, 62);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Tag = "Dashboard";
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pnlLogoBox
            // 
            this.pnlLogoBox.Controls.Add(this.btnMenu);
            this.pnlLogoBox.Controls.Add(this.pcbLogo);
            this.pnlLogoBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogoBox.Location = new System.Drawing.Point(0, 0);
            this.pnlLogoBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlLogoBox.Name = "pnlLogoBox";
            this.pnlLogoBox.Size = new System.Drawing.Size(353, 123);
            this.pnlLogoBox.TabIndex = 0;
            // 
            // btnMenu
            // 
            this.btnMenu.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image5")));
            this.btnMenu.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnMenu.ImageRotate = 0F;
            this.btnMenu.ImageSize = new System.Drawing.Size(40, 40);
            this.btnMenu.Location = new System.Drawing.Point(271, 0);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image6")));
            this.btnMenu.PressedState.ImageSize = new System.Drawing.Size(40, 40);
            this.btnMenu.Size = new System.Drawing.Size(80, 74);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // pcbLogo
            // 
            this.pcbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pcbLogo.Image")));
            this.pcbLogo.ImageRotate = 0F;
            this.pcbLogo.Location = new System.Drawing.Point(57, 0);
            this.pcbLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(189, 92);
            this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbLogo.TabIndex = 0;
            this.pcbLogo.TabStop = false;
            // 
            // guna2TileButton2
            // 
            this.guna2TileButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2TileButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2TileButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2TileButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2TileButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.guna2TileButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TileButton2.ForeColor = System.Drawing.Color.White;
            this.guna2TileButton2.Location = new System.Drawing.Point(152, 3);
            this.guna2TileButton2.Name = "guna2TileButton2";
            this.guna2TileButton2.Size = new System.Drawing.Size(168, 50);
            this.guna2TileButton2.TabIndex = 1;
            this.guna2TileButton2.Text = "REMOVE STUDENT";
            // 
            // frmAdminStudentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1512, 690);
            this.Controls.Add(this.pnlDesktop);
            this.Controls.Add(this.pnlTitleBar);
            this.Controls.Add(this.pnlMenu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAdminStudentManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminStudentManagement";
            this.pnlDesktop.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlDraftQuizzes.ResumeLayout(false);
            this.ADDSTD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.REMOVESTD)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.pnlLogoBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDesktop;
        private Guna.UI2.WinForms.Guna2Panel pnlTitleBar;
        private Guna.UI2.WinForms.Guna2ImageCheckBox btnZooming;
        private Guna.UI2.WinForms.Guna2ImageButton btnMinimize;
        private Guna.UI2.WinForms.Guna2ImageButton btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlMenu;
        private FontAwesome.Sharp.IconButton btnSettings;
        private FontAwesome.Sharp.IconButton btnResults;
        private FontAwesome.Sharp.IconButton btnQuizManagement;
        private FontAwesome.Sharp.IconButton btnStudentManagement;
        private FontAwesome.Sharp.IconButton btnTeacherManagement;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private System.Windows.Forms.Panel pnlLogoBox;
        private Guna.UI2.WinForms.Guna2ImageButton btnMenu;
        private Guna.UI2.WinForms.Guna2PictureBox pcbLogo;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView REMOVESTD;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Panel pnlDraftQuizzes;
        private Guna.UI2.WinForms.Guna2Panel ADDSTD;
        private Guna.UI2.WinForms.Guna2TileButton guna2TileButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MiddleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private Guna.UI2.WinForms.Guna2TileButton guna2TileButton2;
    }
}