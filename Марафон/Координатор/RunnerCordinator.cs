using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Марафон
{
    public partial class RunnerCordinator : MetroFramework.Forms.MetroForm
    {
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime();
        public RunnerCordinator()
        {
            InitializeComponent();
        }

        private void RunnerCordinator_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDataSet.RunCordinatorNew". При необходимости она может быть перемещена или удалена.
            this.runCordinatorNewTableAdapter.Fill(this.myDataSet.RunCordinatorNew);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "marathone.EventType". При необходимости она может быть перемещена или удалена.
            this.eventTypeTableAdapter.Fill(this.marathone.EventType);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "marathone.RegistrationStatus". При необходимости она может быть перемещена или удалена.
            this.registrationStatusTableAdapter.Fill(this.marathone.RegistrationStatus);

            metroLabel6.Text = "Всего забегов: " + this.metroGrid2.RowCount;
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

        private void mbClearFilter_Click(object sender, EventArgs e)
        {
            runCordinatorNewBindingSource.RemoveFilter();
            metroLabel6.Text = "Всего забегов: " + this.metroGrid2.RowCount;
        }

        private void mComboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(mComboStatus.Text != "")
                this.runCordinatorNewBindingSource.Filter = String.Format(@"Convert(RegistrationStatus,'System.String') LIKE '%" + mComboStatus.Text + "%'");
            metroLabel6.Text = "Всего забегов: " + this.metroGrid2.RowCount;
        }

        private void mComboDistant_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mComboDistant.Text != "")
                this.runCordinatorNewBindingSource.Filter = String.Format(@"Convert(EventTypeName, 'System.String') LIKE '%" + mComboDistant.Text + "%'");
            metroLabel6.Text = "Всего забегов: " + this.metroGrid2.RowCount;
        }

        private void mGroupGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mGroupGroup.Text == "Почта")
                this.metroGrid2.Sort(this.metroGrid2.Columns[1], ListSortDirection.Ascending);
            else if (mGroupGroup.Text == "Имя")
                this.metroGrid2.Sort(this.metroGrid2.Columns[3], ListSortDirection.Ascending);
            else if (mGroupGroup.Text == "Фамилия")
                this.metroGrid2.Sort(this.metroGrid2.Columns[4],ListSortDirection.Ascending);
            metroLabel6.Text = "Всего забегов: " + this.metroGrid2.RowCount;
        }

        private void mTileEmailList_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("csv.txt");
            for(int i=0; i < this.metroGrid2.Rows.Count; i++)
                sw.WriteLine(metroGrid2[3,i].Value.ToString() + " : " + metroGrid2[1,i].Value.ToString());
            sw.Close();
            MetroFramework.MetroMessageBox.Show(this,"Список Email адресов успешно записан в файл csv.txt","Успех");
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "CSV|*.csv", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (var sw = new StreamWriter(sfd.FileName))
                    {
                        //var writer = new CsvHelper.CsvWriter(sw);
                        //writer.WriteHeader(typeof(Координатор.Run));
                        //foreach (Координатор.Run s in runCordinatorNewBindingSource.DataSource as List<Координатор.Run>)
                        //{
                        //    writer.WriteRecord(s);
                        //}
                        string temp = "";
                        for(int i=0; i < this.metroGrid2.Rows.Count; i++)
                        {
                            temp = metroGrid2[1, i].Value.ToString() + ";" + metroGrid2[3, i].Value.ToString() + ";" + metroGrid2[4, i].Value.ToString();
                            sw.WriteLine(temp);
                        }
                        sw.Close();
                    }
                    MetroFramework.MetroMessageBox.Show(this,"CSV файл отчета успешно создан!");
                }
            }
        }

        private void metroGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                MetroFramework.MetroMessageBox.Show(this,"В случае некорректной информации откройте окно повторный раз!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Координатор.ManagmentRunner frm = new Координатор.ManagmentRunner(metroGrid2.CurrentRow.Cells[1].Value.ToString(), Convert.ToInt32(metroGrid2.CurrentRow.Cells[0].Value), Convert.ToString(metroGrid2.CurrentRow.Cells[2].Value));
                frm.Show();
            }
        }

        private void timerDay_Tick(object sender, EventArgs e)
        {
            d = date - DateTime.Now;
            mlTime.Text = "Осталось " + d.Days + " д. " + d.Hours + " ч. " + d.Minutes + " мин. " + d.Seconds;
        }
    }
}
