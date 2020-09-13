namespace studentmanagementsystem
{
    partial class student_card_export
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(student_card_export));
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtto = new System.Windows.Forms.ComboBox();
            this.txtfrom = new System.Windows.Forms.ComboBox();
            this.btnfromtowise = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtstudentname = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtrollno = new System.Windows.Forms.TextBox();
            this.btnsingalwise = new MetroFramework.Controls.MetroButton();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnexportall = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(23, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(149, 91);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 190;
            this.pictureBox4.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtto);
            this.groupBox1.Controls.Add(this.txtfrom);
            this.groupBox1.Controls.Add(this.btnfromtowise);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBox1.Location = new System.Drawing.Point(23, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(833, 69);
            this.groupBox1.TabIndex = 191;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Card Export Roll # Wise";
            // 
            // txtto
            // 
            this.txtto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtto.FormattingEnabled = true;
            this.txtto.Items.AddRange(new object[] {
            "Select Team"});
            this.txtto.Location = new System.Drawing.Point(322, 29);
            this.txtto.Name = "txtto";
            this.txtto.Size = new System.Drawing.Size(148, 25);
            this.txtto.TabIndex = 312;
            this.txtto.Text = "Select Roll No";
            // 
            // txtfrom
            // 
            this.txtfrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfrom.FormattingEnabled = true;
            this.txtfrom.Items.AddRange(new object[] {
            "Select Roll"});
            this.txtfrom.Location = new System.Drawing.Point(128, 30);
            this.txtfrom.Name = "txtfrom";
            this.txtfrom.Size = new System.Drawing.Size(148, 25);
            this.txtfrom.TabIndex = 311;
            this.txtfrom.Text = "Select Roll No";
            // 
            // btnfromtowise
            // 
            this.btnfromtowise.BackColor = System.Drawing.Color.Teal;
            this.btnfromtowise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnfromtowise.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnfromtowise.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnfromtowise.Location = new System.Drawing.Point(647, 25);
            this.btnfromtowise.Name = "btnfromtowise";
            this.btnfromtowise.Size = new System.Drawing.Size(154, 30);
            this.btnfromtowise.TabIndex = 302;
            this.btnfromtowise.Text = "Export";
            this.btnfromtowise.UseCustomBackColor = true;
            this.btnfromtowise.UseCustomForeColor = true;
            this.btnfromtowise.UseSelectable = true;
            this.btnfromtowise.UseStyleColors = true;
            this.btnfromtowise.Click += new System.EventHandler(this.btnfromtowise_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 296;
            this.label1.Text = "To:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(78, 32);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 17);
            this.label16.TabIndex = 294;
            this.label16.Text = "From:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtstudentname);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtrollno);
            this.groupBox2.Controls.Add(this.btnsingalwise);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBox2.Location = new System.Drawing.Point(23, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(833, 68);
            this.groupBox2.TabIndex = 192;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Singal Student Card Export";
            // 
            // txtstudentname
            // 
            this.txtstudentname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstudentname.FormattingEnabled = true;
            this.txtstudentname.Items.AddRange(new object[] {
            "Select Team"});
            this.txtstudentname.Location = new System.Drawing.Point(133, 27);
            this.txtstudentname.Name = "txtstudentname";
            this.txtstudentname.Size = new System.Drawing.Size(148, 25);
            this.txtstudentname.TabIndex = 310;
            this.txtstudentname.Text = "Student Name";
            this.txtstudentname.TextChanged += new System.EventHandler(this.txtstudentname_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(287, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 309;
            this.label2.Text = "Student Roll #:";
            // 
            // txtrollno
            // 
            this.txtrollno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrollno.Location = new System.Drawing.Point(409, 27);
            this.txtrollno.Name = "txtrollno";
            this.txtrollno.ReadOnly = true;
            this.txtrollno.Size = new System.Drawing.Size(143, 23);
            this.txtrollno.TabIndex = 308;
            // 
            // btnsingalwise
            // 
            this.btnsingalwise.BackColor = System.Drawing.Color.Teal;
            this.btnsingalwise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsingalwise.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnsingalwise.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnsingalwise.Location = new System.Drawing.Point(647, 22);
            this.btnsingalwise.Name = "btnsingalwise";
            this.btnsingalwise.Size = new System.Drawing.Size(154, 30);
            this.btnsingalwise.TabIndex = 307;
            this.btnsingalwise.Text = "Export";
            this.btnsingalwise.UseCustomBackColor = true;
            this.btnsingalwise.UseCustomForeColor = true;
            this.btnsingalwise.UseSelectable = true;
            this.btnsingalwise.UseStyleColors = true;
            this.btnsingalwise.Click += new System.EventHandler(this.btnsingalwise_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 304;
            this.label3.Text = "Student Name:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnexportall);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBox3.Location = new System.Drawing.Point(23, 258);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(833, 71);
            this.groupBox3.TabIndex = 193;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "All Student Card Export";
            // 
            // btnexportall
            // 
            this.btnexportall.BackColor = System.Drawing.Color.Teal;
            this.btnexportall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexportall.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnexportall.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnexportall.Location = new System.Drawing.Point(647, 22);
            this.btnexportall.Name = "btnexportall";
            this.btnexportall.Size = new System.Drawing.Size(154, 30);
            this.btnexportall.TabIndex = 308;
            this.btnexportall.Text = "Export";
            this.btnexportall.UseCustomBackColor = true;
            this.btnexportall.UseCustomForeColor = true;
            this.btnexportall.UseSelectable = true;
            this.btnexportall.UseStyleColors = true;
            this.btnexportall.Click += new System.EventHandler(this.btnexportall_Click);
            // 
            // student_card_export
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 369);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox4);
            this.Name = "student_card_export";
            this.Load += new System.EventHandler(this.student_card_export_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label16;
        public MetroFramework.Controls.MetroButton btnfromtowise;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtrollno;
        public MetroFramework.Controls.MetroButton btnsingalwise;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox txtto;
        public System.Windows.Forms.ComboBox txtfrom;
        public System.Windows.Forms.ComboBox txtstudentname;
        public MetroFramework.Controls.MetroButton btnexportall;
    }
}