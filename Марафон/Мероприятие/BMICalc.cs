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
    public partial class BMICalc : MetroFramework.Forms.MetroForm
    {
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime();
        public BMICalc()
        {
            InitializeComponent();
            metroTrackBar1.Maximum = 100;
            metroTrackBar1.Minimum = 0;
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            //BMI = вес / (рост х рост)
            //(вес в кг, рост в м)
            double BMI = 0, temp;
            temp = Convert.ToDouble(mtWeight.Text);
            temp /= 100;
            BMI = Convert.ToDouble(mtMassa.Text) / (temp * temp);
            metroTrackBar1.Value = Convert.ToInt32(BMI);
            if (BMI < 18.5)
                metroLabel2.Text = String.Format("Недостаточный вес - {0:0.0}",BMI.ToString());
            else if(BMI >= 18.5 && BMI <= 24.9)
                metroLabel2.Text = String.Format("Здоровый вес - {0:0.0}", BMI.ToString());
            else if(BMI >= 25 && BMI <= 29.9)
                metroLabel2.Text = String.Format("Избыточный вес - {0:0.0}", BMI.ToString());
            else if(BMI >= 30)
                metroLabel2.Text = String.Format("Ожирение, индекс - {0:0.0}", BMI.ToString());
        }

        private void BMICalc_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void BMICalc_Load(object sender, EventArgs e)
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
