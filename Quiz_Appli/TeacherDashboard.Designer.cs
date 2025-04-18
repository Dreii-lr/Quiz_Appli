namespace Quiz_Appli
{
    partial class frmTeacherHomepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTeacherHomepage));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnProfile = new FontAwesome.Sharp.IconButton();
            this.btnResult = new FontAwesome.Sharp.IconButton();
            this.btnQuiz = new FontAwesome.Sharp.IconButton();
            this.btnDashboard = new FontAwesome.Sharp.IconButton();
            this.pnlLogoBox = new System.Windows.Forms.Panel();
            this.btnMenu = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pcbLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnlTitleBar = new Guna.UI2.WinForms.Guna2Panel();
            this.btnZooming = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlDesktop = new System.Windows.Forms.Panel();
            this.tlpDashboardHomepage = new System.Windows.Forms.TableLayoutPanel();
            this.pnlDeadline = new Guna.UI2.WinForms.Guna2Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnlStudentAssigned = new Guna.UI2.WinForms.Guna2Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnlQuizTotal = new Guna.UI2.WinForms.Guna2Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnlMenu.SuspendLayout();
            this.pnlLogoBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.pnlTitleBar.SuspendLayout();
            this.pnlDesktop.SuspendLayout();
            this.tlpDashboardHomepage.SuspendLayout();
            this.pnlDeadline.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            this.pnlStudentAssigned.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.pnlQuizTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.pnlMenu.TabIndex = 0;
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
            this.btnProfile.TabIndex = 4;
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
            this.btnResult.TabIndex = 3;
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
            this.btnQuiz.Click += new System.EventHandler(this.btnQuiz_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.Dyalog;
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
            this.btnMenu.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnMenu.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnMenu.ImageRotate = 0F;
            this.btnMenu.ImageSize = new System.Drawing.Size(40, 40);
            this.btnMenu.Location = new System.Drawing.Point(170, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
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
            this.pnlTitleBar.TabIndex = 1;
            this.pnlTitleBar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTitleBar_Paint);
            this.pnlTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseDown);
            // 
            // btnZooming
            // 
            this.btnZooming.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZooming.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnZooming.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.btnZooming.CheckedState.ImageSize = new System.Drawing.Size(15, 15);
            this.btnZooming.HoverState.ImageSize = new System.Drawing.Size(15, 15);
            this.btnZooming.Image = ((System.Drawing.Image)(resources.GetObject("btnZooming.Image")));
            this.btnZooming.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnZooming.ImageRotate = 0F;
            this.btnZooming.ImageSize = new System.Drawing.Size(15, 15);
            this.btnZooming.Location = new System.Drawing.Point(813, 0);
            this.btnZooming.Name = "btnZooming";
            this.btnZooming.Size = new System.Drawing.Size(45, 25);
            this.btnZooming.TabIndex = 6;
            this.btnZooming.CheckedChanged += new System.EventHandler(this.btnZooming_CheckedChanged);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnMinimize.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.btnMinimize.HoverState.ImageSize = new System.Drawing.Size(15, 15);
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnMinimize.ImageRotate = 0F;
            this.btnMinimize.ImageSize = new System.Drawing.Size(15, 15);
            this.btnMinimize.Location = new System.Drawing.Point(769, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
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
            this.btnClose.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image5")));
            this.btnClose.HoverState.ImageSize = new System.Drawing.Size(15, 15);
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnClose.ImageRotate = 0F;
            this.btnClose.ImageSize = new System.Drawing.Size(15, 15);
            this.btnClose.Location = new System.Drawing.Point(859, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image6")));
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
            this.label1.Size = new System.Drawing.Size(275, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Teacher Dashboard";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnlDesktop
            // 
            this.pnlDesktop.BackColor = System.Drawing.Color.White;
            this.pnlDesktop.Controls.Add(this.tlpDashboardHomepage);
            this.pnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDesktop.Location = new System.Drawing.Point(230, 60);
            this.pnlDesktop.Name = "pnlDesktop";
            this.pnlDesktop.Padding = new System.Windows.Forms.Padding(10);
            this.pnlDesktop.Size = new System.Drawing.Size(904, 501);
            this.pnlDesktop.TabIndex = 2;
            this.pnlDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDesktop_Paint);
            // 
            // tlpDashboardHomepage
            // 
            this.tlpDashboardHomepage.ColumnCount = 3;
            this.tlpDashboardHomepage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpDashboardHomepage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpDashboardHomepage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpDashboardHomepage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpDashboardHomepage.Controls.Add(this.pnlDeadline, 2, 0);
            this.tlpDashboardHomepage.Controls.Add(this.pnlStudentAssigned, 1, 0);
            this.tlpDashboardHomepage.Controls.Add(this.pnlQuizTotal, 0, 0);
            this.tlpDashboardHomepage.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpDashboardHomepage.Location = new System.Drawing.Point(10, 10);
            this.tlpDashboardHomepage.Name = "tlpDashboardHomepage";
            this.tlpDashboardHomepage.RowCount = 1;
            this.tlpDashboardHomepage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDashboardHomepage.Size = new System.Drawing.Size(884, 250);
            this.tlpDashboardHomepage.TabIndex = 0;
            // 
            // pnlDeadline
            // 
            this.pnlDeadline.BackColor = System.Drawing.Color.Indigo;
            this.pnlDeadline.Controls.Add(this.label7);
            this.pnlDeadline.Controls.Add(this.label4);
            this.pnlDeadline.Controls.Add(this.guna2PictureBox3);
            this.pnlDeadline.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDeadline.Location = new System.Drawing.Point(588, 0);
            this.pnlDeadline.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.pnlDeadline.Name = "pnlDeadline";
            this.pnlDeadline.Size = new System.Drawing.Size(296, 240);
            this.pnlDeadline.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(263, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 32);
            this.label7.TabIndex = 9;
            this.label7.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Quiz Deadline";
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2PictureBox3.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox3.Image")));
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(17, 126);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(100, 100);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox3.TabIndex = 1;
            this.guna2PictureBox3.TabStop = false;
            // 
            // pnlStudentAssigned
            // 
            this.pnlStudentAssigned.BackColor = System.Drawing.Color.MediumVioletRed;
            this.pnlStudentAssigned.Controls.Add(this.label6);
            this.pnlStudentAssigned.Controls.Add(this.label3);
            this.pnlStudentAssigned.Controls.Add(this.guna2PictureBox2);
            this.pnlStudentAssigned.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStudentAssigned.Location = new System.Drawing.Point(294, 0);
            this.pnlStudentAssigned.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.pnlStudentAssigned.Name = "pnlStudentAssigned";
            this.pnlStudentAssigned.Size = new System.Drawing.Size(284, 240);
            this.pnlStudentAssigned.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(251, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 32);
            this.label6.TabIndex = 8;
            this.label6.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Student Assigned";
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2PictureBox2.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(18, 128);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(100, 100);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 1;
            this.guna2PictureBox2.TabStop = false;
            // 
            // pnlQuizTotal
            // 
            this.pnlQuizTotal.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.pnlQuizTotal.Controls.Add(this.label5);
            this.pnlQuizTotal.Controls.Add(this.label2);
            this.pnlQuizTotal.Controls.Add(this.guna2PictureBox1);
            this.pnlQuizTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlQuizTotal.Location = new System.Drawing.Point(0, 0);
            this.pnlQuizTotal.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.pnlQuizTotal.Name = "pnlQuizTotal";
            this.pnlQuizTotal.Size = new System.Drawing.Size(284, 240);
            this.pnlQuizTotal.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(251, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 32);
            this.label5.TabIndex = 7;
            this.label5.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Quizzes Created";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2PictureBox1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(3, 118);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(121, 119);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // frmTeacherHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 561);
            this.Controls.Add(this.pnlDesktop);
            this.Controls.Add(this.pnlTitleBar);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmTeacherHomepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeacherDashboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.frmQuizMaker_Resize);
            this.pnlMenu.ResumeLayout(false);
            this.pnlLogoBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            this.pnlDesktop.ResumeLayout(false);
            this.tlpDashboardHomepage.ResumeLayout(false);
            this.pnlDeadline.ResumeLayout(false);
            this.pnlDeadline.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            this.pnlStudentAssigned.ResumeLayout(false);
            this.pnlStudentAssigned.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.pnlQuizTotal.ResumeLayout(false);
            this.pnlQuizTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private Guna.UI2.WinForms.Guna2Panel pnlTitleBar;
        private System.Windows.Forms.Panel pnlLogoBox;
        private System.Windows.Forms.Panel pnlDesktop;
        private Guna.UI2.WinForms.Guna2ImageButton btnMenu;
        private Guna.UI2.WinForms.Guna2PictureBox pcbLogo;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private FontAwesome.Sharp.IconButton btnQuiz;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ImageButton btnClose;
        private Guna.UI2.WinForms.Guna2ImageButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnProfile;
        private FontAwesome.Sharp.IconButton btnResult;
        private System.Windows.Forms.TableLayoutPanel tlpDashboardHomepage;
        private Guna.UI2.WinForms.Guna2Panel pnlQuizTotal;
        private Guna.UI2.WinForms.Guna2Panel pnlDeadline;
        private Guna.UI2.WinForms.Guna2Panel pnlStudentAssigned;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ImageCheckBox btnZooming;
    }
}