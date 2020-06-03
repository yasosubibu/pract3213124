using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Марафон.Координатор
{
    public partial class Sertificat : MetroFramework.Forms.MetroForm
    {
        private string Name, Famile, Distant;
        private int RaceTime, Position;
        private decimal SumBlago;
        public Sertificat(string name, string famile, string distant, int race, int pos, decimal sum)
        {
            InitializeComponent();
            Name = name;
            Famile = famile;
            Distant = distant;
            RaceTime = race;
            Position = pos;
            SumBlago = sum;
        }

        private void Sertificat_Load(object sender, EventArgs e)
        {
            var ts = TimeSpan.FromSeconds(RaceTime);

            metroLabel1.Text = "Поздравляем " + Name + " " + Famile + " с участием в "+Distant+". \n Ваши результаты "+ ts.Days +" д. "+ts.Hours+" час. " + ts.Minutes + " мин. и занятое место " + Position;
            metroLabel2.Text = "Вы так же заработали " + SumBlago + " $ \n для вашей благотворительной организации";
        }
    }
}
