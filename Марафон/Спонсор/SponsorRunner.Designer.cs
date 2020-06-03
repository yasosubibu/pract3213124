namespace Марафон
{
    partial class SponsorRunner
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.mtName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.mComboRunner = new MetroFramework.Controls.MetroComboBox();
            this.runnerSponsorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myDataSet = new Марафон.MyDataSet();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.mtCardFI = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.mtCardNumber = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.mCardCVC = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.charityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marathone = new Марафон.Marathone();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.mbZaplata = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mbCancel = new MaterialSkin.Controls.MaterialFlatButton();
            this.registrationTableAdapter = new Марафон.MarathoneTableAdapters.RegistrationTableAdapter();
            this.sponsorshipTableAdapter = new Марафон.MarathoneTableAdapters.SponsorshipTableAdapter();
            this.runnerSponsorTableAdapter = new Марафон.MyDataSetTableAdapters.RunnerSponsorTableAdapter();
            this.charityTableAdapter = new Марафон.MarathoneTableAdapters.CharityTableAdapter();
            this.mlTime = new MetroFramework.Controls.MetroLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timerDay = new System.Windows.Forms.Timer(this.components);
            this.eventTableAdapter = new Марафон.MarathoneTableAdapters.EventTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.runnerSponsorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.charityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marathone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(28, 119);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(39, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Имя";
            // 
            // mtName
            // 
            this.mtName.Depth = 0;
            this.mtName.Hint = "";
            this.mtName.Location = new System.Drawing.Point(163, 115);
            this.mtName.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtName.Name = "mtName";
            this.mtName.PasswordChar = '\0';
            this.mtName.SelectedText = "";
            this.mtName.SelectionLength = 0;
            this.mtName.SelectionStart = 0;
            this.mtName.Size = new System.Drawing.Size(174, 23);
            this.mtName.TabIndex = 1;
            this.mtName.UseSystemPasswordChar = false;
            this.mtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtCardFI_KeyPress);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(28, 155);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(128, 19);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "Выберите бегуна";
            // 
            // mComboRunner
            // 
            this.mComboRunner.DataSource = this.runnerSponsorBindingSource;
            this.mComboRunner.DisplayMember = "FirstName";
            this.mComboRunner.FormattingEnabled = true;
            this.mComboRunner.ItemHeight = 23;
            this.mComboRunner.Location = new System.Drawing.Point(163, 151);
            this.mComboRunner.Name = "mComboRunner";
            this.mComboRunner.Size = new System.Drawing.Size(174, 29);
            this.mComboRunner.TabIndex = 2;
            this.mComboRunner.UseSelectable = true;
            this.mComboRunner.ValueMember = "RunnerId";
            // 
            // runnerSponsorBindingSource
            // 
            this.runnerSponsorBindingSource.DataMember = "RunnerSponsor";
            this.runnerSponsorBindingSource.DataSource = this.myDataSet;
            // 
            // myDataSet
            // 
            this.myDataSet.DataSetName = "MyDataSet";
            this.myDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(28, 196);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(240, 19);
            this.materialLabel3.TabIndex = 0;
            this.materialLabel3.Text = "Имя фамилия владельца карты:";
            // 
            // mtCardFI
            // 
            this.mtCardFI.Depth = 0;
            this.mtCardFI.Hint = "";
            this.mtCardFI.Location = new System.Drawing.Point(32, 218);
            this.mtCardFI.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtCardFI.Name = "mtCardFI";
            this.mtCardFI.PasswordChar = '\0';
            this.mtCardFI.SelectedText = "";
            this.mtCardFI.SelectionLength = 0;
            this.mtCardFI.SelectionStart = 0;
            this.mtCardFI.Size = new System.Drawing.Size(305, 23);
            this.mtCardFI.TabIndex = 1;
            this.mtCardFI.UseSystemPasswordChar = false;
            this.mtCardFI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtCardFI_KeyPress);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(28, 253);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(107, 19);
            this.materialLabel4.TabIndex = 0;
            this.materialLabel4.Text = "Номер карты:";
            // 
            // mtCardNumber
            // 
            this.mtCardNumber.Depth = 0;
            this.mtCardNumber.Hint = "";
            this.mtCardNumber.Location = new System.Drawing.Point(32, 275);
            this.mtCardNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtCardNumber.Name = "mtCardNumber";
            this.mtCardNumber.PasswordChar = '\0';
            this.mtCardNumber.SelectedText = "";
            this.mtCardNumber.SelectionLength = 0;
            this.mtCardNumber.SelectionStart = 0;
            this.mtCardNumber.Size = new System.Drawing.Size(305, 23);
            this.mtCardNumber.TabIndex = 1;
            this.mtCardNumber.UseSystemPasswordChar = false;
            this.mtCardNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtCardNumber_KeyPress);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(243, 310);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(75, 19);
            this.materialLabel5.TabIndex = 0;
            this.materialLabel5.Text = "Код CVC:";
            // 
            // mCardCVC
            // 
            this.mCardCVC.Depth = 0;
            this.mCardCVC.Hint = "";
            this.mCardCVC.Location = new System.Drawing.Point(247, 340);
            this.mCardCVC.MouseState = MaterialSkin.MouseState.HOVER;
            this.mCardCVC.Name = "mCardCVC";
            this.mCardCVC.PasswordChar = '\0';
            this.mCardCVC.SelectedText = "";
            this.mCardCVC.SelectionLength = 0;
            this.mCardCVC.SelectionStart = 0;
            this.mCardCVC.Size = new System.Drawing.Size(86, 23);
            this.mCardCVC.TabIndex = 1;
            this.mCardCVC.UseSystemPasswordChar = false;
            this.mCardCVC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtCardNumber_KeyPress);
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(32, 337);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(157, 29);
            this.metroDateTime1.TabIndex = 3;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(28, 310);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(119, 19);
            this.materialLabel6.TabIndex = 4;
            this.materialLabel6.Text = "Срок действия:";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(208, 81);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(187, 19);
            this.materialLabel7.TabIndex = 5;
            this.materialLabel7.Text = "Информация о спонсоре";
            this.materialLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(401, 151);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(165, 19);
            this.materialLabel8.TabIndex = 6;
            this.materialLabel8.Text = "Благотворительность";
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.DisplayMember = "CharityId";
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(381, 185);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(216, 29);
            this.metroComboBox1.TabIndex = 7;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.ValueMember = "CharityId";
            this.metroComboBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.metroComboBox1_MouseClick);
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
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(410, 243);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(173, 19);
            this.materialLabel9.TabIndex = 8;
            this.materialLabel9.Text = "Сумма пожертвования";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown1.Location = new System.Drawing.Point(442, 275);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(79, 16);
            this.numericUpDown1.TabIndex = 9;
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(523, 278);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(36, 19);
            this.materialLabel10.TabIndex = 10;
            this.materialLabel10.Text = "руб.";
            // 
            // mbZaplata
            // 
            this.mbZaplata.Depth = 0;
            this.mbZaplata.Location = new System.Drawing.Point(486, 366);
            this.mbZaplata.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbZaplata.Name = "mbZaplata";
            this.mbZaplata.Primary = true;
            this.mbZaplata.Size = new System.Drawing.Size(121, 44);
            this.mbZaplata.TabIndex = 11;
            this.mbZaplata.Text = "Заплатить";
            this.mbZaplata.UseVisualStyleBackColor = true;
            this.mbZaplata.Click += new System.EventHandler(this.mbZaplata_Click);
            // 
            // mbCancel
            // 
            this.mbCancel.AutoSize = true;
            this.mbCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbCancel.Depth = 0;
            this.mbCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.mbCancel.Location = new System.Drawing.Point(392, 371);
            this.mbCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbCancel.Name = "mbCancel";
            this.mbCancel.Primary = false;
            this.mbCancel.Size = new System.Drawing.Size(68, 36);
            this.mbCancel.TabIndex = 12;
            this.mbCancel.Text = "Отмена";
            this.mbCancel.UseVisualStyleBackColor = true;
            // 
            // registrationTableAdapter
            // 
            this.registrationTableAdapter.ClearBeforeFill = true;
            // 
            // sponsorshipTableAdapter
            // 
            this.sponsorshipTableAdapter.ClearBeforeFill = true;
            // 
            // runnerSponsorTableAdapter
            // 
            this.runnerSponsorTableAdapter.ClearBeforeFill = true;
            // 
            // charityTableAdapter
            // 
            this.charityTableAdapter.ClearBeforeFill = true;
            // 
            // mlTime
            // 
            this.mlTime.AutoSize = true;
            this.mlTime.Location = new System.Drawing.Point(201, 10);
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
            this.panel2.Location = new System.Drawing.Point(20, 424);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(590, 39);
            this.panel2.TabIndex = 13;
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
            // SponsorRunner
            // 
            this.AcceptButton = this.mbZaplata;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.mbCancel;
            this.ClientSize = new System.Drawing.Size(630, 483);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.mbCancel);
            this.Controls.Add(this.mbZaplata);
            this.Controls.Add(this.materialLabel10);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.materialLabel9);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.mComboRunner);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.mCardCVC);
            this.Controls.Add(this.mtCardNumber);
            this.Controls.Add(this.mtCardFI);
            this.Controls.Add(this.mtName);
            this.Controls.Add(this.materialLabel1);
            this.Name = "SponsorRunner";
            this.Text = "Спонсировать бегуна";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SponsorRunner_FormClosed);
            this.Load += new System.EventHandler(this.SponsorRunner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.runnerSponsorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.charityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marathone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField mtName;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MetroFramework.Controls.MetroComboBox mComboRunner;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField mtCardFI;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField mtCardNumber;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialSingleLineTextField mCardCVC;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialRaisedButton mbZaplata;
        private MaterialSkin.Controls.MaterialFlatButton mbCancel;
        private Marathone marathone;
        private MarathoneTableAdapters.RegistrationTableAdapter registrationTableAdapter;
        private MarathoneTableAdapters.SponsorshipTableAdapter sponsorshipTableAdapter;
        private MyDataSet myDataSet;
        private System.Windows.Forms.BindingSource runnerSponsorBindingSource;
        private MyDataSetTableAdapters.RunnerSponsorTableAdapter runnerSponsorTableAdapter;
        private System.Windows.Forms.BindingSource charityBindingSource;
        private MarathoneTableAdapters.CharityTableAdapter charityTableAdapter;
        private MetroFramework.Controls.MetroLabel mlTime;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timerDay;
        private MarathoneTableAdapters.EventTableAdapter eventTableAdapter;
    }
}