﻿namespace Quiz_Appli
{
    partial class FormDashBoard
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
            this.pnlDesktop = new System.Windows.Forms.Panel();
            this.dgvCompletedQuizzes = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCompletedQuizzes = new System.Windows.Forms.Label();
            this.lblNoQuizzesAvail = new System.Windows.Forms.Label();
            this.pnlArchivedQuizzes = new Guna.UI2.WinForms.Guna2Panel();
            this.Prg4 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.lblArchivedQuizzes = new System.Windows.Forms.Label();
            this.iconPic4 = new FontAwesome.Sharp.IconPictureBox();
            this.pnlActiveQuizzes = new Guna.UI2.WinForms.Guna2Panel();
            this.Prg3 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.lblActiveQuizzes = new System.Windows.Forms.Label();
            this.iconPic3 = new FontAwesome.Sharp.IconPictureBox();
            this.pnlDraftQuizzes = new Guna.UI2.WinForms.Guna2Panel();
            this.Prg2 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.lblDraftQuizzes = new System.Windows.Forms.Label();
            this.iconPic2 = new FontAwesome.Sharp.IconPictureBox();
            this.pnlTotalQuizzes = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTotalQuizzes = new System.Windows.Forms.Label();
            this.guna2CircleProgressBar1 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.iconPic1 = new FontAwesome.Sharp.IconPictureBox();
            this.pnlTitleBar = new Guna.UI2.WinForms.Guna2Panel();
            this.btnZooming = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnProfile = new FontAwesome.Sharp.IconButton();
            this.btnResults = new FontAwesome.Sharp.IconButton();
            this.btnTakeQuiz = new FontAwesome.Sharp.IconButton();
            this.btnDashboard = new FontAwesome.Sharp.IconButton();
            this.pnlLogoBox = new System.Windows.Forms.Panel();
            this.btnMenu = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pcbLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnlDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompletedQuizzes)).BeginInit();
            this.pnlArchivedQuizzes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPic4)).BeginInit();
            this.pnlActiveQuizzes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPic3)).BeginInit();
            this.pnlDraftQuizzes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPic2)).BeginInit();
            this.pnlTotalQuizzes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPic1)).BeginInit();
            this.pnlTitleBar.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlLogoBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDesktop
            // 
            this.pnlDesktop.BackColor = System.Drawing.Color.White;
            this.pnlDesktop.Controls.Add(this.dgvCompletedQuizzes);
            this.pnlDesktop.Controls.Add(this.lblCompletedQuizzes);
            this.pnlDesktop.Controls.Add(this.lblNoQuizzesAvail);
            this.pnlDesktop.Controls.Add(this.pnlArchivedQuizzes);
            this.pnlDesktop.Controls.Add(this.pnlActiveQuizzes);
            this.pnlDesktop.Controls.Add(this.pnlDraftQuizzes);
            this.pnlDesktop.Controls.Add(this.pnlTotalQuizzes);
            this.pnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDesktop.Location = new System.Drawing.Point(307, 74);
            this.pnlDesktop.Margin = new System.Windows.Forms.Padding(4);
            this.pnlDesktop.Name = "pnlDesktop";
            this.pnlDesktop.Size = new System.Drawing.Size(1205, 616);
            this.pnlDesktop.TabIndex = 5;
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
            this.dgvCompletedQuizzes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvCompletedQuizzes.Location = new System.Drawing.Point(105, 280);
            this.dgvCompletedQuizzes.Name = "dgvCompletedQuizzes";
            this.dgvCompletedQuizzes.ReadOnly = true;
            this.dgvCompletedQuizzes.RowHeadersVisible = false;
            this.dgvCompletedQuizzes.RowHeadersWidth = 51;
            this.dgvCompletedQuizzes.RowTemplate.Height = 24;
            this.dgvCompletedQuizzes.Size = new System.Drawing.Size(600, 300);
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
            this.dgvCompletedQuizzes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompletedQuizzes_CellContentClick);
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
            // lblCompletedQuizzes
            // 
            this.lblCompletedQuizzes.AutoSize = true;
            this.lblCompletedQuizzes.BackColor = System.Drawing.Color.Transparent;
            this.lblCompletedQuizzes.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompletedQuizzes.Location = new System.Drawing.Point(7, 246);
            this.lblCompletedQuizzes.Name = "lblCompletedQuizzes";
            this.lblCompletedQuizzes.Size = new System.Drawing.Size(270, 31);
            this.lblCompletedQuizzes.TabIndex = 3;
            this.lblCompletedQuizzes.Text = "Completed Quizzes";
            // 
            // lblNoQuizzesAvail
            // 
            this.lblNoQuizzesAvail.AutoSize = true;
            this.lblNoQuizzesAvail.BackColor = System.Drawing.Color.Transparent;
            this.lblNoQuizzesAvail.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoQuizzesAvail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblNoQuizzesAvail.Location = new System.Drawing.Point(7, 10);
            this.lblNoQuizzesAvail.Name = "lblNoQuizzesAvail";
            this.lblNoQuizzesAvail.Size = new System.Drawing.Size(408, 31);
            this.lblNoQuizzesAvail.TabIndex = 2;
            this.lblNoQuizzesAvail.Text = "Number Of Quizzes Available";
            // 
            // pnlArchivedQuizzes
            // 
            this.pnlArchivedQuizzes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pnlArchivedQuizzes.Controls.Add(this.Prg4);
            this.pnlArchivedQuizzes.Controls.Add(this.lblArchivedQuizzes);
            this.pnlArchivedQuizzes.Controls.Add(this.iconPic4);
            this.pnlArchivedQuizzes.Location = new System.Drawing.Point(824, 49);
            this.pnlArchivedQuizzes.Name = "pnlArchivedQuizzes";
            this.pnlArchivedQuizzes.Size = new System.Drawing.Size(236, 174);
            this.pnlArchivedQuizzes.TabIndex = 1;
            // 
            // Prg4
            // 
            this.Prg4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Prg4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Prg4.ForeColor = System.Drawing.Color.White;
            this.Prg4.Location = new System.Drawing.Point(72, 38);
            this.Prg4.Minimum = 0;
            this.Prg4.Name = "Prg4";
            this.Prg4.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Prg4.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Prg4.ProgressThickness = 20;
            this.Prg4.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Prg4.Size = new System.Drawing.Size(111, 111);
            this.Prg4.TabIndex = 6;
            this.Prg4.Text = "guna2CircleProgressBar2";
            // 
            // lblArchivedQuizzes
            // 
            this.lblArchivedQuizzes.AutoSize = true;
            this.lblArchivedQuizzes.BackColor = System.Drawing.Color.Transparent;
            this.lblArchivedQuizzes.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArchivedQuizzes.Location = new System.Drawing.Point(54, 5);
            this.lblArchivedQuizzes.Name = "lblArchivedQuizzes";
            this.lblArchivedQuizzes.Size = new System.Drawing.Size(170, 20);
            this.lblArchivedQuizzes.TabIndex = 5;
            this.lblArchivedQuizzes.Text = "Archived Quizzes";
            // 
            // iconPic4
            // 
            this.iconPic4.BackColor = System.Drawing.Color.Transparent;
            this.iconPic4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPic4.IconChar = FontAwesome.Sharp.IconChar.Archive;
            this.iconPic4.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPic4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPic4.IconSize = 45;
            this.iconPic4.Location = new System.Drawing.Point(3, 5);
            this.iconPic4.Name = "iconPic4";
            this.iconPic4.Size = new System.Drawing.Size(45, 51);
            this.iconPic4.TabIndex = 3;
            this.iconPic4.TabStop = false;
            // 
            // pnlActiveQuizzes
            // 
            this.pnlActiveQuizzes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pnlActiveQuizzes.Controls.Add(this.Prg3);
            this.pnlActiveQuizzes.Controls.Add(this.lblActiveQuizzes);
            this.pnlActiveQuizzes.Controls.Add(this.iconPic3);
            this.pnlActiveQuizzes.Location = new System.Drawing.Point(554, 49);
            this.pnlActiveQuizzes.Name = "pnlActiveQuizzes";
            this.pnlActiveQuizzes.Size = new System.Drawing.Size(236, 174);
            this.pnlActiveQuizzes.TabIndex = 1;
            // 
            // Prg3
            // 
            this.Prg3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Prg3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Prg3.ForeColor = System.Drawing.Color.White;
            this.Prg3.Location = new System.Drawing.Point(67, 38);
            this.Prg3.Minimum = 0;
            this.Prg3.Name = "Prg3";
            this.Prg3.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Prg3.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Prg3.ProgressThickness = 20;
            this.Prg3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Prg3.Size = new System.Drawing.Size(111, 111);
            this.Prg3.TabIndex = 5;
            this.Prg3.Text = "guna2CircleProgressBar2";
            // 
            // lblActiveQuizzes
            // 
            this.lblActiveQuizzes.AutoSize = true;
            this.lblActiveQuizzes.BackColor = System.Drawing.Color.Transparent;
            this.lblActiveQuizzes.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveQuizzes.Location = new System.Drawing.Point(54, 5);
            this.lblActiveQuizzes.Name = "lblActiveQuizzes";
            this.lblActiveQuizzes.Size = new System.Drawing.Size(144, 20);
            this.lblActiveQuizzes.TabIndex = 4;
            this.lblActiveQuizzes.Text = "Active Quizzes";
            // 
            // iconPic3
            // 
            this.iconPic3.BackColor = System.Drawing.Color.Transparent;
            this.iconPic3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPic3.IconChar = FontAwesome.Sharp.IconChar.UserCheck;
            this.iconPic3.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPic3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPic3.IconSize = 45;
            this.iconPic3.Location = new System.Drawing.Point(3, 5);
            this.iconPic3.Name = "iconPic3";
            this.iconPic3.Size = new System.Drawing.Size(45, 51);
            this.iconPic3.TabIndex = 2;
            this.iconPic3.TabStop = false;
            // 
            // pnlDraftQuizzes
            // 
            this.pnlDraftQuizzes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pnlDraftQuizzes.Controls.Add(this.Prg2);
            this.pnlDraftQuizzes.Controls.Add(this.lblDraftQuizzes);
            this.pnlDraftQuizzes.Controls.Add(this.iconPic2);
            this.pnlDraftQuizzes.Location = new System.Drawing.Point(290, 49);
            this.pnlDraftQuizzes.Name = "pnlDraftQuizzes";
            this.pnlDraftQuizzes.Size = new System.Drawing.Size(233, 174);
            this.pnlDraftQuizzes.TabIndex = 1;
            // 
            // Prg2
            // 
            this.Prg2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Prg2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Prg2.ForeColor = System.Drawing.Color.White;
            this.Prg2.Location = new System.Drawing.Point(67, 38);
            this.Prg2.Minimum = 0;
            this.Prg2.Name = "Prg2";
            this.Prg2.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Prg2.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Prg2.ProgressThickness = 20;
            this.Prg2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Prg2.Size = new System.Drawing.Size(111, 111);
            this.Prg2.TabIndex = 4;
            this.Prg2.Text = "guna2CircleProgressBar2";
            // 
            // lblDraftQuizzes
            // 
            this.lblDraftQuizzes.AutoSize = true;
            this.lblDraftQuizzes.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDraftQuizzes.Location = new System.Drawing.Point(54, 5);
            this.lblDraftQuizzes.Name = "lblDraftQuizzes";
            this.lblDraftQuizzes.Size = new System.Drawing.Size(134, 20);
            this.lblDraftQuizzes.TabIndex = 3;
            this.lblDraftQuizzes.Text = "Draft Quizzes";
            // 
            // iconPic2
            // 
            this.iconPic2.BackColor = System.Drawing.Color.Transparent;
            this.iconPic2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPic2.IconChar = FontAwesome.Sharp.IconChar.Dropbox;
            this.iconPic2.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPic2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPic2.IconSize = 45;
            this.iconPic2.Location = new System.Drawing.Point(3, 3);
            this.iconPic2.Name = "iconPic2";
            this.iconPic2.Size = new System.Drawing.Size(45, 51);
            this.iconPic2.TabIndex = 1;
            this.iconPic2.TabStop = false;
            this.iconPic2.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // pnlTotalQuizzes
            // 
            this.pnlTotalQuizzes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pnlTotalQuizzes.Controls.Add(this.lblTotalQuizzes);
            this.pnlTotalQuizzes.Controls.Add(this.guna2CircleProgressBar1);
            this.pnlTotalQuizzes.Controls.Add(this.iconPic1);
            this.pnlTotalQuizzes.Location = new System.Drawing.Point(30, 49);
            this.pnlTotalQuizzes.Name = "pnlTotalQuizzes";
            this.pnlTotalQuizzes.Size = new System.Drawing.Size(227, 174);
            this.pnlTotalQuizzes.TabIndex = 0;
            // 
            // lblTotalQuizzes
            // 
            this.lblTotalQuizzes.AutoSize = true;
            this.lblTotalQuizzes.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalQuizzes.Location = new System.Drawing.Point(56, 5);
            this.lblTotalQuizzes.Name = "lblTotalQuizzes";
            this.lblTotalQuizzes.Size = new System.Drawing.Size(130, 20);
            this.lblTotalQuizzes.TabIndex = 2;
            this.lblTotalQuizzes.Text = "Total Quizzes";
            // 
            // guna2CircleProgressBar1
            // 
            this.guna2CircleProgressBar1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2CircleProgressBar1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2CircleProgressBar1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleProgressBar1.Location = new System.Drawing.Point(75, 38);
            this.guna2CircleProgressBar1.Minimum = 0;
            this.guna2CircleProgressBar1.Name = "guna2CircleProgressBar1";
            this.guna2CircleProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.guna2CircleProgressBar1.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.guna2CircleProgressBar1.ProgressThickness = 20;
            this.guna2CircleProgressBar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleProgressBar1.Size = new System.Drawing.Size(111, 111);
            this.guna2CircleProgressBar1.TabIndex = 1;
            this.guna2CircleProgressBar1.Text = "guna2CircleProgressBar1";
            this.guna2CircleProgressBar1.ValueChanged += new System.EventHandler(this.guna2CircleProgressBar1_ValueChanged);
            // 
            // iconPic1
            // 
            this.iconPic1.BackColor = System.Drawing.Color.Transparent;
            this.iconPic1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPic1.IconChar = FontAwesome.Sharp.IconChar.CircleCheck;
            this.iconPic1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPic1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPic1.IconSize = 45;
            this.iconPic1.Location = new System.Drawing.Point(4, 3);
            this.iconPic1.Name = "iconPic1";
            this.iconPic1.Size = new System.Drawing.Size(45, 51);
            this.iconPic1.TabIndex = 0;
            this.iconPic1.TabStop = false;
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pnlTitleBar.Controls.Add(this.btnZooming);
            this.pnlTitleBar.Controls.Add(this.btnMinimize);
            this.pnlTitleBar.Controls.Add(this.btnClose);
            this.pnlTitleBar.Controls.Add(this.lblDashboard);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(307, 0);
            this.pnlTitleBar.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(1205, 74);
            this.pnlTitleBar.TabIndex = 4;
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
            this.btnZooming.Location = new System.Drawing.Point(1085, 0);
            this.btnZooming.Margin = new System.Windows.Forms.Padding(4);
            this.btnZooming.Name = "btnZooming";
            this.btnZooming.Size = new System.Drawing.Size(60, 31);
            this.btnZooming.TabIndex = 5;
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
            this.btnMinimize.Location = new System.Drawing.Point(1025, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.PressedState.Image = global::Quiz_Appli.Properties.Resources.minimize_sign;
            this.btnMinimize.PressedState.ImageSize = new System.Drawing.Size(15, 15);
            this.btnMinimize.Size = new System.Drawing.Size(60, 31);
            this.btnMinimize.TabIndex = 4;
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
            this.btnClose.Location = new System.Drawing.Point(1145, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedState.Image = global::Quiz_Appli.Properties.Resources.close_tab_;
            this.btnClose.PressedState.ImageSize = new System.Drawing.Size(15, 15);
            this.btnClose.Size = new System.Drawing.Size(60, 31);
            this.btnClose.TabIndex = 2;
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard.ForeColor = System.Drawing.Color.Plum;
            this.lblDashboard.Location = new System.Drawing.Point(24, 23);
            this.lblDashboard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(183, 34);
            this.lblDashboard.TabIndex = 0;
            this.lblDashboard.Text = "Dashboard";
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
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(307, 690);
            this.pnlMenu.TabIndex = 3;
            // 
            // btnProfile
            // 
            this.btnProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.IconChar = FontAwesome.Sharp.IconChar.UserGraduate;
            this.btnProfile.IconColor = System.Drawing.Color.White;
            this.btnProfile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProfile.IconSize = 40;
            this.btnProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.Location = new System.Drawing.Point(0, 285);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(4);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(307, 54);
            this.btnProfile.TabIndex = 4;
            this.btnProfile.Tag = "Quiz";
            this.btnProfile.Text = "Profile";
            this.btnProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProfile.UseVisualStyleBackColor = true;
            // 
            // btnResults
            // 
            this.btnResults.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnResults.FlatAppearance.BorderSize = 0;
            this.btnResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResults.ForeColor = System.Drawing.Color.White;
            this.btnResults.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.btnResults.IconColor = System.Drawing.Color.White;
            this.btnResults.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnResults.IconSize = 40;
            this.btnResults.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResults.Location = new System.Drawing.Point(0, 231);
            this.btnResults.Margin = new System.Windows.Forms.Padding(4);
            this.btnResults.Name = "btnResults";
            this.btnResults.Size = new System.Drawing.Size(307, 54);
            this.btnResults.TabIndex = 3;
            this.btnResults.Tag = "Quiz";
            this.btnResults.Text = "Results";
            this.btnResults.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnResults.UseVisualStyleBackColor = true;
            // 
            // btnTakeQuiz
            // 
            this.btnTakeQuiz.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTakeQuiz.FlatAppearance.BorderSize = 0;
            this.btnTakeQuiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTakeQuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakeQuiz.ForeColor = System.Drawing.Color.White;
            this.btnTakeQuiz.IconChar = FontAwesome.Sharp.IconChar.Lightbulb;
            this.btnTakeQuiz.IconColor = System.Drawing.Color.White;
            this.btnTakeQuiz.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTakeQuiz.IconSize = 40;
            this.btnTakeQuiz.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTakeQuiz.Location = new System.Drawing.Point(0, 177);
            this.btnTakeQuiz.Margin = new System.Windows.Forms.Padding(4);
            this.btnTakeQuiz.Name = "btnTakeQuiz";
            this.btnTakeQuiz.Size = new System.Drawing.Size(307, 54);
            this.btnTakeQuiz.TabIndex = 2;
            this.btnTakeQuiz.Tag = "Quiz";
            this.btnTakeQuiz.Text = "Take Quiz";
            this.btnTakeQuiz.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTakeQuiz.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.Cubes;
            this.btnDashboard.IconColor = System.Drawing.Color.White;
            this.btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDashboard.IconSize = 40;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 123);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(4);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(307, 54);
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
            this.pnlLogoBox.Margin = new System.Windows.Forms.Padding(4);
            this.pnlLogoBox.Name = "pnlLogoBox";
            this.pnlLogoBox.Size = new System.Drawing.Size(307, 123);
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
            this.btnMenu.Location = new System.Drawing.Point(227, 0);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.PressedState.Image = global::Quiz_Appli.Properties.Resources.menu;
            this.btnMenu.PressedState.ImageSize = new System.Drawing.Size(40, 40);
            this.btnMenu.Size = new System.Drawing.Size(80, 74);
            this.btnMenu.TabIndex = 1;
            // 
            // pcbLogo
            // 
            this.pcbLogo.Image = global::Quiz_Appli.Properties.Resources.logo;
            this.pcbLogo.ImageRotate = 0F;
            this.pcbLogo.Location = new System.Drawing.Point(28, 0);
            this.pcbLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(220, 115);
            this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbLogo.TabIndex = 0;
            this.pcbLogo.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1512, 690);
            this.Controls.Add(this.pnlDesktop);
            this.Controls.Add(this.pnlTitleBar);
            this.Controls.Add(this.pnlMenu);
            this.Name = "Form2";
            this.Text = "Form2";
            this.pnlDesktop.ResumeLayout(false);
            this.pnlDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompletedQuizzes)).EndInit();
            this.pnlArchivedQuizzes.ResumeLayout(false);
            this.pnlArchivedQuizzes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPic4)).EndInit();
            this.pnlActiveQuizzes.ResumeLayout(false);
            this.pnlActiveQuizzes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPic3)).EndInit();
            this.pnlDraftQuizzes.ResumeLayout(false);
            this.pnlDraftQuizzes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPic2)).EndInit();
            this.pnlTotalQuizzes.ResumeLayout(false);
            this.pnlTotalQuizzes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPic1)).EndInit();
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
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Panel pnlMenu;
        private FontAwesome.Sharp.IconButton btnTakeQuiz;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private System.Windows.Forms.Panel pnlLogoBox;
        private Guna.UI2.WinForms.Guna2ImageButton btnMenu;
        private Guna.UI2.WinForms.Guna2PictureBox pcbLogo;
        private FontAwesome.Sharp.IconButton btnProfile;
        private FontAwesome.Sharp.IconButton btnResults;
        private System.Windows.Forms.Label lblNoQuizzesAvail;
        private Guna.UI2.WinForms.Guna2Panel pnlArchivedQuizzes;
        private Guna.UI2.WinForms.Guna2Panel pnlActiveQuizzes;
        private Guna.UI2.WinForms.Guna2Panel pnlDraftQuizzes;
        private Guna.UI2.WinForms.Guna2Panel pnlTotalQuizzes;
        private FontAwesome.Sharp.IconPictureBox iconPic1;
        private Guna.UI2.WinForms.Guna2CircleProgressBar guna2CircleProgressBar1;
        private System.Windows.Forms.Label lblTotalQuizzes;
        private FontAwesome.Sharp.IconPictureBox iconPic2;
        private Guna.UI2.WinForms.Guna2CircleProgressBar Prg2;
        private System.Windows.Forms.Label lblDraftQuizzes;
        private Guna.UI2.WinForms.Guna2CircleProgressBar Prg3;
        private System.Windows.Forms.Label lblActiveQuizzes;
        private FontAwesome.Sharp.IconPictureBox iconPic3;
        private Guna.UI2.WinForms.Guna2CircleProgressBar Prg4;
        private System.Windows.Forms.Label lblArchivedQuizzes;
        private FontAwesome.Sharp.IconPictureBox iconPic4;
        private System.Windows.Forms.Label lblCompletedQuizzes;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCompletedQuizzes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPercent;
    }
}