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
    public partial class InventoryAdd : MetroFramework.Forms.MetroForm
    {
        public InventoryAdd()
        {
            InitializeComponent();
        }

        private void InventoryAdd_Load(object sender, EventArgs e)
        {
            this.inventoryTableAdapter.Fill(this.marathone.Inventory);
        }

        private void mtSave_Click(object sender, EventArgs e)
        {
            this.inventoryTableAdapter.Update(Convert.ToInt32(this.mtNumber.Text) + this.marathone.Inventory[0].Номер, Convert.ToInt32(this.mtBraslet.Text) + this.marathone.Inventory[0].Браслет, Convert.ToInt32(this.mtVater.Text) + this.marathone.Inventory[0].Вода, Convert.ToInt32(this.mtKepa.Text) + this.marathone.Inventory[0].Бейсболка, Convert.ToInt32(this.mtFutbolka.Text) + this.marathone.Inventory[0].Футболка, Convert.ToInt32(this.mtBucklet.Text) + this.marathone.Inventory[0].Сувенир, this.marathone.Inventory[0].ID, this.marathone.Inventory[0].Номер, this.marathone.Inventory[0].Браслет, this.marathone.Inventory[0].Вода, this.marathone.Inventory[0].Бейсболка, this.marathone.Inventory[0].Футболка, this.marathone.Inventory[0].Сувенир);
            MetroFramework.MetroMessageBox.Show(this,"Товар успешно занесён на склад!","Успех",MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Update();
        }

        private void InventoryAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            Inventory frm = new Inventory();
            frm.ShowDialog();
        }

        private void mtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar == (char)Keys.Back)
                e.Handled = true;
        }
    }
}
