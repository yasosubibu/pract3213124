using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Марафон.Администрация
{
    public partial class EditFormUsers : MetroFramework.Forms.MetroForm
    {
        private string Email = "";
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime();
        public EditFormUsers(string email)
        {
            InitializeComponent();
            Email = email;
        }

        private void EditFormUsers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "marathone.Gender". При необходимости она может быть перемещена или удалена.
            this.genderTableAdapter.Fill(this.marathone.Gender);
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
            this.userTableAdapter.Fill(this.marathone.User);
            this.userTableAdapter.Adapter.SelectCommand.CommandText = String.Format(@"SELECT Email, Password, FirstName, LastName, RoleId FROM [User] WHERE(Email = '{0}')",Email);
            this.userTableAdapter.Fill(this.marathone.User);
            mtFanily.Text = this.marathone.User[0].LastName;
            mtName.Text = this.marathone.User[0].FirstName;
            metroComboBox1.Text = this.marathone.User[0].RoleId;
            mlEmail.Text = Email;
        }

        private void timerDay_Tick(object sender, EventArgs e)
        {
            d = date - DateTime.Now;
            mlTime.Text = "Осталось " + d.Days + " д. " + d.Hours + " ч. " + d.Minutes + " мин. " + d.Seconds;
        }

        private void mbSave_Click(object sender, EventArgs e)
        {
            if(metroTextBox1.Text.Length > 0 && metroTextBox1.Text == metroTextBox2.Text)
            {
                this.userTableAdapter.Update(this.metroTextBox2.Text, mtName.Text, mtFanily.Text, metroComboBox1.Text, Email, this.marathone.User[0].Password, this.marathone.User[0].FirstName, this.marathone.User[0].LastName, this.marathone.User[0].RoleId);
            }
            else
            {
                this.userTableAdapter.Update(this.marathone.User[0].Password, mtName.Text, mtFanily.Text, metroComboBox1.Text, Email, this.marathone.User[0].Password, this.marathone.User[0].FirstName, this.marathone.User[0].LastName, this.marathone.User[0].RoleId);
            }
            MetroFramework.MetroMessageBox.Show(this, "Информация успешно сохранена!");
        }

        private void mbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) && e.KeyChar == (char)Keys.Back)
                e.Handled = true;
        }
    }
}
