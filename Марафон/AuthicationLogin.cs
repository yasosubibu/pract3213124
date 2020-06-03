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
    public partial class AuthicationLogin : MetroFramework.Forms.MetroForm
    {
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime();
        public AuthicationLogin()
        {
            InitializeComponent();
        }

        private void mbLogin_Click(object sender, EventArgs e)
        {
            var pass = mtPassword.Text.Replace("'", "''");

            this.userTableAdapter.Adapter.SelectCommand.CommandText = String.Format(@"SELECT * FROM [User] WHERE (Email = '{0}' and Password = '{1}')",
                mtLogin.Text,
                pass);

            this.userTableAdapter.Fill(this.marathone.User);
            if (this.marathone.User.Count > 0)
            {
                if (this.marathone.User[0].RoleId == "R")
                {
                    MenuRunner frm = new MenuRunner(this.marathone.User[0].Email);
                    Hide();
                    frm.ShowDialog();
                    
                } else if(this.marathone.User[0].RoleId == "C")
                {
                    CoordinatorMenu frm = new CoordinatorMenu();
                    Hide();
                    frm.ShowDialog();
                    
                } else if(this.marathone.User[0].RoleId == "A")
                {
                    AdminPanel frm = new AdminPanel();
                    Hide();
                    frm.ShowDialog();
                }
            }
        }

        private void mbFormMain_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            Hide();
        }

        private void AuthicationLogin_Load(object sender, EventArgs e)
        {
            this.userTableAdapter.Fill(this.marathone.User);
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

        private void AuthicationLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            mbFormMain_Click(this, null);
        }

        private void timerDay_Tick(object sender, EventArgs e)
        {
            d = date - DateTime.Now;
            mlTime.Text = "Осталось " + d.Days + " д. " + d.Hours + " ч. " + d.Minutes + " мин. " + d.Seconds;
        }
    }
}
