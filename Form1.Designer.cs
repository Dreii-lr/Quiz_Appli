namespace Quiz_Appli
{
    partial class frmQuizMaker
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.pnlLogoBox = new System.Windows.Forms.Panel();
            this.pnlTitleBar = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlDesktop = new System.Windows.Forms.Panel();
            this.btnMenu = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pcbLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.btnLibrary = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.pnlLogoBox.SuspendLayout();
            this.pnlTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelMenu.Controls.Add(this.btnLibrary);
            this.panelMenu.Controls.Add(this.btnHome);
            this.panelMenu.Controls.Add(this.pnlLogoBox);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(230, 561);
            this.panelMenu.TabIndex = 0;
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
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.Purple;
            this.pnlTitleBar.Controls.Add(this.label1);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(230, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(904, 60);
            this.pnlTitleBar.TabIndex = 1;
            this.pnlTitleBar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTitleBar_Paint);
            this.pnlTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseDown);
            // 
            // pnlDesktop
            // 
            this.pnlDesktop.BackColor = System.Drawing.Color.White;
            this.pnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDesktop.Location = new System.Drawing.Point(230, 60);
            this.pnlDesktop.Name = "pnlDesktop";
            this.pnlDesktop.Size = new System.Drawing.Size(904, 501);
            this.pnlDesktop.TabIndex = 2;
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
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.House;
            this.btnHome.IconColor = System.Drawing.Color.White;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.IconSize = 40;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(41, 131);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(150, 44);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // btnLibrary
            // 
            this.btnLibrary.FlatAppearance.BorderSize = 0;
            this.btnLibrary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibrary.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibrary.ForeColor = System.Drawing.Color.White;
            this.btnLibrary.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.btnLibrary.IconColor = System.Drawing.Color.White;
            this.btnLibrary.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLibrary.IconSize = 40;
            this.btnLibrary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLibrary.Location = new System.Drawing.Point(41, 182);
            this.btnLibrary.Name = "btnLibrary";
            this.btnLibrary.Size = new System.Drawing.Size(150, 44);
            this.btnLibrary.TabIndex = 2;
            this.btnLibrary.Text = "Quiz";
            this.btnLibrary.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLibrary.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Home";
            // 
            // frmQuizMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 561);
            this.Controls.Add(this.pnlDesktop);
            this.Controls.Add(this.pnlTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "frmQuizMaker";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.pnlLogoBox.ResumeLayout(false);
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private Guna.UI2.WinForms.Guna2Panel pnlTitleBar;
        private System.Windows.Forms.Panel pnlLogoBox;
        private System.Windows.Forms.Panel pnlDesktop;
        private Guna.UI2.WinForms.Guna2ImageButton btnMenu;
        private Guna.UI2.WinForms.Guna2PictureBox pcbLogo;
        private FontAwesome.Sharp.IconButton btnHome;
        private FontAwesome.Sharp.IconButton btnLibrary;
        private System.Windows.Forms.Label label1;
    }
}