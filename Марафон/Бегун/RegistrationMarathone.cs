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
    public partial class RegistrationMarathone : MetroFramework.Forms.MetroForm
    {
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime();
        private int RunID, RegSum=0;
        public RegistrationMarathone(int runID)
        {
            InitializeComponent();
            RunID = runID;
        }

        private void RegistrationMarathone_Load(object sender, EventArgs e)
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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "marathone.Charity". При необходимости она может быть перемещена или удалена.
            this.charityTableAdapter.Fill(this.marathone.Charity);
            this.registrationTableAdapter.Fill(this.marathone.Registration);
            this.runRegistrationMarathoneTableAdapter.Fill(this.myDataSet.RunRegistrationMarathone);
            mRadioVariantA.Text = "Вариант А: браслет + номер ("+this.myDataSet.RunRegistrationMarathone[0].Cost1+"$)";
            mRadioVariantB.Text = "Вариант Б: бейсболка + бутылка воды ("+this.myDataSet.RunRegistrationMarathone[1].Cost1+"$)";
            mRadioVariantC.Text = "Вариант С: футболка + буклет ("+this.myDataSet.RunRegistrationMarathone[3].Cost1+"$)";        
        }
        #region Динамические данные
        private void mCheck5km_CheckedChanged(object sender, EventArgs e)
        {
            RegSum = mCheck5km.Checked ? RegSum += 40 : RegSum -= 40;
            metroLabel2.Text = RegSum.ToString();
        }

        private void mCheck21km_CheckedChanged(object sender, EventArgs e)
        {
            RegSum = mCheck21km.Checked ? RegSum += 75 : RegSum -= 75;
            metroLabel2.Text = RegSum.ToString();
        }

        private void mCheck42km_CheckedChanged(object sender, EventArgs e)
        {
            RegSum = mCheck42km.Checked ? RegSum += 145 : RegSum -= 145;
            metroLabel2.Text = RegSum.ToString();
        }

        private void mRadioVariantA_CheckedChanged(object sender, EventArgs e)
        {
            RegSum = mRadioVariantA.Checked ? RegSum += Convert.ToInt32(this.myDataSet.RunRegistrationMarathone[0].Cost1) : RegSum -= Convert.ToInt32(this.myDataSet.RunRegistrationMarathone[0].Cost1);
            metroLabel2.Text = RegSum.ToString();
        }

        private void mRadioVariantB_CheckedChanged(object sender, EventArgs e)
        {
            RegSum = mRadioVariantB.Checked ? RegSum += Convert.ToInt32(this.myDataSet.RunRegistrationMarathone[1].Cost1) : RegSum -= Convert.ToInt32(this.myDataSet.RunRegistrationMarathone[1].Cost1);
            metroLabel2.Text = RegSum.ToString();
        }

        private void mRadioVariantC_CheckedChanged(object sender, EventArgs e)
        {
            RegSum = mRadioVariantC.Checked ? RegSum += Convert.ToInt32(this.myDataSet.RunRegistrationMarathone[3].Cost1) : RegSum -= Convert.ToInt32(this.myDataSet.RunRegistrationMarathone[3].Cost1);
            metroLabel2.Text = RegSum.ToString();
        }
        #endregion
        private void mLinkInformation_Click(object sender, EventArgs e)
        {
            Бегун.InformationBlago frm = new Бегун.InformationBlago(Convert.ToInt32(this.metroComboBox1.SelectedValue));
            frm.Show();
        }

        private void timerDay_Tick(object sender, EventArgs e)
        {
            d = date - DateTime.Now;
            mlTime.Text = "Осталось " + d.Days + " д. " + d.Hours + " ч. " + d.Minutes + " мин. " + d.Seconds;
        }

        private void mbCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SponsorShipTarget_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar == (char)Keys.Back)
                e.Handled = true;
        }

        private void mbRegistration_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(SponsorShipTarget.Text) >= 0)
            {
                string temp = "";
                if (mRadioVariantA.Checked)
                    temp = "A";
                else if (mRadioVariantB.Checked)
                    temp = "B";
                else if (mRadioVariantC.Checked)
                    temp = "C";
                MessageBox.Show(RunID.ToString());
                this.registrationTableAdapter.Insert(Convert.ToDateTime(DateTime.Now), Convert.ToByte(1), Convert.ToDecimal(RegSum), Convert.ToInt32(metroComboBox1.SelectedValue), Convert.ToDecimal(SponsorShipTarget.Text), RunID, temp);
                MetroFramework.MetroMessageBox.Show(this, "Вы успешно зарегистрировались!", "Успех");
            }
            else
            {
                MessageBox.Show("Сумма взноса не должна быть отрицательной!", "Ошибка");
                return;
            }
        }
    }
}
