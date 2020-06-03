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
using Марафон.Администрация;

namespace Марафон
{
    public partial class AdminVolonter : MetroFramework.Forms.MetroForm
    {
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime();
        public AdminVolonter()
        {
            InitializeComponent();
        }

        private void AdminVolonter_Load(object sender, EventArgs e)
        {
            this.volunteerTableAdapter.Fill(this.marathone.Volunteer);
            metroLabel3.Text = "Всего волонтеров: " + this.volunteerBindingSource.Count.ToString();
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

        private void mComboGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            volunteerBindingSource.RemoveFilter();
            if(mComboGroup.Text == "Имя")
                metroGrid1.Sort(metroGrid1.Columns[1], ListSortDirection.Ascending);
            else if(mComboGroup.Text == "Фамилия")
                metroGrid1.Sort(metroGrid1.Columns[2], ListSortDirection.Ascending);
            else if(mComboGroup.Text == "Страна")
                metroGrid1.Sort(metroGrid1.Columns[3], ListSortDirection.Ascending);
            else if(mComboGroup.Text == "Пол")
                metroGrid1.Sort(metroGrid1.Columns[4], ListSortDirection.Ascending);
            metroLabel3.Text = "Всего волонтеров: " + this.volunteerBindingSource.Count.ToString();
        }

        private void mtLoadFile_Click(object sender, EventArgs e)
        {
            DownloadVolonter frm = new DownloadVolonter();
            frm.ShowDialog();
            mlRefresh_Click(this, null);
        }

        private void mlRefresh_Click(object sender, EventArgs e)
        {
            this.Update();
            this.volunteerTableAdapter.Fill(this.marathone.Volunteer);
            metroLabel3.Text = "Всего волонтеров: " + this.volunteerBindingSource.Count.ToString();
        }

        private void timerDay_Tick(object sender, EventArgs e)
        {
            d = date - DateTime.Now;
            mlTime.Text = "Осталось " + d.Days + " д. " + d.Hours + " ч. " + d.Minutes + " мин. " + d.Seconds;
        }
    }
}
