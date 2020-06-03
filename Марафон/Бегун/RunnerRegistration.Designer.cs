namespace Марафон
{
    partial class RunnerRegistration
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
            this.mtEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.mlPassword = new MaterialSkin.Controls.MaterialLabel();
            this.mtPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.mtPasswordPovtor = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.mtName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.mtFamily = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mHappyBirthday = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.mComboStrana = new MetroFramework.Controls.MetroComboBox();
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marathone = new Марафон.Marathone();
            this.mRegistration = new MaterialSkin.Controls.MaterialFlatButton();
            this.mCancel = new MaterialSkin.Controls.MaterialFlatButton();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.runnerTableAdapter = new Марафон.MarathoneTableAdapters.RunnerTableAdapter();
            this.userTableAdapter = new Марафон.MarathoneTableAdapters.UserTableAdapter();
            this.countryTableAdapter = new Марафон.MarathoneTableAdapters.CountryTableAdapter();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.mlDownloadPhoto = new MetroFramework.Controls.MetroLink();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mlTime = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.timerDay = new System.Windows.Forms.Timer(this.components);
            this.eventTableAdapter = new Марафон.MarathoneTableAdapters.EventTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marathone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(28, 129);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(112, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Почта (логин):";
            // 
            // mtEmail
            // 
            this.mtEmail.Depth = 0;
            this.mtEmail.Hint = "";
            this.mtEmail.Location = new System.Drawing.Point(177, 129);
            this.mtEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtEmail.Name = "mtEmail";
            this.mtEmail.PasswordChar = '\0';
            this.mtEmail.SelectedText = "";
            this.mtEmail.SelectionLength = 0;
            this.mtEmail.SelectionStart = 0;
            this.mtEmail.Size = new System.Drawing.Size(185, 23);
            this.mtEmail.TabIndex = 1;
            this.mtEmail.UseSystemPasswordChar = false;
            // 
            // mlPassword
            // 
            this.mlPassword.AutoSize = true;
            this.mlPassword.Depth = 0;
            this.mlPassword.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlPassword.Location = new System.Drawing.Point(28, 162);
            this.mlPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlPassword.Name = "mlPassword";
            this.mlPassword.Size = new System.Drawing.Size(66, 19);
            this.mlPassword.TabIndex = 0;
            this.mlPassword.Text = "Пароль:";
            // 
            // mtPassword
            // 
            this.mtPassword.Depth = 0;
            this.mtPassword.Hint = "";
            this.mtPassword.Location = new System.Drawing.Point(177, 162);
            this.mtPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtPassword.Name = "mtPassword";
            this.mtPassword.PasswordChar = '\0';
            this.mtPassword.SelectedText = "";
            this.mtPassword.SelectionLength = 0;
            this.mtPassword.SelectionStart = 0;
            this.mtPassword.Size = new System.Drawing.Size(185, 23);
            this.mtPassword.TabIndex = 1;
            this.mtPassword.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(28, 195);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(145, 19);
            this.materialLabel3.TabIndex = 0;
            this.materialLabel3.Text = "Повторить пароль:";
            // 
            // mtPasswordPovtor
            // 
            this.mtPasswordPovtor.Depth = 0;
            this.mtPasswordPovtor.Hint = "";
            this.mtPasswordPovtor.Location = new System.Drawing.Point(177, 195);
            this.mtPasswordPovtor.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtPasswordPovtor.Name = "mtPasswordPovtor";
            this.mtPasswordPovtor.PasswordChar = '\0';
            this.mtPasswordPovtor.SelectedText = "";
            this.mtPasswordPovtor.SelectionLength = 0;
            this.mtPasswordPovtor.SelectionStart = 0;
            this.mtPasswordPovtor.Size = new System.Drawing.Size(185, 23);
            this.mtPasswordPovtor.TabIndex = 1;
            this.mtPasswordPovtor.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(28, 242);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(39, 19);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "Имя";
            // 
            // mtName
            // 
            this.mtName.Depth = 0;
            this.mtName.Hint = "";
            this.mtName.Location = new System.Drawing.Point(177, 242);
            this.mtName.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtName.Name = "mtName";
            this.mtName.PasswordChar = '\0';
            this.mtName.SelectedText = "";
            this.mtName.SelectionLength = 0;
            this.mtName.SelectionStart = 0;
            this.mtName.Size = new System.Drawing.Size(185, 23);
            this.mtName.TabIndex = 1;
            this.mtName.UseSystemPasswordChar = false;
            this.mtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtName_KeyPress);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(28, 271);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(75, 19);
            this.materialLabel4.TabIndex = 0;
            this.materialLabel4.Text = "Фамилия";
            // 
            // mtFamily
            // 
            this.mtFamily.Depth = 0;
            this.mtFamily.Hint = "";
            this.mtFamily.Location = new System.Drawing.Point(177, 271);
            this.mtFamily.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtFamily.Name = "mtFamily";
            this.mtFamily.PasswordChar = '\0';
            this.mtFamily.SelectedText = "";
            this.mtFamily.SelectionLength = 0;
            this.mtFamily.SelectionStart = 0;
            this.mtFamily.Size = new System.Drawing.Size(185, 23);
            this.mtFamily.TabIndex = 1;
            this.mtFamily.UseSystemPasswordChar = false;
            this.mtFamily.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtName_KeyPress);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(423, 256);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(103, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Дата рождения";
            // 
            // mHappyBirthday
            // 
            this.mHappyBirthday.Location = new System.Drawing.Point(532, 251);
            this.mHappyBirthday.MinimumSize = new System.Drawing.Size(0, 29);
            this.mHappyBirthday.Name = "mHappyBirthday";
            this.mHappyBirthday.Size = new System.Drawing.Size(159, 29);
            this.mHappyBirthday.TabIndex = 5;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(423, 299);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(53, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Страна";
            // 
            // mComboStrana
            // 
            this.mComboStrana.DataSource = this.countryBindingSource;
            this.mComboStrana.DisplayMember = "CountryName";
            this.mComboStrana.FormattingEnabled = true;
            this.mComboStrana.ItemHeight = 23;
            this.mComboStrana.Location = new System.Drawing.Point(532, 296);
            this.mComboStrana.Name = "mComboStrana";
            this.mComboStrana.Size = new System.Drawing.Size(159, 29);
            this.mComboStrana.TabIndex = 7;
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
            // mRegistration
            // 
            this.mRegistration.AutoSize = true;
            this.mRegistration.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mRegistration.Depth = 0;
            this.mRegistration.Location = new System.Drawing.Point(532, 349);
            this.mRegistration.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mRegistration.MouseState = MaterialSkin.MouseState.HOVER;
            this.mRegistration.Name = "mRegistration";
            this.mRegistration.Primary = false;
            this.mRegistration.Size = new System.Drawing.Size(170, 36);
            this.mRegistration.TabIndex = 8;
            this.mRegistration.Text = "Зарегистрироваться";
            this.mRegistration.UseVisualStyleBackColor = true;
            this.mRegistration.Click += new System.EventHandler(this.mRegistration_Click);
            // 
            // mCancel
            // 
            this.mCancel.AutoSize = true;
            this.mCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mCancel.Depth = 0;
            this.mCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.mCancel.Location = new System.Drawing.Point(29, 349);
            this.mCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.mCancel.Name = "mCancel";
            this.mCancel.Primary = false;
            this.mCancel.Size = new System.Drawing.Size(68, 36);
            this.mCancel.TabIndex = 8;
            this.mCancel.Text = "Отмена";
            this.mCancel.UseVisualStyleBackColor = true;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.metroComboBox1.Location = new System.Drawing.Point(177, 300);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(185, 29);
            this.metroComboBox1.TabIndex = 7;
            this.metroComboBox1.UseSelectable = true;
            // 
            // runnerTableAdapter
            // 
            this.runnerTableAdapter.ClearBeforeFill = true;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // countryTableAdapter
            // 
            this.countryTableAdapter.ClearBeforeFill = true;
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(532, 93);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(159, 114);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 9;
            this.pbImage.TabStop = false;
            // 
            // mlDownloadPhoto
            // 
            this.mlDownloadPhoto.Location = new System.Drawing.Point(585, 213);
            this.mlDownloadPhoto.Name = "mlDownloadPhoto";
            this.mlDownloadPhoto.Size = new System.Drawing.Size(106, 23);
            this.mlDownloadPhoto.TabIndex = 10;
            this.mlDownloadPhoto.Text = "Загрузить фото";
            this.mlDownloadPhoto.UseSelectable = true;
            this.mlDownloadPhoto.Click += new System.EventHandler(this.mlDownloadPhoto_Click);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(33, 306);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(42, 19);
            this.materialLabel5.TabIndex = 11;
            this.materialLabel5.Text = "Пол:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.mlTime);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(20, 394);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(684, 39);
            this.panel2.TabIndex = 24;
            // 
            // mlTime
            // 
            this.mlTime.AutoSize = true;
            this.mlTime.Location = new System.Drawing.Point(260, 10);
            this.mlTime.Name = "mlTime";
            this.mlTime.Size = new System.Drawing.Size(191, 19);
            this.mlTime.TabIndex = 3;
            this.mlTime.Text = "Осталось 2 дня 3 часа 23 мин";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(280, 70);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(167, 25);
            this.metroLabel1.TabIndex = 25;
            this.metroLabel1.Text = "Регистрация бегуна";
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
            // RunnerRegistration
            // 
            this.AcceptButton = this.mRegistration;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.mCancel;
            this.ClientSize = new System.Drawing.Size(724, 453);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.mlDownloadPhoto);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.mCancel);
            this.Controls.Add(this.mRegistration);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.mComboStrana);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.mHappyBirthday);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.mtFamily);
            this.Controls.Add(this.mtName);
            this.Controls.Add(this.mtPasswordPovtor);
            this.Controls.Add(this.mtPassword);
            this.Controls.Add(this.mtEmail);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.mlPassword);
            this.Controls.Add(this.materialLabel1);
            this.Name = "RunnerRegistration";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Марафон Skills 2017";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RunnerRegistration_FormClosed);
            this.Load += new System.EventHandler(this.RunnerRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marathone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField mtEmail;
        private MaterialSkin.Controls.MaterialLabel mlPassword;
        private MaterialSkin.Controls.MaterialSingleLineTextField mtPassword;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField mtPasswordPovtor;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField mtName;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField mtFamily;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroDateTime mHappyBirthday;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox mComboStrana;
        private MaterialSkin.Controls.MaterialFlatButton mRegistration;
        private MaterialSkin.Controls.MaterialFlatButton mCancel;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MarathoneTableAdapters.RunnerTableAdapter runnerTableAdapter;
        private MarathoneTableAdapters.UserTableAdapter userTableAdapter;
        private Marathone marathone;
        private System.Windows.Forms.BindingSource countryBindingSource;
        private MarathoneTableAdapters.CountryTableAdapter countryTableAdapter;
        private System.Windows.Forms.PictureBox pbImage;
        private MetroFramework.Controls.MetroLink mlDownloadPhoto;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroLabel mlTime;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Timer timerDay;
        private MarathoneTableAdapters.EventTableAdapter eventTableAdapter;
    }
}