namespace Марафон
{
    partial class AdminAddBlagoFond
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
            this.mtNaimenovanie = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mtOpisanie = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.mtPath = new MetroFramework.Controls.MetroTextBox();
            this.mbChoose = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.mbSave = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mbCancel = new MaterialSkin.Controls.MaterialFlatButton();
            this.charityTableAdapter = new Марафон.MarathoneTableAdapters.CharityTableAdapter();
            this.marathone = new Марафон.Marathone();
            this.mlTime = new MetroFramework.Controls.MetroLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.timerDay = new System.Windows.Forms.Timer(this.components);
            this.eventTableAdapter = new Марафон.MarathoneTableAdapters.EventTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marathone)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(27, 103);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(102, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Наименование";
            // 
            // mtNaimenovanie
            // 
            // 
            // 
            // 
            this.mtNaimenovanie.CustomButton.Image = null;
            this.mtNaimenovanie.CustomButton.Location = new System.Drawing.Point(192, 2);
            this.mtNaimenovanie.CustomButton.Name = "";
            this.mtNaimenovanie.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtNaimenovanie.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtNaimenovanie.CustomButton.TabIndex = 1;
            this.mtNaimenovanie.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtNaimenovanie.CustomButton.UseSelectable = true;
            this.mtNaimenovanie.CustomButton.Visible = false;
            this.mtNaimenovanie.Lines = new string[0];
            this.mtNaimenovanie.Location = new System.Drawing.Point(27, 126);
            this.mtNaimenovanie.MaxLength = 32767;
            this.mtNaimenovanie.Multiline = true;
            this.mtNaimenovanie.Name = "mtNaimenovanie";
            this.mtNaimenovanie.PasswordChar = '\0';
            this.mtNaimenovanie.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtNaimenovanie.SelectedText = "";
            this.mtNaimenovanie.SelectionLength = 0;
            this.mtNaimenovanie.SelectionStart = 0;
            this.mtNaimenovanie.ShortcutsEnabled = true;
            this.mtNaimenovanie.Size = new System.Drawing.Size(216, 26);
            this.mtNaimenovanie.TabIndex = 1;
            this.mtNaimenovanie.UseSelectable = true;
            this.mtNaimenovanie.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtNaimenovanie.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mtNaimenovanie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtNaimenovanie_KeyPress);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(27, 155);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(72, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Описание";
            // 
            // mtOpisanie
            // 
            // 
            // 
            // 
            this.mtOpisanie.CustomButton.Image = null;
            this.mtOpisanie.CustomButton.Location = new System.Drawing.Point(92, 2);
            this.mtOpisanie.CustomButton.Name = "";
            this.mtOpisanie.CustomButton.Size = new System.Drawing.Size(121, 121);
            this.mtOpisanie.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtOpisanie.CustomButton.TabIndex = 1;
            this.mtOpisanie.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtOpisanie.CustomButton.UseSelectable = true;
            this.mtOpisanie.CustomButton.Visible = false;
            this.mtOpisanie.Lines = new string[0];
            this.mtOpisanie.Location = new System.Drawing.Point(27, 178);
            this.mtOpisanie.MaxLength = 32767;
            this.mtOpisanie.Multiline = true;
            this.mtOpisanie.Name = "mtOpisanie";
            this.mtOpisanie.PasswordChar = '\0';
            this.mtOpisanie.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtOpisanie.SelectedText = "";
            this.mtOpisanie.SelectionLength = 0;
            this.mtOpisanie.SelectionStart = 0;
            this.mtOpisanie.ShortcutsEnabled = true;
            this.mtOpisanie.Size = new System.Drawing.Size(216, 126);
            this.mtOpisanie.TabIndex = 1;
            this.mtOpisanie.UseSelectable = true;
            this.mtOpisanie.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtOpisanie.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(348, 133);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(77, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Лого файл:";
            // 
            // mtPath
            // 
            // 
            // 
            // 
            this.mtPath.CustomButton.Image = null;
            this.mtPath.CustomButton.Location = new System.Drawing.Point(146, 1);
            this.mtPath.CustomButton.Name = "";
            this.mtPath.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtPath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtPath.CustomButton.TabIndex = 1;
            this.mtPath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtPath.CustomButton.UseSelectable = true;
            this.mtPath.CustomButton.Visible = false;
            this.mtPath.Lines = new string[0];
            this.mtPath.Location = new System.Drawing.Point(431, 133);
            this.mtPath.MaxLength = 32767;
            this.mtPath.Name = "mtPath";
            this.mtPath.PasswordChar = '\0';
            this.mtPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtPath.SelectedText = "";
            this.mtPath.SelectionLength = 0;
            this.mtPath.SelectionStart = 0;
            this.mtPath.ShortcutsEnabled = true;
            this.mtPath.Size = new System.Drawing.Size(168, 23);
            this.mtPath.TabIndex = 3;
            this.mtPath.UseSelectable = true;
            this.mtPath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtPath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mbChoose
            // 
            this.mbChoose.Location = new System.Drawing.Point(605, 133);
            this.mbChoose.Name = "mbChoose";
            this.mbChoose.Size = new System.Drawing.Size(75, 23);
            this.mbChoose.TabIndex = 4;
            this.mbChoose.Text = "Выбрать";
            this.mbChoose.UseSelectable = true;
            this.mbChoose.Click += new System.EventHandler(this.mbChoose_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(458, 174);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(115, 19);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "Текущий логотип";
            // 
            // pbImage
            // 
            this.pbImage.Image = global::Марафон.Properties.Resources.icon_vk;
            this.pbImage.Location = new System.Drawing.Point(445, 196);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(138, 126);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 6;
            this.pbImage.TabStop = false;
            // 
            // mbSave
            // 
            this.mbSave.Depth = 0;
            this.mbSave.Location = new System.Drawing.Point(567, 341);
            this.mbSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbSave.Name = "mbSave";
            this.mbSave.Primary = true;
            this.mbSave.Size = new System.Drawing.Size(117, 43);
            this.mbSave.TabIndex = 7;
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
            this.mbCancel.Location = new System.Drawing.Point(27, 348);
            this.mbCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbCancel.Name = "mbCancel";
            this.mbCancel.Primary = false;
            this.mbCancel.Size = new System.Drawing.Size(68, 36);
            this.mbCancel.TabIndex = 8;
            this.mbCancel.Text = "Отмена";
            this.mbCancel.UseVisualStyleBackColor = true;
            // 
            // charityTableAdapter
            // 
            this.charityTableAdapter.ClearBeforeFill = true;
            // 
            // marathone
            // 
            this.marathone.DataSetName = "Marathone";
            this.marathone.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mlTime
            // 
            this.mlTime.AutoSize = true;
            this.mlTime.Location = new System.Drawing.Point(252, 11);
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
            this.panel2.Location = new System.Drawing.Point(20, 390);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(664, 39);
            this.panel2.TabIndex = 31;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(182, 69);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(357, 25);
            this.metroLabel5.TabIndex = 32;
            this.metroLabel5.Text = "Добавить благотворительную организацию";
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
            // AdminAddBlagoFond
            // 
            this.AcceptButton = this.mbSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.mbCancel;
            this.ClientSize = new System.Drawing.Size(704, 449);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.mbCancel);
            this.Controls.Add(this.mbSave);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.mbChoose);
            this.Controls.Add(this.mtPath);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.mtOpisanie);
            this.Controls.Add(this.mtNaimenovanie);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "AdminAddBlagoFond";
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "Марафон Skills 2017";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.AdminAddBlagoFond_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marathone)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox mtNaimenovanie;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox mtOpisanie;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox mtPath;
        private MetroFramework.Controls.MetroButton mbChoose;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.PictureBox pbImage;
        private MaterialSkin.Controls.MaterialRaisedButton mbSave;
        private MaterialSkin.Controls.MaterialFlatButton mbCancel;
        private MarathoneTableAdapters.CharityTableAdapter charityTableAdapter;
        private Marathone marathone;
        private MetroFramework.Controls.MetroLabel mlTime;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.Timer timerDay;
        private MarathoneTableAdapters.EventTableAdapter eventTableAdapter;
    }
}