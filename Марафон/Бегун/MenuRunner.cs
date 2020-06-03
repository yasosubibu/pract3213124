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
    public partial class MenuRunner : MetroFramework.Forms.MetroForm
    {
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime();
        public string EmailID, Gender;
        public int RegID, RunID;
        public DateTime DateofBirthDay;
        public MenuRunner(string Email)
        {
            InitializeComponent();
            EmailID = Email;
        }

        private void mbRegistration_Click(object sender, EventArgs e)
        {
            RegistrationMarathone frm = new RegistrationMarathone(RunID);
            frm.ShowDialog();
        }

        private void mbResult_Click(object sender, EventArgs e)
        {
            MyResult frm = new MyResult(RegID, Gender, DateofBirthDay);
            frm.ShowDialog();
            frm.MdiParent = null;
        }

        private void mbMySponsor_Click(object sender, EventArgs e)
        {
            MySponsor frm = new MySponsor(RunID);
            frm.ShowDialog();
        }

        private void mbContact_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this,"Телефон: +7 952 323 7092" + Environment.NewLine + "Почта: hd.anufriev@yandex.ru","Контакты спонсора");
        }

        private void timerDay_Tick(object sender, EventArgs e)
        {
            d = date - DateTime.Now;
            mlTime.Text = "Осталось " + d.Days + " д. " + d.Hours + " ч. " + d.Minutes + " мин. " + d.Seconds;
        }

        private void mbEditProfiler_Click(object sender, EventArgs e)
        {
            EditProfilerRunner frm = new EditProfilerRunner(RunID, EmailID);
            frm.ShowDialog();
        }

        private void MenuRunner_Load(object sender, EventArgs e)
        {
            this.runnerTableAdapter.Fill(this.marathone.Runner);
            this.userTableAdapter.Fill(this.marathone.User);
            this.registrationTableAdapter.Fill(this.marathone.Registration);
            if(this.marathone.Runner.Count > 0)
            {
                for(int i=0; i < this.marathone.Runner.Count; i++)
                {
                    if(this.marathone.Runner[i].Email == EmailID)
                    {
                        RunID = this.marathone.Runner[i].RunnerId;
                        Gender = this.marathone.Runner[i].Gender;
                        DateofBirthDay = this.marathone.Runner[i].DateOfBirth;
                    }
                }
            }
            if (this.marathone.Registration.Count > 0)
            {
                for(int i=0; i < this.marathone.Registration.Count; i++)
                    if (this.marathone.Registration[i].RunnerID == RunID)
                        RegID = this.marathone.Registration[i].RegistrationId;
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
    }
}
