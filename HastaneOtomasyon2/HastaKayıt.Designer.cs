namespace HastaneOtomasyon2
{
    partial class HastaKayıt
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtadsoyad = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.datetarih = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txttelefon = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.combocinsiyet = new Guna.UI2.WinForms.Guna2ComboBox();
            this.combokangrubu = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtadres = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnkaydet = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btndüzen = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnsil = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtara = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 123);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(513, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hasta Kayıt Panel";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HastaneOtomasyon2.Properties.Resources.Closeicon;
            this.pictureBox2.Location = new System.Drawing.Point(1226, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HastaneOtomasyon2.Properties.Resources.Logo_of_Ministry_of_Health__Turkey_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(102, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "Telefon :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtadsoyad
            // 
            this.txtadsoyad.BorderColor = System.Drawing.Color.MediumAquamarine;
            this.txtadsoyad.BorderRadius = 10;
            this.txtadsoyad.BorderThickness = 2;
            this.txtadsoyad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtadsoyad.DefaultText = "";
            this.txtadsoyad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtadsoyad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtadsoyad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtadsoyad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtadsoyad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtadsoyad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtadsoyad.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtadsoyad.Location = new System.Drawing.Point(188, 231);
            this.txtadsoyad.Name = "txtadsoyad";
            this.txtadsoyad.PasswordChar = '\0';
            this.txtadsoyad.PlaceholderText = "";
            this.txtadsoyad.SelectedText = "";
            this.txtadsoyad.Size = new System.Drawing.Size(197, 36);
            this.txtadsoyad.TabIndex = 16;
            this.txtadsoyad.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(84, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "Ad Soyad :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(50, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 22);
            this.label4.TabIndex = 17;
            this.label4.Text = "Doğum Tarihi :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // datetarih
            // 
            this.datetarih.BorderColor = System.Drawing.Color.MediumAquamarine;
            this.datetarih.BorderRadius = 10;
            this.datetarih.BorderThickness = 3;
            this.datetarih.Checked = true;
            this.datetarih.FillColor = System.Drawing.Color.WhiteSmoke;
            this.datetarih.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.datetarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetarih.Location = new System.Drawing.Point(188, 363);
            this.datetarih.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datetarih.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datetarih.Name = "datetarih";
            this.datetarih.Size = new System.Drawing.Size(197, 42);
            this.datetarih.TabIndex = 18;
            this.datetarih.Value = new System.DateTime(2023, 12, 26, 15, 23, 59, 451);
            this.datetarih.ValueChanged += new System.EventHandler(this.guna2DateTimePicker1_ValueChanged);
            // 
            // txttelefon
            // 
            this.txttelefon.BorderColor = System.Drawing.Color.MediumAquamarine;
            this.txttelefon.BorderRadius = 10;
            this.txttelefon.BorderThickness = 2;
            this.txttelefon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttelefon.DefaultText = "";
            this.txttelefon.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txttelefon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txttelefon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttelefon.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttelefon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttelefon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txttelefon.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttelefon.Location = new System.Drawing.Point(188, 273);
            this.txttelefon.Name = "txttelefon";
            this.txttelefon.PasswordChar = '\0';
            this.txttelefon.PlaceholderText = "";
            this.txttelefon.SelectedText = "";
            this.txttelefon.Size = new System.Drawing.Size(197, 36);
            this.txttelefon.TabIndex = 19;
            this.txttelefon.TextChanged += new System.EventHandler(this.guna2TextBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(98, 423);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 22);
            this.label5.TabIndex = 20;
            this.label5.Text = "Cinsiyet :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // combocinsiyet
            // 
            this.combocinsiyet.BackColor = System.Drawing.Color.Transparent;
            this.combocinsiyet.BorderColor = System.Drawing.Color.MediumAquamarine;
            this.combocinsiyet.BorderRadius = 10;
            this.combocinsiyet.BorderThickness = 3;
            this.combocinsiyet.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combocinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combocinsiyet.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combocinsiyet.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combocinsiyet.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combocinsiyet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.combocinsiyet.ItemHeight = 30;
            this.combocinsiyet.Items.AddRange(new object[] {
            "Bay",
            "Bayan"});
            this.combocinsiyet.Location = new System.Drawing.Point(188, 416);
            this.combocinsiyet.Name = "combocinsiyet";
            this.combocinsiyet.Size = new System.Drawing.Size(197, 36);
            this.combocinsiyet.TabIndex = 21;
            this.combocinsiyet.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // combokangrubu
            // 
            this.combokangrubu.BackColor = System.Drawing.Color.Transparent;
            this.combokangrubu.BorderColor = System.Drawing.Color.MediumAquamarine;
            this.combokangrubu.BorderRadius = 10;
            this.combokangrubu.BorderThickness = 3;
            this.combokangrubu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combokangrubu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combokangrubu.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combokangrubu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combokangrubu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combokangrubu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.combokangrubu.ItemHeight = 30;
            this.combokangrubu.Items.AddRange(new object[] {
            "A Rh Pozitif",
            "A Rh Negatif",
            "B Rh Pozitif",
            "B Rh Negatif",
            "AB Rh Pozitif",
            "AB Rh Negatif",
            "0 Rh Pozitif",
            "0 Rh Negatif"});
            this.combokangrubu.Location = new System.Drawing.Point(188, 457);
            this.combokangrubu.Name = "combokangrubu";
            this.combokangrubu.Size = new System.Drawing.Size(197, 36);
            this.combokangrubu.TabIndex = 23;
            this.combokangrubu.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox2_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(77, 466);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 22);
            this.label6.TabIndex = 22;
            this.label6.Text = "Kan Grubu :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtadres
            // 
            this.txtadres.BorderColor = System.Drawing.Color.MediumAquamarine;
            this.txtadres.BorderRadius = 10;
            this.txtadres.BorderThickness = 2;
            this.txtadres.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtadres.DefaultText = "";
            this.txtadres.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtadres.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtadres.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtadres.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtadres.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtadres.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtadres.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtadres.Location = new System.Drawing.Point(188, 315);
            this.txtadres.Name = "txtadres";
            this.txtadres.PasswordChar = '\0';
            this.txtadres.PlaceholderText = "";
            this.txtadres.SelectedText = "";
            this.txtadres.Size = new System.Drawing.Size(197, 36);
            this.txtadres.TabIndex = 25;
            this.txtadres.TextChanged += new System.EventHandler(this.guna2TextBox3_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(115, 322);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 22);
            this.label7.TabIndex = 24;
            this.label7.Text = "Adres :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.BorderRadius = 10;
            this.btnkaydet.BorderThickness = 3;
            this.btnkaydet.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnkaydet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnkaydet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnkaydet.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnkaydet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnkaydet.FillColor = System.Drawing.Color.MintCream;
            this.btnkaydet.FillColor2 = System.Drawing.Color.Snow;
            this.btnkaydet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnkaydet.ForeColor = System.Drawing.Color.Black;
            this.btnkaydet.Location = new System.Drawing.Point(58, 531);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(131, 40);
            this.btnkaydet.TabIndex = 26;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // btndüzen
            // 
            this.btndüzen.BorderRadius = 10;
            this.btndüzen.BorderThickness = 3;
            this.btndüzen.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btndüzen.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btndüzen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btndüzen.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btndüzen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btndüzen.FillColor = System.Drawing.Color.MintCream;
            this.btndüzen.FillColor2 = System.Drawing.Color.Snow;
            this.btndüzen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btndüzen.ForeColor = System.Drawing.Color.Black;
            this.btndüzen.Location = new System.Drawing.Point(195, 531);
            this.btndüzen.Name = "btndüzen";
            this.btndüzen.Size = new System.Drawing.Size(131, 40);
            this.btndüzen.TabIndex = 27;
            this.btndüzen.Text = "Düzenle";
            this.btndüzen.Click += new System.EventHandler(this.btndüzen_Click);
            // 
            // btnsil
            // 
            this.btnsil.BorderRadius = 10;
            this.btnsil.BorderThickness = 3;
            this.btnsil.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnsil.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnsil.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnsil.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnsil.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnsil.FillColor = System.Drawing.Color.MintCream;
            this.btnsil.FillColor2 = System.Drawing.Color.Snow;
            this.btnsil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnsil.ForeColor = System.Drawing.Color.Black;
            this.btnsil.Location = new System.Drawing.Point(332, 531);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(131, 40);
            this.btnsil.TabIndex = 28;
            this.btnsil.Text = "Sil";
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 25;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(541, 213);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowTemplate.Height = 20;
            this.guna2DataGridView1.Size = new System.Drawing.Size(697, 358);
            this.guna2DataGridView1.TabIndex = 29;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 25;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 20;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.MediumAquamarine;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.guna2DataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellClick);
            // 
            // txtara
            // 
            this.txtara.BorderColor = System.Drawing.Color.MediumAquamarine;
            this.txtara.BorderRadius = 10;
            this.txtara.BorderThickness = 2;
            this.txtara.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtara.DefaultText = "";
            this.txtara.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtara.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtara.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtara.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtara.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtara.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtara.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtara.Location = new System.Drawing.Point(966, 162);
            this.txtara.Name = "txtara";
            this.txtara.PasswordChar = '\0';
            this.txtara.PlaceholderText = "Hasta Adı Giriniz";
            this.txtara.SelectedText = "";
            this.txtara.Size = new System.Drawing.Size(272, 36);
            this.txtara.TabIndex = 30;
            this.txtara.TextChanged += new System.EventHandler(this.txtara_TextChanged);
            // 
            // HastaKayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 597);
            this.Controls.Add(this.txtara);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btndüzen);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.txtadres);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.combokangrubu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.combocinsiyet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txttelefon);
            this.Controls.Add(this.datetarih);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtadsoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HastaKayıt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HastaKayıt";
            this.Load += new System.EventHandler(this.HastaKayıt_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtadsoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DateTimePicker datetarih;
        private Guna.UI2.WinForms.Guna2TextBox txttelefon;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox combocinsiyet;
        private Guna.UI2.WinForms.Guna2ComboBox combokangrubu;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtadres;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2GradientButton btnkaydet;
        private Guna.UI2.WinForms.Guna2GradientButton btndüzen;
        private Guna.UI2.WinForms.Guna2GradientButton btnsil;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Guna.UI2.WinForms.Guna2TextBox txtara;
    }
}