namespace Марафон.Администрация
{
    partial class Inventory
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
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VarA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VarB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VarC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mbPrint = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mbPrihod = new MaterialSkin.Controls.MaterialRaisedButton();
            this.registrationTableAdapter = new Марафон.MarathoneTableAdapters.RegistrationTableAdapter();
            this.marathone = new Марафон.Marathone();
            this.marathonTableAdapter = new Марафон.MarathoneTableAdapters.MarathonTableAdapter();
            this.inventoryTableAdapter = new Марафон.MarathoneTableAdapters.InventoryTableAdapter();
            this.mlTime = new MetroFramework.Controls.MetroLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.eventTableAdapter = new Марафон.MarathoneTableAdapters.EventTableAdapter();
            this.timerDay = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marathone)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToResizeRows = false;
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
            this.ID,
            this.VarA,
            this.VarB,
            this.VarC,
            this.Hado,
            this.Ost});
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
            this.metroGrid1.Location = new System.Drawing.Point(24, 141);
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
            this.metroGrid1.Size = new System.Drawing.Size(593, 279);
            this.metroGrid1.TabIndex = 0;
            this.metroGrid1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ID.HeaderText = "Комплект";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 81;
            // 
            // VarA
            // 
            this.VarA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.VarA.HeaderText = "Тип А";
            this.VarA.Name = "VarA";
            this.VarA.ReadOnly = true;
            this.VarA.Width = 59;
            // 
            // VarB
            // 
            this.VarB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.VarB.HeaderText = "Тип Б";
            this.VarB.Name = "VarB";
            this.VarB.ReadOnly = true;
            this.VarB.Width = 58;
            // 
            // VarC
            // 
            this.VarC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.VarC.HeaderText = "Тип С";
            this.VarC.Name = "VarC";
            this.VarC.ReadOnly = true;
            this.VarC.Width = 59;
            // 
            // Hado
            // 
            this.Hado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Hado.HeaderText = "Необходимо";
            this.Hado.Name = "Hado";
            this.Hado.ReadOnly = true;
            this.Hado.Width = 98;
            // 
            // Ost
            // 
            this.Ost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Ost.HeaderText = "Остаток";
            this.Ost.Name = "Ost";
            this.Ost.ReadOnly = true;
            this.Ost.Width = 73;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(229, 119);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(141, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Всего участников: 123";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mbPrint
            // 
            this.mbPrint.Depth = 0;
            this.mbPrint.Location = new System.Drawing.Point(24, 426);
            this.mbPrint.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbPrint.Name = "mbPrint";
            this.mbPrint.Primary = true;
            this.mbPrint.Size = new System.Drawing.Size(118, 38);
            this.mbPrint.TabIndex = 2;
            this.mbPrint.Text = "Отчет";
            this.mbPrint.UseVisualStyleBackColor = true;
            this.mbPrint.Click += new System.EventHandler(this.mbPrint_Click);
            // 
            // mbPrihod
            // 
            this.mbPrihod.Depth = 0;
            this.mbPrihod.Location = new System.Drawing.Point(499, 426);
            this.mbPrihod.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbPrihod.Name = "mbPrihod";
            this.mbPrihod.Primary = true;
            this.mbPrihod.Size = new System.Drawing.Size(118, 38);
            this.mbPrihod.TabIndex = 2;
            this.mbPrihod.Text = "Поступление";
            this.mbPrihod.UseVisualStyleBackColor = true;
            this.mbPrihod.Click += new System.EventHandler(this.mbPrihod_Click);
            // 
            // registrationTableAdapter
            // 
            this.registrationTableAdapter.ClearBeforeFill = true;
            // 
            // marathone
            // 
            this.marathone.DataSetName = "Marathone";
            this.marathone.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // marathonTableAdapter
            // 
            this.marathonTableAdapter.ClearBeforeFill = true;
            // 
            // inventoryTableAdapter
            // 
            this.inventoryTableAdapter.ClearBeforeFill = true;
            // 
            // mlTime
            // 
            this.mlTime.AutoSize = true;
            this.mlTime.Location = new System.Drawing.Point(208, 10);
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
            this.panel2.Location = new System.Drawing.Point(20, 470);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 39);
            this.panel2.TabIndex = 25;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(253, 70);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(97, 25);
            this.metroLabel2.TabIndex = 26;
            this.metroLabel2.Text = "Инвентарь";
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
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 529);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.mbPrihod);
            this.Controls.Add(this.mbPrint);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroGrid1);
            this.Name = "Inventory";
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "Марафон Skills 2017";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marathone)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn VarA;
        private System.Windows.Forms.DataGridViewTextBoxColumn VarB;
        private System.Windows.Forms.DataGridViewTextBoxColumn VarC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ost;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton mbPrint;
        private MaterialSkin.Controls.MaterialRaisedButton mbPrihod;
        private MarathoneTableAdapters.RegistrationTableAdapter registrationTableAdapter;
        private Marathone marathone;
        private MarathoneTableAdapters.MarathonTableAdapter marathonTableAdapter;
        private MarathoneTableAdapters.InventoryTableAdapter inventoryTableAdapter;
        private MetroFramework.Controls.MetroLabel mlTime;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MarathoneTableAdapters.EventTableAdapter eventTableAdapter;
        private System.Windows.Forms.Timer timerDay;
    }
}