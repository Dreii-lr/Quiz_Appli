namespace Quiz_Appli
{
    partial class frmAdd_Quiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdd_Quiz));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnProfile_Icon = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnlSlideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnSideBar = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.pnlProfile = new Guna.UI2.WinForms.Guna2Panel();
            this.btnProfile = new Guna.UI2.WinForms.Guna2Button();
            this.btnSettings = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.pnlProfile.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pnlHeader.Controls.Add(this.btnProfile_Icon);
            this.pnlHeader.Controls.Add(this.guna2PictureBox1);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1366, 85);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnProfile_Icon
            // 
            this.btnProfile_Icon.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnProfile_Icon.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnProfile_Icon.Image = ((System.Drawing.Image)(resources.GetObject("btnProfile_Icon.Image")));
            this.btnProfile_Icon.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnProfile_Icon.ImageRotate = 0F;
            this.btnProfile_Icon.Location = new System.Drawing.Point(1286, 12);
            this.btnProfile_Icon.Name = "btnProfile_Icon";
            this.btnProfile_Icon.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnProfile_Icon.Size = new System.Drawing.Size(64, 62);
            this.btnProfile_Icon.TabIndex = 1;
            this.btnProfile_Icon.Click += new System.EventHandler(this.btnProfile_Icon_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::Quiz_Appli.Properties.Resources.logo;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(107, 1);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(103, 81);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // pnlSlideBar
            // 
            this.pnlSlideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pnlSlideBar.Location = new System.Drawing.Point(-140, 83);
            this.pnlSlideBar.Name = "pnlSlideBar";
            this.pnlSlideBar.Size = new System.Drawing.Size(248, 687);
            this.pnlSlideBar.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnSideBar
            // 
            this.btnSideBar.BackColor = System.Drawing.Color.Transparent;
            this.btnSideBar.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnSideBar.CheckedState.ImageSize = new System.Drawing.Size(70, 70);
            this.btnSideBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSideBar.HoverState.ImageSize = new System.Drawing.Size(70, 70);
            this.btnSideBar.Image = ((System.Drawing.Image)(resources.GetObject("btnSideBar.Image")));
            this.btnSideBar.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnSideBar.ImageRotate = 0F;
            this.btnSideBar.ImageSize = new System.Drawing.Size(70, 70);
            this.btnSideBar.Location = new System.Drawing.Point(65, 612);
            this.btnSideBar.Name = "btnSideBar";
            this.btnSideBar.PressedState.ImageSize = new System.Drawing.Size(70, 70);
            this.btnSideBar.Size = new System.Drawing.Size(82, 76);
            this.btnSideBar.TabIndex = 2;
            this.btnSideBar.UseTransparentBackground = true;
            this.btnSideBar.CheckedChanged += new System.EventHandler(this.btnSideBar_CheckedChanged);
            // 
            // pnlProfile
            // 
            this.pnlProfile.BackColor = System.Drawing.Color.Transparent;
            this.pnlProfile.BorderRadius = 20;
            this.pnlProfile.BorderThickness = 1;
            this.pnlProfile.Controls.Add(this.btnProfile);
            this.pnlProfile.Controls.Add(this.btnSettings);
            this.pnlProfile.Controls.Add(this.btnLogout);
            this.pnlProfile.CustomBorderColor = System.Drawing.Color.Black;
            this.pnlProfile.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.pnlProfile.FillColor = System.Drawing.Color.White;
            this.pnlProfile.Location = new System.Drawing.Point(1167, 89);
            this.pnlProfile.Name = "pnlProfile";
            this.pnlProfile.Size = new System.Drawing.Size(184, 147);
            this.pnlProfile.TabIndex = 3;
            // 
            // btnProfile
            // 
            this.btnProfile.Animated = true;
            this.btnProfile.CustomBorderColor = System.Drawing.Color.Black;
            this.btnProfile.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProfile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProfile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProfile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProfile.FillColor = System.Drawing.Color.White;
            this.btnProfile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnProfile.ForeColor = System.Drawing.Color.Black;
            this.btnProfile.Location = new System.Drawing.Point(1, 20);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(182, 35);
            this.btnProfile.TabIndex = 6;
            this.btnProfile.Text = "Profile";
            // 
            // btnSettings
            // 
            this.btnSettings.Animated = true;
            this.btnSettings.CustomBorderColor = System.Drawing.Color.Black;
            this.btnSettings.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSettings.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSettings.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSettings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSettings.FillColor = System.Drawing.Color.White;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSettings.ForeColor = System.Drawing.Color.Black;
            this.btnSettings.Location = new System.Drawing.Point(1, 55);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(182, 35);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.Text = "Settings";
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Animated = true;
            this.btnLogout.CustomBorderColor = System.Drawing.Color.Black;
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.FillColor = System.Drawing.Color.White;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogout.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.Location = new System.Drawing.Point(1, 90);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(182, 35);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // frmAdd_Quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.pnlProfile);
            this.Controls.Add(this.btnSideBar);
            this.Controls.Add(this.pnlSlideBar);
            this.Controls.Add(this.pnlHeader);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdd_Quiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.frmAdd_Quiz_Load);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.pnlProfile.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.FlowLayoutPanel pnlSlideBar;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2ImageCheckBox btnSideBar;
        private Guna.UI2.WinForms.Guna2Panel pnlProfile;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private System.Windows.Forms.Timer timer2;
        private Guna.UI2.WinForms.Guna2Button btnProfile;
        private Guna.UI2.WinForms.Guna2Button btnSettings;
        private Guna.UI2.WinForms.Guna2ImageButton btnProfile_Icon;
    }
}