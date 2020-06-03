using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Марафон
{
    public partial class DaysMarathone : MetroFramework.Forms.MetroForm
    {
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime();
        public DaysMarathone()
        {
            InitializeComponent();
        }

        private void DaysMarathone_Load(object sender, EventArgs e)
        {
            this.howLongTableAdapter.Fill(this.marathone.HowLong);
            timerDay.Start();
            this.eventTableAdapter.Fill(this.marathone.Event);
            if (this.marathone.Event.Count > 0)
            {
                for (int i = 0; i < this.marathone.Event.Count; i++)
                {
                    if (this.marathone.Event[i].EventId == "16_6HM")
                        date = this.marathone.Event[i].StartDateTime;
                }
            }
        }

        private void metroTabControl1_Selected(object sender, TabControlEventArgs e)
        {
            try
            {
                this.howLongBindingSource.RemoveFilter();
                switch ((sender as TabControl).SelectedIndex.ToString())
                {
                    case ("0"):
                        {
                            this.howLongTableAdapter.Adapter.SelectCommand.CommandText = String.Format(@"SELECT id, Name, Photo, Description FROM HowLong WHERE (id >= 1) AND (id <= 7)");
                            this.howLongTableAdapter.Fill(this.marathone.HowLong);
                        }
                        break;
                    case ("1"):
                        {
                            this.howLongTableAdapter.Adapter.SelectCommand.CommandText = String.Format(@"SELECT id, Name, Photo, Description FROM HowLong WHERE (id >= 8)");
                            this.howLongTableAdapter.Fill(this.marathone.HowLong);
                        }
                        break;

                }
            }
            catch(Exception ex) { }
        }

        private void DaysMarathone_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void timerDay_Tick(object sender, EventArgs e)
        {
            d = date - DateTime.Now;
            mlTime.Text = "Осталось " + d.Days + " д. " + d.Hours + " ч. " + d.Minutes + " мин. " + d.Seconds;
        }

        //private void metroButton1_Click(object sender, EventArgs e)
        //{
        //    using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
        //    {
        //        if (ofd.ShowDialog() == DialogResult.OK)
        //        {
        //            filename = ofd.FileName;
        //            pbImage.Image = Image.FromFile(filename);
        //        }
        //    }
        //    Image img = Image.FromFile(filename);
        //    howLongTableAdapter.Insert("Ronaldinho", ConvertImageToBinary(img), "Описание");
        //    this.Validate();
        //    this.howLongBindingSource.EndEdit();
        //    this.howLongTableAdapter.Update(this.marathone.HowLong);
        //}
    }
}
