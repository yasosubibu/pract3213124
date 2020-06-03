using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Марафон
{
    public partial class SponsorCoordinator : MetroFramework.Forms.MetroForm
    {
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime();
        private decimal sum = 0;
        public SponsorCoordinator()
        {
            InitializeComponent();
        }

        private void SponsorCoordinator_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDataSet.SponsorCharity". При необходимости она может быть перемещена или удалена.
            this.sponsorCharityTableAdapter.Fill(this.myDataSet.SponsorCharity);
            if (this.myDataSet.SponsorCharity.Count > 0)
            {
                for (int i= 0; i < myDataSet.SponsorCharity.Count - 1; i++)
                    sum += this.myDataSet.SponsorCharity[i].SponsorshipTarget;
            }
            metroLabel1.Text = "Всего взносов: "+ sum +" $ \n Благотворительных организаций: " + this.sponsorCharityBindingSource.Count;
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

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            sum = 0;
            if(metroComboBox1.Text == "Названию")
            {
                metroGrid1.Sort(metroGrid1.Columns[1],ListSortDirection.Ascending);
                for (int i = 0; i < metroGrid1.Rows.Count; i++)
                    sum += Convert.ToInt32(metroGrid1[2, i].Value);
            }
            else if(metroComboBox1.Text == "Сумме")
            {
                metroGrid1.Sort(metroGrid1.Columns[2], ListSortDirection.Ascending);
                for (int i = 0; i < metroGrid1.Rows.Count; i++)
                    sum += Convert.ToInt32(metroGrid1[2, i].Value);
            }
            metroLabel1.Text = "Всего взносов: " + sum + " $ \n Благотворительных организаций: " + this.sponsorCharityBindingSource.Count;
        }

        private void timerDay_Tick(object sender, EventArgs e)
        {
            d = date - DateTime.Now;
            mlTime.Text = "Осталось " + d.Days + " д. " + d.Hours + " ч. " + d.Minutes + " мин. " + d.Seconds;
        }
    }
}
