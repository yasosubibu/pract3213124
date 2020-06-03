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
using Universal;

namespace Марафон
{
    public partial class RunnerRegistration : MetroFramework.Forms.MetroForm
    {
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime();
        string filename;
        bool Img = false;
        public RunnerRegistration()
        {
            InitializeComponent();
        }

        private void mRegistration_Click(object sender, EventArgs e)
        {
            for(int i=0; i < this.marathone.User.Count; i++)
            {
                if(mtEmail.Text == this.marathone.User[i].Email)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Такой пользователь уже зарегистрирован!", "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (mtEmail.Text != "" && mtFamily.Text != "" && mtName.Text != "" && mtPassword.Text != "" & mtPasswordPovtor.Text != "" && mComboStrana.Text != "" && metroComboBox1.Text != "")
            {
                if (!(Recording.SecurityPassword(mtPassword.Text)))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Пароль должен содержать: \n 1. Минимум 6 символов \n 2. Минимум 1 цифру \n 3. Набор специальных знаков \n 4. 1 прописная буква");
                    return;
                }
                if (!(Recording.IsValidDate(Convert.ToDateTime(mHappyBirthday.Value), 10)))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Возраст участника должен быть не меньше 10 лет!");
                    return;
                }
                if (!(Recording.IsValidEmail(mtEmail.Text)))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Не корректный Email адрес!");
                    return;
                }
                if (mtPassword.Text == mtPasswordPovtor.Text)
                {
                    if (!Img)
                    {
                        if (MetroFramework.MetroMessageBox.Show(this, "Вы хотите загрузить фото профиля?", "Фото", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            return;
                        }
                        else
                        {
                            this.userTableAdapter.Insert(mtEmail.Text, this.mtPassword.Text, mtName.Text, mtFamily.Text, "R");
                            Image img = Image.FromFile(filename);
                            this.runnerTableAdapter.Insert(metroComboBox1.Text, Convert.ToDateTime(this.mHappyBirthday.Value), Convert.ToString(this.mComboStrana.SelectedValue), this.mtEmail.Text, null);
                            MetroFramework.MetroMessageBox.Show(this, "Вы успешно зарегистрировались!", "Успех", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        this.userTableAdapter.Insert(mtEmail.Text, this.mtPassword.Text, mtName.Text, mtFamily.Text, "R");
                        Image img = Image.FromFile(filename);
                        this.runnerTableAdapter.Insert(metroComboBox1.Text, Convert.ToDateTime(this.mHappyBirthday.Value), Convert.ToString(this.mComboStrana.SelectedValue), this.mtEmail.Text, ConvertImageToBinary(img));
                        MetroFramework.MetroMessageBox.Show(this, "Вы успешно зарегистрировались!", "Успех", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Пароли не совпадают", "Ошибка регистрации", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            else
                MetroFramework.MetroMessageBox.Show(this, "Не все поля были заполнены!", "Ошибка заполнения", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void RunnerRegistration_Load(object sender, EventArgs e)
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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "marathone.Country". При необходимости она может быть перемещена или удалена.
            this.countryTableAdapter.Fill(this.marathone.Country);
            this.userTableAdapter.Fill(this.marathone.User);
            this.runnerTableAdapter.Fill(this.marathone.Runner);
        }

        byte[] ConvertImageToBinary(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        } 

        private void mlDownloadPhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    filename = ofd.FileName;
                    pbImage.Image = Image.FromFile(filename);
                    Img = true;
                }
            }
        }

        private void RunnerRegistration_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
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
