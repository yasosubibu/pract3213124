using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Марафон
{
    #region Регистрация на марафон + условия регитсрации
    private void mRegistration_Click(object sender, EventArgs e)
    {
        for (int i = 0; i < this.marathone.User.Count; i++)
        {
            if (mtEmail.Text == this.marathone.User[i].Email)
            {
                MetroFramework.MetroMessageBox.Show(this, "Такой пользователь уже зарегистрирован!", "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        if (mtEmail.Text != "" && mtFamily.Text != "" && mtName.Text != "" && mtPassword.Text != "" & mtPasswordPovtor.Text != "" && mComboStrana.Text != "" && metroComboBox1.Text != "")
        {

            if (mtPassword.Text == mtPasswordPovtor.Text && Recording.SecurityPassword(mtPassword.Text) && Recording.IsValidEmail(mtEmail.Text) && Recording.IsValidDate(mHappyBirthday.Value, 10))
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
                MetroFramework.MetroMessageBox.Show(this, "Пароли не совпадают или их надёжность не высока", "Ошибка регистрации", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        else
            MetroFramework.MetroMessageBox.Show(this, "Не все поля были заполнены!", "Ошибка заполнения", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
    #endregion 

    #region Регистрация на марафон
    //Table RaceKitOption + Registration
    private void mbRegistration_Click(object sender, EventArgs e)
    {
        string temp = "";
        if (mRadioVariantA.Checked)
            temp = "A";
        else if (mRadioVariantB.Checked)
            temp = "B";
        else if (mRadioVariantC.Checked)
            temp = "C";

        this.registrationTableAdapter.Insert(Convert.ToDateTime(DateTime.Now), Convert.ToByte(1), Convert.ToDecimal(RegSum), Convert.ToInt32(metroComboBox1.SelectedValue), Convert.ToDecimal(SponsorShipTarget.Text), RunID, temp);

        this.registrationTableAdapter.Adapter.SelectCommand.CommandText = String.Format(@"SELECT * FROM Registration WHERE(RunnerID = '{0}')", RunID);
        this.registrationTableAdapter.Fill(this.marathone.Registration);
        Random c = new Random();

        for (int i = 0; i < this.marathone.Registration.Count; i++)
        {
            DateTime date = new DateTime();
            date = this.marathone.Registration[i].RegistrationDateTime;
            if (date.Minute == DateTime.Now.Minute && date.Month == DateTime.Now.Month && date.Day == DateTime.Now.Day)
            {
                if (mCheck21km.Checked)
                    this.registrationEventTableAdapter.Insert(Convert.ToInt16(c.Next(40)), Convert.ToInt32(c.Next(5000)), this.marathone.Registration[i].RegistrationId, "16_6HM", 0);
                if (mCheck42km.Checked)
                    this.registrationEventTableAdapter.Insert(Convert.ToInt16(c.Next(40)), Convert.ToInt32(c.Next(5000)), this.marathone.Registration[i].RegistrationId, "16_6FM", 0);
                if (mCheck5km.Checked)
                    this.registrationEventTableAdapter.Insert(Convert.ToInt16(c.Next(40)), Convert.ToInt32(c.Next(5000)), this.marathone.Registration[i].RegistrationId, "16_6FR", 0);
            }
        }
        MetroFramework.MetroMessageBox.Show(this, "Вы успешно зарегистрировались!", "Успех");
    }
    #endregion

    #region Мои результаты
    //Table RegistrationEvent + Event
    private int RegistrationId;
    private string Gen;
    private DateTime Date;
    private void MyResult_Load(object sender, EventArgs e)
    {
        // TODO: данная строка кода позволяет загрузить данные в таблицу "marathone.EventType". При необходимости она может быть перемещена или удалена.
        this.eventTypeTableAdapter.Fill(this.marathone.EventType);
        // TODO: данная строка кода позволяет загрузить данные в таблицу "marathone.Marathon". При необходимости она может быть перемещена или удалена.
        this.marathonTableAdapter.Fill(this.marathone.Marathon);
        // TODO: данная строка кода позволяет загрузить данные в таблицу "myDataSet.ResultRunner". При необходимости она может быть перемещена или удалена.
        this.resultRunnerTableAdapter.Fill(this.myDataSet.ResultRunner);
        this.registrationEventTableAdapter.Fill(this.marathone.RegistrationEvent);

        #region Сортировка мест
        string[] temp = { "11_1FM", "11_1FR", "11_1HM", "14_4FM", "14_4FR", "14_4HM", "15_5FM", "15_5FR", "15_5HM", "16_6FM", "16_6FR", "16_6HM" };
        for (int i = 0; i < temp.Length; i++)
        {
            this.registrationEventTableAdapter.Adapter.SelectCommand.CommandText = String.Format(@"SELECT RegistrationEventId, BibNumber, RaceTime, RegistrationID, EventID, Position FROM RegistrationEvent " +
                                                                                                   " WHERE(EventID = '{0}')" +
                                                                                                   " ORDER BY RaceTime", temp[i]);
            this.registrationEventTableAdapter.Fill(this.marathone.RegistrationEvent);
            if (this.marathone.RegistrationEvent.Count > 0)
            {
                int k = 0;
                for (int j = 0; j < this.marathone.RegistrationEvent.Count; j++)
                {
                    k++;
                    this.registrationEventTableAdapter.Update(this.marathone.RegistrationEvent[j].BibNumber, this.marathone.RegistrationEvent[j].RaceTime, this.marathone.RegistrationEvent[j].RegistrationID, this.marathone.RegistrationEvent[j].EventID, k, this.marathone.RegistrationEvent[j].RegistrationEventId, this.marathone.RegistrationEvent[j].BibNumber, this.marathone.RegistrationEvent[j].RaceTime, this.marathone.RegistrationEvent[j].RegistrationID, this.marathone.RegistrationEvent[j].EventID, this.marathone.RegistrationEvent[j].Position);
                }
            }
        }
        #endregion

        this.resultRunnerTableAdapter.Adapter.SelectCommand.CommandText = String.Format(@"SELECT RegistrationEvent.RaceTime, RegistrationEvent.BibNumber, RegistrationEvent.RegistrationID, Event.EventTypeId, Event.MarathonId, RegistrationEvent.Position " +
                                                                            " FROM Event INNER JOIN RegistrationEvent ON Event.EventId = RegistrationEvent.EventID WHERE(RegistrationEvent.RegistrationID = '{0}')", RegistrationId);
        this.resultRunnerTableAdapter.Fill(this.myDataSet.ResultRunner);


        metroLabel1.Text = "Пол: " + Gen;
        DateTime dt; TimeSpan dt2;
        dt = DateTime.Now;
        dt2 = dt - Date;
        if (dt2.Days / 365 < 18)
            metroLabel2.Text = "Возрастная категория: до 18";
        else if ((dt2.Days / 365) >= 18 && (dt2.Days / 365) <= 29)
            metroLabel2.Text = "Возрастная категория: от 18 до 29";
        else if ((dt2.Days / 365) >= 30 && (dt2.Days / 365) <= 39)
            metroLabel2.Text = "Возрастная категория: от 30 до 39";
        else if ((dt2.Days / 365) >= 40 && (dt2.Days / 365) <= 55)
            metroLabel2.Text = "Возрастная категория: от 40 до 55";
        else if ((dt2.Days / 365) >= 56 && (dt2.Days / 365) <= 70)
            metroLabel2.Text = "Возрастная категория: от 56 до 70";
        else if ((dt2.Days / 365) > 70)
            metroLabel2.Text = "Возрастная категория: более 70";
    }

    #endregion

    #region На сколько долгий марафон

    private void metroTabControl1_Selected(object sender, TabControlEventArgs e)
    {
            this.howLongBindingSource.RemoveFilter();
        switch ((sender as TabControl).SelectedIndex.ToString())
        {
            case ("0"):
                {
                    this.howLongTableAdapter.Adapter.SelectCommand.CommandText = String.Format(@"SELECT id, Name, Photo, Description FROM HowLong WHERE (id >= 1) AND (id <= 7)");
                    this.howLongTableAdapter.Fill(this.marathone.HowLong);
                }
                break;
            case ("1"):
                {
                    this.howLongTableAdapter.Adapter.SelectCommand.CommandText = String.Format(@"SELECT id, Name, Photo, Description FROM HowLong WHERE (id >= 8)");
                    this.howLongTableAdapter.Fill(this.marathone.HowLong);
                }
                break;
        }
    }

    //howLongTableAdapter.Insert("Ronaldinho", ConvertImageToBinary(img), "Описание");
    // this.Validate();
    // this.howLongBindingSource.EndEdit();
    // this.howLongTableAdapter.Update(this.marathone.HowLong);

    #endregion

    #region Инвентарь
    private void Inventory_Load(object sender, EventArgs e)
    {
        short date;
        int count = 0, countA = 0, countB = 0, countC = 0;
        this.registrationTableAdapter.Fill(this.marathone.Registration);
        this.marathonTableAdapter.Fill(this.marathone.Marathon);
        date = this.marathone.Marathon[this.marathone.Marathon.Count - 1].YearHeld;
        if (this.marathone.Registration.Count > 0)
        {
            for (int i = 0; i < this.marathone.Registration.Count; i++)
            {
                DateTime date1 = new DateTime();
                date1 = this.marathone.Registration[i].RegistrationDateTime;
                if (date1.Year == date)
                    count++;
                if (this.marathone.Registration[i].RaceKitOptionID == "A" && this.marathone.Registration[i].RaceKitOptionID != "" && date1.Year == date)
                    countA++;
                else if (this.marathone.Registration[i].RaceKitOptionID == "B" && this.marathone.Registration[i].RaceKitOptionID != "" && date1.Year == date)
                    countB++;
                else if (this.marathone.Registration[i].RaceKitOptionID == "C" && this.marathone.Registration[i].RaceKitOptionID != "" && date1.Year == date)
                    countC++;
            }
        }
        metroLabel1.Text = "Всего участников: " + count;
        this.inventoryTableAdapter.Fill(this.marathone.Inventory);
        int komA = 0, komB = 0, komC = 0;
        if (this.marathone.Inventory[0].Номер >= this.marathone.Inventory[0].Браслет)
            komA = this.marathone.Inventory[0].Браслет;
        else
            komA = this.marathone.Inventory[0].Номер;
        if (this.marathone.Inventory[0].Бейсболка >= this.marathone.Inventory[0].Вода)
            komB = this.marathone.Inventory[0].Вода;
        else
            komB = this.marathone.Inventory[0].Бейсболка;
        if (this.marathone.Inventory[0].Футболка >= this.marathone.Inventory[0].Сувенир)
            komC = this.marathone.Inventory[0].Сувенир;
        else
            komC = this.marathone.Inventory[0].Футболка;
        metroGrid1.Rows.Add("Выбрало данный комплект", countA, countB, countC, countA + countB + countC, komA + komB + komC);
        metroGrid1.Rows.Add("", "", "", "", "", "");
        metroGrid1.Rows.Add("Номер", countA, countB, countC, countA + countB + countC, this.marathone.Inventory[0].Номер);
        metroGrid1.Rows.Add("Браслет", countA, countB, countC, countA + countB + countC, this.marathone.Inventory[0].Браслет);
        metroGrid1.Rows.Add("Бейсболка", "", countB, countC, countB + countC, this.marathone.Inventory[0].Бейсболка);
        metroGrid1.Rows.Add("Бутылка воды", "", countB, countC, countB + countC, this.marathone.Inventory[0].Вода);
        metroGrid1.Rows.Add("Футболка", "", "", countC, countC, this.marathone.Inventory[0].Футболка);
        metroGrid1.Rows.Add("Сувенир", "", "", countC, countC, this.marathone.Inventory[0].Сувенир);

    }
    #endregion
}
