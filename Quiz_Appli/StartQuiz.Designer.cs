namespace Quiz_Appli
{
    partial class frmStartQuiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStartQuiz));
            this.pnlDesktop = new Guna.UI2.WinForms.Guna2Panel();
            this.btnBack = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pnlQuiz = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlQuestion = new Guna.UI2.WinForms.Guna2Panel();
            this.tlpAnswers = new System.Windows.Forms.TableLayoutPanel();
            this.rbAnswer1 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbAnswer3 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbAnswer2 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbAnswer4 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.pnlDesktop.SuspendLayout();
            this.pnlQuiz.SuspendLayout();
            this.pnlQuestion.SuspendLayout();
            this.tlpAnswers.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDesktop
            // 
            this.pnlDesktop.BackgroundImage = global::Quiz_Appli.Properties.Resources.background_page__1_;
            this.pnlDesktop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlDesktop.Controls.Add(this.pnlQuiz);
            this.pnlDesktop.Controls.Add(this.btnClose);
            this.pnlDesktop.Controls.Add(this.btnBack);
            this.pnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDesktop.Location = new System.Drawing.Point(0, 0);
            this.pnlDesktop.Name = "pnlDesktop";
            this.pnlDesktop.Size = new System.Drawing.Size(1067, 615);
            this.pnlDesktop.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.HoverState.Image = global::Quiz_Appli.Properties.Resources.back_button_hover;
            this.btnBack.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnBack.ImageRotate = 0F;
            this.btnBack.ImageSize = new System.Drawing.Size(30, 30);
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.PressedState.Image = global::Quiz_Appli.Properties.Resources.back_button;
            this.btnBack.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnBack.Size = new System.Drawing.Size(43, 47);
            this.btnBack.TabIndex = 2;
            this.btnBack.UseTransparentBackground = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.HoverState.Image = global::Quiz_Appli.Properties.Resources.close_tab_hover;
            this.btnClose.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnClose.ImageRotate = 0F;
            this.btnClose.ImageSize = new System.Drawing.Size(30, 30);
            this.btnClose.Location = new System.Drawing.Point(1005, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedState.Image = global::Quiz_Appli.Properties.Resources.close_tab;
            this.btnClose.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnClose.Size = new System.Drawing.Size(44, 43);
            this.btnClose.TabIndex = 8;
            this.btnClose.UseTransparentBackground = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlQuiz
            // 
            this.pnlQuiz.BackColor = System.Drawing.Color.Transparent;
            this.pnlQuiz.BorderRadius = 30;
            this.pnlQuiz.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.pnlQuiz.Controls.Add(this.btnNext);
            this.pnlQuiz.Controls.Add(this.tlpAnswers);
            this.pnlQuiz.Controls.Add(this.pnlQuestion);
            this.pnlQuiz.CustomBorderColor = System.Drawing.Color.Black;
            this.pnlQuiz.FillColor = System.Drawing.Color.Thistle;
            this.pnlQuiz.Location = new System.Drawing.Point(183, 61);
            this.pnlQuiz.Name = "pnlQuiz";
            this.pnlQuiz.ShadowDecoration.BorderRadius = 30;
            this.pnlQuiz.ShadowDecoration.Enabled = true;
            this.pnlQuiz.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.pnlQuiz.Size = new System.Drawing.Size(688, 411);
            this.pnlQuiz.TabIndex = 1;
            // 
            // pnlQuestion
            // 
            this.pnlQuestion.BorderRadius = 30;
            this.pnlQuestion.Controls.Add(this.lblQuestion);
            this.pnlQuestion.FillColor = System.Drawing.Color.Gainsboro;
            this.pnlQuestion.Location = new System.Drawing.Point(29, 15);
            this.pnlQuestion.Name = "pnlQuestion";
            this.pnlQuestion.Size = new System.Drawing.Size(629, 100);
            this.pnlQuestion.TabIndex = 1;
            // 
            // tlpAnswers
            // 
            this.tlpAnswers.ColumnCount = 2;
            this.tlpAnswers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAnswers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAnswers.Controls.Add(this.rbAnswer4, 1, 1);
            this.tlpAnswers.Controls.Add(this.rbAnswer2, 0, 1);
            this.tlpAnswers.Controls.Add(this.rbAnswer3, 1, 0);
            this.tlpAnswers.Controls.Add(this.rbAnswer1, 0, 0);
            this.tlpAnswers.Location = new System.Drawing.Point(68, 163);
            this.tlpAnswers.Name = "tlpAnswers";
            this.tlpAnswers.RowCount = 2;
            this.tlpAnswers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAnswers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAnswers.Size = new System.Drawing.Size(546, 153);
            this.tlpAnswers.TabIndex = 2;
            // 
            // rbAnswer1
            // 
            this.rbAnswer1.AutoSize = true;
            this.rbAnswer1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbAnswer1.CheckedState.BorderThickness = 0;
            this.rbAnswer1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbAnswer1.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbAnswer1.CheckedState.InnerOffset = -4;
            this.rbAnswer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbAnswer1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAnswer1.Location = new System.Drawing.Point(3, 3);
            this.rbAnswer1.Name = "rbAnswer1";
            this.rbAnswer1.Size = new System.Drawing.Size(267, 70);
            this.rbAnswer1.TabIndex = 0;
            this.rbAnswer1.Text = "guna2RadioButton1";
            this.rbAnswer1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbAnswer1.UncheckedState.BorderThickness = 2;
            this.rbAnswer1.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbAnswer1.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rbAnswer3
            // 
            this.rbAnswer3.AutoSize = true;
            this.rbAnswer3.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbAnswer3.CheckedState.BorderThickness = 0;
            this.rbAnswer3.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbAnswer3.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbAnswer3.CheckedState.InnerOffset = -4;
            this.rbAnswer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbAnswer3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAnswer3.Location = new System.Drawing.Point(276, 3);
            this.rbAnswer3.Name = "rbAnswer3";
            this.rbAnswer3.Size = new System.Drawing.Size(267, 70);
            this.rbAnswer3.TabIndex = 1;
            this.rbAnswer3.Text = "guna2RadioButton1";
            this.rbAnswer3.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbAnswer3.UncheckedState.BorderThickness = 2;
            this.rbAnswer3.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbAnswer3.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rbAnswer2
            // 
            this.rbAnswer2.AutoSize = true;
            this.rbAnswer2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbAnswer2.CheckedState.BorderThickness = 0;
            this.rbAnswer2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbAnswer2.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbAnswer2.CheckedState.InnerOffset = -4;
            this.rbAnswer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbAnswer2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAnswer2.Location = new System.Drawing.Point(3, 79);
            this.rbAnswer2.Name = "rbAnswer2";
            this.rbAnswer2.Size = new System.Drawing.Size(267, 71);
            this.rbAnswer2.TabIndex = 2;
            this.rbAnswer2.Text = "guna2RadioButton1";
            this.rbAnswer2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbAnswer2.UncheckedState.BorderThickness = 2;
            this.rbAnswer2.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbAnswer2.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rbAnswer4
            // 
            this.rbAnswer4.AutoSize = true;
            this.rbAnswer4.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbAnswer4.CheckedState.BorderThickness = 0;
            this.rbAnswer4.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbAnswer4.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbAnswer4.CheckedState.InnerOffset = -4;
            this.rbAnswer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbAnswer4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAnswer4.Location = new System.Drawing.Point(276, 79);
            this.rbAnswer4.Name = "rbAnswer4";
            this.rbAnswer4.Size = new System.Drawing.Size(267, 71);
            this.rbAnswer4.TabIndex = 3;
            this.rbAnswer4.Text = "guna2RadioButton1";
            this.rbAnswer4.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbAnswer4.UncheckedState.BorderThickness = 2;
            this.rbAnswer4.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbAnswer4.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(57, 41);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(385, 20);
            this.lblQuestion.TabIndex = 1;
            this.lblQuestion.Text = "alghlelrhioaeheliahgeioghrolvfvnkeoiveoanbe";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            this.btnNext.BorderRadius = 20;
            this.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNext.FillColor = System.Drawing.Color.Purple;
            this.btnNext.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(250, 343);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(180, 45);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            // 
            // frmStartQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1067, 615);
            this.Controls.Add(this.pnlDesktop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStartQuiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartQuiz";
            this.pnlDesktop.ResumeLayout(false);
            this.pnlQuiz.ResumeLayout(false);
            this.pnlQuestion.ResumeLayout(false);
            this.pnlQuestion.PerformLayout();
            this.tlpAnswers.ResumeLayout(false);
            this.tlpAnswers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlDesktop;
        private Guna.UI2.WinForms.Guna2ImageButton btnBack;
        private Guna.UI2.WinForms.Guna2ImageButton btnClose;
        private Guna.UI2.WinForms.Guna2Panel pnlQuiz;
        private Guna.UI2.WinForms.Guna2Panel pnlQuestion;
        private System.Windows.Forms.TableLayoutPanel tlpAnswers;
        private Guna.UI2.WinForms.Guna2RadioButton rbAnswer1;
        private Guna.UI2.WinForms.Guna2RadioButton rbAnswer4;
        private Guna.UI2.WinForms.Guna2RadioButton rbAnswer2;
        private Guna.UI2.WinForms.Guna2RadioButton rbAnswer3;
        private System.Windows.Forms.Label lblQuestion;
        private Guna.UI2.WinForms.Guna2Button btnNext;
    }
}