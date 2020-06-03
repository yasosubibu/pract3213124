using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Марафон.Бегун;

namespace Марафон
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime();
        public Form1()
        {
            InitializeComponent();
        }

        private void mbRunner_Click(object sender, EventArgs e)
        {
            ChooseRunnner frm = new ChooseRunnner();
            frm.Show();
            this.Hide();
        }

        private void mbSponsor_Click(object sender, EventArgs e)
        {
            SponsorRunner sp = new SponsorRunner();
            sp.Show();
            Hide();
        }

        private void mbHelp_Click(object sender, EventArgs e)
        {
            HelpMarathone frm = new HelpMarathone();
            frm.Show();
            Hide();
        }

        private void mbLogin_Click(object sender, EventArgs e)
        {
            AuthicationLogin fl = new AuthicationLogin();
            fl.Show();
            fl.MdiParent = null;
            Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timerDay.Start();
            this.eventTableAdapter.Fill(this.marathone.Event);
            if(this.marathone.Event.Count > 0)
            {
                for(int i=0; i < this.marathone.Event.Count; i++)
                {
                    if (this.marathone.Event[i].EventId == "16_6HM")
                        date = this.marathone.Event[i].StartDateTime;
                }
            }
            
            this.marathonTableAdapter.Fill(this.marathone.Marathon);
            metroLabel1.Text = "Ближайший марафон \n" + this.marathone.Marathon[this.marathone.Marathon.Count-1].CityName + " " + this.marathone.Marathon[this.marathone.Marathon.Count-1].YearHeld;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            timerDay.Stop();
            Application.Exit();
        }

        private void timerDay_Tick(object sender, EventArgs e)
        {
            d = date - DateTime.Now;
            mlTime.Text = "Осталось " + d.Days + " д. " + d.Hours + " ч. " + d.Minutes + " мин. " + d.Seconds;
        }
    }
}
