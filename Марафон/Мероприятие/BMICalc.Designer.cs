namespace Марафон
{
    partial class BMICalc
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.mtWeight = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.mlMassa = new MaterialSkin.Controls.MaterialLabel();
            this.mtMassa = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.mbCancel = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroTrackBar1 = new MetroFramework.Controls.MetroTrackBar();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mRadioBoy = new MaterialSkin.Controls.MaterialRadioButton();
            this.mRadioGirl = new MaterialSkin.Controls.MaterialRadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.mlTime = new MetroFramework.Controls.MetroLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.timerDay = new System.Windows.Forms.Timer(this.components);
            this.marathone = new Марафон.Marathone();
            this.eventTableAdapter = new Марафон.MarathoneTableAdapters.EventTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marathone)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(72, 114);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(324, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Мы покажем ваш уровень здоровья для марафона";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(24, 290);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(42, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Рост";
            // 
            // mtWeight
            // 
            this.mtWeight.Depth = 0;
            this.mtWeight.Hint = "";
            this.mtWeight.Location = new System.Drawing.Point(89, 290);
            this.mtWeight.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtWeight.Name = "mtWeight";
            this.mtWeight.PasswordChar = '\0';
            this.mtWeight.SelectedText = "";
            this.mtWeight.SelectionLength = 0;
            this.mtWeight.SelectionStart = 0;
            this.mtWeight.Size = new System.Drawing.Size(91, 23);
            this.mtWeight.TabIndex = 3;
            this.mtWeight.UseSystemPasswordChar = false;
            // 
            // mlMassa
            // 
            this.mlMassa.AutoSize = true;
            this.mlMassa.Depth = 0;
            this.mlMassa.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlMassa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlMassa.Location = new System.Drawing.Point(24, 322);
            this.mlMassa.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlMassa.Name = "mlMassa";
            this.mlMassa.Size = new System.Drawing.Size(34, 19);
            this.mlMassa.TabIndex = 2;
            this.mlMassa.Text = "Вес";
            // 
            // mtMassa
            // 
            this.mtMassa.Depth = 0;
            this.mtMassa.Hint = "";
            this.mtMassa.Location = new System.Drawing.Point(89, 322);
            this.mtMassa.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtMassa.Name = "mtMassa";
            this.mtMassa.PasswordChar = '\0';
            this.mtMassa.SelectedText = "";
            this.mtMassa.SelectionLength = 0;
            this.mtMassa.SelectionStart = 0;
            this.mtMassa.Size = new System.Drawing.Size(91, 23);
            this.mtMassa.TabIndex = 3;
            this.mtMassa.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(184, 295);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(28, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "см";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(185, 328);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(23, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "кг";
            // 
            // mbCancel
            // 
            this.mbCancel.AutoSize = true;
            this.mbCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbCancel.Depth = 0;
            this.mbCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.mbCancel.Location = new System.Drawing.Point(23, 373);
            this.mbCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbCancel.Name = "mbCancel";
            this.mbCancel.Primary = false;
            this.mbCancel.Size = new System.Drawing.Size(68, 36);
            this.mbCancel.TabIndex = 4;
            this.mbCancel.Text = "Отмена";
            this.mbCancel.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(116, 373);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(106, 32);
            this.materialRaisedButton1.TabIndex = 5;
            this.materialRaisedButton1.Text = "Расчитать";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Марафон.Properties.Resources.priest;
            this.pictureBox1.Location = new System.Drawing.Point(290, 154);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // metroTrackBar1
            // 
            this.metroTrackBar1.BackColor = System.Drawing.Color.Transparent;
            this.metroTrackBar1.Location = new System.Drawing.Point(270, 373);
            this.metroTrackBar1.Name = "metroTrackBar1";
            this.metroTrackBar1.Size = new System.Drawing.Size(193, 23);
            this.metroTrackBar1.TabIndex = 7;
            this.metroTrackBar1.Text = "metroTrackBar1";
            this.metroTrackBar1.Value = 95;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(311, 351);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(101, 19);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Здоровый 95%";
            // 
            // mRadioBoy
            // 
            this.mRadioBoy.AutoSize = true;
            this.mRadioBoy.Depth = 0;
            this.mRadioBoy.Font = new System.Drawing.Font("Roboto", 10F);
            this.mRadioBoy.Location = new System.Drawing.Point(133, 247);
            this.mRadioBoy.Margin = new System.Windows.Forms.Padding(0);
            this.mRadioBoy.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mRadioBoy.MouseState = MaterialSkin.MouseState.HOVER;
            this.mRadioBoy.Name = "mRadioBoy";
            this.mRadioBoy.Ripple = true;
            this.mRadioBoy.Size = new System.Drawing.Size(89, 30);
            this.mRadioBoy.TabIndex = 9;
            this.mRadioBoy.TabStop = true;
            this.mRadioBoy.Text = "Мужчина";
            this.mRadioBoy.UseVisualStyleBackColor = true;
            // 
            // mRadioGirl
            // 
            this.mRadioGirl.AutoSize = true;
            this.mRadioGirl.Depth = 0;
            this.mRadioGirl.Font = new System.Drawing.Font("Roboto", 10F);
            this.mRadioGirl.Location = new System.Drawing.Point(28, 247);
            this.mRadioGirl.Margin = new System.Windows.Forms.Padding(0);
            this.mRadioGirl.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mRadioGirl.MouseState = MaterialSkin.MouseState.HOVER;
            this.mRadioGirl.Name = "mRadioGirl";
            this.mRadioGirl.Ripple = true;
            this.mRadioGirl.Size = new System.Drawing.Size(87, 30);
            this.mRadioGirl.TabIndex = 9;
            this.mRadioGirl.TabStop = true;
            this.mRadioGirl.Text = "Девушка";
            this.mRadioGirl.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Марафон.Properties.Resources.margodispicableme2icon;
            this.pictureBox2.Location = new System.Drawing.Point(37, 154);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(87, 79);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Марафон.Properties.Resources.boy;
            this.pictureBox3.Location = new System.Drawing.Point(144, 154);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(87, 79);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // mlTime
            // 
            this.mlTime.AutoSize = true;
            this.mlTime.Location = new System.Drawing.Point(124, 11);
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
            this.panel2.Location = new System.Drawing.Point(20, 425);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(446, 39);
            this.panel2.TabIndex = 14;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(172, 73);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(140, 25);
            this.metroLabel3.TabIndex = 15;
            this.metroLabel3.Text = "BMI калькулятор";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerDay
            // 
            this.timerDay.Interval = 1000;
            this.timerDay.Tick += new System.EventHandler(this.timerDay_Tick);
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
            // BMICalc
            // 
            this.AcceptButton = this.materialRaisedButton1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.mbCancel;
            this.ClientSize = new System.Drawing.Size(486, 484);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.mRadioGirl);
            this.Controls.Add(this.mRadioBoy);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroTrackBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.mbCancel);
            this.Controls.Add(this.mtMassa);
            this.Controls.Add(this.mtWeight);
            this.Controls.Add(this.mlMassa);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.metroLabel1);
            this.Name = "BMICalc";
            this.Text = "Марафон Skills 2017";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BMICalc_FormClosed);
            this.Load += new System.EventHandler(this.BMICalc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marathone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField mtWeight;
        private MaterialSkin.Controls.MaterialLabel mlMassa;
        private MaterialSkin.Controls.MaterialSingleLineTextField mtMassa;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialFlatButton mbCancel;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTrackBar metroTrackBar1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MaterialSkin.Controls.MaterialRadioButton mRadioBoy;
        private MaterialSkin.Controls.MaterialRadioButton mRadioGirl;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private MetroFramework.Controls.MetroLabel mlTime;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.Timer timerDay;
        private Marathone marathone;
        private MarathoneTableAdapters.EventTableAdapter eventTableAdapter;
    }
}