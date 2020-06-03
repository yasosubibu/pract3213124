using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Марафон.Спонсор
{
    public partial class FankSponsor : MetroFramework.Forms.MetroForm
    {
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime();
        private string Name;
        private int Coin, Charity;

        private void FankSponsor_Load(object sender, EventArgs e)
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
            this.charityTableAdapter.Fill(this.marathone.Charity);
            if (this.marathone.Charity.Count > 0)
            {
                for(int i=0; i < this.marathone.Charity.Count; i++)
                {
                    if(this.marathone.Charity[i].CharityId == Charity)
                    {
                        metroLabel4.Text = this.marathone.Charity[i].CharityName;
                        break;
                    }
                }
            }
            metroLabel5.Text = Coin + "$";
            metroLabel3.Text = Name;
        }

        private void timerDay_Tick(object sender, EventArgs e)
        {
            d = date - DateTime.Now;
            mlTime.Text = "Осталось " + d.Days + " д. " + d.Hours + " ч. " + d.Minutes + " мин. " + d.Seconds;
        }

        private void mbClose_Click(object sender, EventArgs e)
        {
            SponsorRunner frm = new SponsorRunner();
            frm.Show();
            this.Close();
        }

        public FankSponsor(string name, int coin, int charity)
        {
            InitializeComponent();
            Name = name;
            Coin = coin;
            Charity = charity;
        }
    }
}
