namespace studentmanagementsystem
{
    partial class student_reoprt
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(student_reoprt));
            this.txtstusearch = new MetroFramework.Controls.MetroTextBox();
            this.txtstucombox = new MetroFramework.Controls.MetroComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // txtstusearch
            // 
            this.txtstusearch.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtstusearch.CustomButton.Image = null;
            this.txtstusearch.CustomButton.Location = new System.Drawing.Point(712, 1);
            this.txtstusearch.CustomButton.Name = "";
            this.txtstusearch.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txtstusearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtstusearch.CustomButton.TabIndex = 1;
            this.txtstusearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtstusearch.CustomButton.UseSelectable = true;
            this.txtstusearch.CustomButton.Visible = false;
            this.txtstusearch.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtstusearch.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtstusearch.Lines = new string[0];
            this.txtstusearch.Location = new System.Drawing.Point(350, 91);
            this.txtstusearch.MaxLength = 32767;
            this.txtstusearch.Name = "txtstusearch";
            this.txtstusearch.PasswordChar = '\0';
            this.txtstusearch.PromptText = "Search Bar";
            this.txtstusearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtstusearch.SelectedText = "";
            this.txtstusearch.SelectionLength = 0;
            this.txtstusearch.SelectionStart = 0;
            this.txtstusearch.ShortcutsEnabled = true;
            this.txtstusearch.Size = new System.Drawing.Size(746, 35);
            this.txtstusearch.TabIndex = 1;
            this.txtstusearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtstusearch.UseCustomBackColor = true;
            this.txtstusearch.UseCustomForeColor = true;
            this.txtstusearch.UseSelectable = true;
            this.txtstusearch.UseStyleColors = true;
            this.txtstusearch.WaterMark = "Search Bar";
            this.txtstusearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtstusearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtstusearch.TabIndexChanged += new System.EventHandler(this.txtstusearch_TabIndexChanged);
            this.txtstusearch.TextChanged += new System.EventHandler(this.txtstusearch_TextChanged);
            // 
            // txtstucombox
            // 
            this.txtstucombox.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.txtstucombox.FormattingEnabled = true;
            this.txtstucombox.ItemHeight = 29;
            this.txtstucombox.Items.AddRange(new object[] {
            "Roll #",
            "Student Name",
            "Phone #"});
            this.txtstucombox.Location = new System.Drawing.Point(1102, 91);
            this.txtstucombox.Name = "txtstucombox";
            this.txtstucombox.Size = new System.Drawing.Size(237, 35);
            this.txtstucombox.TabIndex = 3;
            this.txtstucombox.UseCustomBackColor = true;
            this.txtstucombox.UseCustomForeColor = true;
            this.txtstucombox.UseSelectable = true;
            this.txtstucombox.UseStyleColors = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 7);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1315, 444);
            this.dataGridView1.TabIndex = 58;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("DS-Digital", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.Color.Crimson;
            this.time.Location = new System.Drawing.Point(1183, 28);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(124, 31);
            this.time.TabIndex = 187;
            this.time.Text = "00:00:00";
            this.time.Click += new System.EventHandler(this.time_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(12, 11);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(149, 91);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 188;
            this.pictureBox4.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(142)))), ((int)(((byte)(107)))));
            this.label15.Location = new System.Drawing.Point(564, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(313, 60);
            this.label15.TabIndex = 189;
            this.label15.Text = "STUDENTS  LIST";
            // 
            // student_reoprt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 620);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.time);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtstucombox);
            this.Controls.Add(this.txtstusearch);
            this.Name = "student_reoprt";
            this.Text = "Student List";
            this.Activated += new System.EventHandler(this.student_reoprt_Activated);
            this.Load += new System.EventHandler(this.student_reoprt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox txtstusearch;
        private MetroFramework.Controls.MetroComboBox txtstucombox;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label15;
    }
}