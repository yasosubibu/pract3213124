namespace Марафон
{
    partial class EditProfilerRunner
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
            this.mtEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.mtName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.mtFamily = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.mComboMale = new MetroFramework.Controls.MetroComboBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.mComboStrana = new MetroFramework.Controls.MetroComboBox();
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marathone = new Марафон.Marathone();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mtPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.mtPasswordPovtor = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mbSave = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mbCancel = new MaterialSkin.Controls.MaterialFlatButton();
            this.userTableAdapter = new Марафон.MarathoneTableAdapters.UserTableAdapter();
            this.runnerTableAdapter = new Марафон.MarathoneTableAdapters.RunnerTableAdapter();
            this.runnerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countryTableAdapter = new Марафон.MarathoneTableAdapters.CountryTableAdapter();
            this.mlDownloadPhoto = new MetroFramework.Controls.MetroLink();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.mlTime = new MetroFramework.Controls.MetroLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.eventTableAdapter = new Марафон.MarathoneTableAdapters.EventTableAdapter();
            this.timerDay = new System.Windows.Forms.Timer(this.components);
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marathone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.runnerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtEmail
            // 
            this.mtEmail.Depth = 0;
            this.mtEmail.Enabled = false;
            this.mtEmail.Hint = "";
            this.mtEmail.Location = new System.Drawing.Point(104, 257);
            this.mtEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtEmail.Name = "mtEmail";
            this.mtEmail.PasswordChar = '\0';
            this.mtEmail.SelectedText = "";
            this.mtEmail.SelectionLength = 0;
            this.mtEmail.SelectionStart = 0;
            this.mtEmail.Size = new System.Drawing.Size(187, 23);
            this.mtEmail.TabIndex = 0;
            this.mtEmail.Text = "hd.anufriev@yandex.ru";
            this.mtEmail.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(23, 257);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(56, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Почта:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(23, 296);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(39, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Имя";
            // 
            // mtName
            // 
            this.mtName.Depth = 0;
            this.mtName.Hint = "";
            this.mtName.Location = new System.Drawing.Point(104, 291);
            this.mtName.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtName.Name = "mtName";
            this.mtName.PasswordChar = '\0';
            this.mtName.SelectedText = "";
            this.mtName.SelectionLength = 0;
            this.mtName.SelectionStart = 0;
            this.mtName.Size = new System.Drawing.Size(187, 23);
            this.mtName.TabIndex = 2;
            this.mtName.UseSystemPasswordChar = false;
            this.mtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtName_KeyPress);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(23, 326);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(75, 19);
            this.materialLabel3.TabIndex = 1;
            this.materialLabel3.Text = "Фамилия";
            // 
            // mtFamily
            // 
            this.mtFamily.Depth = 0;
            this.mtFamily.Hint = "";
            this.mtFamily.Location = new System.Drawing.Point(104, 326);
            this.mtFamily.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtFamily.Name = "mtFamily";
            this.mtFamily.PasswordChar = '\0';
            this.mtFamily.SelectedText = "";
            this.mtFamily.SelectionLength = 0;
            this.mtFamily.SelectionStart = 0;
            this.mtFamily.Size = new System.Drawing.Size(187, 23);
            this.mtFamily.TabIndex = 2;
            this.mtFamily.UseSystemPasswordChar = false;
            this.mtFamily.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtFamily_KeyPress);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(23, 362);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(110, 19);
            this.materialLabel4.TabIndex = 1;
            this.materialLabel4.Text = "Год рождения";
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(138, 359);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(153, 29);
            this.metroDateTime1.TabIndex = 3;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(24, 407);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(38, 19);
            this.materialLabel5.TabIndex = 4;
            this.materialLabel5.Text = "Пол";
            // 
            // mComboMale
            // 
            this.mComboMale.FormattingEnabled = true;
            this.mComboMale.ItemHeight = 23;
            this.mComboMale.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.mComboMale.Location = new System.Drawing.Point(103, 400);
            this.mComboMale.Name = "mComboMale";
            this.mComboMale.Size = new System.Drawing.Size(188, 29);
            this.mComboMale.TabIndex = 5;
            this.mComboMale.UseSelectable = true;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(24, 442);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(59, 19);
            this.materialLabel6.TabIndex = 4;
            this.materialLabel6.Text = "Страна";
            // 
            // mComboStrana
            // 
            this.mComboStrana.DataSource = this.countryBindingSource;
            this.mComboStrana.DisplayMember = "CountryName";
            this.mComboStrana.FormattingEnabled = true;
            this.mComboStrana.ItemHeight = 23;
            this.mComboStrana.Location = new System.Drawing.Point(103, 435);
            this.mComboStrana.Name = "mComboStrana";
            this.mComboStrana.Size = new System.Drawing.Size(188, 29);
            this.mComboStrana.TabIndex = 5;
            this.mComboStrana.UseSelectable = true;
            this.mComboStrana.ValueMember = "CountryCode";
            // 
            // countryBindingSource
            // 
            this.countryBindingSource.DataMember = "Country";
            this.countryBindingSource.DataSource = this.marathone;
            // 
            // marathone
            // 
            this.marathone.DataSetName = "Marathone";
            this.marathone.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(378, 251);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(124, 25);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Смена пароля";
            // 
            // mtPassword
            // 
            this.mtPassword.Depth = 0;
            this.mtPassword.Hint = "";
            this.mtPassword.Location = new System.Drawing.Point(394, 294);
            this.mtPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtPassword.Name = "mtPassword";
            this.mtPassword.PasswordChar = '\0';
            this.mtPassword.SelectedText = "";
            this.mtPassword.SelectionLength = 0;
            this.mtPassword.SelectionStart = 0;
            this.mtPassword.Size = new System.Drawing.Size(151, 23);
            this.mtPassword.TabIndex = 7;
            this.mtPassword.UseSystemPasswordChar = false;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(298, 298);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(62, 19);
            this.materialLabel7.TabIndex = 8;
            this.materialLabel7.Text = "Пароль";
            // 
            // mtPasswordPovtor
            // 
            this.mtPasswordPovtor.Depth = 0;
            this.mtPasswordPovtor.Hint = "";
            this.mtPasswordPovtor.Location = new System.Drawing.Point(394, 329);
            this.mtPasswordPovtor.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtPasswordPovtor.Name = "mtPasswordPovtor";
            this.mtPasswordPovtor.PasswordChar = '\0';
            this.mtPasswordPovtor.SelectedText = "";
            this.mtPasswordPovtor.SelectionLength = 0;
            this.mtPasswordPovtor.SelectionStart = 0;
            this.mtPasswordPovtor.Size = new System.Drawing.Size(151, 23);
            this.mtPasswordPovtor.TabIndex = 7;
            this.mtPasswordPovtor.UseSystemPasswordChar = false;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(298, 333);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(86, 19);
            this.materialLabel8.TabIndex = 8;
            this.materialLabel8.Text = "Повторите";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(343, 372);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(159, 38);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Оставьте поля пустыми \r\nесли не хотите изменять";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mbSave
            // 
            this.mbSave.Depth = 0;
            this.mbSave.Location = new System.Drawing.Point(436, 474);
            this.mbSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbSave.Name = "mbSave";
            this.mbSave.Primary = true;
            this.mbSave.Size = new System.Drawing.Size(127, 43);
            this.mbSave.TabIndex = 10;
            this.mbSave.Text = "Сохранить";
            this.mbSave.UseVisualStyleBackColor = true;
            this.mbSave.Click += new System.EventHandler(this.mbSave_Click);
            // 
            // mbCancel
            // 
            this.mbCancel.AutoSize = true;
            this.mbCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbCancel.Depth = 0;
            this.mbCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.mbCancel.Location = new System.Drawing.Point(24, 481);
            this.mbCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbCancel.Name = "mbCancel";
            this.mbCancel.Primary = false;
            this.mbCancel.Size = new System.Drawing.Size(68, 36);
            this.mbCancel.TabIndex = 11;
            this.mbCancel.Text = "Отмена";
            this.mbCancel.UseVisualStyleBackColor = true;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // runnerTableAdapter
            // 
            this.runnerTableAdapter.ClearBeforeFill = true;
            // 
            // runnerBindingSource
            // 
            this.runnerBindingSource.DataMember = "Runner";
            this.runnerBindingSource.DataSource = this.marathone;
            // 
            // countryTableAdapter
            // 
            this.countryTableAdapter.ClearBeforeFill = true;
            // 
            // mlDownloadPhoto
            // 
            this.mlDownloadPhoto.Location = new System.Drawing.Point(23, 220);
            this.mlDownloadPhoto.Name = "mlDownloadPhoto";
            this.mlDownloadPhoto.Size = new System.Drawing.Size(106, 23);
            this.mlDownloadPhoto.TabIndex = 13;
            this.mlDownloadPhoto.Text = "Загрузить фото";
            this.mlDownloadPhoto.UseSelectable = true;
            this.mlDownloadPhoto.Click += new System.EventHandler(this.mlDownloadPhoto_Click);
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(23, 100);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(159, 114);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 12;
            this.pbImage.TabStop = false;
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
            this.panel2.Location = new System.Drawing.Point(20, 523);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(543, 39);
            this.panel2.TabIndex = 23;
            // 
            // eventTableAdapter
            // 
            this.eventTableAdapter.ClearBeforeFill = true;
            // 
            // timerDay
            // 
            this.timerDay.Interval = 1000;
            this.timerDay.Tick += new System.EventHandler(this.timerDay_Tick);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(186, 71);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(201, 25);
            this.metroLabel3.TabIndex = 24;
            this.metroLabel3.Text = "Редактировать профиль";
            // 
            // EditProfilerRunner
            // 
            this.AcceptButton = this.mbSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.mbCancel;
            this.ClientSize = new System.Drawing.Size(583, 582);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.mlDownloadPhoto);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.mbCancel);
            this.Controls.Add(this.mbSave);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.mtPasswordPovtor);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.mtPassword);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mComboStrana);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.mComboMale);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.mtFamily);
            this.Controls.Add(this.mtName);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.mtEmail);
            this.Name = "EditProfilerRunner";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Марафон Skills 2017";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.EditProfilerRunner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marathone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.runnerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField mtEmail;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField mtName;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField mtFamily;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MetroFramework.Controls.MetroComboBox mComboMale;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MetroFramework.Controls.MetroComboBox mComboStrana;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField mtPassword;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialSingleLineTextField mtPasswordPovtor;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MaterialSkin.Controls.MaterialRaisedButton mbSave;
        private MaterialSkin.Controls.MaterialFlatButton mbCancel;
        private MarathoneTableAdapters.UserTableAdapter userTableAdapter;
        private MarathoneTableAdapters.RunnerTableAdapter runnerTableAdapter;
        private System.Windows.Forms.BindingSource runnerBindingSource;
        private Marathone marathone;
        private System.Windows.Forms.BindingSource countryBindingSource;
        private MarathoneTableAdapters.CountryTableAdapter countryTableAdapter;
        private MetroFramework.Controls.MetroLink mlDownloadPhoto;
        private System.Windows.Forms.PictureBox pbImage;
        private MetroFramework.Controls.MetroLabel mlTime;
        private System.Windows.Forms.Panel panel2;
        private MarathoneTableAdapters.EventTableAdapter eventTableAdapter;
        private System.Windows.Forms.Timer timerDay;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}