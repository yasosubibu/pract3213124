namespace Марафон
{
    partial class CoordinatorMenu
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
            this.mbRunner = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mbSponsor = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mlTime = new MetroFramework.Controls.MetroLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.timerDay = new System.Windows.Forms.Timer(this.components);
            this.marathone = new Марафон.Marathone();
            this.eventTableAdapter = new Марафон.MarathoneTableAdapters.EventTableAdapter();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marathone)).BeginInit();
            this.SuspendLayout();
            // 
            // mbRunner
            // 
            this.mbRunner.Depth = 0;
            this.mbRunner.Location = new System.Drawing.Point(47, 109);
            this.mbRunner.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbRunner.Name = "mbRunner";
            this.mbRunner.Primary = true;
            this.mbRunner.Size = new System.Drawing.Size(158, 71);
            this.mbRunner.TabIndex = 0;
            this.mbRunner.Text = "Бегуны";
            this.mbRunner.UseVisualStyleBackColor = true;
            this.mbRunner.Click += new System.EventHandler(this.mbRunner_Click);
            // 
            // mbSponsor
            // 
            this.mbSponsor.Depth = 0;
            this.mbSponsor.Location = new System.Drawing.Point(211, 109);
            this.mbSponsor.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbSponsor.Name = "mbSponsor";
            this.mbSponsor.Primary = true;
            this.mbSponsor.Size = new System.Drawing.Size(158, 71);
            this.mbSponsor.TabIndex = 0;
            this.mbSponsor.Text = "Спонсоры";
            this.mbSponsor.UseVisualStyleBackColor = true;
            this.mbSponsor.Click += new System.EventHandler(this.mbSponsor_Click);
            // 
            // mlTime
            // 
            this.mlTime.AutoSize = true;
            this.mlTime.Location = new System.Drawing.Point(106, 10);
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
            this.panel2.Location = new System.Drawing.Point(20, 207);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(388, 39);
            this.panel2.TabIndex = 22;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(116, 71);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(185, 25);
            this.metroLabel1.TabIndex = 23;
            this.metroLabel1.Text = "Панель координатора";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // CoordinatorMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 266);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.mbSponsor);
            this.Controls.Add(this.mbRunner);
            this.Name = "CoordinatorMenu";
            this.Text = "Марафон Skills 2017";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.CoordinatorMenu_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marathone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton mbRunner;
        private MaterialSkin.Controls.MaterialRaisedButton mbSponsor;
        private MetroFramework.Controls.MetroLabel mlTime;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Timer timerDay;
        private Marathone marathone;
        private MarathoneTableAdapters.EventTableAdapter eventTableAdapter;
    }
}