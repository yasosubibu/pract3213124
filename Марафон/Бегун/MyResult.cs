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
    public partial class MyResult : MetroFramework.Forms.MetroForm
    {
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime();
        private int RegistrationId;
        private string Gen;
        private DateTime Date;
        public MyResult(int reg, string gen, DateTime date)
        {
            InitializeComponent();
            RegistrationId = reg;
            Gen = gen;
            Date = date;
        }

        private void MyResult_Load(object sender, EventArgs e)
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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "marathone.EventType". При необходимости она может быть перемещена или удалена.
            this.eventTypeTableAdapter.Fill(this.marathone.EventType);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "marathone.Marathon". При необходимости она может быть перемещена или удалена.
            this.marathonTableAdapter.Fill(this.marathone.Marathon);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDataSet.ResultRunner". При необходимости она может быть перемещена или удалена.
            this.resultRunnerTableAdapter.Fill(this.myDataSet.ResultRunner);
            this.registrationEventTableAdapter.Fill(this.marathone.RegistrationEvent);
            
            #region Сортировка мест
            string[] temp = { "11_1FM", "11_1FR", "11_1HM", "14_4FM", "14_4FR", "14_4HM", "15_5FM", "15_5FR", "15_5HM", "16_6FM", "16_6FR", "16_6HM"};
                for (int i = 0; i < temp.Length; i++)
                {
                    this.registrationEventTableAdapter.Adapter.SelectCommand.CommandText = String.Format(@"SELECT RegistrationEventId, BibNumber, RaceTime, RegistrationID, EventID, Position FROM RegistrationEvent "+
                                                                                                           " WHERE(EventID = '{0}')" +
                                                                                                           " ORDER BY RaceTime", temp[i]);
                    this.registrationEventTableAdapter.Fill(this.marathone.RegistrationEvent);
                    if (this.marathone.RegistrationEvent.Count > 0)
                    {
                        int k = 0;
                        for (int j = 0; j < this.marathone.RegistrationEvent.Count; j++)
                        {
                            k++;
                            this.registrationEventTableAdapter.Update(this.marathone.RegistrationEvent[j].BibNumber, this.marathone.RegistrationEvent[j].RaceTime, this.marathone.RegistrationEvent[j].RegistrationID, this.marathone.RegistrationEvent[j].EventID, k, this.marathone.RegistrationEvent[j].RegistrationEventId, this.marathone.RegistrationEvent[j].BibNumber, this.marathone.RegistrationEvent[j].RaceTime, this.marathone.RegistrationEvent[j].RegistrationID, this.marathone.RegistrationEvent[j].EventID, this.marathone.RegistrationEvent[j].Position);                            
                        }
                    }
                }
            #endregion

            this.resultRunnerTableAdapter.Adapter.SelectCommand.CommandText = String.Format(@"SELECT RegistrationEvent.RaceTime, RegistrationEvent.BibNumber, RegistrationEvent.RegistrationID, Event.EventTypeId, Event.MarathonId, RegistrationEvent.Position " +
                                                                                " FROM Event INNER JOIN RegistrationEvent ON Event.EventId = RegistrationEvent.EventID WHERE(RegistrationEvent.RegistrationID = '{0}')",RegistrationId);
            this.resultRunnerTableAdapter.Fill(this.myDataSet.ResultRunner);


            metroLabel1.Text = "Пол: " + Gen;
            DateTime dt; TimeSpan dt2;
            dt = DateTime.Now;
            dt2 = dt - Date;
            if (dt2.Days / 365 < 18)
                metroLabel2.Text = "Возрастная категория: до 18";
            else if ((dt2.Days / 365) >= 18 && (dt2.Days / 365) <= 29)
                metroLabel2.Text = "Возрастная категория: от 18 до 29";
            else if ((dt2.Days / 365) >= 30 && (dt2.Days / 365) <= 39)
                metroLabel2.Text = "Возрастная категория: от 30 до 39";
            else if ((dt2.Days / 365) >= 40 && (dt2.Days / 365) <= 55)
                metroLabel2.Text = "Возрастная категория: от 40 до 55";
            else if ((dt2.Days / 365) >= 56 && (dt2.Days / 365) <= 70)
                metroLabel2.Text = "Возрастная категория: от 56 до 70";
            else if((dt2.Days / 365) > 70)
                metroLabel2.Text = "Возрастная категория: более 70";
        }

        private void timerDay_Tick(object sender, EventArgs e)
        {
            d = date - DateTime.Now;
            mlTime.Text = "Осталось " + d.Days + " д. " + d.Hours + " ч. " + d.Minutes + " мин. " + d.Seconds;
        }
    }
}
