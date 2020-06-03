using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Марафон.Спонсор;

namespace Марафон
{
    public partial class SponsorRunner : MetroFramework.Forms.MetroForm
    {
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime();
        int tempID;
        public SponsorRunner()
        {
            InitializeComponent();
        }

        private void SponsorRunner_Load(object sender, EventArgs e)
        {
            this.registrationTableAdapter.Fill(this.marathone.Registration);
            this.sponsorshipTableAdapter.Fill(this.marathone.Sponsorship);
            numericUpDown1.Maximum = 100000;
            numericUpDown1.Minimum = 0;
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

        private void mbZaplata_Click(object sender, EventArgs e)
        {            
            this.registrationTableAdapter.Adapter.SelectCommand.CommandText = String.Format(@"SELECT * FROM Registration");
            this.registrationTableAdapter.Fill(this.marathone.Registration);
            if (this.marathone.Registration.Count > 0)
            {
                for(int i=0; i < this.marathone.Registration.Count; i++)
                {
                    if(this.marathone.Registration[i].RunnerID == Convert.ToInt32(this.mComboRunner.SelectedValue))
                    {
                        tempID = this.marathone.Registration[i].RegistrationId;
                        sponsorshipTableAdapter.Insert(this.mtName.Text, Convert.ToDecimal(this.numericUpDown1.Value), tempID);
                        FankSponsor frm = new FankSponsor(mtName.Text,Convert.ToInt32(numericUpDown1.Value),Convert.ToInt32(metroComboBox1.SelectedValue));
                        frm.Show();
                        this.Close();
                        break;
                    }
                }
            }
        }

        private void SponsorRunner_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }

        private void metroComboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                this.registrationTableAdapter.Adapter.SelectCommand.CommandText = String.Format(@"SELECT RegistrationId, RegistrationDateTime, RegistrationStatusId, Cost, CharityId, SponsorshipTarget, RunnerID, RaceKitOptionID FROM Registration WHERE (RunnerID = '{0}')", Convert.ToInt32(mComboRunner.SelectedValue));
                this.registrationTableAdapter.Fill(this.marathone.Registration);
                if (this.marathone.Registration.Count > 0)
                {
                    metroComboBox1.DataSource = this.marathone.Registration;
                    metroComboBox1.DisplayMember = "CharityId";
                    metroComboBox1.ValueMember = "CharityId";
                }
            }catch(Exception ex) { }
        }

        private void timerDay_Tick(object sender, EventArgs e)
        {
            d = date - DateTime.Now;
            mlTime.Text = "Осталось " + d.Days + " д. " + d.Hours + " ч. " + d.Minutes + " мин. " + d.Seconds;
        }

        private void mtCardNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar == (char)Keys.Back)
                e.Handled = true;
        }

        private void mtCardFI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) && e.KeyChar == (char)Keys.Back)
                e.Handled = true;
        }
    }
}
