namespace Марафон
{
    partial class PreviousResult
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mComboMarathone = new MetroFramework.Controls.MetroComboBox();
            this.marathonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marathone = new Марафон.Marathone();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mComboDistant = new MetroFramework.Controls.MetroComboBox();
            this.eventTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mComboGender = new MetroFramework.Controls.MetroComboBox();
            this.genderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.mComboCategories = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.marathonNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventTypeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.raceTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.previousResBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myDataSet = new Марафон.MyDataSet();
            this.countryTableAdapter = new Марафон.MarathoneTableAdapters.CountryTableAdapter();
            this.previousResTableAdapter = new Марафон.MyDataSetTableAdapters.PreviousResTableAdapter();
            this.genderTableAdapter = new Марафон.MarathoneTableAdapters.GenderTableAdapter();
            this.eventTypeTableAdapter = new Марафон.MarathoneTableAdapters.EventTypeTableAdapter();
            this.marathonTableAdapter = new Марафон.MarathoneTableAdapters.MarathonTableAdapter();
            this.mlClear = new MetroFramework.Controls.MetroLink();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mlTime = new MetroFramework.Controls.MetroLabel();
            this.timerDay = new System.Windows.Forms.Timer(this.components);
            this.eventTableAdapter = new Марафон.MarathoneTableAdapters.EventTableAdapter();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.marathonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marathone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previousResBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mComboMarathone
            // 
            this.mComboMarathone.DataSource = this.marathonBindingSource;
            this.mComboMarathone.DisplayMember = "MarathonName";
            this.mComboMarathone.FormattingEnabled = true;
            this.mComboMarathone.ItemHeight = 23;
            this.mComboMarathone.Location = new System.Drawing.Point(104, 118);
            this.mComboMarathone.Name = "mComboMarathone";
            this.mComboMarathone.Size = new System.Drawing.Size(164, 29);
            this.mComboMarathone.TabIndex = 0;
            this.mComboMarathone.UseSelectable = true;
            this.mComboMarathone.ValueMember = "MarathonId";
            this.mComboMarathone.SelectedIndexChanged += new System.EventHandler(this.mComboMarathone_SelectedIndexChanged);
            // 
            // marathonBindingSource
            // 
            this.marathonBindingSource.DataMember = "Marathon";
            this.marathonBindingSource.DataSource = this.marathone;
            // 
            // marathone
            // 
            this.marathone.DataSetName = "Marathone";
            this.marathone.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 123);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(68, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Марафон";
            // 
            // mComboDistant
            // 
            this.mComboDistant.DataSource = this.eventTypeBindingSource;
            this.mComboDistant.DisplayMember = "EventTypeName";
            this.mComboDistant.FormattingEnabled = true;
            this.mComboDistant.ItemHeight = 23;
            this.mComboDistant.Location = new System.Drawing.Point(104, 157);
            this.mComboDistant.Name = "mComboDistant";
            this.mComboDistant.Size = new System.Drawing.Size(164, 29);
            this.mComboDistant.TabIndex = 0;
            this.mComboDistant.UseSelectable = true;
            this.mComboDistant.ValueMember = "EventTypeId";
            this.mComboDistant.SelectedIndexChanged += new System.EventHandler(this.mComboDistant_SelectedIndexChanged);
            // 
            // eventTypeBindingSource
            // 
            this.eventTypeBindingSource.DataMember = "EventType";
            this.eventTypeBindingSource.DataSource = this.marathone;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 162);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(75, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Дистанция";
            // 
            // mComboGender
            // 
            this.mComboGender.DataSource = this.genderBindingSource;
            this.mComboGender.DisplayMember = "Gender";
            this.mComboGender.FormattingEnabled = true;
            this.mComboGender.ItemHeight = 23;
            this.mComboGender.Location = new System.Drawing.Point(495, 113);
            this.mComboGender.Name = "mComboGender";
            this.mComboGender.Size = new System.Drawing.Size(164, 29);
            this.mComboGender.TabIndex = 0;
            this.mComboGender.UseSelectable = true;
            this.mComboGender.ValueMember = "Gender";
            this.mComboGender.SelectedIndexChanged += new System.EventHandler(this.mComboGender_SelectedIndexChanged);
            // 
            // genderBindingSource
            // 
            this.genderBindingSource.DataMember = "Gender";
            this.genderBindingSource.DataSource = this.marathone;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(414, 118);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(33, 19);
            this.metroLabel3.TabIndex = 1;
            this.metroLabel3.Text = "Пол";
            // 
            // mComboCategories
            // 
            this.mComboCategories.FormattingEnabled = true;
            this.mComboCategories.ItemHeight = 23;
            this.mComboCategories.Items.AddRange(new object[] {
            "до 18",
            "от 18 до 29",
            "от 30 до 39",
            "от 40 до 55",
            "от 56 до 70",
            "более 70"});
            this.mComboCategories.Location = new System.Drawing.Point(495, 152);
            this.mComboCategories.Name = "mComboCategories";
            this.mComboCategories.Size = new System.Drawing.Size(164, 29);
            this.mComboCategories.TabIndex = 0;
            this.mComboCategories.UseSelectable = true;
            this.mComboCategories.SelectedIndexChanged += new System.EventHandler(this.mComboCategories_SelectedIndexChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(414, 157);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(71, 19);
            this.metroLabel4.TabIndex = 1;
            this.metroLabel4.Text = "Категория";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(20, 222);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(117, 19);
            this.metroLabel5.TabIndex = 2;
            this.metroLabel5.Text = "Всего бегунов: 43";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(225, 222);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(128, 19);
            this.metroLabel6.TabIndex = 2;
            this.metroLabel6.Text = "Финишировало: 35";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(409, 222);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(250, 19);
            this.metroLabel7.TabIndex = 2;
            this.metroLabel7.Text = "Среднее время: 2 часа 3 минуты 25 сек";
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
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.marathonNameDataGridViewTextBoxColumn,
            this.eventTypeNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.countryCodeDataGridViewTextBoxColumn,
            this.raceTimeDataGridViewTextBoxColumn,
            this.Gender,
            this.DateOfBirth});
            this.metroGrid1.DataSource = this.previousResBindingSource;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle26;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(20, 244);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(639, 310);
            this.metroGrid1.TabIndex = 3;
            // 
            // marathonNameDataGridViewTextBoxColumn
            // 
            this.marathonNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.marathonNameDataGridViewTextBoxColumn.DataPropertyName = "MarathonName";
            this.marathonNameDataGridViewTextBoxColumn.HeaderText = "Марафон";
            this.marathonNameDataGridViewTextBoxColumn.Name = "marathonNameDataGridViewTextBoxColumn";
            this.marathonNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.marathonNameDataGridViewTextBoxColumn.Width = 82;
            // 
            // eventTypeNameDataGridViewTextBoxColumn
            // 
            this.eventTypeNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.eventTypeNameDataGridViewTextBoxColumn.DataPropertyName = "EventTypeName";
            this.eventTypeNameDataGridViewTextBoxColumn.HeaderText = "Дистанция";
            this.eventTypeNameDataGridViewTextBoxColumn.Name = "eventTypeNameDataGridViewTextBoxColumn";
            this.eventTypeNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.eventTypeNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firstNameDataGridViewTextBoxColumn.Width = 52;
            // 
            // countryCodeDataGridViewTextBoxColumn
            // 
            this.countryCodeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.countryCodeDataGridViewTextBoxColumn.DataPropertyName = "CountryCode";
            this.countryCodeDataGridViewTextBoxColumn.DataSource = this.countryBindingSource;
            this.countryCodeDataGridViewTextBoxColumn.DisplayMember = "CountryName";
            this.countryCodeDataGridViewTextBoxColumn.HeaderText = "Страна";
            this.countryCodeDataGridViewTextBoxColumn.Name = "countryCodeDataGridViewTextBoxColumn";
            this.countryCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.countryCodeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.countryCodeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.countryCodeDataGridViewTextBoxColumn.ValueMember = "CountryCode";
            this.countryCodeDataGridViewTextBoxColumn.Width = 68;
            // 
            // countryBindingSource
            // 
            this.countryBindingSource.DataMember = "Country";
            this.countryBindingSource.DataSource = this.marathone;
            // 
            // raceTimeDataGridViewTextBoxColumn
            // 
            this.raceTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.raceTimeDataGridViewTextBoxColumn.DataPropertyName = "RaceTime";
            this.raceTimeDataGridViewTextBoxColumn.HeaderText = "Время";
            this.raceTimeDataGridViewTextBoxColumn.Name = "raceTimeDataGridViewTextBoxColumn";
            this.raceTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.raceTimeDataGridViewTextBoxColumn.Width = 5;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Пол";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            this.Gender.Visible = false;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.DataPropertyName = "DateOfBirth";
            this.DateOfBirth.HeaderText = "Дата рождения";
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.ReadOnly = true;
            this.DateOfBirth.Visible = false;
            // 
            // previousResBindingSource
            // 
            this.previousResBindingSource.DataMember = "PreviousRes";
            this.previousResBindingSource.DataSource = this.myDataSet;
            // 
            // myDataSet
            // 
            this.myDataSet.DataSetName = "MyDataSet";
            this.myDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // countryTableAdapter
            // 
            this.countryTableAdapter.ClearBeforeFill = true;
            // 
            // previousResTableAdapter
            // 
            this.previousResTableAdapter.ClearBeforeFill = true;
            // 
            // genderTableAdapter
            // 
            this.genderTableAdapter.ClearBeforeFill = true;
            // 
            // eventTypeTableAdapter
            // 
            this.eventTypeTableAdapter.ClearBeforeFill = true;
            // 
            // marathonTableAdapter
            // 
            this.marathonTableAdapter.ClearBeforeFill = true;
            // 
            // mlClear
            // 
            this.mlClear.Location = new System.Drawing.Point(546, 186);
            this.mlClear.Margin = new System.Windows.Forms.Padding(2);
            this.mlClear.Name = "mlClear";
            this.mlClear.Size = new System.Drawing.Size(111, 21);
            this.mlClear.TabIndex = 4;
            this.mlClear.Text = "Очистить фильтр";
            this.mlClear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mlClear.UseSelectable = true;
            this.mlClear.Click += new System.EventHandler(this.mlClear_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.mlTime);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(20, 560);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(640, 39);
            this.panel2.TabIndex = 19;
            // 
            // mlTime
            // 
            this.mlTime.AutoSize = true;
            this.mlTime.Location = new System.Drawing.Point(236, 9);
            this.mlTime.Name = "mlTime";
            this.mlTime.Size = new System.Drawing.Size(191, 19);
            this.mlTime.TabIndex = 3;
            this.mlTime.Text = "Осталось 2 дня 3 часа 23 мин";
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
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.Location = new System.Drawing.Point(242, 69);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(205, 25);
            this.metroLabel8.TabIndex = 20;
            this.metroLabel8.Text = "Результаты прошлых лет";
            // 
            // PreviousResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 619);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.mlClear);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.mComboCategories);
            this.Controls.Add(this.mComboDistant);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.mComboGender);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mComboMarathone);
            this.Name = "PreviousResult";
            this.Text = "Марафон Skills 2017";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PreviousResult_FormClosed);
            this.Load += new System.EventHandler(this.PreviousResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.marathonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marathone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previousResBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox mComboMarathone;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox mComboDistant;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox mComboGender;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox mComboCategories;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MyDataSet myDataSet;
        private System.Windows.Forms.BindingSource previousResBindingSource;
        private MyDataSetTableAdapters.PreviousResTableAdapter previousResTableAdapter;
        private Marathone marathone;
        private System.Windows.Forms.BindingSource countryBindingSource;
        private MarathoneTableAdapters.CountryTableAdapter countryTableAdapter;
        private System.Windows.Forms.BindingSource genderBindingSource;
        private MarathoneTableAdapters.GenderTableAdapter genderTableAdapter;
        private System.Windows.Forms.BindingSource eventTypeBindingSource;
        private MarathoneTableAdapters.EventTypeTableAdapter eventTypeTableAdapter;
        private System.Windows.Forms.BindingSource marathonBindingSource;
        private MarathoneTableAdapters.MarathonTableAdapter marathonTableAdapter;
        private MetroFramework.Controls.MetroLink mlClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn marathonNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventTypeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn countryCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn raceTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirth;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroLabel mlTime;
        private System.Windows.Forms.Timer timerDay;
        private MarathoneTableAdapters.EventTableAdapter eventTableAdapter;
        private MetroFramework.Controls.MetroLabel metroLabel8;
    }
}