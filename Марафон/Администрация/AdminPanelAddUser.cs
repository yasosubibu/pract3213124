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
    public partial class AdminPanelAddUser : MetroFramework.Forms.MetroForm
    {
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime();
        public AdminPanelAddUser()
        {
            InitializeComponent();
        }

        private void AdminPanelAddUser_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "marathone.Role". При необходимости она может быть перемещена или удалена.
            this.roleTableAdapter.Fill(this.marathone.Role);
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

        private void mbReg_Click(object sender, EventArgs e)
        {
            if(mtPassordPovtor.Text == mtPassword.Text)
                this.userTableAdapter.Insert(mtEmail.Text, mtPassword.Text, mtName.Text, mtFamile.Text, metroComboBox1.SelectedValue.ToString());
            MetroFramework.MetroMessageBox.Show(this,"Пользователь успешно добавлен!","Успех");    
        }

        private void timerDay_Tick(object sender, EventArgs e)
        {
            d = date - DateTime.Now;
            mlTime.Text = "Осталось " + d.Days + " д. " + d.Hours + " ч. " + d.Minutes + " мин. " + d.Seconds;
        }

        private void mtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) && e.KeyChar == (char)Keys.Back)
                e.Handled = true;
        }
    }
}
