namespace Quiz_Appli
{
    partial class frmStudentProfile
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
            this.pnlDesktop = new System.Windows.Forms.Panel();
            this.pnlSideProfile = new Guna.UI2.WinForms.Guna2Panel();
            this.lblProfle = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlProfile = new Guna.UI2.WinForms.Guna2Panel();
            this.btnChangePass = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateInfo = new Guna.UI2.WinForms.Guna2Button();
            this.lblBirthdate = new System.Windows.Forms.Label();
            this.txtBirthdate = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblName1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.pnlTitleBar = new Guna.UI2.WinForms.Guna2Panel();
            this.btnZooming = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lblProfile = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnProfile = new FontAwesome.Sharp.IconButton();
            this.btnResults = new FontAwesome.Sharp.IconButton();
            this.btnTakeQuiz = new FontAwesome.Sharp.IconButton();
            this.btnDashboard = new FontAwesome.Sharp.IconButton();
            this.pnlLogoBox = new System.Windows.Forms.Panel();
            this.btnMenu = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pcbLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnlDesktop.SuspendLayout();
            this.pnlSideProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.pnlProfile.SuspendLayout();
            this.pnlTitleBar.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlLogoBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDesktop
            // 
            this.pnlDesktop.BackColor = System.Drawing.Color.White;
            this.pnlDesktop.Controls.Add(this.pnlSideProfile);
            this.pnlDesktop.Controls.Add(this.pnlProfile);
            this.pnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDesktop.Location = new System.Drawing.Point(230, 60);
            this.pnlDesktop.Name = "pnlDesktop";
            this.pnlDesktop.Size = new System.Drawing.Size(904, 501);
            this.pnlDesktop.TabIndex = 15;
            // 
            // pnlSideProfile
            // 
            this.pnlSideProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pnlSideProfile.Controls.Add(this.lblProfle);
            this.pnlSideProfile.Controls.Add(this.guna2PictureBox1);
            this.pnlSideProfile.Controls.Add(this.lblName);
            this.pnlSideProfile.Location = new System.Drawing.Point(194, 63);
            this.pnlSideProfile.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSideProfile.Name = "pnlSideProfile";
            this.pnlSideProfile.Size = new System.Drawing.Size(224, 389);
            this.pnlSideProfile.TabIndex = 0;
            // 
            // lblProfle
            // 
            this.lblProfle.AutoSize = true;
            this.lblProfle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfle.ForeColor = System.Drawing.Color.Plum;
            this.lblProfle.Location = new System.Drawing.Point(70, 21);
            this.lblProfle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProfle.Name = "lblProfle";
            this.lblProfle.Size = new System.Drawing.Size(77, 24);
            this.lblProfle.TabIndex = 2;
            this.lblProfle.Text = "Profile";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackgroundImage = global::Quiz_Appli.Properties.Resources.profile;
            this.guna2PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(41, 65);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(135, 108);
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(45, 191);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(127, 18);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Luigee Espiritu";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlProfile
            // 
            this.pnlProfile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlProfile.Controls.Add(this.btnChangePass);
            this.pnlProfile.Controls.Add(this.btnUpdateInfo);
            this.pnlProfile.Controls.Add(this.lblBirthdate);
            this.pnlProfile.Controls.Add(this.txtBirthdate);
            this.pnlProfile.Controls.Add(this.lblUsername);
            this.pnlProfile.Controls.Add(this.lblEmail);
            this.pnlProfile.Controls.Add(this.lblName1);
            this.pnlProfile.Controls.Add(this.txtEmail);
            this.pnlProfile.Controls.Add(this.txtName);
            this.pnlProfile.Controls.Add(this.txtUsername);
            this.pnlProfile.Controls.Add(this.lblInfo);
            this.pnlProfile.Location = new System.Drawing.Point(246, 63);
            this.pnlProfile.Margin = new System.Windows.Forms.Padding(2);
            this.pnlProfile.Name = "pnlProfile";
            this.pnlProfile.Size = new System.Drawing.Size(542, 389);
            this.pnlProfile.TabIndex = 3;
            // 
            // btnChangePass
            // 
            this.btnChangePass.BackColor = System.Drawing.Color.Transparent;
            this.btnChangePass.BorderRadius = 20;
            this.btnChangePass.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChangePass.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChangePass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChangePass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChangePass.FillColor = System.Drawing.Color.Plum;
            this.btnChangePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePass.ForeColor = System.Drawing.Color.Black;
            this.btnChangePass.Location = new System.Drawing.Point(384, 242);
            this.btnChangePass.Margin = new System.Windows.Forms.Padding(2);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(135, 37);
            this.btnChangePass.TabIndex = 10;
            this.btnChangePass.Text = "Change Password";
            // 
            // btnUpdateInfo
            // 
            this.btnUpdateInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateInfo.BorderRadius = 20;
            this.btnUpdateInfo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateInfo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateInfo.FillColor = System.Drawing.Color.Plum;
            this.btnUpdateInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateInfo.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateInfo.Location = new System.Drawing.Point(244, 242);
            this.btnUpdateInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateInfo.Name = "btnUpdateInfo";
            this.btnUpdateInfo.Size = new System.Drawing.Size(135, 37);
            this.btnUpdateInfo.TabIndex = 9;
            this.btnUpdateInfo.Text = "Update Information";
            // 
            // lblBirthdate
            // 
            this.lblBirthdate.AutoSize = true;
            this.lblBirthdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthdate.Location = new System.Drawing.Point(269, 191);
            this.lblBirthdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.Size = new System.Drawing.Size(78, 20);
            this.lblBirthdate.TabIndex = 8;
            this.lblBirthdate.Text = "Birthdate:";
            // 
            // txtBirthdate
            // 
            this.txtBirthdate.Location = new System.Drawing.Point(396, 193);
            this.txtBirthdate.Margin = new System.Windows.Forms.Padding(2);
            this.txtBirthdate.Name = "txtBirthdate";
            this.txtBirthdate.Size = new System.Drawing.Size(100, 20);
            this.txtBirthdate.TabIndex = 7;
            this.txtBirthdate.Text = "Enter birthdate";
            this.txtBirthdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(269, 153);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(87, 20);
            this.lblUsername.TabIndex = 6;
            this.lblUsername.Text = "Username:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(269, 115);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 20);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email:";
            // 
            // lblName1
            // 
            this.lblName1.AutoSize = true;
            this.lblName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName1.Location = new System.Drawing.Point(269, 78);
            this.lblName1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName1.Name = "lblName1";
            this.lblName1.Size = new System.Drawing.Size(55, 20);
            this.lblName1.TabIndex = 4;
            this.lblName1.Text = "Name:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(396, 117);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.Text = "Enter email";
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(396, 80);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "Enter full name";
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(396, 155);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.Text = "Enter username";
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(241, 10);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(90, 20);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Information";
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.Purple;
            this.pnlTitleBar.Controls.Add(this.btnZooming);
            this.pnlTitleBar.Controls.Add(this.btnMinimize);
            this.pnlTitleBar.Controls.Add(this.btnClose);
            this.pnlTitleBar.Controls.Add(this.lblProfile);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(230, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(904, 60);
            this.pnlTitleBar.TabIndex = 14;
            this.pnlTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseDown);
            // 
            // btnZooming
            // 
            this.btnZooming.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZooming.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnZooming.CheckedState.Image = global::Quiz_Appli.Properties.Resources.minimize;
            this.btnZooming.CheckedState.ImageSize = new System.Drawing.Size(15, 15);
            this.btnZooming.HoverState.ImageSize = new System.Drawing.Size(15, 15);
            this.btnZooming.Image = global::Quiz_Appli.Properties.Resources.zoom;
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
            this.btnMinimize.HoverState.Image = global::Quiz_Appli.Properties.Resources.minimize_sign_hover;
            this.btnMinimize.HoverState.ImageSize = new System.Drawing.Size(15, 15);
            this.btnMinimize.Image = global::Quiz_Appli.Properties.Resources.minimize_sign;
            this.btnMinimize.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnMinimize.ImageRotate = 0F;
            this.btnMinimize.ImageSize = new System.Drawing.Size(15, 15);
            this.btnMinimize.Location = new System.Drawing.Point(769, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.PressedState.Image = global::Quiz_Appli.Properties.Resources.minimize_sign;
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
            this.btnClose.HoverState.Image = global::Quiz_Appli.Properties.Resources.close_tab_hover_;
            this.btnClose.HoverState.ImageSize = new System.Drawing.Size(15, 15);
            this.btnClose.Image = global::Quiz_Appli.Properties.Resources.close_tab_;
            this.btnClose.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnClose.ImageRotate = 0F;
            this.btnClose.ImageSize = new System.Drawing.Size(15, 15);
            this.btnClose.Location = new System.Drawing.Point(859, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedState.Image = global::Quiz_Appli.Properties.Resources.close_tab_;
            this.btnClose.PressedState.ImageSize = new System.Drawing.Size(15, 15);
            this.btnClose.Size = new System.Drawing.Size(45, 25);
            this.btnClose.TabIndex = 2;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblProfile
            // 
            this.lblProfile.AutoSize = true;
            this.lblProfile.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfile.ForeColor = System.Drawing.Color.White;
            this.lblProfile.Location = new System.Drawing.Point(18, 14);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(99, 32);
            this.lblProfile.TabIndex = 0;
            this.lblProfile.Text = "Profile";
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pnlMenu.Controls.Add(this.btnProfile);
            this.pnlMenu.Controls.Add(this.btnResults);
            this.pnlMenu.Controls.Add(this.btnTakeQuiz);
            this.pnlMenu.Controls.Add(this.btnDashboard);
            this.pnlMenu.Controls.Add(this.pnlLogoBox);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(230, 561);
            this.pnlMenu.TabIndex = 13;
            // 
            // btnProfile
            // 
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnProfile.IconColor = System.Drawing.Color.White;
            this.btnProfile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProfile.IconSize = 40;
            this.btnProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.Location = new System.Drawing.Point(0, 250);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(230, 50);
            this.btnProfile.TabIndex = 4;
            this.btnProfile.Tag = "Profile";
            this.btnProfile.Text = "Profile";
            this.btnProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProfile.UseVisualStyleBackColor = true;
            // 
            // btnResults
            // 
            this.btnResults.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResults.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnResults.FlatAppearance.BorderSize = 0;
            this.btnResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResults.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResults.ForeColor = System.Drawing.Color.White;
            this.btnResults.IconChar = FontAwesome.Sharp.IconChar.ChartSimple;
            this.btnResults.IconColor = System.Drawing.Color.White;
            this.btnResults.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnResults.IconSize = 40;
            this.btnResults.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResults.Location = new System.Drawing.Point(0, 200);
            this.btnResults.Name = "btnResults";
            this.btnResults.Size = new System.Drawing.Size(230, 50);
            this.btnResults.TabIndex = 3;
            this.btnResults.Tag = "Results";
            this.btnResults.Text = "Results";
            this.btnResults.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnResults.UseVisualStyleBackColor = true;
            this.btnResults.Click += new System.EventHandler(this.btnResults_Click);
            // 
            // btnTakeQuiz
            // 
            this.btnTakeQuiz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTakeQuiz.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTakeQuiz.FlatAppearance.BorderSize = 0;
            this.btnTakeQuiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTakeQuiz.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakeQuiz.ForeColor = System.Drawing.Color.White;
            this.btnTakeQuiz.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.btnTakeQuiz.IconColor = System.Drawing.Color.White;
            this.btnTakeQuiz.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTakeQuiz.IconSize = 40;
            this.btnTakeQuiz.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTakeQuiz.Location = new System.Drawing.Point(0, 150);
            this.btnTakeQuiz.Name = "btnTakeQuiz";
            this.btnTakeQuiz.Size = new System.Drawing.Size(230, 50);
            this.btnTakeQuiz.TabIndex = 2;
            this.btnTakeQuiz.Tag = "Take Quiz";
            this.btnTakeQuiz.Text = "Take Quiz";
            this.btnTakeQuiz.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTakeQuiz.UseVisualStyleBackColor = true;
            this.btnTakeQuiz.Click += new System.EventHandler(this.btnTakeQuiz_Click_1);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.BarsProgress;
            this.btnDashboard.IconColor = System.Drawing.Color.White;
            this.btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDashboard.IconSize = 40;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 100);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(230, 50);
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
            this.pnlLogoBox.Name = "pnlLogoBox";
            this.pnlLogoBox.Size = new System.Drawing.Size(230, 100);
            this.pnlLogoBox.TabIndex = 0;
            // 
            // btnMenu
            // 
            this.btnMenu.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.HoverState.Image = global::Quiz_Appli.Properties.Resources.menu_hover;
            this.btnMenu.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.btnMenu.Image = global::Quiz_Appli.Properties.Resources.menu;
            this.btnMenu.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnMenu.ImageRotate = 0F;
            this.btnMenu.ImageSize = new System.Drawing.Size(40, 40);
            this.btnMenu.Location = new System.Drawing.Point(170, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.PressedState.Image = global::Quiz_Appli.Properties.Resources.menu;
            this.btnMenu.PressedState.ImageSize = new System.Drawing.Size(40, 40);
            this.btnMenu.Size = new System.Drawing.Size(60, 60);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // pcbLogo
            // 
            this.pcbLogo.Image = global::Quiz_Appli.Properties.Resources.logo;
            this.pcbLogo.ImageRotate = 0F;
            this.pcbLogo.Location = new System.Drawing.Point(21, 0);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(142, 75);
            this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbLogo.TabIndex = 0;
            this.pcbLogo.TabStop = false;
            // 
            // frmStudentProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 561);
            this.Controls.Add(this.pnlDesktop);
            this.Controls.Add(this.pnlTitleBar);
            this.Controls.Add(this.pnlMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmStudentProfile";
            this.Text = "FormProfile";
            this.pnlDesktop.ResumeLayout(false);
            this.pnlSideProfile.ResumeLayout(false);
            this.pnlSideProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.pnlProfile.ResumeLayout(false);
            this.pnlProfile.PerformLayout();
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
        private System.Windows.Forms.Label lblProfile;
        private System.Windows.Forms.Panel pnlMenu;
        private FontAwesome.Sharp.IconButton btnProfile;
        private FontAwesome.Sharp.IconButton btnResults;
        private FontAwesome.Sharp.IconButton btnTakeQuiz;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private System.Windows.Forms.Panel pnlLogoBox;
        private Guna.UI2.WinForms.Guna2ImageButton btnMenu;
        private Guna.UI2.WinForms.Guna2PictureBox pcbLogo;
        private Guna.UI2.WinForms.Guna2Panel pnlSideProfile;
        private System.Windows.Forms.Label lblName;
        private Guna.UI2.WinForms.Guna2Panel pnlProfile;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label lblProfle;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblName1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblBirthdate;
        private System.Windows.Forms.TextBox txtBirthdate;
        private Guna.UI2.WinForms.Guna2Button btnChangePass;
        private Guna.UI2.WinForms.Guna2Button btnUpdateInfo;
    }
}