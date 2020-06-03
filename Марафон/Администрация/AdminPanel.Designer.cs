namespace Марафон
{
    partial class AdminPanel
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
            this.mbUser = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mbVolonter = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mbBlagoOrg = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mbInstrument = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mlTime = new MetroFramework.Controls.MetroLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mbUser
            // 
            this.mbUser.Depth = 0;
            this.mbUser.Location = new System.Drawing.Point(23, 100);
            this.mbUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbUser.Name = "mbUser";
            this.mbUser.Primary = true;
            this.mbUser.Size = new System.Drawing.Size(167, 64);
            this.mbUser.TabIndex = 0;
            this.mbUser.Text = "Пользователи";
            this.mbUser.UseVisualStyleBackColor = true;
            this.mbUser.Click += new System.EventHandler(this.mbUser_Click);
            // 
            // mbVolonter
            // 
            this.mbVolonter.Depth = 0;
            this.mbVolonter.Location = new System.Drawing.Point(196, 100);
            this.mbVolonter.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbVolonter.Name = "mbVolonter";
            this.mbVolonter.Primary = true;
            this.mbVolonter.Size = new System.Drawing.Size(167, 64);
            this.mbVolonter.TabIndex = 0;
            this.mbVolonter.Text = "Волонтёры";
            this.mbVolonter.UseVisualStyleBackColor = true;
            this.mbVolonter.Click += new System.EventHandler(this.mbVolonter_Click);
            // 
            // mbBlagoOrg
            // 
            this.mbBlagoOrg.Depth = 0;
            this.mbBlagoOrg.Location = new System.Drawing.Point(23, 170);
            this.mbBlagoOrg.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbBlagoOrg.Name = "mbBlagoOrg";
            this.mbBlagoOrg.Primary = true;
            this.mbBlagoOrg.Size = new System.Drawing.Size(167, 64);
            this.mbBlagoOrg.TabIndex = 0;
            this.mbBlagoOrg.Text = "Благотворительные организации";
            this.mbBlagoOrg.UseVisualStyleBackColor = true;
            this.mbBlagoOrg.Click += new System.EventHandler(this.mbBlagoOrg_Click);
            // 
            // mbInstrument
            // 
            this.mbInstrument.Depth = 0;
            this.mbInstrument.Location = new System.Drawing.Point(196, 170);
            this.mbInstrument.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbInstrument.Name = "mbInstrument";
            this.mbInstrument.Primary = true;
            this.mbInstrument.Size = new System.Drawing.Size(167, 64);
            this.mbInstrument.TabIndex = 0;
            this.mbInstrument.Text = "Инвентарь";
            this.mbInstrument.UseVisualStyleBackColor = true;
            this.mbInstrument.Click += new System.EventHandler(this.mbInstrument_Click);
            // 
            // mlTime
            // 
            this.mlTime.AutoSize = true;
            this.mlTime.Location = new System.Drawing.Point(91, 9);
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
            this.panel2.Location = new System.Drawing.Point(20, 249);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(349, 39);
            this.panel2.TabIndex = 29;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(132, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(123, 25);
            this.metroLabel1.TabIndex = 30;
            this.metroLabel1.Text = "Админ панель";
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 308);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.mbBlagoOrg);
            this.Controls.Add(this.mbInstrument);
            this.Controls.Add(this.mbVolonter);
            this.Controls.Add(this.mbUser);
            this.Name = "AdminPanel";
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "Марафон Skills 2017";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton mbUser;
        private MaterialSkin.Controls.MaterialRaisedButton mbVolonter;
        private MaterialSkin.Controls.MaterialRaisedButton mbBlagoOrg;
        private MaterialSkin.Controls.MaterialRaisedButton mbInstrument;
        private MetroFramework.Controls.MetroLabel mlTime;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}