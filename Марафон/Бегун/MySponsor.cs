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
    public partial class MySponsor : MetroFramework.Forms.MetroForm
    {
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime();

        private int RunID;
        private decimal Sum=0;
        public MySponsor(int id)
        {
            InitializeComponent();
            RunID = id;
        }

        private void MySponsor_Load(object sender, EventArgs e)
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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDataSet.MySponsor". При необходимости она может быть перемещена или удалена.
            this.mySponsorTableAdapter.Fill(this.myDataSet.MySponsor);
            this.mySponsorTableAdapter.Adapter.SelectCommand.CommandText = String.Format(@"SELECT Sponsorship.SponsorshipId, Sponsorship.SponsorName, Sponsorship.Amount, Sponsorship.RegistrationID, Registration.RegistrationId AS RegistrationIdFK, Registration.RunnerID, Charity.CharityName, Charity.CharityDescription, Charity.CharityLogo "+
                                                                                        " FROM   Registration INNER JOIN " +
                                                                                        " Sponsorship ON Registration.RegistrationId = Sponsorship.RegistrationID INNER JOIN " +
                                                                                        " Charity ON Registration.CharityId = Charity.CharityId WHERE (Registration.RunnerID = '{0}')", RunID);
            this.mySponsorTableAdapter.Fill(this.myDataSet.MySponsor);
            for(int i=0; i < this.myDataSet.MySponsor.Count; i++)
            {
                Sum += this.myDataSet.MySponsor[i].Amount;
            }
            metroLabel3.Text = "Всего: " + Sum + "$";
        }

        private void timerDay_Tick(object sender, EventArgs e)
        {
            d = date - DateTime.Now;
            mlTime.Text = "Осталось " + d.Days + " д. " + d.Hours + " ч. " + d.Minutes + " мин. " + d.Seconds;
        }
    }
}
