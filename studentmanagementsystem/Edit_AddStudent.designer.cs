namespace studentmanagementsystem
{
    partial class Edit_AddStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_AddStudent));
            this.editslastscl = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.editsadress = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.editsdob = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.editsfcnic = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.editscontact = new System.Windows.Forms.MaskedTextBox();
            this.editsclassection = new System.Windows.Forms.ComboBox();
            this.editsclass = new System.Windows.Forms.ComboBox();
            this.editscnic = new System.Windows.Forms.MaskedTextBox();
            this.editsgender = new System.Windows.Forms.ComboBox();
            this.editsfname = new System.Windows.Forms.TextBox();
            this.editsname = new System.Windows.Forms.TextBox();
            this.editsrolno = new System.Windows.Forms.TextBox();
            this.seditupdate = new MetroFramework.Controls.MetroButton();
            this.btndelet = new MetroFramework.Controls.MetroButton();
            this.label15 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.editchang_pic = new MetroFramework.Controls.MetroButton();
            this.editspic = new System.Windows.Forms.PictureBox();
            this.time = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sedittimer = new System.Windows.Forms.Timer(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.editsbarcod = new System.Windows.Forms.TextBox();
            this.editsid = new System.Windows.Forms.TextBox();
            this.editstupic = new MetroFramework.Controls.MetroTile();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.edittxtstatus = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.edittxtstudentfee = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.edittxtdiscountfee = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.editstudentfeediscount = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editspic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // editslastscl
            // 
            this.editslastscl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editslastscl.Location = new System.Drawing.Point(226, 397);
            this.editslastscl.Name = "editslastscl";
            this.editslastscl.Size = new System.Drawing.Size(325, 29);
            this.editslastscl.TabIndex = 10;
            this.editslastscl.Enter += new System.EventHandler(this.edittxtstulaschool_Enter);
            this.editslastscl.Leave += new System.EventHandler(this.edittxtstulaschool_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(91, 404);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 19);
            this.label13.TabIndex = 69;
            this.label13.Text = "Last School :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(122, 441);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 19);
            this.label12.TabIndex = 68;
            this.label12.Text = "Address :";
            // 
            // editsadress
            // 
            this.editsadress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editsadress.Location = new System.Drawing.Point(226, 434);
            this.editsadress.Name = "editsadress";
            this.editsadress.Size = new System.Drawing.Size(537, 29);
            this.editsadress.TabIndex = 11;
            this.editsadress.Leave += new System.EventHandler(this.edittxtstuadress_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(560, 218);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 19);
            this.label11.TabIndex = 66;
            this.label11.Text = "DOB :";
            // 
            // editsdob
            // 
            this.editsdob.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editsdob.Location = new System.Drawing.Point(634, 211);
            this.editsdob.Mask = "99-99-9999";
            this.editsdob.Name = "editsdob";
            this.editsdob.Size = new System.Drawing.Size(183, 29);
            this.editsdob.TabIndex = 6;
            this.editsdob.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edittxtstudob_KeyPress);
            this.editsdob.Leave += new System.EventHandler(this.edittxtstudob_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(62, 367);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 19);
            this.label10.TabIndex = 64;
            this.label10.Text = "Father_CNIC # :";
            // 
            // editsfcnic
            // 
            this.editsfcnic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editsfcnic.Location = new System.Drawing.Point(226, 360);
            this.editsfcnic.Mask = "99999-9999999-9";
            this.editsfcnic.Name = "editsfcnic";
            this.editsfcnic.Size = new System.Drawing.Size(234, 29);
            this.editsfcnic.TabIndex = 5;
            this.editsfcnic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edittxtmaskfcnic_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(534, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 19);
            this.label8.TabIndex = 62;
            this.label8.Text = "Section :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(552, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 19);
            this.label7.TabIndex = 61;
            this.label7.Text = "Class :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(511, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 19);
            this.label6.TabIndex = 60;
            this.label6.Text = "Contact # :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(127, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 19);
            this.label5.TabIndex = 59;
            this.label5.Text = "CNIC # :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(128, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 19);
            this.label4.TabIndex = 58;
            this.label4.Text = "Gender :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(80, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 19);
            this.label3.TabIndex = 57;
            this.label3.Text = "Father Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(69, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 19);
            this.label2.TabIndex = 56;
            this.label2.Text = "Student Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(139, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 55;
            this.label1.Text = "Roll # :";
            // 
            // editscontact
            // 
            this.editscontact.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editscontact.Location = new System.Drawing.Point(634, 319);
            this.editscontact.Mask = "9999-9999999";
            this.editscontact.Name = "editscontact";
            this.editscontact.Size = new System.Drawing.Size(183, 29);
            this.editscontact.TabIndex = 9;
            this.editscontact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edittxtstucontact_KeyPress);
            this.editscontact.Leave += new System.EventHandler(this.edittxtstucontact_Leave);
            // 
            // editsclassection
            // 
            this.editsclassection.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editsclassection.FormattingEnabled = true;
            this.editsclassection.Items.AddRange(new object[] {
            "A Section",
            "B Section",
            "C Section",
            "D Section"});
            this.editsclassection.Location = new System.Drawing.Point(634, 284);
            this.editsclassection.Name = "editsclassection";
            this.editsclassection.Size = new System.Drawing.Size(183, 32);
            this.editsclassection.TabIndex = 8;
            this.editsclassection.Enter += new System.EventHandler(this.edittxtstusection_Enter);
            this.editsclassection.Leave += new System.EventHandler(this.edittxtstusection_Leave);
            // 
            // editsclass
            // 
            this.editsclass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editsclass.FormattingEnabled = true;
            this.editsclass.Items.AddRange(new object[] {
            "Middle",
            "Martric",
            "FSC",
            "ICS",
            "I.Com",
            "D.Com",
            "F.A",
            "M.A",
            "BSCS",
            "BBA"});
            this.editsclass.Location = new System.Drawing.Point(634, 246);
            this.editsclass.Name = "editsclass";
            this.editsclass.Size = new System.Drawing.Size(183, 32);
            this.editsclass.TabIndex = 7;
            this.editsclass.Enter += new System.EventHandler(this.edittxtstuclass_Enter);
            this.editsclass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edittxtstuclass_KeyPress);
            this.editsclass.Leave += new System.EventHandler(this.edittxtstuclass_Leave);
            // 
            // editscnic
            // 
            this.editscnic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editscnic.Location = new System.Drawing.Point(226, 326);
            this.editscnic.Mask = "99999-9999999-9";
            this.editscnic.Name = "editscnic";
            this.editscnic.Size = new System.Drawing.Size(234, 29);
            this.editscnic.TabIndex = 4;
            this.editscnic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edittxtcnicno_KeyPress);
            this.editscnic.Leave += new System.EventHandler(this.edittxtcnicno_Leave);
            // 
            // editsgender
            // 
            this.editsgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editsgender.FormattingEnabled = true;
            this.editsgender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "SheMale"});
            this.editsgender.Location = new System.Drawing.Point(226, 288);
            this.editsgender.Name = "editsgender";
            this.editsgender.Size = new System.Drawing.Size(234, 32);
            this.editsgender.TabIndex = 3;
            this.editsgender.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edittxtgender_KeyPress);
            this.editsgender.Leave += new System.EventHandler(this.edittxtgender_Leave);
            // 
            // editsfname
            // 
            this.editsfname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editsfname.Location = new System.Drawing.Point(226, 253);
            this.editsfname.Name = "editsfname";
            this.editsfname.Size = new System.Drawing.Size(234, 29);
            this.editsfname.TabIndex = 2;
            this.editsfname.Enter += new System.EventHandler(this.edittxtfathername_Enter);
            this.editsfname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edittxtfathername_KeyPress);
            this.editsfname.Leave += new System.EventHandler(this.edittxtfathername_Leave);
            // 
            // editsname
            // 
            this.editsname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editsname.Location = new System.Drawing.Point(226, 218);
            this.editsname.Name = "editsname";
            this.editsname.Size = new System.Drawing.Size(234, 29);
            this.editsname.TabIndex = 1;
            this.editsname.Enter += new System.EventHandler(this.edittxtstudentname_Enter);
            this.editsname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edittxtstudentname_KeyPress);
            this.editsname.Leave += new System.EventHandler(this.edittxtstudentname_Leave);
            // 
            // editsrolno
            // 
            this.editsrolno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editsrolno.Location = new System.Drawing.Point(226, 183);
            this.editsrolno.Name = "editsrolno";
            this.editsrolno.Size = new System.Drawing.Size(234, 29);
            this.editsrolno.TabIndex = 0;
            this.editsrolno.Enter += new System.EventHandler(this.edittxtsturegno_Enter);
            this.editsrolno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edittxtsturegno_KeyPress);
            this.editsrolno.Leave += new System.EventHandler(this.edittxtsturegno_Leave);
            // 
            // seditupdate
            // 
            this.seditupdate.BackColor = System.Drawing.Color.Teal;
            this.seditupdate.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.seditupdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.seditupdate.Location = new System.Drawing.Point(522, 491);
            this.seditupdate.Name = "seditupdate";
            this.seditupdate.Size = new System.Drawing.Size(129, 39);
            this.seditupdate.TabIndex = 17;
            this.seditupdate.Text = "Update";
            this.seditupdate.UseCustomBackColor = true;
            this.seditupdate.UseCustomForeColor = true;
            this.seditupdate.UseSelectable = true;
            this.seditupdate.UseStyleColors = true;
            this.seditupdate.Click += new System.EventHandler(this.txtinsert_Click);
            // 
            // btndelet
            // 
            this.btndelet.BackColor = System.Drawing.Color.IndianRed;
            this.btndelet.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btndelet.ForeColor = System.Drawing.Color.White;
            this.btndelet.Location = new System.Drawing.Point(377, 491);
            this.btndelet.Name = "btndelet";
            this.btndelet.Size = new System.Drawing.Size(130, 39);
            this.btndelet.TabIndex = 16;
            this.btndelet.Text = "Delete";
            this.btndelet.UseCustomBackColor = true;
            this.btndelet.UseCustomForeColor = true;
            this.btndelet.UseSelectable = true;
            this.btndelet.UseStyleColors = true;
            this.btndelet.Click += new System.EventHandler(this.btndelet_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Forte", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.SlateGray;
            this.label15.Location = new System.Drawing.Point(523, 84);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(289, 41);
            this.label15.TabIndex = 79;
            this.label15.Text = "Edit_STUDENTS";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // editchang_pic
            // 
            this.editchang_pic.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.editchang_pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editchang_pic.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.editchang_pic.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.editchang_pic.Location = new System.Drawing.Point(904, 326);
            this.editchang_pic.Name = "editchang_pic";
            this.editchang_pic.Size = new System.Drawing.Size(162, 23);
            this.editchang_pic.TabIndex = 13;
            this.editchang_pic.Text = "Chang Pic";
            this.editchang_pic.UseCustomBackColor = true;
            this.editchang_pic.UseCustomForeColor = true;
            this.editchang_pic.UseSelectable = true;
            this.editchang_pic.UseStyleColors = true;
            this.editchang_pic.Click += new System.EventHandler(this.editchang_pic_Click);
            // 
            // editspic
            // 
            this.editspic.BackColor = System.Drawing.Color.White;
            this.editspic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editspic.Image = global::studentmanagementsystem.Properties.Resources._13_512;
            this.editspic.Location = new System.Drawing.Point(904, 173);
            this.editspic.Name = "editspic";
            this.editspic.Size = new System.Drawing.Size(162, 147);
            this.editspic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.editspic.TabIndex = 175;
            this.editspic.TabStop = false;
            this.editspic.Click += new System.EventHandler(this.editspic_Click);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("DS-Digital", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.time.ForeColor = System.Drawing.Color.Crimson;
            this.time.Location = new System.Drawing.Point(946, 44);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(124, 31);
            this.time.TabIndex = 180;
            this.time.Text = "00:00:00";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(320, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 181;
            this.pictureBox1.TabStop = false;
            // 
            // sedittimer
            // 
            this.sedittimer.Tick += new System.EventHandler(this.sedittimer_Tick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(528, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 19);
            this.label9.TabIndex = 183;
            this.label9.Text = "Barcode :";
            // 
            // editsbarcod
            // 
            this.editsbarcod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editsbarcod.Location = new System.Drawing.Point(634, 176);
            this.editsbarcod.Name = "editsbarcod";
            this.editsbarcod.Size = new System.Drawing.Size(183, 29);
            this.editsbarcod.TabIndex = 14;
            // 
            // editsid
            // 
            this.editsid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editsid.Location = new System.Drawing.Point(226, 148);
            this.editsid.Name = "editsid";
            this.editsid.Size = new System.Drawing.Size(234, 29);
            this.editsid.TabIndex = 15;
            // 
            // editstupic
            // 
            this.editstupic.ActiveControl = null;
            this.editstupic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editstupic.Location = new System.Drawing.Point(1072, 154);
            this.editstupic.Name = "editstupic";
            this.editstupic.Size = new System.Drawing.Size(13, 23);
            this.editstupic.TabIndex = 12;
            this.editstupic.TileImage = ((System.Drawing.Image)(resources.GetObject("editstupic.TileImage")));
            this.editstupic.UseCustomBackColor = true;
            this.editstupic.UseCustomForeColor = true;
            this.editstupic.UseSelectable = true;
            this.editstupic.UseStyleColors = true;
            this.editstupic.UseTileImage = true;
            this.editstupic.Click += new System.EventHandler(this.editstupic_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::studentmanagementsystem.Properties.Resources.ssu_school_logo;
            this.pictureBox4.Location = new System.Drawing.Point(23, 13);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(173, 62);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 186;
            this.pictureBox4.TabStop = false;
            // 
            // edittxtstatus
            // 
            this.edittxtstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edittxtstatus.FormattingEnabled = true;
            this.edittxtstatus.Items.AddRange(new object[] {
            "Active",
            "Leave"});
            this.edittxtstatus.Location = new System.Drawing.Point(634, 138);
            this.edittxtstatus.Name = "edittxtstatus";
            this.edittxtstatus.Size = new System.Drawing.Size(183, 32);
            this.edittxtstatus.TabIndex = 196;
            this.edittxtstatus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtstatus_KeyPress);
            this.edittxtstatus.Leave += new System.EventHandler(this.edittxtstatus_Leave);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(542, 142);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 19);
            this.label17.TabIndex = 195;
            this.label17.Text = "Status :";
            // 
            // edittxtstudentfee
            // 
            this.edittxtstudentfee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edittxtstudentfee.Location = new System.Drawing.Point(634, 357);
            this.edittxtstudentfee.Name = "edittxtstudentfee";
            this.edittxtstudentfee.Size = new System.Drawing.Size(183, 29);
            this.edittxtstudentfee.TabIndex = 198;
            this.edittxtstudentfee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtstudentfee_KeyPress);
            this.edittxtstudentfee.Leave += new System.EventHandler(this.txtstudentfee_Leave);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(494, 364);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(125, 19);
            this.label16.TabIndex = 197;
            this.label16.Text = "Monthly Fee :";
            // 
            // edittxtdiscountfee
            // 
            this.edittxtdiscountfee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edittxtdiscountfee.Location = new System.Drawing.Point(734, 397);
            this.edittxtdiscountfee.Name = "edittxtdiscountfee";
            this.edittxtdiscountfee.Size = new System.Drawing.Size(62, 29);
            this.edittxtdiscountfee.TabIndex = 200;
            this.edittxtdiscountfee.TextChanged += new System.EventHandler(this.edittxtdiscountfee_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(633, 402);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(95, 19);
            this.label18.TabIndex = 199;
            this.label18.Text = "Discount :";
            // 
            // editstudentfeediscount
            // 
            this.editstudentfeediscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editstudentfeediscount.Location = new System.Drawing.Point(634, 357);
            this.editstudentfeediscount.Name = "editstudentfeediscount";
            this.editstudentfeediscount.Size = new System.Drawing.Size(183, 29);
            this.editstudentfeediscount.TabIndex = 203;
            // 
            // Edit_AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 754);
            this.Controls.Add(this.editstudentfeediscount);
            this.Controls.Add(this.edittxtdiscountfee);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.edittxtstudentfee);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.edittxtstatus);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.editstupic);
            this.Controls.Add(this.editsid);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.editsbarcod);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.time);
            this.Controls.Add(this.editchang_pic);
            this.Controls.Add(this.editspic);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btndelet);
            this.Controls.Add(this.seditupdate);
            this.Controls.Add(this.editslastscl);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.editsadress);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.editsdob);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.editsfcnic);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.editscontact);
            this.Controls.Add(this.editsclassection);
            this.Controls.Add(this.editsclass);
            this.Controls.Add(this.editscnic);
            this.Controls.Add(this.editsgender);
            this.Controls.Add(this.editsfname);
            this.Controls.Add(this.editsname);
            this.Controls.Add(this.editsrolno);
            this.Name = "Edit_AddStudent";
            this.Text = "Edit_AddStudent";
            this.Load += new System.EventHandler(this.Edit_AddStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editspic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox editslastscl;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox editsadress;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.MaskedTextBox editsdob;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.MaskedTextBox editsfcnic;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.MaskedTextBox editscontact;
        public System.Windows.Forms.ComboBox editsclassection;
        public System.Windows.Forms.ComboBox editsclass;
        public System.Windows.Forms.MaskedTextBox editscnic;
        public System.Windows.Forms.ComboBox editsgender;
        public System.Windows.Forms.TextBox editsfname;
        public System.Windows.Forms.TextBox editsname;
        public System.Windows.Forms.TextBox editsrolno;
        private MetroFramework.Controls.MetroButton seditupdate;
        private MetroFramework.Controls.MetroButton btndelet;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MetroFramework.Controls.MetroButton editchang_pic;
        private System.Windows.Forms.PictureBox editspic;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer sedittimer;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox editsbarcod;
        public System.Windows.Forms.TextBox editsid;
        private MetroFramework.Controls.MetroTile editstupic;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.ComboBox edittxtstatus;
        public System.Windows.Forms.TextBox edittxtstudentfee;
        private System.Windows.Forms.Label label18;
        public System.Windows.Forms.TextBox edittxtdiscountfee;
        public System.Windows.Forms.TextBox editstudentfeediscount;
    }
}