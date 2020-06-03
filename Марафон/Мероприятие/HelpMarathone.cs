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
    public partial class HelpMarathone : MetroFramework.Forms.MetroForm
    {
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime();
        public HelpMarathone()
        {
            InitializeComponent();
        }

        private void mbMarathone_Click(object sender, EventArgs e)
        {
            InfoMarathone fm = new InfoMarathone();
            fm.ShowDialog();
        }

        private void mbDays_Click(object sender, EventArgs e)
        {
            DaysMarathone fr = new DaysMarathone();
            fr.ShowDialog();
        }

        private void mbNextResult_Click(object sender, EventArgs e)
        {
            PreviousResult fr = new PreviousResult();
            fr.ShowDialog();
        }

        private void mbListBlago_Click(object sender, EventArgs e)
        {
            ListBlagoFond frm = new ListBlagoFond();
            frm.ShowDialog();
        }

        private void mbBMI_Click(object sender, EventArgs e)
        {
            BMICalc frm = new BMICalc();
            frm.ShowDialog();
        }

        private void mbBMR_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this,"Данная форма в разработке","BMR калькулятор");
        }

        private void HelpMarathone_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.ShowDialog();
        }

        private void HelpMarathone_Load(object sender, EventArgs e)
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
        }

        private void timerDay_Tick(object sender, EventArgs e)
        {
            d = date - DateTime.Now;
            mlTime.Text = "Осталось " + d.Days + " д. " + d.Hours + " ч. " + d.Minutes + " мин. " + d.Seconds;
        }
    }
}
