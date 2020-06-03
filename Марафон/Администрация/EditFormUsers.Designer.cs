namespace Марафон.Администрация
{
    partial class EditFormUsers
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
            this.mlTime = new MetroFramework.Controls.MetroLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.marathone = new Марафон.Marathone();
            this.eventTableAdapter = new Марафон.MarathoneTableAdapters.EventTableAdapter();
            this.timerDay = new System.Windows.Forms.Timer(this.components);
            this.userTableAdapter = new Марафон.MarathoneTableAdapters.UserTableAdapter();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mlEmail = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.mtName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.mtFanily = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.genderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genderTableAdapter = new Марафон.MarathoneTableAdapters.GenderTableAdapter();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.mbSave = new MetroFramework.Controls.MetroButton();
            this.mbClose = new MetroFramework.Controls.MetroButton();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marathone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mlTime
            // 
            this.mlTime.AutoSize = true;
            this.mlTime.Location = new System.Drawing.Point(203, 10);
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
            this.panel2.Location = new System.Drawing.Point(20, 347);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(560, 39);
            this.panel2.TabIndex = 28;
            // 
            // marathone
            // 
            this.marathone.DataSetName = "Marathone";
            this.marathone.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(139, 73);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(328, 25);
            this.metroLabel1.TabIndex = 29;
            this.metroLabel1.Text = "Редактирование профиля пользователя";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(24, 132);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(48, 19);
            this.metroLabel2.TabIndex = 30;
            this.metroLabel2.Text = "Почта:";
            // 
            // mlEmail
            // 
            this.mlEmail.AutoSize = true;
            this.mlEmail.Location = new System.Drawing.Point(110, 132);
            this.mlEmail.Name = "mlEmail";
            this.mlEmail.Size = new System.Drawing.Size(44, 19);
            this.mlEmail.TabIndex = 30;
            this.mlEmail.Text = "почта";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 168);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(38, 19);
            this.metroLabel3.TabIndex = 30;
            this.metroLabel3.Text = "Имя:";
            // 
            // mtName
            // 
            // 
            // 
            // 
            this.mtName.CustomButton.Image = null;
            this.mtName.CustomButton.Location = new System.Drawing.Point(104, 1);
            this.mtName.CustomButton.Name = "";
            this.mtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtName.CustomButton.TabIndex = 1;
            this.mtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtName.CustomButton.UseSelectable = true;
            this.mtName.CustomButton.Visible = false;
            this.mtName.Lines = new string[0];
            this.mtName.Location = new System.Drawing.Point(110, 168);
            this.mtName.MaxLength = 32767;
            this.mtName.Name = "mtName";
            this.mtName.PasswordChar = '\0';
            this.mtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtName.SelectedText = "";
            this.mtName.SelectionLength = 0;
            this.mtName.SelectionStart = 0;
            this.mtName.ShortcutsEnabled = true;
            this.mtName.Size = new System.Drawing.Size(126, 23);
            this.mtName.TabIndex = 31;
            this.mtName.UseSelectable = true;
            this.mtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtName_KeyPress);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 197);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(68, 19);
            this.metroLabel4.TabIndex = 30;
            this.metroLabel4.Text = "Фамилия:";
            // 
            // mtFanily
            // 
            // 
            // 
            // 
            this.mtFanily.CustomButton.Image = null;
            this.mtFanily.CustomButton.Location = new System.Drawing.Point(104, 1);
            this.mtFanily.CustomButton.Name = "";
            this.mtFanily.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtFanily.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtFanily.CustomButton.TabIndex = 1;
            this.mtFanily.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtFanily.CustomButton.UseSelectable = true;
            this.mtFanily.CustomButton.Visible = false;
            this.mtFanily.Lines = new string[0];
            this.mtFanily.Location = new System.Drawing.Point(110, 197);
            this.mtFanily.MaxLength = 32767;
            this.mtFanily.Name = "mtFanily";
            this.mtFanily.PasswordChar = '\0';
            this.mtFanily.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtFanily.SelectedText = "";
            this.mtFanily.SelectionLength = 0;
            this.mtFanily.SelectionStart = 0;
            this.mtFanily.ShortcutsEnabled = true;
            this.mtFanily.Size = new System.Drawing.Size(126, 23);
            this.mtFanily.TabIndex = 31;
            this.mtFanily.UseSelectable = true;
            this.mtFanily.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtFanily.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mtFanily.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtName_KeyPress);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(23, 240);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(36, 19);
            this.metroLabel5.TabIndex = 30;
            this.metroLabel5.Text = "Пол:";
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.DataSource = this.genderBindingSource;
            this.metroComboBox1.DisplayMember = "Gender";
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(110, 236);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(126, 29);
            this.metroComboBox1.TabIndex = 32;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.ValueMember = "Gender";
            // 
            // genderBindingSource
            // 
            this.genderBindingSource.DataMember = "Gender";
            this.genderBindingSource.DataSource = this.marathone;
            // 
            // genderTableAdapter
            // 
            this.genderTableAdapter.ClearBeforeFill = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(364, 115);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(162, 76);
            this.metroLabel6.TabIndex = 33;
            this.metroLabel6.Text = "Новый пароль:\r\n\r\nесли не хотите изменять,\r\nоставьте поле пустыми";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(309, 211);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(101, 19);
            this.metroLabel7.TabIndex = 30;
            this.metroLabel7.Text = "Новый пароль:";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(329, 240);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(77, 19);
            this.metroLabel8.TabIndex = 30;
            this.metroLabel8.Text = "Повторите:";
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(104, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(416, 211);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(126, 23);
            this.metroTextBox1.TabIndex = 31;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox2
            // 
            // 
            // 
            // 
            this.metroTextBox2.CustomButton.Image = null;
            this.metroTextBox2.CustomButton.Location = new System.Drawing.Point(104, 1);
            this.metroTextBox2.CustomButton.Name = "";
            this.metroTextBox2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox2.CustomButton.TabIndex = 1;
            this.metroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox2.CustomButton.UseSelectable = true;
            this.metroTextBox2.CustomButton.Visible = false;
            this.metroTextBox2.Lines = new string[0];
            this.metroTextBox2.Location = new System.Drawing.Point(416, 240);
            this.metroTextBox2.MaxLength = 32767;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '\0';
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.SelectionLength = 0;
            this.metroTextBox2.SelectionStart = 0;
            this.metroTextBox2.ShortcutsEnabled = true;
            this.metroTextBox2.Size = new System.Drawing.Size(126, 23);
            this.metroTextBox2.TabIndex = 31;
            this.metroTextBox2.UseSelectable = true;
            this.metroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mbSave
            // 
            this.mbSave.Location = new System.Drawing.Point(179, 292);
            this.mbSave.Name = "mbSave";
            this.mbSave.Size = new System.Drawing.Size(110, 38);
            this.mbSave.TabIndex = 34;
            this.mbSave.Text = "Сохранить";
            this.mbSave.UseSelectable = true;
            this.mbSave.Click += new System.EventHandler(this.mbSave_Click);
            // 
            // mbClose
            // 
            this.mbClose.Location = new System.Drawing.Point(295, 292);
            this.mbClose.Name = "mbClose";
            this.mbClose.Size = new System.Drawing.Size(110, 38);
            this.mbClose.TabIndex = 34;
            this.mbClose.Text = "Отмена";
            this.mbClose.UseSelectable = true;
            this.mbClose.Click += new System.EventHandler(this.mbClose_Click);
            // 
            // EditFormUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 406);
            this.Controls.Add(this.mbClose);
            this.Controls.Add(this.mbSave);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.metroTextBox2);
            this.Controls.Add(this.mtFanily);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.mtName);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.mlEmail);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.panel2);
            this.Name = "EditFormUsers";
            this.Text = "Марафон Skills 2017";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.EditFormUsers_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marathone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel mlTime;
        private System.Windows.Forms.Panel panel2;
        private Marathone marathone;
        private MarathoneTableAdapters.EventTableAdapter eventTableAdapter;
        private System.Windows.Forms.Timer timerDay;
        private MarathoneTableAdapters.UserTableAdapter userTableAdapter;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel mlEmail;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox mtName;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox mtFanily;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private System.Windows.Forms.BindingSource genderBindingSource;
        private MarathoneTableAdapters.GenderTableAdapter genderTableAdapter;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroButton mbSave;
        private MetroFramework.Controls.MetroButton mbClose;
    }
}