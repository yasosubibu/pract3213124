using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Марафон.Администрация;

namespace Марафон
{
    public partial class AdminUser : MetroFramework.Forms.MetroForm
    {
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime();
        public AdminUser()
        {
            InitializeComponent();
        }

        private void mbAddUser_Click(object sender, EventArgs e)
        {
            AdminPanelAddUser frm = new AdminPanelAddUser();
            frm.ShowDialog();
        }

        private void AdminUser_Load(object sender, EventArgs e)
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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "marathone.Role". При необходимости она может быть перемещена или удалена.
            this.roleTableAdapter.Fill(this.marathone.Role);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "marathone.User". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter.Fill(this.marathone.User);
            metroLabel4.Text = "Всего пользователй: " + this.metroGrid1.RowCount;
            this.runnerTableAdapter.Fill(this.marathone.Runner);
        }

        private void mtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.userBindingSource.RemoveFilter();

                if (!string.IsNullOrEmpty(mtSearch.Text))
                {
                    userBindingSource.Filter = "Convert(FirstName,'System.String') LIKE '%" + mtSearch.Text + "%' or Convert(LastName,'System.String') LIKE '%" + mtSearch.Text + "%' or Convert(Email,'System.String') LIKE '%" + mtSearch.Text + "%'";
                    if (this.userBindingSource.Count == 0)
                    {
                        this.userBindingSource.RemoveFilter();
                        mtSearch.Text = "";
                    }
                    mtSearch.Text = "";
                }
                else
                {
                    userBindingSource.Filter = string.Empty;
                    mtSearch.Text = "";
                }
                metroLabel4.Text = "Всего пользователей: " + this.metroGrid1.RowCount;
            }
        }

        private void mComboGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            userBindingSource.RemoveFilter();
            if (mComboGroup.Text == "Почта") 
                metroGrid1.Sort(metroGrid1.Columns[0], ListSortDirection.Ascending);
            else if (mComboGroup.Text == "Имя") 
                metroGrid1.Sort(metroGrid1.Columns[2], ListSortDirection.Ascending);
            else if (mComboGroup.Text == "Фамилия") 
                metroGrid1.Sort(metroGrid1.Columns[3], ListSortDirection.Ascending);
            else if (mComboGroup.Text == "Роль")
                metroGrid1.Sort(metroGrid1.Columns[4],ListSortDirection.Ascending);
            metroLabel4.Text = "Всего пользователй: " + this.metroGrid1.RowCount;
        }

        private void mComboRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            userBindingSource.RemoveFilter();
            if (mComboRole.Text != "")
                userBindingSource.Filter = String.Format(@"Convert(RoleId,'System.String') LIKE '{0}'", mComboRole.SelectedValue.ToString());
            metroLabel4.Text = "Всего пользователй: " + this.metroGrid1.RowCount;
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (metroGrid1.CurrentCell.ColumnIndex == 5)
            {
                EditFormUsers frm = new EditFormUsers(metroGrid1.CurrentRow.Cells[0].Value.ToString());
                frm.ShowDialog();
            }
        }

        private void timerDay_Tick(object sender, EventArgs e)
        {
            d = date - DateTime.Now;
            mlTime.Text = "Осталось " + d.Days + " д. " + d.Hours + " ч. " + d.Minutes + " мин. " + d.Seconds;
        }
    }
}
