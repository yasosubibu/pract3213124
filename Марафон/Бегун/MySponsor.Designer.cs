namespace Марафон
{
    partial class MySponsor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mySponsorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myDataSet = new Марафон.MyDataSet();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.sponsorshipIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sponsorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CharityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CharityDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrationIdFKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.runnerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CharityLogo1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.mySponsorTableAdapter = new Марафон.MyDataSetTableAdapters.MySponsorTableAdapter();
            this.mlTime = new MetroFramework.Controls.MetroLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.timerDay = new System.Windows.Forms.Timer(this.components);
            this.eventTableAdapter = new Марафон.MarathoneTableAdapters.EventTableAdapter();
            this.marathone = new Марафон.Marathone();
            ((System.ComponentModel.ISupportInitialize)(this.mySponsorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marathone)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mySponsorBindingSource, "CharityName", true));
            this.metroLabel1.Location = new System.Drawing.Point(58, 112);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(196, 38);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Название благотворительной \r\nораганизации";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mySponsorBindingSource
            // 
            this.mySponsorBindingSource.DataMember = "MySponsor";
            this.mySponsorBindingSource.DataSource = this.myDataSet;
            // 
            // myDataSet
            // 
            this.myDataSet.DataSetName = "MyDataSet";
            this.myDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.mySponsorBindingSource, "CharityLogo1", true));
            this.pictureBox1.Image = global::Марафон.Properties.Resources.icon_vk;
            this.pictureBox1.Location = new System.Drawing.Point(58, 162);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mySponsorBindingSource, "CharityDescription", true));
            this.metroLabel2.Location = new System.Drawing.Point(20, 285);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(278, 57);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Описание: крупная помощь нужна всем, \r\nа нам лишь малая капля, которая поможет \r\n" +
    "нашим пёсикам";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.AutoGenerateColumns = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sponsorshipIdDataGridViewTextBoxColumn,
            this.sponsorNameDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.CharityName,
            this.CharityDescription,
            this.registrationIDDataGridViewTextBoxColumn,
            this.registrationIdFKDataGridViewTextBoxColumn,
            this.runnerIDDataGridViewTextBoxColumn,
            this.CharityLogo1});
            this.metroGrid1.DataSource = this.mySponsorBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(340, 112);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(240, 192);
            this.metroGrid1.TabIndex = 2;
            // 
            // sponsorshipIdDataGridViewTextBoxColumn
            // 
            this.sponsorshipIdDataGridViewTextBoxColumn.DataPropertyName = "SponsorshipId";
            this.sponsorshipIdDataGridViewTextBoxColumn.HeaderText = "SponsorshipId";
            this.sponsorshipIdDataGridViewTextBoxColumn.Name = "sponsorshipIdDataGridViewTextBoxColumn";
            this.sponsorshipIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.sponsorshipIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // sponsorNameDataGridViewTextBoxColumn
            // 
            this.sponsorNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.sponsorNameDataGridViewTextBoxColumn.DataPropertyName = "SponsorName";
            this.sponsorNameDataGridViewTextBoxColumn.HeaderText = "Спонсор";
            this.sponsorNameDataGridViewTextBoxColumn.Name = "sponsorNameDataGridViewTextBoxColumn";
            this.sponsorNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.sponsorNameDataGridViewTextBoxColumn.Width = 77;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Сумма";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            this.amountDataGridViewTextBoxColumn.Width = 64;
            // 
            // CharityName
            // 
            this.CharityName.DataPropertyName = "CharityName";
            this.CharityName.HeaderText = "Название благотворительной организации";
            this.CharityName.Name = "CharityName";
            this.CharityName.ReadOnly = true;
            this.CharityName.Visible = false;
            // 
            // CharityDescription
            // 
            this.CharityDescription.DataPropertyName = "CharityDescription";
            this.CharityDescription.HeaderText = "Описание благотворительной ораганизации";
            this.CharityDescription.Name = "CharityDescription";
            this.CharityDescription.ReadOnly = true;
            this.CharityDescription.Visible = false;
            // 
            // registrationIDDataGridViewTextBoxColumn
            // 
            this.registrationIDDataGridViewTextBoxColumn.DataPropertyName = "RegistrationID";
            this.registrationIDDataGridViewTextBoxColumn.HeaderText = "RegistrationID";
            this.registrationIDDataGridViewTextBoxColumn.Name = "registrationIDDataGridViewTextBoxColumn";
            this.registrationIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.registrationIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // registrationIdFKDataGridViewTextBoxColumn
            // 
            this.registrationIdFKDataGridViewTextBoxColumn.DataPropertyName = "RegistrationIdFK";
            this.registrationIdFKDataGridViewTextBoxColumn.HeaderText = "RegistrationIdFK";
            this.registrationIdFKDataGridViewTextBoxColumn.Name = "registrationIdFKDataGridViewTextBoxColumn";
            this.registrationIdFKDataGridViewTextBoxColumn.ReadOnly = true;
            this.registrationIdFKDataGridViewTextBoxColumn.Visible = false;
            // 
            // runnerIDDataGridViewTextBoxColumn
            // 
            this.runnerIDDataGridViewTextBoxColumn.DataPropertyName = "RunnerID";
            this.runnerIDDataGridViewTextBoxColumn.HeaderText = "RunnerID";
            this.runnerIDDataGridViewTextBoxColumn.Name = "runnerIDDataGridViewTextBoxColumn";
            this.runnerIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.runnerIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // CharityLogo1
            // 
            this.CharityLogo1.DataPropertyName = "CharityLogo1";
            this.CharityLogo1.HeaderText = "CharityLogo1";
            this.CharityLogo1.Name = "CharityLogo1";
            this.CharityLogo1.ReadOnly = true;
            this.CharityLogo1.Visible = false;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(500, 307);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(80, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Итого: 500$";
            // 
            // mySponsorTableAdapter
            // 
            this.mySponsorTableAdapter.ClearBeforeFill = true;
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
            this.panel2.Location = new System.Drawing.Point(20, 356);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(564, 39);
            this.panel2.TabIndex = 26;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(239, 72);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(130, 25);
            this.metroLabel4.TabIndex = 27;
            this.metroLabel4.Text = "Мои спонсоры";
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
            // marathone
            // 
            this.marathone.DataSetName = "Marathone";
            this.marathone.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MySponsor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 415);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "MySponsor";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Марафон Skills 2017";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.MySponsor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mySponsorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marathone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MyDataSet myDataSet;
        private System.Windows.Forms.BindingSource mySponsorBindingSource;
        private MyDataSetTableAdapters.MySponsorTableAdapter mySponsorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sponsorshipIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sponsorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CharityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CharityDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationIdFKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn runnerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn CharityLogo1;
        private MetroFramework.Controls.MetroLabel mlTime;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.Timer timerDay;
        private MarathoneTableAdapters.EventTableAdapter eventTableAdapter;
        private Marathone marathone;
    }
}