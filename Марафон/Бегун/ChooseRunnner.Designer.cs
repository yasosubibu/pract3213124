namespace Марафон.Бегун
{
    partial class ChooseRunnner
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
            this.mlTime = new MetroFramework.Controls.MetroLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mbReg = new MetroFramework.Controls.MetroButton();
            this.mbLoginOne = new MetroFramework.Controls.MetroButton();
            this.btLogin = new MetroFramework.Controls.MetroButton();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mlTime
            // 
            this.mlTime.AutoSize = true;
            this.mlTime.Location = new System.Drawing.Point(123, 10);
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
            this.panel2.Location = new System.Drawing.Point(20, 315);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(441, 39);
            this.panel2.TabIndex = 6;
            // 
            // mbReg
            // 
            this.mbReg.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.mbReg.Location = new System.Drawing.Point(138, 96);
            this.mbReg.Name = "mbReg";
            this.mbReg.Size = new System.Drawing.Size(209, 65);
            this.mbReg.TabIndex = 7;
            this.mbReg.Text = "Я новый участник";
            this.mbReg.UseSelectable = true;
            this.mbReg.Click += new System.EventHandler(this.mbReg_Click);
            // 
            // mbLoginOne
            // 
            this.mbLoginOne.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.mbLoginOne.Location = new System.Drawing.Point(138, 180);
            this.mbLoginOne.Name = "mbLoginOne";
            this.mbLoginOne.Size = new System.Drawing.Size(209, 65);
            this.mbLoginOne.TabIndex = 7;
            this.mbLoginOne.Text = "Я участвовал ранее";
            this.mbLoginOne.UseSelectable = true;
            this.mbLoginOne.Click += new System.EventHandler(this.mbLoginOne_Click);
            // 
            // btLogin
            // 
            this.btLogin.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btLogin.Location = new System.Drawing.Point(344, 264);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(114, 45);
            this.btLogin.TabIndex = 7;
            this.btLogin.Text = "Login";
            this.btLogin.UseSelectable = true;
            this.btLogin.Click += new System.EventHandler(this.mbLoginOne_Click);
            // 
            // ChooseRunnner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 374);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.mbLoginOne);
            this.Controls.Add(this.mbReg);
            this.Controls.Add(this.panel2);
            this.Name = "ChooseRunnner";
            this.Text = "Марафон Skills 2017";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel mlTime;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroButton mbReg;
        private MetroFramework.Controls.MetroButton mbLoginOne;
        private MetroFramework.Controls.MetroButton btLogin;
    }
}