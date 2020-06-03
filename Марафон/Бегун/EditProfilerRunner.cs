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
    public partial class EditProfilerRunner : MetroFramework.Forms.MetroForm
    {
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime();
        private string Email;
        private int RunID;
        string filename = "";
        public EditProfilerRunner(int runid, string email)
        {
            InitializeComponent();
            Email = email;
            RunID = runid;
        }

        private void EditProfilerRunner_Load(object sender, EventArgs e)
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
            this.runnerTableAdapter.Fill(this.marathone.Runner);
            this.runnerTableAdapter.Adapter.SelectCommand.CommandText = String.Format(@"SELECT RunnerId, Gender, DateOfBirth, CountryCode, Email FROM Runner WHERE(RunnerId = '{0}')", RunID);
            this.runnerTableAdapter.Fill(this.marathone.Runner);
            if(this.marathone.Runner.Count > 0)
            {
               
                    metroDateTime1.Text = this.marathone.Runner[0].DateOfBirth.ToShortDateString();
                    mComboMale.Text = this.marathone.Runner[0].Gender.ToString();
                    mComboStrana.Text = this.marathone.Runner[0].CountryCode.ToString();
                    mtEmail.Text = this.marathone.Runner[0].Email;
                if (!(this.marathone.Runner[0].IsPhotoNull()))
                    pbImage.Image = ConvertToImage(this.marathone.Runner[0].Photo);
            }
            this.userTableAdapter.Fill(this.marathone.User);
            this.userTableAdapter.Adapter.SelectCommand.CommandText = String.Format(@"SELECT Email, Password, FirstName, LastName, RoleId FROM [User] WHERE (Email = '{0}')", Email);
            this.userTableAdapter.Fill(this.marathone.User);
            if(this.marathone.User.Count > 0)
            {
                mtName.Text = this.marathone.User[0].FirstName;
                mtFamily.Text = this.marathone.User[0].LastName;
            }
        }

        private void mbSave_Click(object sender, EventArgs e)
        {
            if (filename != "")
            {
                Image img = Image.FromFile(filename);
                this.runnerTableAdapter.Update(this.mComboMale.Text, Convert.ToDateTime(metroDateTime1.Value), Convert.ToString(this.mComboStrana.SelectedValue), this.mtEmail.Text, ConvertImageToBinary(img), RunID, this.marathone.Runner[0].Gender, this.marathone.Runner[0].DateOfBirth, this.marathone.Runner[0].CountryCode, this.marathone.Runner[0].Email, RunID);
                if (mtPassword.Text != "")
                {
                    if (Recording.SecurityPassword(mtPassword.Text))
                    {
                        //Меняем пароль
                        if (mtPassword.Text == mtPasswordPovtor.Text)
                            this.userTableAdapter.Update(this.mtPassword.Text, this.mtName.Text, this.mtFamily.Text, this.marathone.User[0].RoleId, this.marathone.User[0].Email, this.marathone.User[0].Password, this.marathone.User[0].FirstName, this.marathone.User[0].LastName, this.marathone.User[0].RoleId);
                        else
                            MetroFramework.MetroMessageBox.Show(this, "Не правильный повторный пароль!", "Ошибка смены пароля");
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Пароль должен содержать: \n 1. Минимум 6 символов \n 2. Минимум 1 цифру \n 3. Набор специальных знаков \n 4. 1 прописная буква");
                        return;
                    }
                }
                else
                {
                    this.userTableAdapter.Update(this.marathone.User[0].Password, this.mtName.Text, this.mtFamily.Text, this.marathone.User[0].RoleId, this.marathone.User[0].Email, this.marathone.User[0].Password, this.marathone.User[0].FirstName, this.marathone.User[0].LastName, this.marathone.User[0].RoleId);
                }
                this.Update();
                MetroFramework.MetroMessageBox.Show(this, "Данные успешно измененые", "Успех");
            }
            else
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Фото профиля не загружено?", "Фото не загружено", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    return;
                }
            }
        }

        byte[] ConvertImageToBinary(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
        Image ConvertToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
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
                }
            }
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

        private void mtFamily_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) && e.KeyChar == (char)Keys.Back)
                e.Handled = true;
        }
    }
}
