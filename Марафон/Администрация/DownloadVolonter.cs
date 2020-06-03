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

namespace Марафон.Администрация
{
    public partial class DownloadVolonter : MetroFramework.Forms.MetroForm
    {
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime();
        public DownloadVolonter()
        {
            InitializeComponent();
        }

        private void mbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mbOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    mtPath.Text = ofd.FileName;
                }
            }
        }

        private void mbDownload_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(mtPath.Text);
            bool flag = false;
            while (!sr.EndOfStream)
            {
                if (flag)
                {
                    string line = sr.ReadLine();
                    if (line == "")
                        break;
                    string[] temp = line.Split(',');
                    this.volunteerTableAdapter.Insert(temp[1].Trim(), temp[2].Trim(), temp[3].Trim(), temp[4].Trim());
                }
                flag = true;
            }
            sr.Close();
            MessageBox.Show("!");
            metroLabel3.Text = "Статус загрузки: успешно загружено";
            MetroFramework.MetroMessageBox.Show(this, "Информация о волонтерах успешно загружена!");
        }

        private void DownloadVolonter_Load(object sender, EventArgs e)
        {
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
            this.volunteerTableAdapter.Fill(this.marathone.Volunteer);
        }

        private void timerDay_Tick(object sender, EventArgs e)
        {
            d = date - DateTime.Now;
            mlTime.Text = "Осталось " + d.Days + " д. " + d.Hours + " ч. " + d.Minutes + " мин. " + d.Seconds;
        }
    }
}
