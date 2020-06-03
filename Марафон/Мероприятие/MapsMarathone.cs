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
    public partial class MapsMarathone : MetroFramework.Forms.MetroForm
    {
        public MapsMarathone()
        {
            InitializeComponent();
        }

        private void MapsMarathone_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void MapsMarathone_Load(object sender, EventArgs e)
        {
            this.howLongTableAdapter.Fill(this.marathone.HowLong);
        }

        private void mbOne_Click(object sender, EventArgs e)
        {
            Мероприятие.ButtonOne frm = new Мероприятие.ButtonOne();
            frm.Show();
        }

        private void mbFinish_Click(object sender, EventArgs e)
        {
            Мероприятие.Точки_на_карте.FinishandStart frm = new Мероприятие.Точки_на_карте.FinishandStart();
            frm.Show();
        }

        private void mbThree_Click(object sender, EventArgs e)
        {
            Мероприятие.Точки_на_карте.Three frm = new Мероприятие.Точки_на_карте.Three();
            frm.Show();
        }

        private void mbFive_Click(object sender, EventArgs e)
        {
            Мероприятие.Точки_на_карте.Five frm = new Мероприятие.Точки_на_карте.Five();
            frm.Show();
        }

        private void mbSix_Click(object sender, EventArgs e)
        {
            Мероприятие.Точки_на_карте.Six frm = new Мероприятие.Точки_на_карте.Six();
            frm.Show();
        }

        private void mbFoure_Click(object sender, EventArgs e)
        {
            Мероприятие.Точки_на_карте.Three frm = new Мероприятие.Точки_на_карте.Three();
            frm.Show();
        }

        private void mbTwo_Click(object sender, EventArgs e)
        {
            Мероприятие.Точки_на_карте.Two frm = new Мероприятие.Точки_на_карте.Two();
            frm.Show();
        }
    }
}
