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
            this.btnBack = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pnlQuiz = new Guna.UI2.WinForms.Guna2Panel();
            this.rdbGroupBox = new Guna.UI2.WinForms.Guna2GroupBox();
            this.rdbChoices1 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdbChoices2 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdbChoices4 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdbChoices3 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.txtQuestions = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.pnlDesktop = new Guna.UI2.WinForms.Guna2Panel();
            this.lblCounter = new System.Windows.Forms.Label();
            this.pnlQuiz.SuspendLayout();
            this.rdbGroupBox.SuspendLayout();
            this.pnlDesktop.SuspendLayout();
            this.SuspendLayout();
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
            this.btnBack.Location = new System.Drawing.Point(3, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.PressedState.Image = global::Quiz_Appli.Properties.Resources.back_button;
            this.btnBack.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnBack.Size = new System.Drawing.Size(32, 38);
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
            this.btnClose.Location = new System.Drawing.Point(1330, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedState.Image = global::Quiz_Appli.Properties.Resources.close_tab;
            this.btnClose.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnClose.Size = new System.Drawing.Size(33, 35);
            this.btnClose.TabIndex = 8;
            this.btnClose.UseTransparentBackground = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlQuiz
            // 
            this.pnlQuiz.BackColor = System.Drawing.Color.Transparent;
            this.pnlQuiz.BorderRadius = 30;
            this.pnlQuiz.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.pnlQuiz.Controls.Add(this.lblCounter);
            this.pnlQuiz.Controls.Add(this.rdbGroupBox);
            this.pnlQuiz.Controls.Add(this.txtQuestions);
            this.pnlQuiz.Controls.Add(this.btnNext);
            this.pnlQuiz.CustomBorderColor = System.Drawing.Color.Black;
            this.pnlQuiz.FillColor = System.Drawing.Color.Thistle;
            this.pnlQuiz.Location = new System.Drawing.Point(205, 63);
            this.pnlQuiz.Margin = new System.Windows.Forms.Padding(2);
            this.pnlQuiz.Name = "pnlQuiz";
            this.pnlQuiz.ShadowDecoration.BorderRadius = 30;
            this.pnlQuiz.ShadowDecoration.Enabled = true;
            this.pnlQuiz.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.pnlQuiz.Size = new System.Drawing.Size(923, 657);
            this.pnlQuiz.TabIndex = 1;
            // 
            // rdbGroupBox
            // 
            this.rdbGroupBox.BorderColor = System.Drawing.Color.Transparent;
            this.rdbGroupBox.Controls.Add(this.rdbChoices1);
            this.rdbGroupBox.Controls.Add(this.rdbChoices2);
            this.rdbGroupBox.Controls.Add(this.rdbChoices4);
            this.rdbGroupBox.Controls.Add(this.rdbChoices3);
            this.rdbGroupBox.CustomBorderColor = System.Drawing.Color.Transparent;
            this.rdbGroupBox.FillColor = System.Drawing.Color.Transparent;
            this.rdbGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rdbGroupBox.ForeColor = System.Drawing.Color.Transparent;
            this.rdbGroupBox.Location = new System.Drawing.Point(78, 206);
            this.rdbGroupBox.Name = "rdbGroupBox";
            this.rdbGroupBox.Size = new System.Drawing.Size(772, 343);
            this.rdbGroupBox.TabIndex = 6;
            this.rdbGroupBox.Text = "guna2GroupBox1";
            // 
            // rdbChoices1
            // 
            this.rdbChoices1.AutoSize = true;
            this.rdbChoices1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbChoices1.CheckedState.BorderThickness = 0;
            this.rdbChoices1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbChoices1.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbChoices1.CheckedState.InnerOffset = -4;
            this.rdbChoices1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbChoices1.Location = new System.Drawing.Point(21, 29);
            this.rdbChoices1.Name = "rdbChoices1";
            this.rdbChoices1.Size = new System.Drawing.Size(14, 13);
            this.rdbChoices1.TabIndex = 2;
            this.rdbChoices1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdbChoices1.UncheckedState.BorderThickness = 2;
            this.rdbChoices1.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdbChoices1.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rdbChoices2
            // 
            this.rdbChoices2.AutoSize = true;
            this.rdbChoices2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbChoices2.CheckedState.BorderThickness = 0;
            this.rdbChoices2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbChoices2.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbChoices2.CheckedState.InnerOffset = -4;
            this.rdbChoices2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbChoices2.Location = new System.Drawing.Point(21, 122);
            this.rdbChoices2.Name = "rdbChoices2";
            this.rdbChoices2.Size = new System.Drawing.Size(14, 13);
            this.rdbChoices2.TabIndex = 3;
            this.rdbChoices2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdbChoices2.UncheckedState.BorderThickness = 2;
            this.rdbChoices2.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdbChoices2.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rdbChoices4
            // 
            this.rdbChoices4.AutoSize = true;
            this.rdbChoices4.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbChoices4.CheckedState.BorderThickness = 0;
            this.rdbChoices4.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbChoices4.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbChoices4.CheckedState.InnerOffset = -4;
            this.rdbChoices4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.rdbChoices4.Location = new System.Drawing.Point(21, 307);
            this.rdbChoices4.Name = "rdbChoices4";
            this.rdbChoices4.Size = new System.Drawing.Size(14, 13);
            this.rdbChoices4.TabIndex = 5;
            this.rdbChoices4.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdbChoices4.UncheckedState.BorderThickness = 2;
            this.rdbChoices4.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdbChoices4.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rdbChoices3
            // 
            this.rdbChoices3.AutoSize = true;
            this.rdbChoices3.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbChoices3.CheckedState.BorderThickness = 0;
            this.rdbChoices3.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbChoices3.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbChoices3.CheckedState.InnerOffset = -4;
            this.rdbChoices3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbChoices3.Location = new System.Drawing.Point(21, 215);
            this.rdbChoices3.Name = "rdbChoices3";
            this.rdbChoices3.Size = new System.Drawing.Size(14, 13);
            this.rdbChoices3.TabIndex = 4;
            this.rdbChoices3.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdbChoices3.UncheckedState.BorderThickness = 2;
            this.rdbChoices3.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdbChoices3.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // txtQuestions
            // 
            this.txtQuestions.BorderColor = System.Drawing.Color.Thistle;
            this.txtQuestions.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtQuestions.DefaultText = "";
            this.txtQuestions.DisabledState.BorderColor = System.Drawing.Color.Thistle;
            this.txtQuestions.DisabledState.FillColor = System.Drawing.Color.Thistle;
            this.txtQuestions.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.txtQuestions.DisabledState.PlaceholderForeColor = System.Drawing.Color.Thistle;
            this.txtQuestions.Enabled = false;
            this.txtQuestions.FillColor = System.Drawing.Color.Thistle;
            this.txtQuestions.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuestions.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestions.ForeColor = System.Drawing.Color.Black;
            this.txtQuestions.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuestions.Location = new System.Drawing.Point(99, 51);
            this.txtQuestions.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtQuestions.Name = "txtQuestions";
            this.txtQuestions.PlaceholderForeColor = System.Drawing.Color.Thistle;
            this.txtQuestions.PlaceholderText = "";
            this.txtQuestions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtQuestions.SelectedText = "";
            this.txtQuestions.Size = new System.Drawing.Size(772, 123);
            this.txtQuestions.TabIndex = 0;
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
            this.btnNext.Location = new System.Drawing.Point(66, 605);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(135, 37);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
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
            this.pnlDesktop.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDesktop.Name = "pnlDesktop";
            this.pnlDesktop.Size = new System.Drawing.Size(1366, 768);
            this.pnlDesktop.TabIndex = 0;
            // 
            // lblCounter
            // 
            this.lblCounter.AutoSize = true;
            this.lblCounter.BackColor = System.Drawing.Color.Transparent;
            this.lblCounter.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounter.Location = new System.Drawing.Point(670, 12);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(22, 24);
            this.lblCounter.TabIndex = 9;
            this.lblCounter.Text = "0";
            // 
            // frmStartQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.pnlDesktop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmStartQuiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartQuiz";
            this.Load += new System.EventHandler(this.frmStartQuiz_Load);
            this.pnlQuiz.ResumeLayout(false);
            this.pnlQuiz.PerformLayout();
            this.rdbGroupBox.ResumeLayout(false);
            this.rdbGroupBox.PerformLayout();
            this.pnlDesktop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ImageButton btnBack;
        private Guna.UI2.WinForms.Guna2ImageButton btnClose;
        private Guna.UI2.WinForms.Guna2Panel pnlQuiz;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private Guna.UI2.WinForms.Guna2Panel pnlDesktop;
        private Guna.UI2.WinForms.Guna2RadioButton rdbChoices4;
        private Guna.UI2.WinForms.Guna2RadioButton rdbChoices3;
        private Guna.UI2.WinForms.Guna2RadioButton rdbChoices2;
        private Guna.UI2.WinForms.Guna2RadioButton rdbChoices1;
        private Guna.UI2.WinForms.Guna2TextBox txtQuestions;
        private Guna.UI2.WinForms.Guna2GroupBox rdbGroupBox;
        private System.Windows.Forms.Label lblCounter;
    }
}