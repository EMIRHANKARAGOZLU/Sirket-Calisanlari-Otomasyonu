namespace Personel_Kayit
{
    partial class FrmAnaForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Rb_carpi = new System.Windows.Forms.RadioButton();
            this.Rb_tik = new System.Windows.Forms.RadioButton();
            this.Mtb_maas = new System.Windows.Forms.MaskedTextBox();
            this.Txt_departman = new System.Windows.Forms.TextBox();
            this.Cmb_sehir = new System.Windows.Forms.ComboBox();
            this.Txt_soyad = new System.Windows.Forms.TextBox();
            this.Txt_ad = new System.Windows.Forms.TextBox();
            this.Txt_id = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.peridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peradDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.persoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.persehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perdepartmanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permaasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perprimDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tblpersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sirketCalisanlariVeriTabaniDataSet1 = new Personel_Kayit.SirketCalisanlariVeriTabaniDataSet1();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Btn_raporlar = new System.Windows.Forms.Button();
            this.Btn_grafikler = new System.Windows.Forms.Button();
            this.Btn_istatistik = new System.Windows.Forms.Button();
            this.Btn_temizle = new System.Windows.Forms.Button();
            this.Btn_güncelle = new System.Windows.Forms.Button();
            this.Btn_sil = new System.Windows.Forms.Button();
            this.Btn_kaydet = new System.Windows.Forms.Button();
            this.Btn_listele = new System.Windows.Forms.Button();
            this.tbl_personelTableAdapter = new Personel_Kayit.SirketCalisanlariVeriTabaniDataSet1TableAdapters.Tbl_personelTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpersonelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sirketCalisanlariVeriTabaniDataSet1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Rb_carpi);
            this.groupBox1.Controls.Add(this.Rb_tik);
            this.groupBox1.Controls.Add(this.Mtb_maas);
            this.groupBox1.Controls.Add(this.Txt_departman);
            this.groupBox1.Controls.Add(this.Cmb_sehir);
            this.groupBox1.Controls.Add(this.Txt_soyad);
            this.groupBox1.Controls.Add(this.Txt_ad);
            this.groupBox1.Controls.Add(this.Txt_id);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(25, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(820, 411);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Kayıt";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(503, 306);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 32);
            this.label8.TabIndex = 9;
            this.label8.Text = "label";
            this.label8.TextChanged += new System.EventHandler(this.label8_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(6, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 33);
            this.label7.TabIndex = 14;
            this.label7.Text = "Prim";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(6, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 33);
            this.label6.TabIndex = 13;
            this.label6.Text = "Maaş";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(6, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 33);
            this.label5.TabIndex = 12;
            this.label5.Text = "Departman:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 33);
            this.label4.TabIndex = 11;
            this.label4.Text = "Şehir";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 33);
            this.label3.TabIndex = 10;
            this.label3.Text = "Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 33);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 33);
            this.label1.TabIndex = 8;
            this.label1.Text = "Id:";
            // 
            // Rb_carpi
            // 
            this.Rb_carpi.AutoSize = true;
            this.Rb_carpi.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Rb_carpi.Location = new System.Drawing.Point(405, 306);
            this.Rb_carpi.Name = "Rb_carpi";
            this.Rb_carpi.Size = new System.Drawing.Size(55, 36);
            this.Rb_carpi.TabIndex = 7;
            this.Rb_carpi.TabStop = true;
            this.Rb_carpi.Text = "×";
            this.Rb_carpi.UseVisualStyleBackColor = true;
            this.Rb_carpi.CheckedChanged += new System.EventHandler(this.Rb_carpi_CheckedChanged);
            // 
            // Rb_tik
            // 
            this.Rb_tik.AutoSize = true;
            this.Rb_tik.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Rb_tik.Location = new System.Drawing.Point(240, 306);
            this.Rb_tik.Name = "Rb_tik";
            this.Rb_tik.Size = new System.Drawing.Size(56, 36);
            this.Rb_tik.TabIndex = 6;
            this.Rb_tik.TabStop = true;
            this.Rb_tik.Text = "✓";
            this.Rb_tik.UseVisualStyleBackColor = true;
            this.Rb_tik.CheckedChanged += new System.EventHandler(this.Rb_tik_CheckedChanged);
            // 
            // Mtb_maas
            // 
            this.Mtb_maas.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Mtb_maas.Location = new System.Drawing.Point(240, 260);
            this.Mtb_maas.Mask = "00000";
            this.Mtb_maas.Name = "Mtb_maas";
            this.Mtb_maas.Size = new System.Drawing.Size(220, 40);
            this.Mtb_maas.TabIndex = 5;
            this.Mtb_maas.ValidatingType = typeof(int);
            // 
            // Txt_departman
            // 
            this.Txt_departman.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txt_departman.Location = new System.Drawing.Point(240, 214);
            this.Txt_departman.Name = "Txt_departman";
            this.Txt_departman.Size = new System.Drawing.Size(220, 40);
            this.Txt_departman.TabIndex = 4;
            // 
            // Cmb_sehir
            // 
            this.Cmb_sehir.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Cmb_sehir.FormattingEnabled = true;
            this.Cmb_sehir.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyonkarahisar",
            "Ağrı",
            "Aksaray",
            "Amasya",
            "Ankara",
            "Antalya",
            "Ardahan",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bartın",
            "Batman",
            "Bayburt",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Düzce",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkâri",
            "Hatay",
            "Iğdır",
            "Isparta",
            "İstanbul",
            "İzmir",
            "Kahramanmaraş",
            "Karabük",
            "Karaman",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kilis",
            "Kırıkkale",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Mardin",
            "Mersin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Osmaniye",
            "Rize",
            "Sakarya",
            "Samsun",
            "Şanlıurfa",
            "Siirt",
            "Sinop",
            "Sivas",
            "Şırnak",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Uşak",
            "Van",
            "Yalova",
            "Yozgat",
            "Zonguldak"});
            this.Cmb_sehir.Location = new System.Drawing.Point(240, 168);
            this.Cmb_sehir.Name = "Cmb_sehir";
            this.Cmb_sehir.Size = new System.Drawing.Size(220, 40);
            this.Cmb_sehir.TabIndex = 3;
            // 
            // Txt_soyad
            // 
            this.Txt_soyad.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txt_soyad.Location = new System.Drawing.Point(240, 122);
            this.Txt_soyad.Name = "Txt_soyad";
            this.Txt_soyad.Size = new System.Drawing.Size(220, 40);
            this.Txt_soyad.TabIndex = 2;
            // 
            // Txt_ad
            // 
            this.Txt_ad.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txt_ad.Location = new System.Drawing.Point(240, 76);
            this.Txt_ad.Name = "Txt_ad";
            this.Txt_ad.Size = new System.Drawing.Size(220, 40);
            this.Txt_ad.TabIndex = 1;
            // 
            // Txt_id
            // 
            this.Txt_id.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txt_id.Location = new System.Drawing.Point(240, 30);
            this.Txt_id.Name = "Txt_id";
            this.Txt_id.Size = new System.Drawing.Size(220, 40);
            this.Txt_id.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(25, 441);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1674, 362);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Veriler";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.peridDataGridViewTextBoxColumn,
            this.peradDataGridViewTextBoxColumn,
            this.persoyadDataGridViewTextBoxColumn,
            this.persehirDataGridViewTextBoxColumn,
            this.perdepartmanDataGridViewTextBoxColumn,
            this.permaasDataGridViewTextBoxColumn,
            this.perprimDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.tblpersonelBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1668, 323);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // peridDataGridViewTextBoxColumn
            // 
            this.peridDataGridViewTextBoxColumn.DataPropertyName = "Per_id";
            this.peridDataGridViewTextBoxColumn.HeaderText = "Per_id";
            this.peridDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.peridDataGridViewTextBoxColumn.Name = "peridDataGridViewTextBoxColumn";
            this.peridDataGridViewTextBoxColumn.ReadOnly = true;
            this.peridDataGridViewTextBoxColumn.Width = 150;
            // 
            // peradDataGridViewTextBoxColumn
            // 
            this.peradDataGridViewTextBoxColumn.DataPropertyName = "Per_ad";
            this.peradDataGridViewTextBoxColumn.HeaderText = "Per_ad";
            this.peradDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.peradDataGridViewTextBoxColumn.Name = "peradDataGridViewTextBoxColumn";
            this.peradDataGridViewTextBoxColumn.Width = 150;
            // 
            // persoyadDataGridViewTextBoxColumn
            // 
            this.persoyadDataGridViewTextBoxColumn.DataPropertyName = "Per_soyad";
            this.persoyadDataGridViewTextBoxColumn.HeaderText = "Per_soyad";
            this.persoyadDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.persoyadDataGridViewTextBoxColumn.Name = "persoyadDataGridViewTextBoxColumn";
            this.persoyadDataGridViewTextBoxColumn.Width = 150;
            // 
            // persehirDataGridViewTextBoxColumn
            // 
            this.persehirDataGridViewTextBoxColumn.DataPropertyName = "Per_sehir";
            this.persehirDataGridViewTextBoxColumn.HeaderText = "Per_sehir";
            this.persehirDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.persehirDataGridViewTextBoxColumn.Name = "persehirDataGridViewTextBoxColumn";
            this.persehirDataGridViewTextBoxColumn.Width = 150;
            // 
            // perdepartmanDataGridViewTextBoxColumn
            // 
            this.perdepartmanDataGridViewTextBoxColumn.DataPropertyName = "Per_departman";
            this.perdepartmanDataGridViewTextBoxColumn.HeaderText = "Per_departman";
            this.perdepartmanDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.perdepartmanDataGridViewTextBoxColumn.Name = "perdepartmanDataGridViewTextBoxColumn";
            this.perdepartmanDataGridViewTextBoxColumn.Width = 150;
            // 
            // permaasDataGridViewTextBoxColumn
            // 
            this.permaasDataGridViewTextBoxColumn.DataPropertyName = "Per_maas";
            this.permaasDataGridViewTextBoxColumn.HeaderText = "Per_maas";
            this.permaasDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.permaasDataGridViewTextBoxColumn.Name = "permaasDataGridViewTextBoxColumn";
            this.permaasDataGridViewTextBoxColumn.Width = 150;
            // 
            // perprimDataGridViewCheckBoxColumn
            // 
            this.perprimDataGridViewCheckBoxColumn.DataPropertyName = "Per_prim";
            this.perprimDataGridViewCheckBoxColumn.HeaderText = "Per_prim";
            this.perprimDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.perprimDataGridViewCheckBoxColumn.Name = "perprimDataGridViewCheckBoxColumn";
            this.perprimDataGridViewCheckBoxColumn.Width = 150;
            // 
            // tblpersonelBindingSource
            // 
            this.tblpersonelBindingSource.DataMember = "Tbl_personel";
            this.tblpersonelBindingSource.DataSource = this.sirketCalisanlariVeriTabaniDataSet1;
            // 
            // sirketCalisanlariVeriTabaniDataSet1
            // 
            this.sirketCalisanlariVeriTabaniDataSet1.DataSetName = "SirketCalisanlariVeriTabaniDataSet1";
            this.sirketCalisanlariVeriTabaniDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.Btn_raporlar);
            this.groupBox2.Controls.Add(this.Btn_grafikler);
            this.groupBox2.Controls.Add(this.Btn_istatistik);
            this.groupBox2.Controls.Add(this.Btn_temizle);
            this.groupBox2.Controls.Add(this.Btn_güncelle);
            this.groupBox2.Controls.Add(this.Btn_sil);
            this.groupBox2.Controls.Add(this.Btn_kaydet);
            this.groupBox2.Controls.Add(this.Btn_listele);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(891, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(362, 411);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            // 
            // Btn_raporlar
            // 
            this.Btn_raporlar.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_raporlar.Location = new System.Drawing.Point(6, 365);
            this.Btn_raporlar.Name = "Btn_raporlar";
            this.Btn_raporlar.Size = new System.Drawing.Size(345, 40);
            this.Btn_raporlar.TabIndex = 7;
            this.Btn_raporlar.Text = "Raporlar";
            this.Btn_raporlar.UseVisualStyleBackColor = true;
            this.Btn_raporlar.Click += new System.EventHandler(this.Btn_raporlar_Click);
            // 
            // Btn_grafikler
            // 
            this.Btn_grafikler.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_grafikler.Location = new System.Drawing.Point(6, 319);
            this.Btn_grafikler.Name = "Btn_grafikler";
            this.Btn_grafikler.Size = new System.Drawing.Size(345, 40);
            this.Btn_grafikler.TabIndex = 6;
            this.Btn_grafikler.Text = "Grafikler";
            this.Btn_grafikler.UseVisualStyleBackColor = true;
            this.Btn_grafikler.Click += new System.EventHandler(this.Btn_grafikler_Click);
            // 
            // Btn_istatistik
            // 
            this.Btn_istatistik.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_istatistik.Location = new System.Drawing.Point(6, 273);
            this.Btn_istatistik.Name = "Btn_istatistik";
            this.Btn_istatistik.Size = new System.Drawing.Size(345, 40);
            this.Btn_istatistik.TabIndex = 5;
            this.Btn_istatistik.Text = "İstatistik";
            this.Btn_istatistik.UseVisualStyleBackColor = true;
            this.Btn_istatistik.Click += new System.EventHandler(this.Btn_istatistik_Click);
            // 
            // Btn_temizle
            // 
            this.Btn_temizle.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_temizle.Location = new System.Drawing.Point(6, 227);
            this.Btn_temizle.Name = "Btn_temizle";
            this.Btn_temizle.Size = new System.Drawing.Size(345, 40);
            this.Btn_temizle.TabIndex = 4;
            this.Btn_temizle.Text = "Temizle";
            this.Btn_temizle.UseVisualStyleBackColor = true;
            this.Btn_temizle.Click += new System.EventHandler(this.Btn_temizle_Click);
            // 
            // Btn_güncelle
            // 
            this.Btn_güncelle.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_güncelle.Location = new System.Drawing.Point(6, 181);
            this.Btn_güncelle.Name = "Btn_güncelle";
            this.Btn_güncelle.Size = new System.Drawing.Size(345, 40);
            this.Btn_güncelle.TabIndex = 3;
            this.Btn_güncelle.Text = "Güncelle";
            this.Btn_güncelle.UseVisualStyleBackColor = true;
            this.Btn_güncelle.Click += new System.EventHandler(this.Btn_güncelle_Click);
            // 
            // Btn_sil
            // 
            this.Btn_sil.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_sil.Location = new System.Drawing.Point(6, 135);
            this.Btn_sil.Name = "Btn_sil";
            this.Btn_sil.Size = new System.Drawing.Size(345, 40);
            this.Btn_sil.TabIndex = 2;
            this.Btn_sil.Text = "Sil";
            this.Btn_sil.UseVisualStyleBackColor = true;
            this.Btn_sil.Click += new System.EventHandler(this.Btn_sil_Click);
            // 
            // Btn_kaydet
            // 
            this.Btn_kaydet.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_kaydet.Location = new System.Drawing.Point(6, 89);
            this.Btn_kaydet.Name = "Btn_kaydet";
            this.Btn_kaydet.Size = new System.Drawing.Size(345, 40);
            this.Btn_kaydet.TabIndex = 1;
            this.Btn_kaydet.Text = "Kaydet";
            this.Btn_kaydet.UseVisualStyleBackColor = true;
            this.Btn_kaydet.Click += new System.EventHandler(this.Btn_kaydet_Click);
            // 
            // Btn_listele
            // 
            this.Btn_listele.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_listele.Location = new System.Drawing.Point(6, 43);
            this.Btn_listele.Name = "Btn_listele";
            this.Btn_listele.Size = new System.Drawing.Size(345, 40);
            this.Btn_listele.TabIndex = 0;
            this.Btn_listele.Text = "Listele";
            this.Btn_listele.UseVisualStyleBackColor = true;
            this.Btn_listele.Click += new System.EventHandler(this.Btn_listele_Click);
            // 
            // tbl_personelTableAdapter
            // 
            this.tbl_personelTableAdapter.ClearBeforeFill = true;
            // 
            // FrmAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(1810, 816);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmAnaForm";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpersonelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sirketCalisanlariVeriTabaniDataSet1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Txt_soyad;
        private System.Windows.Forms.TextBox Txt_ad;
        private System.Windows.Forms.TextBox Txt_id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Rb_carpi;
        private System.Windows.Forms.RadioButton Rb_tik;
        private System.Windows.Forms.MaskedTextBox Mtb_maas;
        private System.Windows.Forms.TextBox Txt_departman;
        private System.Windows.Forms.ComboBox Cmb_sehir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Btn_listele;
        private System.Windows.Forms.Button Btn_grafikler;
        private System.Windows.Forms.Button Btn_istatistik;
        private System.Windows.Forms.Button Btn_temizle;
        private System.Windows.Forms.Button Btn_güncelle;
        private System.Windows.Forms.Button Btn_sil;
        private System.Windows.Forms.Button Btn_kaydet;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SirketCalisanlariVeriTabaniDataSet1 sirketCalisanlariVeriTabaniDataSet1;
        private System.Windows.Forms.BindingSource tblpersonelBindingSource;
        private SirketCalisanlariVeriTabaniDataSet1TableAdapters.Tbl_personelTableAdapter tbl_personelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn peridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn peradDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn persoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn persehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perdepartmanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn permaasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn perprimDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button Btn_raporlar;
    }
}

