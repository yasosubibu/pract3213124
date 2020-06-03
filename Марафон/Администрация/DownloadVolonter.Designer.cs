namespace Марафон.Администрация
{
    partial class DownloadVolonter
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mtPath = new MetroFramework.Controls.MetroTextBox();
            this.mbOpen = new MetroFramework.Controls.MetroButton();
            this.mbDownload = new MetroFramework.Controls.MetroButton();
            this.mbClose = new MetroFramework.Controls.MetroButton();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.marathone = new Марафон.Marathone();
            this.volunteerTableAdapter = new Марафон.MarathoneTableAdapters.VolunteerTableAdapter();
            this.timerDay = new System.Windows.Forms.Timer(this.components);
            this.eventTableAdapter = new Марафон.MarathoneTableAdapters.EventTableAdapter();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marathone)).BeginInit();
            this.SuspendLayout();
            // 
            // mlTime
            // 
            this.mlTime.AutoSize = true;
            this.mlTime.Location = new System.Drawing.Point(186, 10);
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
            this.panel2.Location = new System.Drawing.Point(20, 310);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(591, 39);
            this.panel2.TabIndex = 31;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(231, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(178, 25);
            this.metroLabel1.TabIndex = 32;
            this.metroLabel1.Text = "Загрузка волонтеров";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(38, 125);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(148, 19);
            this.metroLabel2.TabIndex = 33;
            this.metroLabel2.Text = "CSV файл волонтеров:";
            // 
            // mtPath
            // 
            // 
            // 
            // 
            this.mtPath.CustomButton.Image = null;
            this.mtPath.CustomButton.Location = new System.Drawing.Point(244, 1);
            this.mtPath.CustomButton.Name = "";
            this.mtPath.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtPath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtPath.CustomButton.TabIndex = 1;
            this.mtPath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtPath.CustomButton.UseSelectable = true;
            this.mtPath.CustomButton.Visible = false;
            this.mtPath.Lines = new string[0];
            this.mtPath.Location = new System.Drawing.Point(192, 125);
            this.mtPath.MaxLength = 32767;
            this.mtPath.Name = "mtPath";
            this.mtPath.PasswordChar = '\0';
            this.mtPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtPath.SelectedText = "";
            this.mtPath.SelectionLength = 0;
            this.mtPath.SelectionStart = 0;
            this.mtPath.ShortcutsEnabled = true;
            this.mtPath.Size = new System.Drawing.Size(266, 23);
            this.mtPath.TabIndex = 34;
            this.mtPath.UseSelectable = true;
            this.mtPath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtPath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mbOpen
            // 
            this.mbOpen.Location = new System.Drawing.Point(465, 124);
            this.mbOpen.Name = "mbOpen";
            this.mbOpen.Size = new System.Drawing.Size(91, 23);
            this.mbOpen.TabIndex = 35;
            this.mbOpen.Text = " Просмотр";
            this.mbOpen.UseSelectable = true;
            this.mbOpen.Click += new System.EventHandler(this.mbOpen_Click);
            // 
            // mbDownload
            // 
            this.mbDownload.Location = new System.Drawing.Point(183, 180);
            this.mbDownload.Name = "mbDownload";
            this.mbDownload.Size = new System.Drawing.Size(111, 34);
            this.mbDownload.TabIndex = 35;
            this.mbDownload.Text = "Загрузка";
            this.mbDownload.UseSelectable = true;
            this.mbDownload.Click += new System.EventHandler(this.mbDownload_Click);
            // 
            // mbClose
            // 
            this.mbClose.Location = new System.Drawing.Point(300, 180);
            this.mbClose.Name = "mbClose";
            this.mbClose.Size = new System.Drawing.Size(111, 34);
            this.mbClose.TabIndex = 35;
            this.mbClose.Text = "Отмена";
            this.mbClose.UseSelectable = true;
            this.mbClose.Click += new System.EventHandler(this.mbClose_Click);
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Location = new System.Drawing.Point(91, 265);
            this.metroProgressBar1.Minimum = 1;
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.Size = new System.Drawing.Size(422, 23);
            this.metroProgressBar1.TabIndex = 36;
            this.metroProgressBar1.Value = 1;
            this.metroProgressBar1.Visible = false;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(248, 243);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(172, 19);
            this.metroLabel3.TabIndex = 37;
            this.metroLabel3.Text = "Статус загрузки: ожидание";
            this.metroLabel3.Visible = false;
            // 
            // marathone
            // 
            this.marathone.DataSetName = "Marathone";
            this.marathone.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // volunteerTableAdapter
            // 
            this.volunteerTableAdapter.ClearBeforeFill = true;
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
            // DownloadVolonter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 369);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroProgressBar1);
            this.Controls.Add(this.mbClose);
            this.Controls.Add(this.mbDownload);
            this.Controls.Add(this.mbOpen);
            this.Controls.Add(this.mtPath);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.panel2);
            this.Name = "DownloadVolonter";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Марафон Skills 2017";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.DownloadVolonter_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marathone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel mlTime;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox mtPath;
        private MetroFramework.Controls.MetroButton mbOpen;
        private MetroFramework.Controls.MetroButton mbDownload;
        private MetroFramework.Controls.MetroButton mbClose;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private Marathone marathone;
        private MarathoneTableAdapters.VolunteerTableAdapter volunteerTableAdapter;
        private System.Windows.Forms.Timer timerDay;
        private MarathoneTableAdapters.EventTableAdapter eventTableAdapter;
    }
}