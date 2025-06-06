﻿namespace Quiz_Appli
{
    partial class frmAdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminDashboard));
            this.pnlDesktop = new System.Windows.Forms.Panel();
            this.pnlCompleteQuizzes = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvCompletedQuizzes = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTitle2 = new System.Windows.Forms.Panel();
            this.lblCompletedQuizzes = new System.Windows.Forms.Label();
            this.tlpDashboardHomepage = new System.Windows.Forms.TableLayoutPanel();
            this.pnlDeadline = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTotalQuizzes = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnlStudentAssigned = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTotalTeachers = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnlQuizTotal = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTotalStudents = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnlTitle = new Guna.UI2.WinForms.Guna2Panel();
            this.lblNoQuizzesAvail = new System.Windows.Forms.Label();
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
            this.pnlDesktop.SuspendLayout();
            this.pnlCompleteQuizzes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompletedQuizzes)).BeginInit();
            this.pnlTitle2.SuspendLayout();
            this.tlpDashboardHomepage.SuspendLayout();
            this.pnlDeadline.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            this.pnlStudentAssigned.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.pnlQuizTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.pnlTitle.SuspendLayout();
            this.pnlTitleBar.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlLogoBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDesktop
            // 
            this.pnlDesktop.BackColor = System.Drawing.Color.White;
            this.pnlDesktop.Controls.Add(this.pnlCompleteQuizzes);
            this.pnlDesktop.Controls.Add(this.pnlTitle2);
            this.pnlDesktop.Controls.Add(this.tlpDashboardHomepage);
            this.pnlDesktop.Controls.Add(this.pnlTitle);
            this.pnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDesktop.Location = new System.Drawing.Point(353, 74);
            this.pnlDesktop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlDesktop.Name = "pnlDesktop";
            this.pnlDesktop.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.pnlDesktop.Size = new System.Drawing.Size(1018, 616);
            this.pnlDesktop.TabIndex = 11;
            // 
            // pnlCompleteQuizzes
            // 
            this.pnlCompleteQuizzes.Controls.Add(this.dgvCompletedQuizzes);
            this.pnlCompleteQuizzes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCompleteQuizzes.Location = new System.Drawing.Point(11, 391);
            this.pnlCompleteQuizzes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlCompleteQuizzes.Name = "pnlCompleteQuizzes";
            this.pnlCompleteQuizzes.Size = new System.Drawing.Size(996, 215);
            this.pnlCompleteQuizzes.TabIndex = 11;
            // 
            // dgvCompletedQuizzes
            // 
            this.dgvCompletedQuizzes.AllowUserToAddRows = false;
            this.dgvCompletedQuizzes.AllowUserToDeleteRows = false;
            this.dgvCompletedQuizzes.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvCompletedQuizzes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCompletedQuizzes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCompletedQuizzes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCompletedQuizzes.ColumnHeadersHeight = 20;
            this.dgvCompletedQuizzes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCompletedQuizzes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTitle,
            this.colDate,
            this.colScore,
            this.colPercent});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCompletedQuizzes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCompletedQuizzes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCompletedQuizzes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvCompletedQuizzes.Location = new System.Drawing.Point(0, 0);
            this.dgvCompletedQuizzes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCompletedQuizzes.Name = "dgvCompletedQuizzes";
            this.dgvCompletedQuizzes.ReadOnly = true;
            this.dgvCompletedQuizzes.RowHeadersVisible = false;
            this.dgvCompletedQuizzes.RowHeadersWidth = 51;
            this.dgvCompletedQuizzes.RowTemplate.Height = 24;
            this.dgvCompletedQuizzes.Size = new System.Drawing.Size(996, 215);
            this.dgvCompletedQuizzes.TabIndex = 4;
            this.dgvCompletedQuizzes.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCompletedQuizzes.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvCompletedQuizzes.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvCompletedQuizzes.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCompletedQuizzes.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCompletedQuizzes.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvCompletedQuizzes.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvCompletedQuizzes.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvCompletedQuizzes.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCompletedQuizzes.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCompletedQuizzes.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCompletedQuizzes.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCompletedQuizzes.ThemeStyle.HeaderStyle.Height = 20;
            this.dgvCompletedQuizzes.ThemeStyle.ReadOnly = true;
            this.dgvCompletedQuizzes.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCompletedQuizzes.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCompletedQuizzes.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCompletedQuizzes.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvCompletedQuizzes.ThemeStyle.RowsStyle.Height = 24;
            this.dgvCompletedQuizzes.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCompletedQuizzes.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // colTitle
            // 
            this.colTitle.HeaderText = "Title";
            this.colTitle.MinimumWidth = 6;
            this.colTitle.Name = "colTitle";
            this.colTitle.ReadOnly = true;
            // 
            // colDate
            // 
            this.colDate.HeaderText = "Date";
            this.colDate.MinimumWidth = 6;
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // colScore
            // 
            this.colScore.HeaderText = "Score";
            this.colScore.MinimumWidth = 6;
            this.colScore.Name = "colScore";
            this.colScore.ReadOnly = true;
            // 
            // colPercent
            // 
            this.colPercent.HeaderText = "Percentage";
            this.colPercent.MinimumWidth = 6;
            this.colPercent.Name = "colPercent";
            this.colPercent.ReadOnly = true;
            // 
            // pnlTitle2
            // 
            this.pnlTitle2.Controls.Add(this.lblCompletedQuizzes);
            this.pnlTitle2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle2.Location = new System.Drawing.Point(11, 355);
            this.pnlTitle2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlTitle2.Name = "pnlTitle2";
            this.pnlTitle2.Size = new System.Drawing.Size(996, 36);
            this.pnlTitle2.TabIndex = 10;
            // 
            // lblCompletedQuizzes
            // 
            this.lblCompletedQuizzes.AutoSize = true;
            this.lblCompletedQuizzes.BackColor = System.Drawing.Color.Transparent;
            this.lblCompletedQuizzes.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCompletedQuizzes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompletedQuizzes.Location = new System.Drawing.Point(0, 0);
            this.lblCompletedQuizzes.Name = "lblCompletedQuizzes";
            this.lblCompletedQuizzes.Size = new System.Drawing.Size(191, 29);
            this.lblCompletedQuizzes.TabIndex = 3;
            this.lblCompletedQuizzes.Text = "Quizzes Created";
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
            this.tlpDashboardHomepage.Location = new System.Drawing.Point(11, 47);
            this.tlpDashboardHomepage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tlpDashboardHomepage.Name = "tlpDashboardHomepage";
            this.tlpDashboardHomepage.RowCount = 1;
            this.tlpDashboardHomepage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDashboardHomepage.Size = new System.Drawing.Size(996, 308);
            this.tlpDashboardHomepage.TabIndex = 1;
            // 
            // pnlDeadline
            // 
            this.pnlDeadline.BackColor = System.Drawing.Color.Indigo;
            this.pnlDeadline.Controls.Add(this.lblTotalQuizzes);
            this.pnlDeadline.Controls.Add(this.label4);
            this.pnlDeadline.Controls.Add(this.guna2PictureBox3);
            this.pnlDeadline.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDeadline.Location = new System.Drawing.Point(664, 0);
            this.pnlDeadline.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.pnlDeadline.Name = "pnlDeadline";
            this.pnlDeadline.Size = new System.Drawing.Size(332, 296);
            this.pnlDeadline.TabIndex = 1;
            // 
            // lblTotalQuizzes
            // 
            this.lblTotalQuizzes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalQuizzes.AutoSize = true;
            this.lblTotalQuizzes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalQuizzes.ForeColor = System.Drawing.Color.White;
            this.lblTotalQuizzes.Location = new System.Drawing.Point(288, 241);
            this.lblTotalQuizzes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalQuizzes.Name = "lblTotalQuizzes";
            this.lblTotalQuizzes.Size = new System.Drawing.Size(36, 39);
            this.lblTotalQuizzes.TabIndex = 9;
            this.lblTotalQuizzes.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(15, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(255, 39);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total of quizzes";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2PictureBox3.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox3.Image")));
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(21, 175);
            this.guna2PictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(104, 110);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox3.TabIndex = 1;
            this.guna2PictureBox3.TabStop = false;
            // 
            // pnlStudentAssigned
            // 
            this.pnlStudentAssigned.BackColor = System.Drawing.Color.MediumVioletRed;
            this.pnlStudentAssigned.Controls.Add(this.lblTotalTeachers);
            this.pnlStudentAssigned.Controls.Add(this.label3);
            this.pnlStudentAssigned.Controls.Add(this.guna2PictureBox2);
            this.pnlStudentAssigned.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStudentAssigned.Location = new System.Drawing.Point(332, 0);
            this.pnlStudentAssigned.Margin = new System.Windows.Forms.Padding(0, 0, 13, 12);
            this.pnlStudentAssigned.Name = "pnlStudentAssigned";
            this.pnlStudentAssigned.Size = new System.Drawing.Size(319, 296);
            this.pnlStudentAssigned.TabIndex = 1;
            // 
            // lblTotalTeachers
            // 
            this.lblTotalTeachers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalTeachers.AutoSize = true;
            this.lblTotalTeachers.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTeachers.ForeColor = System.Drawing.Color.White;
            this.lblTotalTeachers.Location = new System.Drawing.Point(276, 241);
            this.lblTotalTeachers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalTeachers.Name = "lblTotalTeachers";
            this.lblTotalTeachers.Size = new System.Drawing.Size(36, 39);
            this.lblTotalTeachers.TabIndex = 8;
            this.lblTotalTeachers.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 39);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total of teachers";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2PictureBox2.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(24, 160);
            this.guna2PictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(133, 123);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 1;
            this.guna2PictureBox2.TabStop = false;
            // 
            // pnlQuizTotal
            // 
            this.pnlQuizTotal.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.pnlQuizTotal.Controls.Add(this.lblTotalStudents);
            this.pnlQuizTotal.Controls.Add(this.label2);
            this.pnlQuizTotal.Controls.Add(this.guna2PictureBox1);
            this.pnlQuizTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlQuizTotal.Location = new System.Drawing.Point(0, 0);
            this.pnlQuizTotal.Margin = new System.Windows.Forms.Padding(0, 0, 13, 12);
            this.pnlQuizTotal.Name = "pnlQuizTotal";
            this.pnlQuizTotal.Size = new System.Drawing.Size(319, 296);
            this.pnlQuizTotal.TabIndex = 0;
            // 
            // lblTotalStudents
            // 
            this.lblTotalStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalStudents.AutoSize = true;
            this.lblTotalStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalStudents.ForeColor = System.Drawing.Color.White;
            this.lblTotalStudents.Location = new System.Drawing.Point(276, 241);
            this.lblTotalStudents.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalStudents.Name = "lblTotalStudents";
            this.lblTotalStudents.Size = new System.Drawing.Size(36, 39);
            this.lblTotalStudents.TabIndex = 7;
            this.lblTotalStudents.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(37, 2);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 39);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total of students";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2PictureBox1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(4, 147);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(161, 146);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // pnlTitle
            // 
            this.pnlTitle.Controls.Add(this.lblNoQuizzesAvail);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(11, 10);
            this.pnlTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(996, 37);
            this.pnlTitle.TabIndex = 7;
            // 
            // lblNoQuizzesAvail
            // 
            this.lblNoQuizzesAvail.AutoSize = true;
            this.lblNoQuizzesAvail.BackColor = System.Drawing.Color.Transparent;
            this.lblNoQuizzesAvail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNoQuizzesAvail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoQuizzesAvail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblNoQuizzesAvail.Location = new System.Drawing.Point(0, 0);
            this.lblNoQuizzesAvail.Name = "lblNoQuizzesAvail";
            this.lblNoQuizzesAvail.Size = new System.Drawing.Size(327, 29);
            this.lblNoQuizzesAvail.TabIndex = 2;
            this.lblNoQuizzesAvail.Text = "Number Of Quizzes Available";
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
            this.pnlTitleBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(1018, 74);
            this.pnlTitleBar.TabIndex = 10;
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
            this.btnZooming.Location = new System.Drawing.Point(898, 0);
            this.btnZooming.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btnMinimize.Location = new System.Drawing.Point(838, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btnClose.Location = new System.Drawing.Point(958, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.lblTitle.Size = new System.Drawing.Size(184, 39);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Dashboard";
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
            this.pnlMenu.TabIndex = 9;
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
            this.btnStudentManagement.Click += new System.EventHandler(this.btnStudentManagement_Click);
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
            // frmAdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 690);
            this.Controls.Add(this.pnlDesktop);
            this.Controls.Add(this.pnlTitleBar);
            this.Controls.Add(this.pnlMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            this.pnlDesktop.ResumeLayout(false);
            this.pnlCompleteQuizzes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompletedQuizzes)).EndInit();
            this.pnlTitle2.ResumeLayout(false);
            this.pnlTitle2.PerformLayout();
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
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
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
        private FontAwesome.Sharp.IconButton btnDashboard;
        private System.Windows.Forms.Panel pnlLogoBox;
        private Guna.UI2.WinForms.Guna2ImageButton btnMenu;
        private Guna.UI2.WinForms.Guna2PictureBox pcbLogo;
        private FontAwesome.Sharp.IconButton btnSettings;
        private FontAwesome.Sharp.IconButton btnResults;
        private FontAwesome.Sharp.IconButton btnQuizManagement;
        private FontAwesome.Sharp.IconButton btnStudentManagement;
        private FontAwesome.Sharp.IconButton btnTeacherManagement;
        private System.Windows.Forms.TableLayoutPanel tlpDashboardHomepage;
        private Guna.UI2.WinForms.Guna2Panel pnlDeadline;
        private System.Windows.Forms.Label lblTotalQuizzes;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private Guna.UI2.WinForms.Guna2Panel pnlStudentAssigned;
        private System.Windows.Forms.Label lblTotalTeachers;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2Panel pnlQuizTotal;
        private System.Windows.Forms.Label lblTotalStudents;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Panel pnlTitle;
        private System.Windows.Forms.Label lblNoQuizzesAvail;
        private Guna.UI2.WinForms.Guna2Panel pnlCompleteQuizzes;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCompletedQuizzes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPercent;
        private System.Windows.Forms.Panel pnlTitle2;
        private System.Windows.Forms.Label lblCompletedQuizzes;
    }
}