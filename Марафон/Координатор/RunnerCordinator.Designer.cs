namespace Марафон
{
    partial class RunnerCordinator
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mComboDistant = new MetroFramework.Controls.MetroComboBox();
            this.eventTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marathone = new Марафон.Marathone();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.mComboStatus = new MetroFramework.Controls.MetroComboBox();
            this.registrationStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.mGroupGroup = new MetroFramework.Controls.MetroComboBox();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.mTileEmailList = new MetroFramework.Controls.MetroTile();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.myDataSet = new Марафон.MyDataSet();
            this.mbClearFilter = new MetroFramework.Controls.MetroButton();
            this.registrationStatusTableAdapter = new Марафон.MarathoneTableAdapters.RegistrationStatusTableAdapter();
            this.eventTypeTableAdapter = new Марафон.MarathoneTableAdapters.EventTypeTableAdapter();
            this.metroGrid2 = new MetroFramework.Controls.MetroGrid();
            this.registrationIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrationStatusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditNew = new System.Windows.Forms.DataGridViewButtonColumn();
            this.runCordinatorNewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.runCordinatorNewTableAdapter = new Марафон.MyDataSetTableAdapters.RunCordinatorNewTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mlTime = new MetroFramework.Controls.MetroLabel();
            this.eventTableAdapter = new Марафон.MarathoneTableAdapters.EventTableAdapter();
            this.timerDay = new System.Windows.Forms.Timer(this.components);
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.eventTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marathone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.runCordinatorNewBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(119, 91);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(68, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Фильтр";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(24, 166);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(75, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Дистанция";
            // 
            // mComboDistant
            // 
            this.mComboDistant.DataSource = this.eventTypeBindingSource;
            this.mComboDistant.DisplayMember = "EventTypeName";
            this.mComboDistant.FormattingEnabled = true;
            this.mComboDistant.ItemHeight = 23;
            this.mComboDistant.Location = new System.Drawing.Point(144, 160);
            this.mComboDistant.Name = "mComboDistant";
            this.mComboDistant.Size = new System.Drawing.Size(155, 29);
            this.mComboDistant.TabIndex = 2;
            this.mComboDistant.UseSelectable = true;
            this.mComboDistant.ValueMember = "EventTypeId";
            this.mComboDistant.SelectedIndexChanged += new System.EventHandler(this.mComboDistant_SelectedIndexChanged);
            // 
            // eventTypeBindingSource
            // 
            this.eventTypeBindingSource.DataMember = "EventType";
            this.eventTypeBindingSource.DataSource = this.marathone;
            // 
            // marathone
            // 
            this.marathone.DataSetName = "Marathone";
            this.marathone.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(24, 135);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(47, 19);
            this.metroLabel3.TabIndex = 1;
            this.metroLabel3.Text = "Статус";
            // 
            // mComboStatus
            // 
            this.mComboStatus.DataSource = this.registrationStatusBindingSource;
            this.mComboStatus.DisplayMember = "RegistrationStatus";
            this.mComboStatus.FormattingEnabled = true;
            this.mComboStatus.ItemHeight = 23;
            this.mComboStatus.Location = new System.Drawing.Point(144, 125);
            this.mComboStatus.Name = "mComboStatus";
            this.mComboStatus.Size = new System.Drawing.Size(155, 29);
            this.mComboStatus.TabIndex = 2;
            this.mComboStatus.UseSelectable = true;
            this.mComboStatus.ValueMember = "RegistrationStatusId";
            this.mComboStatus.SelectedIndexChanged += new System.EventHandler(this.mComboStatus_SelectedIndexChanged);
            // 
            // registrationStatusBindingSource
            // 
            this.registrationStatusBindingSource.DataMember = "RegistrationStatus";
            this.registrationStatusBindingSource.DataSource = this.marathone;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(24, 198);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(114, 19);
            this.metroLabel4.TabIndex = 1;
            this.metroLabel4.Text = "Группировать по";
            // 
            // mGroupGroup
            // 
            this.mGroupGroup.FormattingEnabled = true;
            this.mGroupGroup.ItemHeight = 23;
            this.mGroupGroup.Items.AddRange(new object[] {
            "Имя",
            "Фамилия",
            "Почта"});
            this.mGroupGroup.Location = new System.Drawing.Point(144, 195);
            this.mGroupGroup.Name = "mGroupGroup";
            this.mGroupGroup.Size = new System.Drawing.Size(155, 29);
            this.mGroupGroup.TabIndex = 2;
            this.mGroupGroup.UseSelectable = true;
            this.mGroupGroup.SelectedIndexChanged += new System.EventHandler(this.mGroupGroup_SelectedIndexChanged);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroTile1.Location = new System.Drawing.Point(372, 135);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(176, 57);
            this.metroTile1.TabIndex = 3;
            this.metroTile1.Text = "Детальная информация \r\n(CSV)";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // mTileEmailList
            // 
            this.mTileEmailList.ActiveControl = null;
            this.mTileEmailList.Location = new System.Drawing.Point(554, 135);
            this.mTileEmailList.Name = "mTileEmailList";
            this.mTileEmailList.Size = new System.Drawing.Size(176, 57);
            this.mTileEmailList.TabIndex = 3;
            this.mTileEmailList.Text = "Email список";
            this.mTileEmailList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTileEmailList.UseSelectable = true;
            this.mTileEmailList.Click += new System.EventHandler(this.mTileEmailList_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(510, 91);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(83, 25);
            this.metroLabel5.TabIndex = 0;
            this.metroLabel5.Text = "Выгрузка";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(579, 230);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(148, 25);
            this.metroLabel6.TabIndex = 5;
            this.metroLabel6.Text = "Всего забегов: 68";
            // 
            // myDataSet
            // 
            this.myDataSet.DataSetName = "MyDataSet";
            this.myDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mbClearFilter
            // 
            this.mbClearFilter.Location = new System.Drawing.Point(24, 230);
            this.mbClearFilter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mbClearFilter.Name = "mbClearFilter";
            this.mbClearFilter.Size = new System.Drawing.Size(84, 23);
            this.mbClearFilter.TabIndex = 7;
            this.mbClearFilter.Text = "Очистить";
            this.mbClearFilter.UseSelectable = true;
            this.mbClearFilter.Click += new System.EventHandler(this.mbClearFilter_Click);
            // 
            // registrationStatusTableAdapter
            // 
            this.registrationStatusTableAdapter.ClearBeforeFill = true;
            // 
            // eventTypeTableAdapter
            // 
            this.eventTypeTableAdapter.ClearBeforeFill = true;
            // 
            // metroGrid2
            // 
            this.metroGrid2.AllowUserToAddRows = false;
            this.metroGrid2.AllowUserToDeleteRows = false;
            this.metroGrid2.AllowUserToResizeRows = false;
            this.metroGrid2.AutoGenerateColumns = false;
            this.metroGrid2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.metroGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.registrationIdDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn1,
            this.firstNameDataGridViewTextBoxColumn1,
            this.lastNameDataGridViewTextBoxColumn1,
            this.registrationStatusDataGridViewTextBoxColumn1,
            this.EditNew});
            this.metroGrid2.DataSource = this.runCordinatorNewBindingSource;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid2.DefaultCellStyle = dataGridViewCellStyle20;
            this.metroGrid2.EnableHeadersVisualStyles = false;
            this.metroGrid2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid2.Location = new System.Drawing.Point(23, 258);
            this.metroGrid2.Name = "metroGrid2";
            this.metroGrid2.ReadOnly = true;
            this.metroGrid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid2.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.metroGrid2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid2.Size = new System.Drawing.Size(704, 314);
            this.metroGrid2.TabIndex = 8;
            this.metroGrid2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid2_CellContentClick);
            // 
            // registrationIdDataGridViewTextBoxColumn
            // 
            this.registrationIdDataGridViewTextBoxColumn.DataPropertyName = "RegistrationId";
            this.registrationIdDataGridViewTextBoxColumn.HeaderText = "RegistrationId";
            this.registrationIdDataGridViewTextBoxColumn.Name = "registrationIdDataGridViewTextBoxColumn";
            this.registrationIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.registrationIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // emailDataGridViewTextBoxColumn1
            // 
            this.emailDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.emailDataGridViewTextBoxColumn1.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn1.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn1.Name = "emailDataGridViewTextBoxColumn1";
            this.emailDataGridViewTextBoxColumn1.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn1.Width = 57;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "EventTypeName";
            this.dataGridViewTextBoxColumn1.HeaderText = "EventTypeName";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // firstNameDataGridViewTextBoxColumn1
            // 
            this.firstNameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.firstNameDataGridViewTextBoxColumn1.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn1.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn1.Name = "firstNameDataGridViewTextBoxColumn1";
            this.firstNameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.firstNameDataGridViewTextBoxColumn1.Width = 81;
            // 
            // lastNameDataGridViewTextBoxColumn1
            // 
            this.lastNameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.lastNameDataGridViewTextBoxColumn1.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn1.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn1.Name = "lastNameDataGridViewTextBoxColumn1";
            this.lastNameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.lastNameDataGridViewTextBoxColumn1.Width = 79;
            // 
            // registrationStatusDataGridViewTextBoxColumn1
            // 
            this.registrationStatusDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.registrationStatusDataGridViewTextBoxColumn1.DataPropertyName = "RegistrationStatus";
            this.registrationStatusDataGridViewTextBoxColumn1.HeaderText = "RegistrationStatus";
            this.registrationStatusDataGridViewTextBoxColumn1.Name = "registrationStatusDataGridViewTextBoxColumn1";
            this.registrationStatusDataGridViewTextBoxColumn1.ReadOnly = true;
            this.registrationStatusDataGridViewTextBoxColumn1.Width = 125;
            // 
            // EditNew
            // 
            this.EditNew.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.EditNew.HeaderText = "Редактировать";
            this.EditNew.Name = "EditNew";
            this.EditNew.ReadOnly = true;
            this.EditNew.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EditNew.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EditNew.UseColumnTextForButtonValue = true;
            this.EditNew.Width = 109;
            // 
            // runCordinatorNewBindingSource
            // 
            this.runCordinatorNewBindingSource.DataMember = "RunCordinatorNew";
            this.runCordinatorNewBindingSource.DataSource = this.myDataSet;
            // 
            // runCordinatorNewTableAdapter
            // 
            this.runCordinatorNewTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.mlTime);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(20, 578);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(703, 39);
            this.panel2.TabIndex = 21;
            // 
            // mlTime
            // 
            this.mlTime.AutoSize = true;
            this.mlTime.Location = new System.Drawing.Point(266, 10);
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
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.Location = new System.Drawing.Point(277, 72);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(185, 25);
            this.metroLabel7.TabIndex = 22;
            this.metroLabel7.Text = "Управление бегунами";
            // 
            // RunnerCordinator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 637);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.metroGrid2);
            this.Controls.Add(this.mbClearFilter);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.mTileEmailList);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.mComboStatus);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.mGroupGroup);
            this.Controls.Add(this.mComboDistant);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel1);
            this.Name = "RunnerCordinator";
            this.Text = "Марафон Skills 2017";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.RunnerCordinator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marathone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.runCordinatorNewBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox mComboDistant;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox mComboStatus;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox mGroupGroup;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile mTileEmailList;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroButton mbClearFilter;
        private Marathone marathone;
        private System.Windows.Forms.BindingSource registrationStatusBindingSource;
        private MarathoneTableAdapters.RegistrationStatusTableAdapter registrationStatusTableAdapter;
        private System.Windows.Forms.BindingSource eventTypeBindingSource;
        private MarathoneTableAdapters.EventTypeTableAdapter eventTypeTableAdapter;
        private MyDataSet myDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventTypeNameDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroGrid metroGrid2;
        private System.Windows.Forms.BindingSource runCordinatorNewBindingSource;
        private MyDataSetTableAdapters.RunCordinatorNewTableAdapter runCordinatorNewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationStatusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn EditNew;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroLabel mlTime;
        private MarathoneTableAdapters.EventTableAdapter eventTableAdapter;
        private System.Windows.Forms.Timer timerDay;
        private MetroFramework.Controls.MetroLabel metroLabel7;
    }
}