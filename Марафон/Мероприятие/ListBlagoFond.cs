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
    public partial class ListBlagoFond : MetroFramework.Forms.MetroForm
    {
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime();
        public ListBlagoFond()
        {
            InitializeComponent();
        }

        private void ListBlagoFond_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "marathone.Charity". При необходимости она может быть перемещена или удалена.
            this.charityTableAdapter.Fill(this.marathone.Charity);
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

        private void ListBlagoFond_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void timerDay_Tick(object sender, EventArgs e)
        {
            d = date - DateTime.Now;
            mlTime.Text = "Осталось " + d.Days + " д. " + d.Hours + " ч. " + d.Minutes + " мин. " + d.Seconds;
        }
    }
}
