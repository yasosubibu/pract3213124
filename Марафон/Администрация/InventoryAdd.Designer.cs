namespace Марафон.Администрация
{
    partial class InventoryAdd
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
            this.inventoryTableAdapter = new Марафон.MarathoneTableAdapters.InventoryTableAdapter();
            this.marathone = new Марафон.Marathone();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mtNumber = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mtBraslet = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.mtKepa = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.mtVater = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.mtFutbolka = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.mtBucklet = new MetroFramework.Controls.MetroTextBox();
            this.mtSave = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.marathone)).BeginInit();
            this.SuspendLayout();
            // 
            // inventoryTableAdapter
            // 
            this.inventoryTableAdapter.ClearBeforeFill = true;
            // 
            // marathone
            // 
            this.marathone.DataSetName = "Marathone";
            this.marathone.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(17, 71);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(128, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Номера нагрудные:";
            // 
            // mtNumber
            // 
            // 
            // 
            // 
            this.mtNumber.CustomButton.Image = null;
            this.mtNumber.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.mtNumber.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.mtNumber.CustomButton.Name = "";
            this.mtNumber.CustomButton.Size = new System.Drawing.Size(13, 13);
            this.mtNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtNumber.CustomButton.TabIndex = 1;
            this.mtNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtNumber.CustomButton.UseSelectable = true;
            this.mtNumber.CustomButton.Visible = false;
            this.mtNumber.Lines = new string[0];
            this.mtNumber.Location = new System.Drawing.Point(166, 75);
            this.mtNumber.Margin = new System.Windows.Forms.Padding(2);
            this.mtNumber.MaxLength = 32767;
            this.mtNumber.Name = "mtNumber";
            this.mtNumber.PasswordChar = '\0';
            this.mtNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtNumber.SelectedText = "";
            this.mtNumber.SelectionLength = 0;
            this.mtNumber.SelectionStart = 0;
            this.mtNumber.ShortcutsEnabled = true;
            this.mtNumber.Size = new System.Drawing.Size(132, 15);
            this.mtNumber.TabIndex = 1;
            this.mtNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtNumber.UseSelectable = true;
            this.mtNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mtNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtNumber_KeyPress);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(17, 99);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(91, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Браслет PDFI:";
            // 
            // mtBraslet
            // 
            // 
            // 
            // 
            this.mtBraslet.CustomButton.Image = null;
            this.mtBraslet.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.mtBraslet.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.mtBraslet.CustomButton.Name = "";
            this.mtBraslet.CustomButton.Size = new System.Drawing.Size(13, 13);
            this.mtBraslet.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtBraslet.CustomButton.TabIndex = 1;
            this.mtBraslet.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtBraslet.CustomButton.UseSelectable = true;
            this.mtBraslet.CustomButton.Visible = false;
            this.mtBraslet.Lines = new string[0];
            this.mtBraslet.Location = new System.Drawing.Point(166, 105);
            this.mtBraslet.Margin = new System.Windows.Forms.Padding(2);
            this.mtBraslet.MaxLength = 32767;
            this.mtBraslet.Name = "mtBraslet";
            this.mtBraslet.PasswordChar = '\0';
            this.mtBraslet.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtBraslet.SelectedText = "";
            this.mtBraslet.SelectionLength = 0;
            this.mtBraslet.SelectionStart = 0;
            this.mtBraslet.ShortcutsEnabled = true;
            this.mtBraslet.Size = new System.Drawing.Size(132, 15);
            this.mtBraslet.TabIndex = 1;
            this.mtBraslet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtBraslet.UseSelectable = true;
            this.mtBraslet.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtBraslet.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mtBraslet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtNumber_KeyPress);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(17, 127);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(78, 19);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Бейсболки:";
            // 
            // mtKepa
            // 
            // 
            // 
            // 
            this.mtKepa.CustomButton.Image = null;
            this.mtKepa.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.mtKepa.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.mtKepa.CustomButton.Name = "";
            this.mtKepa.CustomButton.Size = new System.Drawing.Size(13, 13);
            this.mtKepa.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtKepa.CustomButton.TabIndex = 1;
            this.mtKepa.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtKepa.CustomButton.UseSelectable = true;
            this.mtKepa.CustomButton.Visible = false;
            this.mtKepa.Lines = new string[0];
            this.mtKepa.Location = new System.Drawing.Point(166, 133);
            this.mtKepa.Margin = new System.Windows.Forms.Padding(2);
            this.mtKepa.MaxLength = 32767;
            this.mtKepa.Name = "mtKepa";
            this.mtKepa.PasswordChar = '\0';
            this.mtKepa.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtKepa.SelectedText = "";
            this.mtKepa.SelectionLength = 0;
            this.mtKepa.SelectionStart = 0;
            this.mtKepa.ShortcutsEnabled = true;
            this.mtKepa.Size = new System.Drawing.Size(132, 15);
            this.mtKepa.TabIndex = 1;
            this.mtKepa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtKepa.UseSelectable = true;
            this.mtKepa.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtKepa.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mtKepa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtNumber_KeyPress);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(17, 156);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(95, 19);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "Бутылка воды:";
            // 
            // mtVater
            // 
            // 
            // 
            // 
            this.mtVater.CustomButton.Image = null;
            this.mtVater.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.mtVater.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.mtVater.CustomButton.Name = "";
            this.mtVater.CustomButton.Size = new System.Drawing.Size(13, 13);
            this.mtVater.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtVater.CustomButton.TabIndex = 1;
            this.mtVater.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtVater.CustomButton.UseSelectable = true;
            this.mtVater.CustomButton.Visible = false;
            this.mtVater.Lines = new string[0];
            this.mtVater.Location = new System.Drawing.Point(166, 162);
            this.mtVater.Margin = new System.Windows.Forms.Padding(2);
            this.mtVater.MaxLength = 32767;
            this.mtVater.Name = "mtVater";
            this.mtVater.PasswordChar = '\0';
            this.mtVater.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtVater.SelectedText = "";
            this.mtVater.SelectionLength = 0;
            this.mtVater.SelectionStart = 0;
            this.mtVater.ShortcutsEnabled = true;
            this.mtVater.Size = new System.Drawing.Size(132, 15);
            this.mtVater.TabIndex = 1;
            this.mtVater.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtVater.UseSelectable = true;
            this.mtVater.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtVater.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mtVater.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtNumber_KeyPress);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(17, 186);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(69, 19);
            this.metroLabel5.TabIndex = 0;
            this.metroLabel5.Text = "Футболка:";
            // 
            // mtFutbolka
            // 
            // 
            // 
            // 
            this.mtFutbolka.CustomButton.Image = null;
            this.mtFutbolka.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.mtFutbolka.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.mtFutbolka.CustomButton.Name = "";
            this.mtFutbolka.CustomButton.Size = new System.Drawing.Size(13, 13);
            this.mtFutbolka.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtFutbolka.CustomButton.TabIndex = 1;
            this.mtFutbolka.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtFutbolka.CustomButton.UseSelectable = true;
            this.mtFutbolka.CustomButton.Visible = false;
            this.mtFutbolka.Lines = new string[0];
            this.mtFutbolka.Location = new System.Drawing.Point(166, 192);
            this.mtFutbolka.Margin = new System.Windows.Forms.Padding(2);
            this.mtFutbolka.MaxLength = 32767;
            this.mtFutbolka.Name = "mtFutbolka";
            this.mtFutbolka.PasswordChar = '\0';
            this.mtFutbolka.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtFutbolka.SelectedText = "";
            this.mtFutbolka.SelectionLength = 0;
            this.mtFutbolka.SelectionStart = 0;
            this.mtFutbolka.ShortcutsEnabled = true;
            this.mtFutbolka.Size = new System.Drawing.Size(132, 15);
            this.mtFutbolka.TabIndex = 1;
            this.mtFutbolka.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtFutbolka.UseSelectable = true;
            this.mtFutbolka.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtFutbolka.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mtFutbolka.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtNumber_KeyPress);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(17, 216);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(133, 19);
            this.metroLabel6.TabIndex = 0;
            this.metroLabel6.Text = "Сувенирный буклет:";
            // 
            // mtBucklet
            // 
            // 
            // 
            // 
            this.mtBucklet.CustomButton.Image = null;
            this.mtBucklet.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.mtBucklet.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.mtBucklet.CustomButton.Name = "";
            this.mtBucklet.CustomButton.Size = new System.Drawing.Size(13, 13);
            this.mtBucklet.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtBucklet.CustomButton.TabIndex = 1;
            this.mtBucklet.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtBucklet.CustomButton.UseSelectable = true;
            this.mtBucklet.CustomButton.Visible = false;
            this.mtBucklet.Lines = new string[0];
            this.mtBucklet.Location = new System.Drawing.Point(166, 220);
            this.mtBucklet.Margin = new System.Windows.Forms.Padding(2);
            this.mtBucklet.MaxLength = 32767;
            this.mtBucklet.Name = "mtBucklet";
            this.mtBucklet.PasswordChar = '\0';
            this.mtBucklet.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtBucklet.SelectedText = "";
            this.mtBucklet.SelectionLength = 0;
            this.mtBucklet.SelectionStart = 0;
            this.mtBucklet.ShortcutsEnabled = true;
            this.mtBucklet.Size = new System.Drawing.Size(132, 15);
            this.mtBucklet.TabIndex = 1;
            this.mtBucklet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtBucklet.UseSelectable = true;
            this.mtBucklet.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtBucklet.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mtBucklet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtNumber_KeyPress);
            // 
            // mtSave
            // 
            this.mtSave.Depth = 0;
            this.mtSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mtSave.Location = new System.Drawing.Point(13, 255);
            this.mtSave.Margin = new System.Windows.Forms.Padding(2);
            this.mtSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtSave.Name = "mtSave";
            this.mtSave.Primary = true;
            this.mtSave.Size = new System.Drawing.Size(288, 37);
            this.mtSave.TabIndex = 2;
            this.mtSave.Text = "Занести в базу";
            this.mtSave.UseVisualStyleBackColor = true;
            this.mtSave.Click += new System.EventHandler(this.mtSave_Click);
            // 
            // InventoryAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 305);
            this.Controls.Add(this.mtSave);
            this.Controls.Add(this.mtBucklet);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.mtFutbolka);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.mtVater);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.mtKepa);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.mtBraslet);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.mtNumber);
            this.Controls.Add(this.metroLabel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InventoryAdd";
            this.Padding = new System.Windows.Forms.Padding(13, 60, 13, 13);
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "Поступление инвентаря";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InventoryAdd_FormClosed);
            this.Load += new System.EventHandler(this.InventoryAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.marathone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MarathoneTableAdapters.InventoryTableAdapter inventoryTableAdapter;
        private Marathone marathone;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox mtNumber;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox mtBraslet;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox mtKepa;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox mtVater;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox mtFutbolka;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox mtBucklet;
        private MaterialSkin.Controls.MaterialRaisedButton mtSave;
    }
}