namespace Марафон.Координатор
{
    partial class ManagmentRunner
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mlEmail = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.mlName = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.mlfamily = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.mlGender = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.mlData = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.mlSummaBlago = new MetroFramework.Controls.MetroLabel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel19 = new MetroFramework.Controls.MetroLabel();
            this.mlDistant = new MetroFramework.Controls.MetroLabel();
            this.metroLabel21 = new MetroFramework.Controls.MetroLabel();
            this.mcbReg = new MaterialSkin.Controls.MaterialCheckBox();
            this.mcbOplata = new MaterialSkin.Controls.MaterialCheckBox();
            this.mcbPaket = new MaterialSkin.Controls.MaterialCheckBox();
            this.mcbStart = new MaterialSkin.Controls.MaterialCheckBox();
            this.mTileSertificat = new MetroFramework.Controls.MetroTile();
            this.mTileEditProfiler = new MetroFramework.Controls.MetroTile();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.managmentRunnerTableAdapter = new Марафон.MyDataSetTableAdapters.ManagmentRunnerTableAdapter();
            this.myDataSet = new Марафон.MyDataSet();
            this.mlBlago = new MetroFramework.Controls.MetroComboBox();
            this.charityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marathone = new Марафон.Marathone();
            this.charityTableAdapter = new Марафон.MarathoneTableAdapters.CharityTableAdapter();
            this.mlStrana = new MetroFramework.Controls.MetroComboBox();
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countryTableAdapter = new Марафон.MarathoneTableAdapters.CountryTableAdapter();
            this.mlPacket = new MetroFramework.Controls.MetroComboBox();
            this.raceKitOptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.raceKitOptionTableAdapter = new Марафон.MarathoneTableAdapters.RaceKitOptionTableAdapter();
            this.registrationTableAdapter = new Марафон.MarathoneTableAdapters.RegistrationTableAdapter();
            this.registrationEventTableAdapter = new Марафон.MarathoneTableAdapters.RegistrationEventTableAdapter();
            this.mlTime = new MetroFramework.Controls.MetroLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.timerDay = new System.Windows.Forms.Timer(this.components);
            this.eventTableAdapter = new Марафон.MarathoneTableAdapters.EventTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.charityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marathone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raceKitOptionBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 125);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(48, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Почта:";
            // 
            // mlEmail
            // 
            this.mlEmail.AutoSize = true;
            this.mlEmail.Location = new System.Drawing.Point(166, 125);
            this.mlEmail.Name = "mlEmail";
            this.mlEmail.Size = new System.Drawing.Size(83, 19);
            this.mlEmail.TabIndex = 1;
            this.mlEmail.Text = "metroLabel2";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 155);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(38, 19);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Имя:";
            // 
            // mlName
            // 
            this.mlName.AutoSize = true;
            this.mlName.Location = new System.Drawing.Point(166, 155);
            this.mlName.Name = "mlName";
            this.mlName.Size = new System.Drawing.Size(83, 19);
            this.mlName.TabIndex = 1;
            this.mlName.Text = "metroLabel2";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(23, 186);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(68, 19);
            this.metroLabel5.TabIndex = 0;
            this.metroLabel5.Text = "Фамилия:";
            // 
            // mlfamily
            // 
            this.mlfamily.AutoSize = true;
            this.mlfamily.Location = new System.Drawing.Point(166, 186);
            this.mlfamily.Name = "mlfamily";
            this.mlfamily.Size = new System.Drawing.Size(83, 19);
            this.mlfamily.TabIndex = 1;
            this.mlfamily.Text = "metroLabel2";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(23, 216);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(36, 19);
            this.metroLabel7.TabIndex = 0;
            this.metroLabel7.Text = "Пол:";
            // 
            // mlGender
            // 
            this.mlGender.AutoSize = true;
            this.mlGender.Location = new System.Drawing.Point(166, 216);
            this.mlGender.Name = "mlGender";
            this.mlGender.Size = new System.Drawing.Size(83, 19);
            this.mlGender.TabIndex = 1;
            this.mlGender.Text = "metroLabel2";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(23, 244);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(106, 19);
            this.metroLabel9.TabIndex = 0;
            this.metroLabel9.Text = "Дата рождения:";
            // 
            // mlData
            // 
            this.mlData.AutoSize = true;
            this.mlData.Location = new System.Drawing.Point(166, 244);
            this.mlData.Name = "mlData";
            this.mlData.Size = new System.Drawing.Size(83, 19);
            this.mlData.TabIndex = 1;
            this.mlData.Text = "metroLabel2";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(23, 274);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(53, 19);
            this.metroLabel11.TabIndex = 0;
            this.metroLabel11.Text = "Страна";
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(23, 332);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(103, 19);
            this.metroLabel13.TabIndex = 0;
            this.metroLabel13.Text = "Пожертвовано:";
            // 
            // mlSummaBlago
            // 
            this.mlSummaBlago.AutoSize = true;
            this.mlSummaBlago.Location = new System.Drawing.Point(166, 332);
            this.mlSummaBlago.Name = "mlSummaBlago";
            this.mlSummaBlago.Size = new System.Drawing.Size(83, 19);
            this.mlSummaBlago.TabIndex = 1;
            this.mlSummaBlago.Text = "metroLabel2";
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Location = new System.Drawing.Point(23, 304);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(141, 19);
            this.metroLabel15.TabIndex = 0;
            this.metroLabel15.Text = "Благотворительность:";
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Location = new System.Drawing.Point(23, 362);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(122, 19);
            this.metroLabel16.TabIndex = 0;
            this.metroLabel16.Text = "Выбранный пакет:";
            // 
            // metroLabel19
            // 
            this.metroLabel19.AutoSize = true;
            this.metroLabel19.Location = new System.Drawing.Point(23, 391);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(78, 19);
            this.metroLabel19.TabIndex = 0;
            this.metroLabel19.Text = "Дистанция:";
            // 
            // mlDistant
            // 
            this.mlDistant.AutoSize = true;
            this.mlDistant.Location = new System.Drawing.Point(166, 391);
            this.mlDistant.Name = "mlDistant";
            this.mlDistant.Size = new System.Drawing.Size(83, 19);
            this.mlDistant.TabIndex = 1;
            this.mlDistant.Text = "metroLabel2";
            // 
            // metroLabel21
            // 
            this.metroLabel21.AutoSize = true;
            this.metroLabel21.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel21.Location = new System.Drawing.Point(540, 108);
            this.metroLabel21.Name = "metroLabel21";
            this.metroLabel21.Size = new System.Drawing.Size(206, 25);
            this.metroLabel21.TabIndex = 3;
            this.metroLabel21.Text = "Регистрационный статус";
            // 
            // mcbReg
            // 
            this.mcbReg.AutoSize = true;
            this.mcbReg.Depth = 0;
            this.mcbReg.Font = new System.Drawing.Font("Roboto", 10F);
            this.mcbReg.Location = new System.Drawing.Point(567, 155);
            this.mcbReg.Margin = new System.Windows.Forms.Padding(0);
            this.mcbReg.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mcbReg.MouseState = MaterialSkin.MouseState.HOVER;
            this.mcbReg.Name = "mcbReg";
            this.mcbReg.Ripple = true;
            this.mcbReg.Size = new System.Drawing.Size(143, 30);
            this.mcbReg.TabIndex = 4;
            this.mcbReg.Text = "Зарегистрирован";
            this.mcbReg.UseVisualStyleBackColor = true;
            this.mcbReg.CheckedChanged += new System.EventHandler(this.mcbReg_CheckedChanged);
            // 
            // mcbOplata
            // 
            this.mcbOplata.AutoSize = true;
            this.mcbOplata.Depth = 0;
            this.mcbOplata.Font = new System.Drawing.Font("Roboto", 10F);
            this.mcbOplata.Location = new System.Drawing.Point(567, 195);
            this.mcbOplata.Margin = new System.Windows.Forms.Padding(0);
            this.mcbOplata.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mcbOplata.MouseState = MaterialSkin.MouseState.HOVER;
            this.mcbOplata.Name = "mcbOplata";
            this.mcbOplata.Ripple = true;
            this.mcbOplata.Size = new System.Drawing.Size(177, 30);
            this.mcbOplata.TabIndex = 4;
            this.mcbOplata.Text = "Подтверждена оплата";
            this.mcbOplata.UseVisualStyleBackColor = true;
            this.mcbOplata.CheckedChanged += new System.EventHandler(this.mcbOplata_CheckedChanged);
            // 
            // mcbPaket
            // 
            this.mcbPaket.AutoSize = true;
            this.mcbPaket.Depth = 0;
            this.mcbPaket.Font = new System.Drawing.Font("Roboto", 10F);
            this.mcbPaket.Location = new System.Drawing.Point(567, 233);
            this.mcbPaket.Margin = new System.Windows.Forms.Padding(0);
            this.mcbPaket.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mcbPaket.MouseState = MaterialSkin.MouseState.HOVER;
            this.mcbPaket.Name = "mcbPaket";
            this.mcbPaket.Ripple = true;
            this.mcbPaket.Size = new System.Drawing.Size(114, 30);
            this.mcbPaket.TabIndex = 4;
            this.mcbPaket.Text = "Выдан пакет";
            this.mcbPaket.UseVisualStyleBackColor = true;
            this.mcbPaket.CheckedChanged += new System.EventHandler(this.mcbPaket_CheckedChanged);
            // 
            // mcbStart
            // 
            this.mcbStart.AutoSize = true;
            this.mcbStart.Depth = 0;
            this.mcbStart.Font = new System.Drawing.Font("Roboto", 10F);
            this.mcbStart.Location = new System.Drawing.Point(567, 273);
            this.mcbStart.Margin = new System.Windows.Forms.Padding(0);
            this.mcbStart.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mcbStart.MouseState = MaterialSkin.MouseState.HOVER;
            this.mcbStart.Name = "mcbStart";
            this.mcbStart.Ripple = true;
            this.mcbStart.Size = new System.Drawing.Size(134, 30);
            this.mcbStart.TabIndex = 4;
            this.mcbStart.Text = "Вышел на старт";
            this.mcbStart.UseVisualStyleBackColor = true;
            this.mcbStart.CheckedChanged += new System.EventHandler(this.mcbStart_CheckedChanged);
            // 
            // mTileSertificat
            // 
            this.mTileSertificat.ActiveControl = null;
            this.mTileSertificat.Location = new System.Drawing.Point(23, 428);
            this.mTileSertificat.Name = "mTileSertificat";
            this.mTileSertificat.Size = new System.Drawing.Size(159, 50);
            this.mTileSertificat.TabIndex = 5;
            this.mTileSertificat.Text = "Показ сертификата";
            this.mTileSertificat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTileSertificat.UseSelectable = true;
            this.mTileSertificat.Click += new System.EventHandler(this.mTileSertificat_Click);
            // 
            // mTileEditProfiler
            // 
            this.mTileEditProfiler.ActiveControl = null;
            this.mTileEditProfiler.Location = new System.Drawing.Point(567, 428);
            this.mTileEditProfiler.Name = "mTileEditProfiler";
            this.mTileEditProfiler.Size = new System.Drawing.Size(176, 50);
            this.mTileEditProfiler.TabIndex = 5;
            this.mTileEditProfiler.Text = "Редактировать профиль";
            this.mTileEditProfiler.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTileEditProfiler.UseSelectable = true;
            this.mTileEditProfiler.Click += new System.EventHandler(this.mTileEditProfiler_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(329, 144);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 196);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // managmentRunnerTableAdapter
            // 
            this.managmentRunnerTableAdapter.ClearBeforeFill = true;
            // 
            // myDataSet
            // 
            this.myDataSet.DataSetName = "MyDataSet";
            this.myDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mlBlago
            // 
            this.mlBlago.DataSource = this.charityBindingSource;
            this.mlBlago.DisplayMember = "CharityName";
            this.mlBlago.FormattingEnabled = true;
            this.mlBlago.ItemHeight = 23;
            this.mlBlago.Location = new System.Drawing.Point(170, 300);
            this.mlBlago.Name = "mlBlago";
            this.mlBlago.Size = new System.Drawing.Size(153, 29);
            this.mlBlago.TabIndex = 6;
            this.mlBlago.UseSelectable = true;
            this.mlBlago.ValueMember = "CharityId";
            // 
            // charityBindingSource
            // 
            this.charityBindingSource.DataMember = "Charity";
            this.charityBindingSource.DataSource = this.marathone;
            // 
            // marathone
            // 
            this.marathone.DataSetName = "Marathone";
            this.marathone.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // charityTableAdapter
            // 
            this.charityTableAdapter.ClearBeforeFill = true;
            // 
            // mlStrana
            // 
            this.mlStrana.DataSource = this.countryBindingSource;
            this.mlStrana.DisplayMember = "CountryName";
            this.mlStrana.FormattingEnabled = true;
            this.mlStrana.ItemHeight = 23;
            this.mlStrana.Location = new System.Drawing.Point(170, 266);
            this.mlStrana.Name = "mlStrana";
            this.mlStrana.Size = new System.Drawing.Size(153, 29);
            this.mlStrana.TabIndex = 6;
            this.mlStrana.UseSelectable = true;
            this.mlStrana.ValueMember = "CountryCode";
            // 
            // countryBindingSource
            // 
            this.countryBindingSource.DataMember = "Country";
            this.countryBindingSource.DataSource = this.marathone;
            // 
            // countryTableAdapter
            // 
            this.countryTableAdapter.ClearBeforeFill = true;
            // 
            // mlPacket
            // 
            this.mlPacket.DataSource = this.raceKitOptionBindingSource;
            this.mlPacket.DisplayMember = "RaceKitOption";
            this.mlPacket.FormattingEnabled = true;
            this.mlPacket.ItemHeight = 23;
            this.mlPacket.Location = new System.Drawing.Point(170, 354);
            this.mlPacket.Name = "mlPacket";
            this.mlPacket.Size = new System.Drawing.Size(153, 29);
            this.mlPacket.TabIndex = 6;
            this.mlPacket.UseSelectable = true;
            this.mlPacket.ValueMember = "RaceKitOptionId";
            // 
            // raceKitOptionBindingSource
            // 
            this.raceKitOptionBindingSource.DataMember = "RaceKitOption";
            this.raceKitOptionBindingSource.DataSource = this.marathone;
            // 
            // raceKitOptionTableAdapter
            // 
            this.raceKitOptionTableAdapter.ClearBeforeFill = true;
            // 
            // registrationTableAdapter
            // 
            this.registrationTableAdapter.ClearBeforeFill = true;
            // 
            // registrationEventTableAdapter
            // 
            this.registrationEventTableAdapter.ClearBeforeFill = true;
            // 
            // mlTime
            // 
            this.mlTime.AutoSize = true;
            this.mlTime.Location = new System.Drawing.Point(266, 10);
            this.mlTime.Name = "mlTime";
            this.mlTime.Size = new System.Drawing.Size(191, 19);
            this.mlTime.TabIndex = 3;
            this.mlTime.Text = "Осталось 2 дня 3 часа 23 мин";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.mlTime);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(20, 484);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(726, 39);
            this.panel2.TabIndex = 22;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(286, 73);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(185, 25);
            this.metroLabel2.TabIndex = 23;
            this.metroLabel2.Text = "Управление бегунами";
            // 
            // timerDay
            // 
            this.timerDay.Interval = 1000;
            this.timerDay.Tick += new System.EventHandler(this.timerDay_Tick);
            // 
            // eventTableAdapter
            // 
            this.eventTableAdapter.ClearBeforeFill = true;
            // 
            // ManagmentRunner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 543);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.mlStrana);
            this.Controls.Add(this.mlPacket);
            this.Controls.Add(this.mlBlago);
            this.Controls.Add(this.mTileEditProfiler);
            this.Controls.Add(this.mTileSertificat);
            this.Controls.Add(this.mcbStart);
            this.Controls.Add(this.mcbOplata);
            this.Controls.Add(this.mcbPaket);
            this.Controls.Add(this.mcbReg);
            this.Controls.Add(this.metroLabel21);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mlDistant);
            this.Controls.Add(this.metroLabel19);
            this.Controls.Add(this.mlGender);
            this.Controls.Add(this.metroLabel16);
            this.Controls.Add(this.mlName);
            this.Controls.Add(this.metroLabel15);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.mlSummaBlago);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.mlData);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.mlfamily);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.mlEmail);
            this.Controls.Add(this.metroLabel1);
            this.Name = "ManagmentRunner";
            this.Text = "Марафон Skills 2017";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.ManagmentRunner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.charityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marathone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raceKitOptionBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel mlEmail;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel mlName;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel mlfamily;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel mlGender;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel mlData;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel mlSummaBlago;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroLabel metroLabel19;
        private MetroFramework.Controls.MetroLabel mlDistant;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel21;
        private MaterialSkin.Controls.MaterialCheckBox mcbReg;
        private MaterialSkin.Controls.MaterialCheckBox mcbOplata;
        private MaterialSkin.Controls.MaterialCheckBox mcbPaket;
        private MaterialSkin.Controls.MaterialCheckBox mcbStart;
        private MetroFramework.Controls.MetroTile mTileSertificat;
        private MetroFramework.Controls.MetroTile mTileEditProfiler;
        private MyDataSetTableAdapters.ManagmentRunnerTableAdapter managmentRunnerTableAdapter;
        private MyDataSet myDataSet;
        private MetroFramework.Controls.MetroComboBox mlBlago;
        private Marathone marathone;
        private System.Windows.Forms.BindingSource charityBindingSource;
        private MarathoneTableAdapters.CharityTableAdapter charityTableAdapter;
        private MetroFramework.Controls.MetroComboBox mlStrana;
        private System.Windows.Forms.BindingSource countryBindingSource;
        private MarathoneTableAdapters.CountryTableAdapter countryTableAdapter;
        private MetroFramework.Controls.MetroComboBox mlPacket;
        private System.Windows.Forms.BindingSource raceKitOptionBindingSource;
        private MarathoneTableAdapters.RaceKitOptionTableAdapter raceKitOptionTableAdapter;
        private MarathoneTableAdapters.RegistrationTableAdapter registrationTableAdapter;
        private MarathoneTableAdapters.RegistrationEventTableAdapter registrationEventTableAdapter;
        private MetroFramework.Controls.MetroLabel mlTime;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.Timer timerDay;
        private MarathoneTableAdapters.EventTableAdapter eventTableAdapter;
    }
}