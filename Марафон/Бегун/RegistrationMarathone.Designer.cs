namespace Марафон
{
    partial class RegistrationMarathone
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.charityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marathone = new Марафон.Marathone();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.SponsorShipTarget = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.mbRegistration = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mbCancel = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.mRadioVariantA = new MaterialSkin.Controls.MaterialRadioButton();
            this.mRadioVariantB = new MaterialSkin.Controls.MaterialRadioButton();
            this.mRadioVariantC = new MaterialSkin.Controls.MaterialRadioButton();
            this.mCheck5km = new MaterialSkin.Controls.MaterialCheckBox();
            this.mCheck21km = new MaterialSkin.Controls.MaterialCheckBox();
            this.mCheck42km = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.charityTableAdapter = new Марафон.MarathoneTableAdapters.CharityTableAdapter();
            this.registrationTableAdapter = new Марафон.MarathoneTableAdapters.RegistrationTableAdapter();
            this.myDataSet = new Марафон.MyDataSet();
            this.runRegistrationMarathoneTableAdapter = new Марафон.MyDataSetTableAdapters.RunRegistrationMarathoneTableAdapter();
            this.registrationEventTableAdapter = new Марафон.MarathoneTableAdapters.RegistrationEventTableAdapter();
            this.mLinkInformation = new MetroFramework.Controls.MetroLink();
            this.mlTime = new MetroFramework.Controls.MetroLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.timerDay = new System.Windows.Forms.Timer(this.components);
            this.eventTableAdapter = new Марафон.MarathoneTableAdapters.EventTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.charityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marathone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 105);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(529, 38);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Пожалуйста заполните все поля, после с вами свяжутся для подтверждения данных.\r\nС" +
    " уважением администрация Марафон Skills 2016";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(62, 170);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(112, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Вид марафона";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(44, 313);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(157, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Детали спонсорства";
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.DataSource = this.charityBindingSource;
            this.metroComboBox1.DisplayMember = "CharityName";
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(79, 344);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(176, 29);
            this.metroComboBox1.TabIndex = 3;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.ValueMember = "CharityId";
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
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(21, 349);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(52, 19);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "Взнос";
            // 
            // SponsorShipTarget
            // 
            this.SponsorShipTarget.Depth = 0;
            this.SponsorShipTarget.Hint = "";
            this.SponsorShipTarget.Location = new System.Drawing.Point(87, 387);
            this.SponsorShipTarget.MouseState = MaterialSkin.MouseState.HOVER;
            this.SponsorShipTarget.Name = "SponsorShipTarget";
            this.SponsorShipTarget.PasswordChar = '\0';
            this.SponsorShipTarget.SelectedText = "";
            this.SponsorShipTarget.SelectionLength = 0;
            this.SponsorShipTarget.SelectionStart = 0;
            this.SponsorShipTarget.Size = new System.Drawing.Size(123, 23);
            this.SponsorShipTarget.TabIndex = 5;
            this.SponsorShipTarget.UseSystemPasswordChar = false;
            this.SponsorShipTarget.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SponsorShipTarget_KeyPress);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(21, 389);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(60, 19);
            this.materialLabel4.TabIndex = 6;
            this.materialLabel4.Text = "Сумма:";
            // 
            // mbRegistration
            // 
            this.mbRegistration.Depth = 0;
            this.mbRegistration.Location = new System.Drawing.Point(135, 431);
            this.mbRegistration.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbRegistration.Name = "mbRegistration";
            this.mbRegistration.Primary = true;
            this.mbRegistration.Size = new System.Drawing.Size(120, 36);
            this.mbRegistration.TabIndex = 7;
            this.mbRegistration.Text = "Регистрация";
            this.mbRegistration.UseVisualStyleBackColor = true;
            this.mbRegistration.Click += new System.EventHandler(this.mbRegistration_Click);
            // 
            // mbCancel
            // 
            this.mbCancel.AutoSize = true;
            this.mbCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbCancel.Depth = 0;
            this.mbCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.mbCancel.Location = new System.Drawing.Point(25, 431);
            this.mbCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbCancel.Name = "mbCancel";
            this.mbCancel.Primary = false;
            this.mbCancel.Size = new System.Drawing.Size(68, 36);
            this.mbCancel.TabIndex = 8;
            this.mbCancel.Text = "Отмена";
            this.mbCancel.UseVisualStyleBackColor = true;
            this.mbCancel.Click += new System.EventHandler(this.mbCancel_Click);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(219, 393);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(36, 19);
            this.materialLabel5.TabIndex = 9;
            this.materialLabel5.Text = "руб.";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(335, 170);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(170, 19);
            this.materialLabel6.TabIndex = 1;
            this.materialLabel6.Text = "Варианты комплектов";
            // 
            // mRadioVariantA
            // 
            this.mRadioVariantA.AutoSize = true;
            this.mRadioVariantA.Checked = true;
            this.mRadioVariantA.Depth = 0;
            this.mRadioVariantA.Font = new System.Drawing.Font("Roboto", 10F);
            this.mRadioVariantA.Location = new System.Drawing.Point(304, 199);
            this.mRadioVariantA.Margin = new System.Windows.Forms.Padding(0);
            this.mRadioVariantA.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mRadioVariantA.MouseState = MaterialSkin.MouseState.HOVER;
            this.mRadioVariantA.Name = "mRadioVariantA";
            this.mRadioVariantA.Ripple = true;
            this.mRadioVariantA.Size = new System.Drawing.Size(239, 30);
            this.mRadioVariantA.TabIndex = 2;
            this.mRadioVariantA.TabStop = true;
            this.mRadioVariantA.Text = "Вариант А: браслет + номер (0$)";
            this.mRadioVariantA.UseVisualStyleBackColor = true;
            this.mRadioVariantA.CheckedChanged += new System.EventHandler(this.mRadioVariantA_CheckedChanged);
            // 
            // mRadioVariantB
            // 
            this.mRadioVariantB.AutoSize = true;
            this.mRadioVariantB.Depth = 0;
            this.mRadioVariantB.Font = new System.Drawing.Font("Roboto", 10F);
            this.mRadioVariantB.Location = new System.Drawing.Point(304, 229);
            this.mRadioVariantB.Margin = new System.Windows.Forms.Padding(0);
            this.mRadioVariantB.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mRadioVariantB.MouseState = MaterialSkin.MouseState.HOVER;
            this.mRadioVariantB.Name = "mRadioVariantB";
            this.mRadioVariantB.Ripple = true;
            this.mRadioVariantB.Size = new System.Drawing.Size(315, 30);
            this.mRadioVariantB.TabIndex = 2;
            this.mRadioVariantB.Text = "Вариант Б: бейсболка + бутылка воды (20$)";
            this.mRadioVariantB.UseVisualStyleBackColor = true;
            this.mRadioVariantB.CheckedChanged += new System.EventHandler(this.mRadioVariantB_CheckedChanged);
            // 
            // mRadioVariantC
            // 
            this.mRadioVariantC.AutoSize = true;
            this.mRadioVariantC.Depth = 0;
            this.mRadioVariantC.Font = new System.Drawing.Font("Roboto", 10F);
            this.mRadioVariantC.Location = new System.Drawing.Point(304, 259);
            this.mRadioVariantC.Margin = new System.Windows.Forms.Padding(0);
            this.mRadioVariantC.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mRadioVariantC.MouseState = MaterialSkin.MouseState.HOVER;
            this.mRadioVariantC.Name = "mRadioVariantC";
            this.mRadioVariantC.Ripple = true;
            this.mRadioVariantC.Size = new System.Drawing.Size(259, 30);
            this.mRadioVariantC.TabIndex = 2;
            this.mRadioVariantC.Text = "Вариант С: футболка + буклет (32$)";
            this.mRadioVariantC.UseVisualStyleBackColor = true;
            this.mRadioVariantC.CheckedChanged += new System.EventHandler(this.mRadioVariantC_CheckedChanged);
            // 
            // mCheck5km
            // 
            this.mCheck5km.AutoSize = true;
            this.mCheck5km.Depth = 0;
            this.mCheck5km.Font = new System.Drawing.Font("Roboto", 10F);
            this.mCheck5km.Location = new System.Drawing.Point(25, 200);
            this.mCheck5km.Margin = new System.Windows.Forms.Padding(0);
            this.mCheck5km.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mCheck5km.MouseState = MaterialSkin.MouseState.HOVER;
            this.mCheck5km.Name = "mCheck5km";
            this.mCheck5km.Ripple = true;
            this.mCheck5km.Size = new System.Drawing.Size(220, 30);
            this.mCheck5km.TabIndex = 10;
            this.mCheck5km.Text = "5 км - малая дистанция (40$)";
            this.mCheck5km.UseVisualStyleBackColor = true;
            this.mCheck5km.CheckedChanged += new System.EventHandler(this.mCheck5km_CheckedChanged);
            // 
            // mCheck21km
            // 
            this.mCheck21km.AutoSize = true;
            this.mCheck21km.Depth = 0;
            this.mCheck21km.Font = new System.Drawing.Font("Roboto", 10F);
            this.mCheck21km.Location = new System.Drawing.Point(25, 230);
            this.mCheck21km.Margin = new System.Windows.Forms.Padding(0);
            this.mCheck21km.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mCheck21km.MouseState = MaterialSkin.MouseState.HOVER;
            this.mCheck21km.Name = "mCheck21km";
            this.mCheck21km.Ripple = true;
            this.mCheck21km.Size = new System.Drawing.Size(204, 30);
            this.mCheck21km.TabIndex = 10;
            this.mCheck21km.Text = "21 км - полумарафон (75$)";
            this.mCheck21km.UseVisualStyleBackColor = true;
            this.mCheck21km.CheckedChanged += new System.EventHandler(this.mCheck21km_CheckedChanged);
            // 
            // mCheck42km
            // 
            this.mCheck42km.AutoSize = true;
            this.mCheck42km.Depth = 0;
            this.mCheck42km.Font = new System.Drawing.Font("Roboto", 10F);
            this.mCheck42km.Location = new System.Drawing.Point(25, 260);
            this.mCheck42km.Margin = new System.Windows.Forms.Padding(0);
            this.mCheck42km.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mCheck42km.MouseState = MaterialSkin.MouseState.HOVER;
            this.mCheck42km.Name = "mCheck42km";
            this.mCheck42km.Ripple = true;
            this.mCheck42km.Size = new System.Drawing.Size(235, 30);
            this.mCheck42km.TabIndex = 10;
            this.mCheck42km.Text = "42 км - полный марафон (145$)";
            this.mCheck42km.UseVisualStyleBackColor = true;
            this.mCheck42km.CheckedChanged += new System.EventHandler(this.mCheck42km_CheckedChanged);
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(358, 329);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(185, 19);
            this.materialLabel7.TabIndex = 11;
            this.materialLabel7.Text = "Регистрационный взнос";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(422, 363);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(20, 25);
            this.metroLabel2.TabIndex = 12;
            this.metroLabel2.Text = "?";
            // 
            // charityTableAdapter
            // 
            this.charityTableAdapter.ClearBeforeFill = true;
            // 
            // registrationTableAdapter
            // 
            this.registrationTableAdapter.ClearBeforeFill = true;
            // 
            // myDataSet
            // 
            this.myDataSet.DataSetName = "MyDataSet";
            this.myDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // runRegistrationMarathoneTableAdapter
            // 
            this.runRegistrationMarathoneTableAdapter.ClearBeforeFill = true;
            // 
            // registrationEventTableAdapter
            // 
            this.registrationEventTableAdapter.ClearBeforeFill = true;
            // 
            // mLinkInformation
            // 
            this.mLinkInformation.BackgroundImage = global::Марафон.Properties.Resources.info;
            this.mLinkInformation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mLinkInformation.Location = new System.Drawing.Point(207, 311);
            this.mLinkInformation.Name = "mLinkInformation";
            this.mLinkInformation.Size = new System.Drawing.Size(36, 24);
            this.mLinkInformation.TabIndex = 13;
            this.mLinkInformation.UseSelectable = true;
            this.mLinkInformation.Click += new System.EventHandler(this.mLinkInformation_Click);
            // 
            // mlTime
            // 
            this.mlTime.AutoSize = true;
            this.mlTime.Location = new System.Drawing.Point(190, 11);
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
            this.panel2.Location = new System.Drawing.Point(20, 473);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(609, 39);
            this.panel2.TabIndex = 24;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(223, 70);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(210, 25);
            this.metroLabel3.TabIndex = 25;
            this.metroLabel3.Text = "Регистрация на марафон";
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
            // RegistrationMarathone
            // 
            this.AcceptButton = this.mbRegistration;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.mbCancel;
            this.ClientSize = new System.Drawing.Size(649, 532);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.mLinkInformation);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.mCheck42km);
            this.Controls.Add(this.mCheck21km);
            this.Controls.Add(this.mCheck5km);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.mbCancel);
            this.Controls.Add(this.mbRegistration);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.SponsorShipTarget);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.mRadioVariantC);
            this.Controls.Add(this.mRadioVariantB);
            this.Controls.Add(this.mRadioVariantA);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.metroLabel1);
            this.Name = "RegistrationMarathone";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Марафон Skills 2017";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.RegistrationMarathone_Load);
            ((System.ComponentModel.ISupportInitialize)(this.charityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marathone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField SponsorShipTarget;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialRaisedButton mbRegistration;
        private MaterialSkin.Controls.MaterialFlatButton mbCancel;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialRadioButton mRadioVariantA;
        private MaterialSkin.Controls.MaterialRadioButton mRadioVariantB;
        private MaterialSkin.Controls.MaterialRadioButton mRadioVariantC;
        private MaterialSkin.Controls.MaterialCheckBox mCheck5km;
        private MaterialSkin.Controls.MaterialCheckBox mCheck21km;
        private MaterialSkin.Controls.MaterialCheckBox mCheck42km;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private Marathone marathone;
        private System.Windows.Forms.BindingSource charityBindingSource;
        private MarathoneTableAdapters.CharityTableAdapter charityTableAdapter;
        private MarathoneTableAdapters.RegistrationTableAdapter registrationTableAdapter;
        private MyDataSet myDataSet;
        private MyDataSetTableAdapters.RunRegistrationMarathoneTableAdapter runRegistrationMarathoneTableAdapter;
        private MarathoneTableAdapters.RegistrationEventTableAdapter registrationEventTableAdapter;
        private MetroFramework.Controls.MetroLink mLinkInformation;
        private MetroFramework.Controls.MetroLabel mlTime;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.Timer timerDay;
        private MarathoneTableAdapters.EventTableAdapter eventTableAdapter;
    }
}