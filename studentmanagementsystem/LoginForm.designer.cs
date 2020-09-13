namespace studentmanagementsystem
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.checkbox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnlogin = new MetroFramework.Controls.MetroButton();
            this.txtpassword = new MetroFramework.Controls.MetroTextBox();
            this.txtusername = new MetroFramework.Controls.MetroTextBox();
            this.metroUserControl1 = new MetroFramework.Controls.MetroUserControl();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // checkbox
            // 
            this.checkbox.AutoSize = true;
            this.checkbox.Location = new System.Drawing.Point(158, 427);
            this.checkbox.Margin = new System.Windows.Forms.Padding(4);
            this.checkbox.Name = "checkbox";
            this.checkbox.Size = new System.Drawing.Size(129, 21);
            this.checkbox.TabIndex = 140;
            this.checkbox.Text = "Show Password";
            this.checkbox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("DS-Digital", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(423, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 40);
            this.label2.TabIndex = 139;
            this.label2.Text = "00:00:00";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.linkLabel1.LinkColor = System.Drawing.Color.Navy;
            this.linkLabel1.Location = new System.Drawing.Point(349, 429);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(140, 26);
            this.linkLabel1.TabIndex = 136;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = " Forget Password";
            this.linkLabel1.UseCompatibleTextRendering = true;
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(142)))), ((int)(((byte)(107)))));
            this.btnlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnlogin.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnlogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnlogin.Location = new System.Drawing.Point(157, 464);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(336, 43);
            this.btnlogin.TabIndex = 135;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseCustomBackColor = true;
            this.btnlogin.UseCustomForeColor = true;
            this.btnlogin.UseSelectable = true;
            this.btnlogin.UseStyleColors = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(224)))), ((int)(((byte)(10)))));
            // 
            // 
            // 
            this.txtpassword.CustomButton.Image = null;
            this.txtpassword.CustomButton.Location = new System.Drawing.Point(298, 1);
            this.txtpassword.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtpassword.CustomButton.Name = "";
            this.txtpassword.CustomButton.Size = new System.Drawing.Size(37, 37);
            this.txtpassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtpassword.CustomButton.TabIndex = 1;
            this.txtpassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtpassword.CustomButton.UseSelectable = true;
            this.txtpassword.CustomButton.Visible = false;
            this.txtpassword.DisplayIcon = true;
            this.txtpassword.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtpassword.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtpassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(142)))), ((int)(((byte)(107)))));
            this.txtpassword.Lines = new string[0];
            this.txtpassword.Location = new System.Drawing.Point(157, 366);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtpassword.MaxLength = 32767;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '\0';
            this.txtpassword.PromptText = "Password";
            this.txtpassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtpassword.SelectedText = "";
            this.txtpassword.SelectionLength = 0;
            this.txtpassword.SelectionStart = 0;
            this.txtpassword.ShortcutsEnabled = true;
            this.txtpassword.Size = new System.Drawing.Size(336, 39);
            this.txtpassword.TabIndex = 134;
            this.txtpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtpassword.UseCustomBackColor = true;
            this.txtpassword.UseCustomForeColor = true;
            this.txtpassword.UseSelectable = true;
            this.txtpassword.UseStyleColors = true;
            this.txtpassword.WaterMark = "Password";
            this.txtpassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(142)))), ((int)(((byte)(107)))));
            this.txtpassword.WaterMarkFont = new System.Drawing.Font("Google Sans", 9F, System.Drawing.FontStyle.Italic);
            // 
            // txtusername
            // 
            this.txtusername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(224)))), ((int)(((byte)(10)))));
            // 
            // 
            // 
            this.txtusername.CustomButton.Image = null;
            this.txtusername.CustomButton.Location = new System.Drawing.Point(300, 1);
            this.txtusername.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtusername.CustomButton.Name = "";
            this.txtusername.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtusername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtusername.CustomButton.TabIndex = 1;
            this.txtusername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtusername.CustomButton.UseSelectable = true;
            this.txtusername.CustomButton.Visible = false;
            this.txtusername.DisplayIcon = true;
            this.txtusername.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtusername.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtusername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(142)))), ((int)(((byte)(107)))));
            this.txtusername.Lines = new string[0];
            this.txtusername.Location = new System.Drawing.Point(157, 321);
            this.txtusername.Margin = new System.Windows.Forms.Padding(4);
            this.txtusername.MaxLength = 32767;
            this.txtusername.Name = "txtusername";
            this.txtusername.PasswordChar = '\0';
            this.txtusername.PromptText = "User Name";
            this.txtusername.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtusername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtusername.SelectedText = "";
            this.txtusername.SelectionLength = 0;
            this.txtusername.SelectionStart = 0;
            this.txtusername.ShortcutsEnabled = true;
            this.txtusername.Size = new System.Drawing.Size(336, 37);
            this.txtusername.TabIndex = 133;
            this.txtusername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtusername.UseCustomBackColor = true;
            this.txtusername.UseCustomForeColor = true;
            this.txtusername.UseSelectable = true;
            this.txtusername.UseStyleColors = true;
            this.txtusername.WaterMark = "User Name";
            this.txtusername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(142)))), ((int)(((byte)(107)))));
            this.txtusername.WaterMarkFont = new System.Drawing.Font("Google Sans", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroUserControl1
            // 
            this.metroUserControl1.Location = new System.Drawing.Point(178, 173);
            this.metroUserControl1.Margin = new System.Windows.Forms.Padding(4);
            this.metroUserControl1.Name = "metroUserControl1";
            this.metroUserControl1.Size = new System.Drawing.Size(11, 10);
            this.metroUserControl1.TabIndex = 137;
            this.metroUserControl1.UseSelectable = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(16, 17);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 64);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 186;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::studentmanagementsystem.Properties.Resources.lgo12;
            this.pictureBox1.Location = new System.Drawing.Point(58, 78);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(559, 222);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 138;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(676, 540);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.checkbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroUserControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Opacity = 0.95D;
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Admin Login Panel";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Activated += new System.EventHandler(this.LoginForm_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.CheckBox checkbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private MetroFramework.Controls.MetroButton btnlogin;
        private MetroFramework.Controls.MetroTextBox txtpassword;
        public MetroFramework.Controls.MetroTextBox txtusername;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroUserControl metroUserControl1;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}