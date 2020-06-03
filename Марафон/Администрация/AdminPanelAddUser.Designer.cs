namespace Марафон
{
    partial class AdminPanelAddUser
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
            this.mtEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.mlName = new MetroFramework.Controls.MetroLabel();
            this.mtName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.mtFamile = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.roleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marathone = new Марафон.Marathone();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mtPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.mtPassordPovtor = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.mbCancel = new MaterialSkin.Controls.MaterialFlatButton();
            this.mbReg = new MaterialSkin.Controls.MaterialRaisedButton();
            this.roleTableAdapter = new Марафон.MarathoneTableAdapters.RoleTableAdapter();
            this.userTableAdapter = new Марафон.MarathoneTableAdapters.UserTableAdapter();
            this.mlTime = new MetroFramework.Controls.MetroLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.timerDay = new System.Windows.Forms.Timer(this.components);
            this.eventTableAdapter = new Марафон.MarathoneTableAdapters.EventTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marathone)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 106);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(45, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Почта";
            // 
            // mtEmail
            // 
            this.mtEmail.Depth = 0;
            this.mtEmail.Hint = "";
            this.mtEmail.Location = new System.Drawing.Point(112, 106);
            this.mtEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtEmail.Name = "mtEmail";
            this.mtEmail.PasswordChar = '\0';
            this.mtEmail.SelectedText = "";
            this.mtEmail.SelectionLength = 0;
            this.mtEmail.SelectionStart = 0;
            this.mtEmail.Size = new System.Drawing.Size(172, 23);
            this.mtEmail.TabIndex = 1;
            this.mtEmail.UseSystemPasswordChar = false;
            // 
            // mlName
            // 
            this.mlName.AutoSize = true;
            this.mlName.Location = new System.Drawing.Point(24, 135);
            this.mlName.Name = "mlName";
            this.mlName.Size = new System.Drawing.Size(35, 19);
            this.mlName.TabIndex = 0;
            this.mlName.Text = "Имя";
            // 
            // mtName
            // 
            this.mtName.Depth = 0;
            this.mtName.Hint = "";
            this.mtName.Location = new System.Drawing.Point(112, 135);
            this.mtName.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtName.Name = "mtName";
            this.mtName.PasswordChar = '\0';
            this.mtName.SelectedText = "";
            this.mtName.SelectionLength = 0;
            this.mtName.SelectionStart = 0;
            this.mtName.Size = new System.Drawing.Size(172, 23);
            this.mtName.TabIndex = 1;
            this.mtName.UseSystemPasswordChar = false;
            this.mtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtName_KeyPress);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(24, 164);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(65, 19);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Фамилия";
            // 
            // mtFamile
            // 
            this.mtFamile.Depth = 0;
            this.mtFamile.Hint = "";
            this.mtFamile.Location = new System.Drawing.Point(112, 164);
            this.mtFamile.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtFamile.Name = "mtFamile";
            this.mtFamile.PasswordChar = '\0';
            this.mtFamile.SelectedText = "";
            this.mtFamile.SelectionLength = 0;
            this.mtFamile.SelectionStart = 0;
            this.mtFamile.Size = new System.Drawing.Size(172, 23);
            this.mtFamile.TabIndex = 1;
            this.mtFamile.UseSystemPasswordChar = false;
            this.mtFamile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtName_KeyPress);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(24, 193);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(38, 19);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "Роль";
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.DataSource = this.roleBindingSource;
            this.metroComboBox1.DisplayMember = "RoleName";
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(112, 190);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(172, 29);
            this.metroComboBox1.TabIndex = 2;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.ValueMember = "RoleId";
            // 
            // roleBindingSource
            // 
            this.roleBindingSource.DataMember = "Role";
            this.roleBindingSource.DataSource = this.marathone;
            // 
            // marathone
            // 
            this.marathone.DataSetName = "Marathone";
            this.marathone.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(434, 106);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(98, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Новый пароль";
            // 
            // mtPassword
            // 
            this.mtPassword.Depth = 0;
            this.mtPassword.Hint = "";
            this.mtPassword.Location = new System.Drawing.Point(404, 131);
            this.mtPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtPassword.Name = "mtPassword";
            this.mtPassword.PasswordChar = '\0';
            this.mtPassword.SelectedText = "";
            this.mtPassword.SelectionLength = 0;
            this.mtPassword.SelectionStart = 0;
            this.mtPassword.Size = new System.Drawing.Size(158, 23);
            this.mtPassword.TabIndex = 4;
            this.mtPassword.UseSystemPasswordChar = false;
            // 
            // mtPassordPovtor
            // 
            this.mtPassordPovtor.Depth = 0;
            this.mtPassordPovtor.Hint = "";
            this.mtPassordPovtor.Location = new System.Drawing.Point(404, 179);
            this.mtPassordPovtor.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtPassordPovtor.Name = "mtPassordPovtor";
            this.mtPassordPovtor.PasswordChar = '\0';
            this.mtPassordPovtor.SelectedText = "";
            this.mtPassordPovtor.SelectionLength = 0;
            this.mtPassordPovtor.SelectionStart = 0;
            this.mtPassordPovtor.Size = new System.Drawing.Size(158, 23);
            this.mtPassordPovtor.TabIndex = 4;
            this.mtPassordPovtor.UseSystemPasswordChar = false;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(446, 157);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(74, 19);
            this.metroLabel5.TabIndex = 3;
            this.metroLabel5.Text = "Повторите";
            // 
            // mbCancel
            // 
            this.mbCancel.AutoSize = true;
            this.mbCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbCancel.Depth = 0;
            this.mbCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.mbCancel.Location = new System.Drawing.Point(25, 230);
            this.mbCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbCancel.Name = "mbCancel";
            this.mbCancel.Primary = false;
            this.mbCancel.Size = new System.Drawing.Size(68, 36);
            this.mbCancel.TabIndex = 5;
            this.mbCancel.Text = "Отмена";
            this.mbCancel.UseVisualStyleBackColor = true;
            // 
            // mbReg
            // 
            this.mbReg.Depth = 0;
            this.mbReg.Location = new System.Drawing.Point(434, 230);
            this.mbReg.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbReg.Name = "mbReg";
            this.mbReg.Primary = true;
            this.mbReg.Size = new System.Drawing.Size(171, 42);
            this.mbReg.TabIndex = 6;
            this.mbReg.Text = "Зарегистрировать";
            this.mbReg.UseVisualStyleBackColor = true;
            this.mbReg.Click += new System.EventHandler(this.mbReg_Click);
            // 
            // roleTableAdapter
            // 
            this.roleTableAdapter.ClearBeforeFill = true;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // mlTime
            // 
            this.mlTime.AutoSize = true;
            this.mlTime.Location = new System.Drawing.Point(205, 10);
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
            this.panel2.Location = new System.Drawing.Point(20, 278);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(588, 39);
            this.panel2.TabIndex = 28;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(170, 60);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(281, 25);
            this.metroLabel6.TabIndex = 29;
            this.metroLabel6.Text = "Добавление нового пользователя";
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
            // AdminPanelAddUser
            // 
            this.AcceptButton = this.mbReg;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.mbCancel;
            this.ClientSize = new System.Drawing.Size(628, 337);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.mbReg);
            this.Controls.Add(this.mbCancel);
            this.Controls.Add(this.mtPassordPovtor);
            this.Controls.Add(this.mtPassword);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.mtFamile);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.mtName);
            this.Controls.Add(this.mlName);
            this.Controls.Add(this.mtEmail);
            this.Controls.Add(this.metroLabel1);
            this.Name = "AdminPanelAddUser";
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "Марафон Skills 2017";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.AdminPanelAddUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marathone)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField mtEmail;
        private MetroFramework.Controls.MetroLabel mlName;
        private MaterialSkin.Controls.MaterialSingleLineTextField mtName;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField mtFamile;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField mtPassword;
        private MaterialSkin.Controls.MaterialSingleLineTextField mtPassordPovtor;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MaterialSkin.Controls.MaterialFlatButton mbCancel;
        private MaterialSkin.Controls.MaterialRaisedButton mbReg;
        private Marathone marathone;
        private System.Windows.Forms.BindingSource roleBindingSource;
        private MarathoneTableAdapters.RoleTableAdapter roleTableAdapter;
        private MarathoneTableAdapters.UserTableAdapter userTableAdapter;
        private MetroFramework.Controls.MetroLabel mlTime;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.Timer timerDay;
        private MarathoneTableAdapters.EventTableAdapter eventTableAdapter;
    }
}