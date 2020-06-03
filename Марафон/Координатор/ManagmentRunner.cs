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

namespace Марафон.Координатор
{
    public partial class ManagmentRunner : MetroFramework.Forms.MetroForm
    {
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime();
        public string Email;
        public int RegId;
        public string Distant;
        public ManagmentRunner(string email,int regID, string dist)
        {
            InitializeComponent();
            Email = email;
            RegId = regID;
            Distant = dist;
        }

        Image ConvertToByte(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }
        private void ManagmentRunner_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "marathone.RaceKitOption". При необходимости она может быть перемещена или удалена.
            this.raceKitOptionTableAdapter.Fill(this.marathone.RaceKitOption);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "marathone.Country". При необходимости она может быть перемещена или удалена.
            this.countryTableAdapter.Fill(this.marathone.Country);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "marathone.Charity". При необходимости она может быть перемещена или удалена.
            this.charityTableAdapter.Fill(this.marathone.Charity);
            this.registrationEventTableAdapter.Fill(this.marathone.RegistrationEvent);
            this.managmentRunnerTableAdapter.Fill(this.myDataSet.ManagmentRunner);
            this.registrationTableAdapter.Fill(this.marathone.Registration);
            this.registrationTableAdapter.Adapter.SelectCommand.CommandText = String.Format(@"SELECT RegistrationId, RegistrationDateTime, RegistrationStatusId, Cost, CharityId, SponsorshipTarget, RunnerID, RaceKitOptionID FROM Registration WHERE(RegistrationId = '{0}')",RegId);
            this.managmentRunnerTableAdapter.Adapter.SelectCommand.CommandText = String.Format(@"SELECT Registration.RegistrationId, Registration.RegistrationDateTime, Registration.RegistrationStatusId, Registration.Cost, Registration.CharityId, Registration.SponsorshipTarget, Registration.RunnerID, " +
                                                                                                 " Registration.RaceKitOptionID, Runner.RunnerId AS Expr1, Runner.Gender, Runner.DateOfBirth, Runner.CountryCode, Runner.Email, Runner.Photo, [User].Email AS Expr2, [User].Password, [User].FirstName, " +
                                                                                                 " [User].LastName, [User].RoleId" +
                                                                                                 " FROM Registration INNER JOIN" +
                                                                                                 " Runner ON Registration.RunnerID = Runner.RunnerId INNER JOIN" +
                                                                                                 " [User] ON Runner.Email = [User].Email" +
                                                                                                 " WHERE ([User].Email = '{0}' AND Registration.RegistrationId = '{1}')", Email,RegId);
            this.managmentRunnerTableAdapter.Fill(this.myDataSet.ManagmentRunner);
            if(this.myDataSet.ManagmentRunner.Count > 0)
            {
                mlBlago.SelectedValue = this.myDataSet.ManagmentRunner[0].CharityId.ToString();
                mlSummaBlago.Text = this.myDataSet.ManagmentRunner[0].SponsorshipTarget.ToString();
                mlGender.Text = this.myDataSet.ManagmentRunner[0].Gender;
                mlfamily.Text = this.myDataSet.ManagmentRunner[0].LastName;
                mlName.Text = this.myDataSet.ManagmentRunner[0].FirstName;
                mlStrana.SelectedValue = this.myDataSet.ManagmentRunner[0].CountryCode;
                mlPacket.SelectedValue = this.myDataSet.ManagmentRunner[0].RaceKitOptionID;
                mlEmail.Text = this.myDataSet.ManagmentRunner[0].Email;

                if(!(this.myDataSet.ManagmentRunner[0].IsPhotoNull()))
                    pictureBox1.Image = ConvertToByte(this.myDataSet.ManagmentRunner[0].Photo);

                mlData.Text = this.myDataSet.ManagmentRunner[0].DateOfBirth.ToShortDateString();
                mlDistant.Text = Distant;
                if (this.myDataSet.ManagmentRunner[0].RegistrationStatusId == 1)
                    mcbReg.Checked = true;
                else if (this.myDataSet.ManagmentRunner[0].RegistrationStatusId == 2){
                    mcbReg.Checked = true; mcbOplata.Checked = true;
                }
                else if(this.myDataSet.ManagmentRunner[0].RegistrationStatusId == 3)
                {
                    mcbReg.Checked = true; mcbOplata.Checked = true; mcbPaket.Checked = true;
                }
                else if (this.myDataSet.ManagmentRunner[0].RegistrationStatusId == 4)
                {
                    mcbReg.Checked = true; mcbOplata.Checked = true; mcbPaket.Checked = true; mcbStart.Checked = true;
                }
            }
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

        private void mTileEditProfiler_Click(object sender, EventArgs e)
        {
            EditProfilerRunner frm = new EditProfilerRunner(this.myDataSet.ManagmentRunner[0].RunnerID, mlEmail.Text);
            frm.Show();
        }

        private void mcbOplata_CheckedChanged(object sender, EventArgs e)
        {
            if (mcbReg.Checked)
                this.registrationTableAdapter.Update(this.marathone.Registration[0].RegistrationDateTime, 2, this.marathone.Registration[0].Cost, this.marathone.Registration[0].CharityId, this.marathone.Registration[0].SponsorshipTarget, this.marathone.Registration[0].RunnerID, this.marathone.Registration[0].RaceKitOptionID, this.marathone.Registration[0].RegistrationId, this.marathone.Registration[0].RegistrationDateTime, this.marathone.Registration[0].RegistrationStatusId, this.marathone.Registration[0].Cost, this.marathone.Registration[0].CharityId, this.marathone.Registration[0].SponsorshipTarget, this.marathone.Registration[0].RunnerID, this.marathone.Registration[0].RaceKitOptionID);
            else
                this.registrationTableAdapter.Update(this.marathone.Registration[0].RegistrationDateTime, 1, this.marathone.Registration[0].Cost, this.marathone.Registration[0].CharityId, this.marathone.Registration[0].SponsorshipTarget, this.marathone.Registration[0].RunnerID, this.marathone.Registration[0].RaceKitOptionID, this.marathone.Registration[0].RegistrationId, this.marathone.Registration[0].RegistrationDateTime, this.marathone.Registration[0].RegistrationStatusId, this.marathone.Registration[0].Cost, this.marathone.Registration[0].CharityId, this.marathone.Registration[0].SponsorshipTarget, this.marathone.Registration[0].RunnerID, this.marathone.Registration[0].RaceKitOptionID);
        }

        private void mcbPaket_CheckedChanged(object sender, EventArgs e)
        {
            if(mcbReg.Checked && mcbOplata.Checked)
                this.registrationTableAdapter.Update(this.marathone.Registration[0].RegistrationDateTime, 3, this.marathone.Registration[0].Cost, this.marathone.Registration[0].CharityId, this.marathone.Registration[0].SponsorshipTarget, this.marathone.Registration[0].RunnerID, this.marathone.Registration[0].RaceKitOptionID, this.marathone.Registration[0].RegistrationId, this.marathone.Registration[0].RegistrationDateTime, this.marathone.Registration[0].RegistrationStatusId, this.marathone.Registration[0].Cost, this.marathone.Registration[0].CharityId, this.marathone.Registration[0].SponsorshipTarget, this.marathone.Registration[0].RunnerID, this.marathone.Registration[0].RaceKitOptionID);
            else
                this.registrationTableAdapter.Update(this.marathone.Registration[0].RegistrationDateTime, 2, this.marathone.Registration[0].Cost, this.marathone.Registration[0].CharityId, this.marathone.Registration[0].SponsorshipTarget, this.marathone.Registration[0].RunnerID, this.marathone.Registration[0].RaceKitOptionID, this.marathone.Registration[0].RegistrationId, this.marathone.Registration[0].RegistrationDateTime, this.marathone.Registration[0].RegistrationStatusId, this.marathone.Registration[0].Cost, this.marathone.Registration[0].CharityId, this.marathone.Registration[0].SponsorshipTarget, this.marathone.Registration[0].RunnerID, this.marathone.Registration[0].RaceKitOptionID);
        }

        private void mcbStart_CheckedChanged(object sender, EventArgs e)
        {
            if (mcbReg.Checked && mcbOplata.Checked && mcbPaket.Checked)
                this.registrationTableAdapter.Update(this.marathone.Registration[0].RegistrationDateTime, 4, this.marathone.Registration[0].Cost, this.marathone.Registration[0].CharityId, this.marathone.Registration[0].SponsorshipTarget, this.marathone.Registration[0].RunnerID, this.marathone.Registration[0].RaceKitOptionID, this.marathone.Registration[0].RegistrationId, this.marathone.Registration[0].RegistrationDateTime, this.marathone.Registration[0].RegistrationStatusId, this.marathone.Registration[0].Cost, this.marathone.Registration[0].CharityId, this.marathone.Registration[0].SponsorshipTarget, this.marathone.Registration[0].RunnerID, this.marathone.Registration[0].RaceKitOptionID);
            else
                this.registrationTableAdapter.Update(this.marathone.Registration[0].RegistrationDateTime, 3, this.marathone.Registration[0].Cost, this.marathone.Registration[0].CharityId, this.marathone.Registration[0].SponsorshipTarget, this.marathone.Registration[0].RunnerID, this.marathone.Registration[0].RaceKitOptionID, this.marathone.Registration[0].RegistrationId, this.marathone.Registration[0].RegistrationDateTime, this.marathone.Registration[0].RegistrationStatusId, this.marathone.Registration[0].Cost, this.marathone.Registration[0].CharityId, this.marathone.Registration[0].SponsorshipTarget, this.marathone.Registration[0].RunnerID, this.marathone.Registration[0].RaceKitOptionID);
        }

        private void mTileSertificat_Click(object sender, EventArgs e)
        {
            if (this.marathone.RegistrationEvent.Count > 0)
            {
                for (int i = 0; i < this.marathone.RegistrationEvent.Count; i++)
                {
                    if (this.myDataSet.ManagmentRunner[0].RegistrationId == this.marathone.RegistrationEvent[i].RegistrationID)
                    {
                        Sertificat frm = new Sertificat(mlName.Text, mlfamily.Text, mlDistant.Text, Convert.ToInt32(this.marathone.RegistrationEvent[i].RaceTime.ToString()), Convert.ToInt32(this.marathone.RegistrationEvent[i].Position.ToString()), Convert.ToDecimal(mlSummaBlago.Text));
                        frm.Show();
                    }
                }
            }
        }

        private void timerDay_Tick(object sender, EventArgs e)
        {
            d = date - DateTime.Now;
            mlTime.Text = "Осталось " + d.Days + " д. " + d.Hours + " ч. " + d.Minutes + " мин. " + d.Seconds;
        }

        private void mcbReg_CheckedChanged(object sender, EventArgs e)
        {
            if (mcbReg.Checked)
                this.registrationTableAdapter.Update(this.marathone.Registration[0].RegistrationDateTime, 1, this.marathone.Registration[0].Cost, this.marathone.Registration[0].CharityId, this.marathone.Registration[0].SponsorshipTarget, this.marathone.Registration[0].RunnerID, this.marathone.Registration[0].RaceKitOptionID, this.marathone.Registration[0].RegistrationId, this.marathone.Registration[0].RegistrationDateTime, 1, this.marathone.Registration[0].Cost, this.marathone.Registration[0].CharityId, this.marathone.Registration[0].SponsorshipTarget, this.marathone.Registration[0].RunnerID, this.marathone.Registration[0].RaceKitOptionID);
        }
    }
}
