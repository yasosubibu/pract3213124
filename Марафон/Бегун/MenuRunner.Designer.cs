namespace Марафон
{
    partial class MenuRunner
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
            this.mbRegistration = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mbResult = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mbEditProfiler = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mbMySponsor = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mbContact = new MaterialSkin.Controls.MaterialRaisedButton();
            this.registrationTableAdapter = new Марафон.MarathoneTableAdapters.RegistrationTableAdapter();
            this.runnerTableAdapter = new Марафон.MarathoneTableAdapters.RunnerTableAdapter();
            this.marathone = new Марафон.Marathone();
            this.userTableAdapter = new Марафон.MarathoneTableAdapters.UserTableAdapter();
            this.mlTime = new MetroFramework.Controls.MetroLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.eventTableAdapter = new Марафон.MarathoneTableAdapters.EventTableAdapter();
            this.timerDay = new System.Windows.Forms.Timer(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.marathone)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mbRegistration
            // 
            this.mbRegistration.Depth = 0;
            this.mbRegistration.Location = new System.Drawing.Point(21, 118);
            this.mbRegistration.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbRegistration.Name = "mbRegistration";
            this.mbRegistration.Primary = true;
            this.mbRegistration.Size = new System.Drawing.Size(160, 63);
            this.mbRegistration.TabIndex = 0;
            this.mbRegistration.Text = "Регистрация на марафон";
            this.mbRegistration.UseVisualStyleBackColor = true;
            this.mbRegistration.Click += new System.EventHandler(this.mbRegistration_Click);
            // 
            // mbResult
            // 
            this.mbResult.Depth = 0;
            this.mbResult.Location = new System.Drawing.Point(187, 118);
            this.mbResult.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbResult.Name = "mbResult";
            this.mbResult.Primary = true;
            this.mbResult.Size = new System.Drawing.Size(160, 63);
            this.mbResult.TabIndex = 0;
            this.mbResult.Text = "Мои результаты";
            this.mbResult.UseVisualStyleBackColor = true;
            this.mbResult.Click += new System.EventHandler(this.mbResult_Click);
            // 
            // mbEditProfiler
            // 
            this.mbEditProfiler.Depth = 0;
            this.mbEditProfiler.Location = new System.Drawing.Point(353, 118);
            this.mbEditProfiler.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbEditProfiler.Name = "mbEditProfiler";
            this.mbEditProfiler.Primary = true;
            this.mbEditProfiler.Size = new System.Drawing.Size(160, 63);
            this.mbEditProfiler.TabIndex = 0;
            this.mbEditProfiler.Text = "Редактировать профиль";
            this.mbEditProfiler.UseVisualStyleBackColor = true;
            this.mbEditProfiler.Click += new System.EventHandler(this.mbEditProfiler_Click);
            // 
            // mbMySponsor
            // 
            this.mbMySponsor.Depth = 0;
            this.mbMySponsor.Location = new System.Drawing.Point(108, 187);
            this.mbMySponsor.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbMySponsor.Name = "mbMySponsor";
            this.mbMySponsor.Primary = true;
            this.mbMySponsor.Size = new System.Drawing.Size(160, 63);
            this.mbMySponsor.TabIndex = 0;
            this.mbMySponsor.Text = "Мой спонсор";
            this.mbMySponsor.UseVisualStyleBackColor = true;
            this.mbMySponsor.Click += new System.EventHandler(this.mbMySponsor_Click);
            // 
            // mbContact
            // 
            this.mbContact.Depth = 0;
            this.mbContact.Location = new System.Drawing.Point(274, 187);
            this.mbContact.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbContact.Name = "mbContact";
            this.mbContact.Primary = true;
            this.mbContact.Size = new System.Drawing.Size(160, 63);
            this.mbContact.TabIndex = 0;
            this.mbContact.Text = "Контакты";
            this.mbContact.UseVisualStyleBackColor = true;
            this.mbContact.Click += new System.EventHandler(this.mbContact_Click);
            // 
            // registrationTableAdapter
            // 
            this.registrationTableAdapter.ClearBeforeFill = true;
            // 
            // runnerTableAdapter
            // 
            this.runnerTableAdapter.ClearBeforeFill = true;
            // 
            // marathone
            // 
            this.marathone.DataSetName = "Marathone";
            this.marathone.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // mlTime
            // 
            this.mlTime.AutoSize = true;
            this.mlTime.Location = new System.Drawing.Point(167, 11);
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
            this.panel2.Location = new System.Drawing.Point(20, 265);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(502, 39);
            this.panel2.TabIndex = 24;
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
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(210, 76);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(126, 25);
            this.metroLabel1.TabIndex = 25;
            this.metroLabel1.Text = "Панель бегуна";
            // 
            // MenuRunner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 324);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.mbContact);
            this.Controls.Add(this.mbMySponsor);
            this.Controls.Add(this.mbEditProfiler);
            this.Controls.Add(this.mbResult);
            this.Controls.Add(this.mbRegistration);
            this.Name = "MenuRunner";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Марафон Skills 2017";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.MenuRunner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.marathone)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton mbRegistration;
        private MaterialSkin.Controls.MaterialRaisedButton mbResult;
        private MaterialSkin.Controls.MaterialRaisedButton mbEditProfiler;
        private MaterialSkin.Controls.MaterialRaisedButton mbMySponsor;
        private MaterialSkin.Controls.MaterialRaisedButton mbContact;
        private MarathoneTableAdapters.RegistrationTableAdapter registrationTableAdapter;
        private MarathoneTableAdapters.RunnerTableAdapter runnerTableAdapter;
        private Marathone marathone;
        private MarathoneTableAdapters.UserTableAdapter userTableAdapter;
        private MetroFramework.Controls.MetroLabel mlTime;
        private System.Windows.Forms.Panel panel2;
        private MarathoneTableAdapters.EventTableAdapter eventTableAdapter;
        private System.Windows.Forms.Timer timerDay;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}