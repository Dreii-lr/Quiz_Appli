namespace Quiz_Appli
{
    partial class frmTeacherQuizPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTeacherQuizPage));
            this.pnlDesktop = new System.Windows.Forms.Panel();
            this.tlpQuizManagement = new System.Windows.Forms.TableLayoutPanel();
            this.pnlQuizzes5 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlQuizzes4 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlQuizzes3 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlQuizzes2 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlQuizzes1 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlTitleBar = new Guna.UI2.WinForms.Guna2Panel();
            this.btnZooming = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnProfile = new FontAwesome.Sharp.IconButton();
            this.btnResult = new FontAwesome.Sharp.IconButton();
            this.btnQuiz = new FontAwesome.Sharp.IconButton();
            this.btnDashboard = new FontAwesome.Sharp.IconButton();
            this.pnlLogoBox = new System.Windows.Forms.Panel();
            this.btnMenu = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pcbLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblQuizTitle3 = new System.Windows.Forms.Label();
            this.lblQuizTitle4 = new System.Windows.Forms.Label();
            this.lblQuizTitle5 = new System.Windows.Forms.Label();
            this.lblQuizTitle2 = new System.Windows.Forms.Label();
            this.lblQuizTitle1 = new System.Windows.Forms.Label();
            this.pnlDesktop.SuspendLayout();
            this.tlpQuizManagement.SuspendLayout();
            this.pnlQuizzes5.SuspendLayout();
            this.pnlQuizzes4.SuspendLayout();
            this.pnlQuizzes3.SuspendLayout();
            this.pnlQuizzes2.SuspendLayout();
            this.pnlQuizzes1.SuspendLayout();
            this.pnlTitleBar.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlLogoBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDesktop
            // 
            this.pnlDesktop.BackColor = System.Drawing.Color.White;
            this.pnlDesktop.Controls.Add(this.tlpQuizManagement);
            this.pnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDesktop.Location = new System.Drawing.Point(230, 60);
            this.pnlDesktop.Name = "pnlDesktop";
            this.pnlDesktop.Padding = new System.Windows.Forms.Padding(10);
            this.pnlDesktop.Size = new System.Drawing.Size(904, 501);
            this.pnlDesktop.TabIndex = 5;
            this.pnlDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDesktop_Paint);
            // 
            // tlpQuizManagement
            // 
            this.tlpQuizManagement.ColumnCount = 1;
            this.tlpQuizManagement.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpQuizManagement.Controls.Add(this.pnlQuizzes5, 0, 4);
            this.tlpQuizManagement.Controls.Add(this.pnlQuizzes4, 0, 3);
            this.tlpQuizManagement.Controls.Add(this.pnlQuizzes3, 0, 2);
            this.tlpQuizManagement.Controls.Add(this.pnlQuizzes2, 0, 1);
            this.tlpQuizManagement.Controls.Add(this.pnlQuizzes1, 0, 0);
            this.tlpQuizManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpQuizManagement.Location = new System.Drawing.Point(10, 10);
            this.tlpQuizManagement.Margin = new System.Windows.Forms.Padding(0);
            this.tlpQuizManagement.Name = "tlpQuizManagement";
            this.tlpQuizManagement.RowCount = 5;
            this.tlpQuizManagement.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpQuizManagement.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpQuizManagement.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpQuizManagement.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpQuizManagement.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpQuizManagement.Size = new System.Drawing.Size(884, 481);
            this.tlpQuizManagement.TabIndex = 0;
            // 
            // pnlQuizzes5
            // 
            this.pnlQuizzes5.BackColor = System.Drawing.Color.Transparent;
            this.pnlQuizzes5.BorderColor = System.Drawing.Color.Black;
            this.pnlQuizzes5.BorderRadius = 20;
            this.pnlQuizzes5.BorderThickness = 1;
            this.pnlQuizzes5.Controls.Add(this.lblQuizTitle5);
            this.pnlQuizzes5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlQuizzes5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlQuizzes5.Location = new System.Drawing.Point(0, 384);
            this.pnlQuizzes5.Margin = new System.Windows.Forms.Padding(0);
            this.pnlQuizzes5.Name = "pnlQuizzes5";
            this.pnlQuizzes5.Size = new System.Drawing.Size(884, 97);
            this.pnlQuizzes5.TabIndex = 1;
            // 
            // pnlQuizzes4
            // 
            this.pnlQuizzes4.BackColor = System.Drawing.Color.Transparent;
            this.pnlQuizzes4.BorderColor = System.Drawing.Color.Black;
            this.pnlQuizzes4.BorderRadius = 20;
            this.pnlQuizzes4.BorderThickness = 1;
            this.pnlQuizzes4.Controls.Add(this.lblQuizTitle4);
            this.pnlQuizzes4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlQuizzes4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlQuizzes4.Location = new System.Drawing.Point(0, 288);
            this.pnlQuizzes4.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.pnlQuizzes4.Name = "pnlQuizzes4";
            this.pnlQuizzes4.Size = new System.Drawing.Size(884, 86);
            this.pnlQuizzes4.TabIndex = 1;
            // 
            // pnlQuizzes3
            // 
            this.pnlQuizzes3.BackColor = System.Drawing.Color.Transparent;
            this.pnlQuizzes3.BorderColor = System.Drawing.Color.Black;
            this.pnlQuizzes3.BorderRadius = 20;
            this.pnlQuizzes3.BorderThickness = 1;
            this.pnlQuizzes3.Controls.Add(this.lblQuizTitle3);
            this.pnlQuizzes3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlQuizzes3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlQuizzes3.Location = new System.Drawing.Point(0, 192);
            this.pnlQuizzes3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.pnlQuizzes3.Name = "pnlQuizzes3";
            this.pnlQuizzes3.Size = new System.Drawing.Size(884, 86);
            this.pnlQuizzes3.TabIndex = 1;
            // 
            // pnlQuizzes2
            // 
            this.pnlQuizzes2.BackColor = System.Drawing.Color.Transparent;
            this.pnlQuizzes2.BorderColor = System.Drawing.Color.Black;
            this.pnlQuizzes2.BorderRadius = 20;
            this.pnlQuizzes2.BorderThickness = 1;
            this.pnlQuizzes2.Controls.Add(this.lblQuizTitle2);
            this.pnlQuizzes2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlQuizzes2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlQuizzes2.Location = new System.Drawing.Point(0, 96);
            this.pnlQuizzes2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.pnlQuizzes2.Name = "pnlQuizzes2";
            this.pnlQuizzes2.Size = new System.Drawing.Size(884, 86);
            this.pnlQuizzes2.TabIndex = 1;
            // 
            // pnlQuizzes1
            // 
            this.pnlQuizzes1.BackColor = System.Drawing.Color.Transparent;
            this.pnlQuizzes1.BorderColor = System.Drawing.Color.Black;
            this.pnlQuizzes1.BorderRadius = 20;
            this.pnlQuizzes1.BorderThickness = 1;
            this.pnlQuizzes1.Controls.Add(this.lblQuizTitle1);
            this.pnlQuizzes1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlQuizzes1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlQuizzes1.Location = new System.Drawing.Point(0, 0);
            this.pnlQuizzes1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.pnlQuizzes1.Name = "pnlQuizzes1";
            this.pnlQuizzes1.Size = new System.Drawing.Size(884, 86);
            this.pnlQuizzes1.TabIndex = 0;
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.Purple;
            this.pnlTitleBar.Controls.Add(this.btnZooming);
            this.pnlTitleBar.Controls.Add(this.btnMinimize);
            this.pnlTitleBar.Controls.Add(this.btnClose);
            this.pnlTitleBar.Controls.Add(this.label1);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(230, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(904, 60);
            this.pnlTitleBar.TabIndex = 4;
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
            this.btnZooming.Location = new System.Drawing.Point(814, 0);
            this.btnZooming.Name = "btnZooming";
            this.btnZooming.Size = new System.Drawing.Size(45, 25);
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
            this.btnMinimize.Location = new System.Drawing.Point(769, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.btnMinimize.PressedState.ImageSize = new System.Drawing.Size(15, 15);
            this.btnMinimize.Size = new System.Drawing.Size(45, 25);
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
            this.btnClose.Location = new System.Drawing.Point(859, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            this.btnClose.PressedState.ImageSize = new System.Drawing.Size(15, 15);
            this.btnClose.Size = new System.Drawing.Size(45, 25);
            this.btnClose.TabIndex = 2;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quiz Management";
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pnlMenu.Controls.Add(this.btnProfile);
            this.pnlMenu.Controls.Add(this.btnResult);
            this.pnlMenu.Controls.Add(this.btnQuiz);
            this.pnlMenu.Controls.Add(this.btnDashboard);
            this.pnlMenu.Controls.Add(this.pnlLogoBox);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(230, 561);
            this.pnlMenu.TabIndex = 3;
            // 
            // btnProfile
            // 
            this.btnProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.btnProfile.IconColor = System.Drawing.Color.White;
            this.btnProfile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProfile.IconSize = 40;
            this.btnProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.Location = new System.Drawing.Point(0, 232);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(230, 44);
            this.btnProfile.TabIndex = 8;
            this.btnProfile.Tag = "Profile";
            this.btnProfile.Text = "Profile";
            this.btnProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnResult
            // 
            this.btnResult.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnResult.FlatAppearance.BorderSize = 0;
            this.btnResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResult.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResult.ForeColor = System.Drawing.Color.White;
            this.btnResult.IconChar = FontAwesome.Sharp.IconChar.ListUl;
            this.btnResult.IconColor = System.Drawing.Color.White;
            this.btnResult.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnResult.IconSize = 40;
            this.btnResult.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResult.Location = new System.Drawing.Point(0, 188);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(230, 44);
            this.btnResult.TabIndex = 7;
            this.btnResult.Tag = "Results";
            this.btnResult.Text = "Results";
            this.btnResult.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // btnQuiz
            // 
            this.btnQuiz.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuiz.FlatAppearance.BorderSize = 0;
            this.btnQuiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuiz.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuiz.ForeColor = System.Drawing.Color.White;
            this.btnQuiz.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.btnQuiz.IconColor = System.Drawing.Color.White;
            this.btnQuiz.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQuiz.IconSize = 40;
            this.btnQuiz.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuiz.Location = new System.Drawing.Point(0, 144);
            this.btnQuiz.Name = "btnQuiz";
            this.btnQuiz.Size = new System.Drawing.Size(230, 44);
            this.btnQuiz.TabIndex = 2;
            this.btnQuiz.Tag = "Quiz";
            this.btnQuiz.Text = "Quiz Management";
            this.btnQuiz.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuiz.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.House;
            this.btnDashboard.IconColor = System.Drawing.Color.White;
            this.btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDashboard.IconSize = 40;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 100);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(230, 44);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Tag = "Home";
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pnlLogoBox
            // 
            this.pnlLogoBox.Controls.Add(this.btnMenu);
            this.pnlLogoBox.Controls.Add(this.pcbLogo);
            this.pnlLogoBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogoBox.Location = new System.Drawing.Point(0, 0);
            this.pnlLogoBox.Name = "pnlLogoBox";
            this.pnlLogoBox.Size = new System.Drawing.Size(230, 100);
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
            this.btnMenu.Location = new System.Drawing.Point(170, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image6")));
            this.btnMenu.PressedState.ImageSize = new System.Drawing.Size(40, 40);
            this.btnMenu.Size = new System.Drawing.Size(60, 60);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // pcbLogo
            // 
            this.pcbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pcbLogo.Image")));
            this.pcbLogo.ImageRotate = 0F;
            this.pcbLogo.Location = new System.Drawing.Point(21, 0);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(142, 75);
            this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbLogo.TabIndex = 0;
            this.pcbLogo.TabStop = false;
            // 
            // lblQuizTitle3
            // 
            this.lblQuizTitle3.AutoSize = true;
            this.lblQuizTitle3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuizTitle3.ForeColor = System.Drawing.Color.White;
            this.lblQuizTitle3.Location = new System.Drawing.Point(24, 15);
            this.lblQuizTitle3.Name = "lblQuizTitle3";
            this.lblQuizTitle3.Size = new System.Drawing.Size(136, 32);
            this.lblQuizTitle3.TabIndex = 6;
            this.lblQuizTitle3.Text = "Quiz Title";
            // 
            // lblQuizTitle4
            // 
            this.lblQuizTitle4.AutoSize = true;
            this.lblQuizTitle4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuizTitle4.ForeColor = System.Drawing.Color.White;
            this.lblQuizTitle4.Location = new System.Drawing.Point(24, 16);
            this.lblQuizTitle4.Name = "lblQuizTitle4";
            this.lblQuizTitle4.Size = new System.Drawing.Size(136, 32);
            this.lblQuizTitle4.TabIndex = 7;
            this.lblQuizTitle4.Text = "Quiz Title";
            // 
            // lblQuizTitle5
            // 
            this.lblQuizTitle5.AutoSize = true;
            this.lblQuizTitle5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuizTitle5.ForeColor = System.Drawing.Color.White;
            this.lblQuizTitle5.Location = new System.Drawing.Point(24, 14);
            this.lblQuizTitle5.Name = "lblQuizTitle5";
            this.lblQuizTitle5.Size = new System.Drawing.Size(136, 32);
            this.lblQuizTitle5.TabIndex = 8;
            this.lblQuizTitle5.Text = "Quiz Title";
            // 
            // lblQuizTitle2
            // 
            this.lblQuizTitle2.AutoSize = true;
            this.lblQuizTitle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuizTitle2.ForeColor = System.Drawing.Color.White;
            this.lblQuizTitle2.Location = new System.Drawing.Point(24, 15);
            this.lblQuizTitle2.Name = "lblQuizTitle2";
            this.lblQuizTitle2.Size = new System.Drawing.Size(136, 32);
            this.lblQuizTitle2.TabIndex = 8;
            this.lblQuizTitle2.Text = "Quiz Title";
            // 
            // lblQuizTitle1
            // 
            this.lblQuizTitle1.AutoSize = true;
            this.lblQuizTitle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuizTitle1.ForeColor = System.Drawing.Color.White;
            this.lblQuizTitle1.Location = new System.Drawing.Point(24, 17);
            this.lblQuizTitle1.Name = "lblQuizTitle1";
            this.lblQuizTitle1.Size = new System.Drawing.Size(136, 32);
            this.lblQuizTitle1.TabIndex = 9;
            this.lblQuizTitle1.Text = "Quiz Title";
            // 
            // frmTeacherQuizPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 561);
            this.Controls.Add(this.pnlDesktop);
            this.Controls.Add(this.pnlTitleBar);
            this.Controls.Add(this.pnlMenu);
            this.Name = "frmTeacherQuizPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeacherQuizPage";
            this.pnlDesktop.ResumeLayout(false);
            this.tlpQuizManagement.ResumeLayout(false);
            this.pnlQuizzes5.ResumeLayout(false);
            this.pnlQuizzes5.PerformLayout();
            this.pnlQuizzes4.ResumeLayout(false);
            this.pnlQuizzes4.PerformLayout();
            this.pnlQuizzes3.ResumeLayout(false);
            this.pnlQuizzes3.PerformLayout();
            this.pnlQuizzes2.ResumeLayout(false);
            this.pnlQuizzes2.PerformLayout();
            this.pnlQuizzes1.ResumeLayout(false);
            this.pnlQuizzes1.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlMenu;
        private FontAwesome.Sharp.IconButton btnQuiz;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private System.Windows.Forms.Panel pnlLogoBox;
        private Guna.UI2.WinForms.Guna2ImageButton btnMenu;
        private Guna.UI2.WinForms.Guna2PictureBox pcbLogo;
        private FontAwesome.Sharp.IconButton btnProfile;
        private FontAwesome.Sharp.IconButton btnResult;
        private System.Windows.Forms.TableLayoutPanel tlpQuizManagement;
        private Guna.UI2.WinForms.Guna2Panel pnlQuizzes5;
        private Guna.UI2.WinForms.Guna2Panel pnlQuizzes4;
        private Guna.UI2.WinForms.Guna2Panel pnlQuizzes3;
        private Guna.UI2.WinForms.Guna2Panel pnlQuizzes2;
        private Guna.UI2.WinForms.Guna2Panel pnlQuizzes1;
        private System.Windows.Forms.Label lblQuizTitle5;
        private System.Windows.Forms.Label lblQuizTitle4;
        private System.Windows.Forms.Label lblQuizTitle3;
        private System.Windows.Forms.Label lblQuizTitle2;
        private System.Windows.Forms.Label lblQuizTitle1;
    }
}