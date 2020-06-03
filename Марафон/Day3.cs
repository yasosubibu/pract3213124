using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Марафон
{
    #region Управление волонтерами
    //Сортировка
    private void mComboGroup_SelectedIndexChanged(object sender, EventArgs e)
    {
        volunteerBindingSource.RemoveFilter();
        if (mComboGroup.Text == "Имя")
            metroGrid1.Sort(metroGrid1.Columns[1], ListSortDirection.Ascending);
        else if (mComboGroup.Text == "Фамилия")
            metroGrid1.Sort(metroGrid1.Columns[2], ListSortDirection.Ascending);
        else if (mComboGroup.Text == "Страна")
            metroGrid1.Sort(metroGrid1.Columns[3], ListSortDirection.Ascending);
        else if (mComboGroup.Text == "Пол")
            metroGrid1.Sort(metroGrid1.Columns[4], ListSortDirection.Ascending);
        metroLabel3.Text = "Всего волонтеров: " + this.volunteerBindingSource.Count.ToString();
    }

    //Загрузка волонтеров
    private void mtLoadFile_Click(object sender, EventArgs e)
    {
        using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "CSV|*.csv", ValidateNames = true })
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var sr = new StreamReader(new FileStream(ofd.FileName, FileMode.Open));
                using (var csvReader = new CsvReader(sr))
                {
                    csvReader.Read();
                    volunteerBindingSource.DataSource = csvReader.GetRecords<Администрация.Volonter>().ToArray();
                }
            }
        }
    }
    #endregion

    #region Мои спонсоры

    //Таблицы Registration + Charity + SponsorShip

    #endregion
}
