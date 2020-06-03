using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Марафон.Бегун
{
    public partial class InformationBlago : MetroFramework.Forms.MetroForm
    {
        private int IDBlago;
        public InformationBlago(int ID)
        {
            InitializeComponent();
            IDBlago = ID;
        }

        Image ConvertBinaryToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }

        private void InformationBlago_Load(object sender, EventArgs e)
        {
            this.charityTableAdapter.Fill(this.marathone.Charity);
            if(this.marathone.Charity.Count > 0)
            {
                for(int i=0; i < this.marathone.Charity.Count; i++)
                    if(IDBlago == this.marathone.Charity[i].CharityId)
                    {
                        try
                        {
                            this.metroLabel1.Text = this.marathone.Charity[i].CharityDescription;
                            this.Text = this.marathone.Charity[i].CharityName;
                            this.pictureBox1.Image = ConvertBinaryToImage(this.marathone.Charity[i].CharityLogo);
                        }catch(Exception ex) { }
                    }
            }
        }
    }
}
