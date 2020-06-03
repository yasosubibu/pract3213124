using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Universal;

namespace Марафон
{
    public partial class PreviousResult : MetroFramework.Forms.MetroForm
    {
        private double avgTime = 0;
        private int temp;
        private double count = 0;
        private string Str,Str1;
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime();
        public PreviousResult()
        {
            InitializeComponent();
        }

        private void Refresh()
        {
            avgTime = 0; count = 0;
            for(int i=0; i < metroGrid1.Rows.Count; i++)
            {
                avgTime += Convert.ToDouble(metroGrid1[4, i].Value);
            }
            metroLabel5.Text = "Всего бегунов: " + metroGrid1.RowCount;
            metroLabel6.Text = "Всего финишировало: " + Convert.ToInt32(metroGrid1.RowCount);

            metroLabel7.Text = String.Format("Среднее время {0:0} дней. {1:0} час. {2:0} мин. ", Recording.RaceTimeDay(avgTime, metroGrid1.RowCount), Recording.RaceTimeHour(avgTime, metroGrid1.RowCount), Recording.RaceTimeMinute(avgTime, metroGrid1.RowCount));
            
        }

        private void PreviousResult_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "marathone.Marathon". При необходимости она может быть перемещена или удалена.
            this.marathonTableAdapter.Fill(this.marathone.Marathon);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "marathone.EventType". При необходимости она может быть перемещена или удалена.
            this.eventTypeTableAdapter.Fill(this.marathone.EventType);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "marathone.Gender". При необходимости она может быть перемещена или удалена.
            this.genderTableAdapter.Fill(this.marathone.Gender);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "marathone.Country". При необходимости она может быть перемещена или удалена.
            this.countryTableAdapter.Fill(this.marathone.Country);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDataSet.PreviousRes". При необходимости она может быть перемещена или удалена.
            this.previousResTableAdapter.Fill(this.myDataSet.PreviousRes);

            avgTime = 0; count = 0;
            if (this.myDataSet.PreviousRes.Count > 0)
            {
                for (int i = 0; i < myDataSet.PreviousRes.Count; i++)
                {
                    avgTime += this.myDataSet.PreviousRes[i].RaceTime;
                    if (this.myDataSet.PreviousRes[i].RaceTime != 0 || this.myDataSet.PreviousRes[i].IsRaceTimeNull())
                        count++;
                }

            }
            temp = Convert.ToInt32(count);
            metroLabel5.Text = "Всего бегунов: " + metroGrid1.RowCount;
            metroLabel6.Text = "Всего финишировало: " + count;

            metroLabel7.Text = String.Format("Среднее время {0:0} дней. {1:0} час. {2:0} мин. ", Recording.RaceTimeDay(avgTime, metroGrid1.RowCount), Recording.RaceTimeHour(avgTime, metroGrid1.RowCount), Recording.RaceTimeMinute(avgTime, metroGrid1.RowCount));
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

        private void mComboMarathone_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.previousResBindingSource.Filter = String.Format(@"Convert(MarathonName,'System.String') LIKE '%" + mComboMarathone.Text+"%'");
            Refresh();
        }

        private void mComboDistant_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.previousResBindingSource.Filter = String.Format(@"Convert(EventTypeName,'System.String') LIKE '%" + mComboDistant.Text+"%'");
            Refresh();
        }

        private void mComboGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.previousResBindingSource.Filter = String.Format(@"Convert(Gender,'System.String') LIKE '%" + mComboGender.Text+"%'");
            Refresh();
        }

        private void mlClear_Click(object sender, EventArgs e)
        {
            previousResBindingSource.RemoveFilter();
            previousResBindingSource.RemoveSort();
        }

        private void mComboCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mComboCategories.Text == "до 18")
            {
                Str = Convert.ToString(DateTime.Now.AddYears(-17).ToLongDateString());
                this.previousResBindingSource.Filter = "DateOfBirth >= '" + Convert.ToDateTime(Str) + "'";
            }
            else if(mComboCategories.Text == "от 18 до 29")
            {
                Str1 = Convert.ToString(DateTime.Now.AddYears(-18).ToLongDateString());
                Str = Convert.ToString(DateTime.Now.AddYears(-29).ToLongDateString());
                this.previousResBindingSource.Filter = "DateOfBirth<='" + Str + "' AND DateOfBirth>='" + Str1 + "'";
            }
            else if(mComboCategories.Text == "от 30 до 39")
            {
                Str1 = Convert.ToString(DateTime.Now.AddYears(-30).ToLongDateString());
                Str = Convert.ToString(DateTime.Now.AddYears(-39).ToLongDateString());
                this.previousResBindingSource.Filter = "DateOfBirth<='" + Str + "' AND DateOfBirth>='" + Str1 + "'";
            }
            else if(mComboCategories.Text == "от 40 до 55")
            {
                Str1 = Convert.ToString(DateTime.Now.AddYears(-40).ToLongDateString());
                Str = Convert.ToString(DateTime.Now.AddYears(-55).ToLongDateString());
                this.previousResBindingSource.Filter = "DateOfBirth<='" + Str + "' AND DateOfBirth>='" + Str1 + "'";
            }
            else if(mComboCategories.Text == "от 56 до 70")
            {
                Str1 = Convert.ToString(DateTime.Now.AddYears(-56).ToLongDateString());
                Str = Convert.ToString(DateTime.Now.AddYears(-70).ToLongDateString());
                this.previousResBindingSource.Filter = "DateOfBirth<='" + Str + "' AND DateOfBirth>='" + Str1 + "'";
            }
            else if(mComboCategories.Text == "более 70")
            {
                Str = Convert.ToString(DateTime.Now.AddYears(-70).ToLongDateString());
                this.previousResBindingSource.Filter = "DateOfBirth <= '" + Convert.ToDateTime(Str) + "'";
            }
            Refresh();
        }

        private void timerDay_Tick(object sender, EventArgs e)
        {
            d = date - DateTime.Now;
            mlTime.Text = "Осталось " + d.Days + " д. " + d.Hours + " ч. " + d.Minutes + " мин. " + d.Seconds;
        }

        private void PreviousResult_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
