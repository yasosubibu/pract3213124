namespace Марафон
{
    partial class MapsMarathone
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
            this.howLongTableAdapter = new Марафон.MarathoneTableAdapters.HowLongTableAdapter();
            this.marathone = new Марафон.Marathone();
            this.mbOne = new MetroFramework.Controls.MetroButton();
            this.mbTwo = new MetroFramework.Controls.MetroButton();
            this.mbThree = new MetroFramework.Controls.MetroButton();
            this.mbFoure = new MetroFramework.Controls.MetroButton();
            this.mbFive = new MetroFramework.Controls.MetroButton();
            this.mbSix = new MetroFramework.Controls.MetroButton();
            this.mbFinish = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.marathone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // howLongTableAdapter
            // 
            this.howLongTableAdapter.ClearBeforeFill = true;
            // 
            // marathone
            // 
            this.marathone.DataSetName = "Marathone";
            this.marathone.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mbOne
            // 
            this.mbOne.Location = new System.Drawing.Point(64, 76);
            this.mbOne.Name = "mbOne";
            this.mbOne.Size = new System.Drawing.Size(25, 23);
            this.mbOne.TabIndex = 1;
            this.mbOne.UseSelectable = true;
            this.mbOne.Click += new System.EventHandler(this.mbOne_Click);
            // 
            // mbTwo
            // 
            this.mbTwo.Location = new System.Drawing.Point(435, 76);
            this.mbTwo.Name = "mbTwo";
            this.mbTwo.Size = new System.Drawing.Size(25, 23);
            this.mbTwo.TabIndex = 1;
            this.mbTwo.UseSelectable = true;
            this.mbTwo.Click += new System.EventHandler(this.mbTwo_Click);
            // 
            // mbThree
            // 
            this.mbThree.Location = new System.Drawing.Point(108, 222);
            this.mbThree.Name = "mbThree";
            this.mbThree.Size = new System.Drawing.Size(25, 23);
            this.mbThree.TabIndex = 1;
            this.mbThree.UseSelectable = true;
            this.mbThree.Click += new System.EventHandler(this.mbThree_Click);
            // 
            // mbFoure
            // 
            this.mbFoure.Location = new System.Drawing.Point(258, 271);
            this.mbFoure.Name = "mbFoure";
            this.mbFoure.Size = new System.Drawing.Size(25, 23);
            this.mbFoure.TabIndex = 1;
            this.mbFoure.UseSelectable = true;
            this.mbFoure.Click += new System.EventHandler(this.mbFoure_Click);
            // 
            // mbFive
            // 
            this.mbFive.Location = new System.Drawing.Point(426, 403);
            this.mbFive.Name = "mbFive";
            this.mbFive.Size = new System.Drawing.Size(25, 23);
            this.mbFive.TabIndex = 1;
            this.mbFive.UseSelectable = true;
            this.mbFive.Click += new System.EventHandler(this.mbFive_Click);
            // 
            // mbSix
            // 
            this.mbSix.Location = new System.Drawing.Point(198, 484);
            this.mbSix.Name = "mbSix";
            this.mbSix.Size = new System.Drawing.Size(25, 23);
            this.mbSix.TabIndex = 1;
            this.mbSix.UseSelectable = true;
            this.mbSix.Click += new System.EventHandler(this.mbSix_Click);
            // 
            // mbFinish
            // 
            this.mbFinish.Location = new System.Drawing.Point(282, 63);
            this.mbFinish.Name = "mbFinish";
            this.mbFinish.Size = new System.Drawing.Size(21, 54);
            this.mbFinish.TabIndex = 2;
            this.mbFinish.UseSelectable = true;
            this.mbFinish.Click += new System.EventHandler(this.mbFinish_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Марафон.Properties.Resources.marathon_skills_2016_marathon_map;
            this.pictureBox1.Location = new System.Drawing.Point(20, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(464, 464);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MapsMarathone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 544);
            this.Controls.Add(this.mbFinish);
            this.Controls.Add(this.mbSix);
            this.Controls.Add(this.mbFive);
            this.Controls.Add(this.mbFoure);
            this.Controls.Add(this.mbThree);
            this.Controls.Add(this.mbTwo);
            this.Controls.Add(this.mbOne);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MapsMarathone";
            this.Text = "Карта марафона";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MapsMarathone_FormClosed);
            this.Load += new System.EventHandler(this.MapsMarathone_Load);
            ((System.ComponentModel.ISupportInitialize)(this.marathone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MarathoneTableAdapters.HowLongTableAdapter howLongTableAdapter;
        private Marathone marathone;
        private MetroFramework.Controls.MetroButton mbOne;
        private MetroFramework.Controls.MetroButton mbTwo;
        private MetroFramework.Controls.MetroButton mbThree;
        private MetroFramework.Controls.MetroButton mbFoure;
        private MetroFramework.Controls.MetroButton mbFive;
        private MetroFramework.Controls.MetroButton mbSix;
        private MetroFramework.Controls.MetroButton mbFinish;
    }
}