namespace Марафон
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mbLogin = new MaterialSkin.Controls.MaterialFlatButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.marathonTableAdapter = new Марафон.MarathoneTableAdapters.MarathonTableAdapter();
            this.marathone = new Марафон.Marathone();
            this.mlTime = new MetroFramework.Controls.MetroLabel();
            this.eventTableAdapter = new Марафон.MarathoneTableAdapters.EventTableAdapter();
            this.timerDay = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btInfo = new System.Windows.Forms.Button();
            this.btSponsor = new System.Windows.Forms.Button();
            this.btRunner = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.marathone)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mbLogin
            // 
            this.mbLogin.AutoSize = true;
            this.mbLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbLogin.Depth = 0;
            this.mbLogin.Location = new System.Drawing.Point(356, 329);
            this.mbLogin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbLogin.Name = "mbLogin";
            this.mbLogin.Primary = false;
            this.mbLogin.Size = new System.Drawing.Size(58, 36);
            this.mbLogin.TabIndex = 1;
            this.mbLogin.Text = "Войти";
            this.mbLogin.UseVisualStyleBackColor = true;
            this.mbLogin.Click += new System.EventHandler(this.mbLogin_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroLabel1.Location = new System.Drawing.Point(117, 12);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(182, 50);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Ближайший марафон\r\nSaul Paul 2017";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // marathonTableAdapter
            // 
            this.marathonTableAdapter.ClearBeforeFill = true;
            // 
            // marathone
            // 
            this.marathone.DataSetName = "Marathone";
            this.marathone.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mlTime
            // 
            this.mlTime.AutoSize = true;
            this.mlTime.Location = new System.Drawing.Point(97, 11);
            this.mlTime.Name = "mlTime";
            this.mlTime.Size = new System.Drawing.Size(191, 19);
            this.mlTime.TabIndex = 3;
            this.mlTime.Text = "Осталось 2 дня 3 часа 23 мин";
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 77);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.mlTime);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(20, 368);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(397, 39);
            this.panel2.TabIndex = 5;
            // 
            // btInfo
            // 
            this.btInfo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btInfo.Location = new System.Drawing.Point(96, 267);
            this.btInfo.Name = "btInfo";
            this.btInfo.Size = new System.Drawing.Size(275, 53);
            this.btInfo.TabIndex = 4;
            this.btInfo.Text = "Я хочу узнать больше о марафоне";
            this.btInfo.UseVisualStyleBackColor = true;
            this.btInfo.Click += new System.EventHandler(this.mbHelp_Click);
            // 
            // btSponsor
            // 
            this.btSponsor.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btSponsor.Location = new System.Drawing.Point(96, 218);
            this.btSponsor.Name = "btSponsor";
            this.btSponsor.Size = new System.Drawing.Size(275, 43);
            this.btSponsor.TabIndex = 5;
            this.btSponsor.Text = "Я хочу стать спонсором";
            this.btSponsor.UseVisualStyleBackColor = true;
            this.btSponsor.Click += new System.EventHandler(this.mbSponsor_Click);
            // 
            // btRunner
            // 
            this.btRunner.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btRunner.Location = new System.Drawing.Point(96, 169);
            this.btRunner.Name = "btRunner";
            this.btRunner.Size = new System.Drawing.Size(275, 43);
            this.btRunner.TabIndex = 6;
            this.btRunner.Text = "Я хочу стать бегуном";
            this.btRunner.UseVisualStyleBackColor = true;
            this.btRunner.Click += new System.EventHandler(this.mbRunner_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 427);
            this.Controls.Add(this.btInfo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btSponsor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btRunner);
            this.Controls.Add(this.mbLogin);
            this.Name = "Form1";
            this.Text = "Марафон Skills 2016";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.marathone)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialFlatButton mbLogin;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MarathoneTableAdapters.MarathonTableAdapter marathonTableAdapter;
        private Marathone marathone;
        private MetroFramework.Controls.MetroLabel mlTime;
        private MarathoneTableAdapters.EventTableAdapter eventTableAdapter;
        private System.Windows.Forms.Timer timerDay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btInfo;
        private System.Windows.Forms.Button btSponsor;
        private System.Windows.Forms.Button btRunner;
    }
}

