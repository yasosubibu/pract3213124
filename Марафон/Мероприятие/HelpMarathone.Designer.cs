namespace Марафон
{
    partial class HelpMarathone
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
            this.mbMarathone = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mbNextResult = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mbBMI = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mbDays = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mbListBlago = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mbBMR = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mlTime = new MetroFramework.Controls.MetroLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.marathone = new Марафон.Marathone();
            this.eventTableAdapter = new Марафон.MarathoneTableAdapters.EventTableAdapter();
            this.timerDay = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marathone)).BeginInit();
            this.SuspendLayout();
            // 
            // mbMarathone
            // 
            this.mbMarathone.Depth = 0;
            this.mbMarathone.Location = new System.Drawing.Point(41, 84);
            this.mbMarathone.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbMarathone.Name = "mbMarathone";
            this.mbMarathone.Primary = true;
            this.mbMarathone.Size = new System.Drawing.Size(181, 51);
            this.mbMarathone.TabIndex = 0;
            this.mbMarathone.Text = "Марафон Skills 2016";
            this.mbMarathone.UseVisualStyleBackColor = true;
            this.mbMarathone.Click += new System.EventHandler(this.mbMarathone_Click);
            // 
            // mbNextResult
            // 
            this.mbNextResult.Depth = 0;
            this.mbNextResult.Location = new System.Drawing.Point(41, 141);
            this.mbNextResult.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbNextResult.Name = "mbNextResult";
            this.mbNextResult.Primary = true;
            this.mbNextResult.Size = new System.Drawing.Size(181, 51);
            this.mbNextResult.TabIndex = 0;
            this.mbNextResult.Text = "Предыдущие результаты";
            this.mbNextResult.UseVisualStyleBackColor = true;
            this.mbNextResult.Click += new System.EventHandler(this.mbNextResult_Click);
            // 
            // mbBMI
            // 
            this.mbBMI.Depth = 0;
            this.mbBMI.Location = new System.Drawing.Point(41, 198);
            this.mbBMI.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbBMI.Name = "mbBMI";
            this.mbBMI.Primary = true;
            this.mbBMI.Size = new System.Drawing.Size(181, 51);
            this.mbBMI.TabIndex = 0;
            this.mbBMI.Text = "BMI калькулятор";
            this.mbBMI.UseVisualStyleBackColor = true;
            this.mbBMI.Click += new System.EventHandler(this.mbBMI_Click);
            // 
            // mbDays
            // 
            this.mbDays.Depth = 0;
            this.mbDays.Location = new System.Drawing.Point(228, 84);
            this.mbDays.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbDays.Name = "mbDays";
            this.mbDays.Primary = true;
            this.mbDays.Size = new System.Drawing.Size(181, 51);
            this.mbDays.TabIndex = 0;
            this.mbDays.Text = "Насколько долгий марафон";
            this.mbDays.UseVisualStyleBackColor = true;
            this.mbDays.Click += new System.EventHandler(this.mbDays_Click);
            // 
            // mbListBlago
            // 
            this.mbListBlago.Depth = 0;
            this.mbListBlago.Location = new System.Drawing.Point(228, 141);
            this.mbListBlago.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbListBlago.Name = "mbListBlago";
            this.mbListBlago.Primary = true;
            this.mbListBlago.Size = new System.Drawing.Size(181, 51);
            this.mbListBlago.TabIndex = 0;
            this.mbListBlago.Text = "Список благотворительных организаций";
            this.mbListBlago.UseVisualStyleBackColor = true;
            this.mbListBlago.Click += new System.EventHandler(this.mbListBlago_Click);
            // 
            // mbBMR
            // 
            this.mbBMR.Depth = 0;
            this.mbBMR.Location = new System.Drawing.Point(228, 198);
            this.mbBMR.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbBMR.Name = "mbBMR";
            this.mbBMR.Primary = true;
            this.mbBMR.Size = new System.Drawing.Size(181, 51);
            this.mbBMR.TabIndex = 0;
            this.mbBMR.Text = "BMR калькулятор";
            this.mbBMR.UseVisualStyleBackColor = true;
            this.mbBMR.Click += new System.EventHandler(this.mbBMR_Click);
            // 
            // mlTime
            // 
            this.mlTime.AutoSize = true;
            this.mlTime.Location = new System.Drawing.Point(119, 9);
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
            this.panel2.Location = new System.Drawing.Point(20, 262);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(409, 39);
            this.panel2.TabIndex = 16;
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
            // timerDay
            // 
            this.timerDay.Interval = 1000;
            this.timerDay.Tick += new System.EventHandler(this.timerDay_Tick);
            // 
            // HelpMarathone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 321);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.mbBMR);
            this.Controls.Add(this.mbBMI);
            this.Controls.Add(this.mbListBlago);
            this.Controls.Add(this.mbNextResult);
            this.Controls.Add(this.mbDays);
            this.Controls.Add(this.mbMarathone);
            this.Name = "HelpMarathone";
            this.Text = "О мероприятии";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HelpMarathone_FormClosed);
            this.Load += new System.EventHandler(this.HelpMarathone_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marathone)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton mbMarathone;
        private MaterialSkin.Controls.MaterialRaisedButton mbNextResult;
        private MaterialSkin.Controls.MaterialRaisedButton mbBMI;
        private MaterialSkin.Controls.MaterialRaisedButton mbDays;
        private MaterialSkin.Controls.MaterialRaisedButton mbListBlago;
        private MaterialSkin.Controls.MaterialRaisedButton mbBMR;
        private MetroFramework.Controls.MetroLabel mlTime;
        private System.Windows.Forms.Panel panel2;
        private Marathone marathone;
        private MarathoneTableAdapters.EventTableAdapter eventTableAdapter;
        private System.Windows.Forms.Timer timerDay;
    }
}