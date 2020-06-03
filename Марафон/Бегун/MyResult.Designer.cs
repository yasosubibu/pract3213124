namespace Марафон
{
    partial class MyResult
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
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.registrationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marathonIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.marathonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marathone = new Марафон.Marathone();
            this.eventTypeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.eventTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.raceTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bibNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultRunnerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myDataSet = new Марафон.MyDataSet();
            this.marathonTableAdapter = new Марафон.MarathoneTableAdapters.MarathonTableAdapter();
            this.eventTypeTableAdapter = new Марафон.MarathoneTableAdapters.EventTypeTableAdapter();
            this.resultRunnerTableAdapter = new Марафон.MyDataSetTableAdapters.ResultRunnerTableAdapter();
            this.registrationEventTableAdapter = new Марафон.MarathoneTableAdapters.RegistrationEventTableAdapter();
            this.mlTime = new MetroFramework.Controls.MetroLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.timerDay = new System.Windows.Forms.Timer(this.components);
            this.eventTableAdapter = new Марафон.MarathoneTableAdapters.EventTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marathonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marathone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultRunnerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(55, 100);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(92, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Пол: мужской";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(208, 100);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(183, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Возрастная категория: 18-23";
            // 
            // metroGrid1
            // 
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
            this.registrationIDDataGridViewTextBoxColumn,
            this.marathonIdDataGridViewTextBoxColumn,
            this.eventTypeIdDataGridViewTextBoxColumn,
            this.raceTimeDataGridViewTextBoxColumn,
            this.Position,
            this.bibNumberDataGridViewTextBoxColumn});
            this.metroGrid1.DataSource = this.resultRunnerBindingSource;
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
            this.metroGrid1.Location = new System.Drawing.Point(20, 133);
            this.metroGrid1.Name = "metroGrid1";
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
            this.metroGrid1.Size = new System.Drawing.Size(506, 242);
            this.metroGrid1.TabIndex = 1;
            // 
            // registrationIDDataGridViewTextBoxColumn
            // 
            this.registrationIDDataGridViewTextBoxColumn.DataPropertyName = "RegistrationID";
            this.registrationIDDataGridViewTextBoxColumn.HeaderText = "RegistrationID";
            this.registrationIDDataGridViewTextBoxColumn.Name = "registrationIDDataGridViewTextBoxColumn";
            this.registrationIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // marathonIdDataGridViewTextBoxColumn
            // 
            this.marathonIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.marathonIdDataGridViewTextBoxColumn.DataPropertyName = "MarathonId";
            this.marathonIdDataGridViewTextBoxColumn.DataSource = this.marathonBindingSource;
            this.marathonIdDataGridViewTextBoxColumn.DisplayMember = "MarathonName";
            this.marathonIdDataGridViewTextBoxColumn.HeaderText = "Марафон";
            this.marathonIdDataGridViewTextBoxColumn.Name = "marathonIdDataGridViewTextBoxColumn";
            this.marathonIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.marathonIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.marathonIdDataGridViewTextBoxColumn.ValueMember = "MarathonId";
            this.marathonIdDataGridViewTextBoxColumn.Width = 82;
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
            // eventTypeIdDataGridViewTextBoxColumn
            // 
            this.eventTypeIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.eventTypeIdDataGridViewTextBoxColumn.DataPropertyName = "EventTypeId";
            this.eventTypeIdDataGridViewTextBoxColumn.DataSource = this.eventTypeBindingSource;
            this.eventTypeIdDataGridViewTextBoxColumn.DisplayMember = "EventTypeName";
            this.eventTypeIdDataGridViewTextBoxColumn.HeaderText = "Дистанция";
            this.eventTypeIdDataGridViewTextBoxColumn.Name = "eventTypeIdDataGridViewTextBoxColumn";
            this.eventTypeIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.eventTypeIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.eventTypeIdDataGridViewTextBoxColumn.ValueMember = "EventTypeId";
            this.eventTypeIdDataGridViewTextBoxColumn.Width = 88;
            // 
            // eventTypeBindingSource
            // 
            this.eventTypeBindingSource.DataMember = "EventType";
            this.eventTypeBindingSource.DataSource = this.marathone;
            // 
            // raceTimeDataGridViewTextBoxColumn
            // 
            this.raceTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.raceTimeDataGridViewTextBoxColumn.DataPropertyName = "RaceTime";
            this.raceTimeDataGridViewTextBoxColumn.HeaderText = "Время";
            this.raceTimeDataGridViewTextBoxColumn.Name = "raceTimeDataGridViewTextBoxColumn";
            this.raceTimeDataGridViewTextBoxColumn.Width = 64;
            // 
            // Position
            // 
            this.Position.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Position.DataPropertyName = "Position";
            this.Position.HeaderText = "Место";
            this.Position.Name = "Position";
            this.Position.Width = 63;
            // 
            // bibNumberDataGridViewTextBoxColumn
            // 
            this.bibNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.bibNumberDataGridViewTextBoxColumn.DataPropertyName = "BibNumber";
            this.bibNumberDataGridViewTextBoxColumn.HeaderText = "Нагрудный номер";
            this.bibNumberDataGridViewTextBoxColumn.Name = "bibNumberDataGridViewTextBoxColumn";
            this.bibNumberDataGridViewTextBoxColumn.Width = 116;
            // 
            // resultRunnerBindingSource
            // 
            this.resultRunnerBindingSource.DataMember = "ResultRunner";
            this.resultRunnerBindingSource.DataSource = this.myDataSet;
            // 
            // myDataSet
            // 
            this.myDataSet.DataSetName = "MyDataSet";
            this.myDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // marathonTableAdapter
            // 
            this.marathonTableAdapter.ClearBeforeFill = true;
            // 
            // eventTypeTableAdapter
            // 
            this.eventTypeTableAdapter.ClearBeforeFill = true;
            // 
            // resultRunnerTableAdapter
            // 
            this.resultRunnerTableAdapter.ClearBeforeFill = true;
            // 
            // registrationEventTableAdapter
            // 
            this.registrationEventTableAdapter.ClearBeforeFill = true;
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
            this.panel2.Location = new System.Drawing.Point(20, 381);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(508, 39);
            this.panel2.TabIndex = 25;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(196, 60);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(137, 25);
            this.metroLabel3.TabIndex = 26;
            this.metroLabel3.Text = "Мои результаты";
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
            // MyResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 440);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "MyResult";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Марафон Skills 2017";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.MyResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marathonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marathone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultRunnerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MyDataSet myDataSet;
        private System.Windows.Forms.BindingSource resultRunnerBindingSource;
        private MyDataSetTableAdapters.ResultRunnerTableAdapter resultRunnerTableAdapter;
        private Marathone marathone;
        private System.Windows.Forms.BindingSource marathonBindingSource;
        private MarathoneTableAdapters.MarathonTableAdapter marathonTableAdapter;
        private System.Windows.Forms.BindingSource eventTypeBindingSource;
        private MarathoneTableAdapters.EventTypeTableAdapter eventTypeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn marathonIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn eventTypeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn raceTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn bibNumberDataGridViewTextBoxColumn;
        private MarathoneTableAdapters.RegistrationEventTableAdapter registrationEventTableAdapter;
        private MetroFramework.Controls.MetroLabel mlTime;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.Timer timerDay;
        private MarathoneTableAdapters.EventTableAdapter eventTableAdapter;
    }
}