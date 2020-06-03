namespace Марафон
{
    partial class AuthicationLogin
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
            this.mtLogin = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.mtPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.mbLogin = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mbFormMain = new MaterialSkin.Controls.MaterialFlatButton();
            this.userTableAdapter = new Марафон.MarathoneTableAdapters.UserTableAdapter();
            this.marathone = new Марафон.Marathone();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mlTime = new MetroFramework.Controls.MetroLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.eventTableAdapter = new Марафон.MarathoneTableAdapters.EventTableAdapter();
            this.timerDay = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.marathone)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtLogin
            // 
            this.mtLogin.Depth = 0;
            this.mtLogin.Hint = "";
            this.mtLogin.Location = new System.Drawing.Point(145, 125);
            this.mtLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtLogin.Name = "mtLogin";
            this.mtLogin.PasswordChar = '\0';
            this.mtLogin.SelectedText = "";
            this.mtLogin.SelectionLength = 0;
            this.mtLogin.SelectionStart = 0;
            this.mtLogin.Size = new System.Drawing.Size(141, 23);
            this.mtLogin.TabIndex = 0;
            this.mtLogin.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(77, 125);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(53, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Логин";
            // 
            // mtPassword
            // 
            this.mtPassword.Depth = 0;
            this.mtPassword.Hint = "";
            this.mtPassword.Location = new System.Drawing.Point(145, 156);
            this.mtPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtPassword.Name = "mtPassword";
            this.mtPassword.PasswordChar = '\0';
            this.mtPassword.SelectedText = "";
            this.mtPassword.SelectionLength = 0;
            this.mtPassword.SelectionStart = 0;
            this.mtPassword.Size = new System.Drawing.Size(141, 23);
            this.mtPassword.TabIndex = 0;
            this.mtPassword.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(77, 156);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(62, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Пароль";
            // 
            // mbLogin
            // 
            this.mbLogin.Depth = 0;
            this.mbLogin.Location = new System.Drawing.Point(244, 219);
            this.mbLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbLogin.Name = "mbLogin";
            this.mbLogin.Primary = true;
            this.mbLogin.Size = new System.Drawing.Size(75, 32);
            this.mbLogin.TabIndex = 3;
            this.mbLogin.Text = "Войти";
            this.mbLogin.UseVisualStyleBackColor = true;
            this.mbLogin.Click += new System.EventHandler(this.mbLogin_Click);
            // 
            // mbFormMain
            // 
            this.mbFormMain.AutoSize = true;
            this.mbFormMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbFormMain.Depth = 0;
            this.mbFormMain.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.mbFormMain.Location = new System.Drawing.Point(49, 215);
            this.mbFormMain.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbFormMain.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbFormMain.Name = "mbFormMain";
            this.mbFormMain.Primary = false;
            this.mbFormMain.Size = new System.Drawing.Size(68, 36);
            this.mbFormMain.TabIndex = 4;
            this.mbFormMain.Text = "Отмена";
            this.mbFormMain.UseVisualStyleBackColor = true;
            this.mbFormMain.Click += new System.EventHandler(this.mbFormMain_Click);
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
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
            this.metroLabel1.Location = new System.Drawing.Point(100, 76);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(172, 25);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Форма авторизации";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mlTime
            // 
            this.mlTime.AutoSize = true;
            this.mlTime.Location = new System.Drawing.Point(75, 11);
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
            this.panel2.Location = new System.Drawing.Point(20, 287);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(335, 39);
            this.panel2.TabIndex = 6;
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
            // AuthicationLogin
            // 
            this.AcceptButton = this.mbLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.mbFormMain;
            this.ClientSize = new System.Drawing.Size(375, 346);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mbFormMain);
            this.Controls.Add(this.mbLogin);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.mtPassword);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.mtLogin);
            this.Name = "AuthicationLogin";
            this.Text = "Марафон Skills 2017";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AuthicationLogin_FormClosed);
            this.Load += new System.EventHandler(this.AuthicationLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.marathone)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField mtLogin;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField mtPassword;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialRaisedButton mbLogin;
        private MaterialSkin.Controls.MaterialFlatButton mbFormMain;
        private MarathoneTableAdapters.UserTableAdapter userTableAdapter;
        private Marathone marathone;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel mlTime;
        private System.Windows.Forms.Panel panel2;
        private MarathoneTableAdapters.EventTableAdapter eventTableAdapter;
        private System.Windows.Forms.Timer timerDay;
    }
}