using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace Марафон.Администрация
{
    public partial class Inventory : MetroFramework.Forms.MetroForm
    {
        Word.Application wrdApp;
        Word._Document wrdDoc;
        Object oMissing = System.Reflection.Missing.Value;
        Object oFalse = false;
        TimeSpan d = new TimeSpan();
        DateTime dates = new DateTime();
        public Inventory()
        {
            InitializeComponent();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            timerDay.Start();
            this.eventTableAdapter.Fill(this.marathone.Event);
            if (this.marathone.Event.Count > 0)
            {
                for (int i = 0; i < this.marathone.Event.Count; i++)
                {
                    if (this.marathone.Event[i].EventId == "16_6HM")
                        dates = this.marathone.Event[i].StartDateTime;
                }
            }

            short date;
            int count=0,countA=0,countB=0,countC=0;
            this.registrationTableAdapter.Fill(this.marathone.Registration);
            this.marathonTableAdapter.Fill(this.marathone.Marathon);
            date = this.marathone.Marathon[this.marathone.Marathon.Count-1].YearHeld;
            if(this.marathone.Registration.Count > 0)
            {
                for(int i=0; i<this.marathone.Registration.Count; i++)
                {
                    DateTime date1 = new DateTime();
                    date1 = this.marathone.Registration[i].RegistrationDateTime;
                    if (date1.Year == date)
                        count++;
                    if (this.marathone.Registration[i].RaceKitOptionID == "A"  && date1.Year == date && this.marathone.Registration[i].IsRaceKitOptionIDNull())
                        countA++;
                    else if (this.marathone.Registration[i].RaceKitOptionID == "B"  && date1.Year == date && this.marathone.Registration[i].IsRaceKitOptionIDNull())
                        countB++;
                    else if (this.marathone.Registration[i].RaceKitOptionID == "C"  && date1.Year == date && this.marathone.Registration[i].IsRaceKitOptionIDNull())
                        countC++;
                }
            }
            metroLabel1.Text = "Всего участников: " + count;
            this.inventoryTableAdapter.Fill(this.marathone.Inventory);
            int komA=0, komB = 0, komC = 0;
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
            metroGrid1.Rows.Add("Выбрало данный комплект", countA, countB, countC, countA+countB+countC,komA+komB+komC);
            metroGrid1.Rows.Add("", "", "", "", "", "");
            metroGrid1.Rows.Add("Номер", countA, countB, countC, countA + countB + countC, this.marathone.Inventory[0].Номер);
            metroGrid1.Rows.Add("Браслет", countA, countB, countC, countA + countB + countC, this.marathone.Inventory[0].Браслет);
            metroGrid1.Rows.Add("Бейсболка", "", countB, countC, countB + countC, this.marathone.Inventory[0].Бейсболка);
            metroGrid1.Rows.Add("Бутылка воды", "", countB, countC, countB + countC, this.marathone.Inventory[0].Вода);
            metroGrid1.Rows.Add("Футболка", "", "", countC, countC, this.marathone.Inventory[0].Футболка);
            metroGrid1.Rows.Add("Сувенир", "", "", countC, countC, this.marathone.Inventory[0].Сувенир);

        }

        #region Word
        private void FillRow(Word._Document oDoc, int Row, string Text1, string Text2, string Text3, string Text4)
        {
            // заполнение полей таблицы отчета
            oDoc.Tables[1].Cell(Row, 1).Range.InsertAfter(Text1);
            oDoc.Tables[1].Cell(Row, 2).Range.InsertAfter(Text2);
            oDoc.Tables[1].Cell(Row, 3).Range.InsertAfter(Text3);
            oDoc.Tables[1].Cell(Row, 4).Range.InsertAfter(Text4);
        }
        private void InsertLines(int LineNum)//новый параграф
        {
            int iCount;
            for (iCount = 1; iCount <= LineNum; iCount++)
            {
                wrdApp.Selection.TypeParagraph();
            }
        }
        private void mbPrint_Click(object sender, EventArgs e)
        {
            try
            {
                Word.Selection wrdSelection;
                Word.Table wrdTable;
                string StrToAdd;

                // открываем Word и делаем его видимым
                wrdApp = new Word.Application();
                wrdApp.Visible = true;

                // создаем документ
                wrdDoc = wrdApp.Documents.Add(ref oMissing, ref oMissing,
                ref oMissing, ref oMissing);
                wrdDoc.Select();
                wrdSelection = wrdApp.Selection;

                // Заголовок документа.
                StrToAdd = "Отчет";
                wrdSelection.ParagraphFormat.Alignment =
                Word.WdParagraphAlignment.wdAlignParagraphCenter;
                wrdSelection.TypeText(StrToAdd);

                InsertLines(2);

                //выравнивание по правому краю и ставка времени и даты
                wrdSelection.ParagraphFormat.Alignment =
                    Word.WdParagraphAlignment.wdAlignParagraphRight;

                Object objDate = "Дата составления: dddd, MMMM dd, yyyy" + " г.";
                wrdSelection.InsertDateTime(ref objDate, ref oFalse, ref oMissing,
                    ref oMissing, ref oMissing);

                InsertLines(2);

                if (this.metroGrid1.Rows.Count <= 0)
                {
                    StrToAdd = "Таблица пустая";
                    wrdSelection.TypeText(StrToAdd);
                }
                else
                {
                    wrdTable = wrdDoc.Tables.Add(wrdSelection.Range, this.metroGrid1.Rows.Count + 1, 4,
                        ref oMissing, ref oMissing);
                    //Параметры таблицы
                    wrdTable.Columns[1].SetWidth(100, Word.WdRulerStyle.wdAdjustNone);
                    wrdTable.Columns[2].SetWidth(170, Word.WdRulerStyle.wdAdjustNone);
                    wrdTable.Columns[3].SetWidth(100, Word.WdRulerStyle.wdAdjustNone);
                    wrdTable.Columns[4].SetWidth(111, Word.WdRulerStyle.wdAdjustNone);

                    wrdTable.Rows[1].Cells.Shading.BackgroundPatternColorIndex =
                        Word.WdColorIndex.wdGray25;

                    wrdTable.Rows[1].Range.Bold = 1;

                    wrdTable.Cell(1, 1).Range.Paragraphs.Alignment =
                        Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    //отрисовка таблицы
                    wrdTable.Borders[Word.WdBorderType.wdBorderBottom].LineStyle =
                                                 Word.WdLineStyle.wdLineStyleSingle;
                    wrdTable.Borders[Word.WdBorderType.wdBorderTop].LineStyle =
                                                 Word.WdLineStyle.wdLineStyleSingle;
                    wrdTable.Borders[Word.WdBorderType.wdBorderVertical].LineStyle =
                                                 Word.WdLineStyle.wdLineStyleSingle;
                    wrdTable.Borders[Word.WdBorderType.wdBorderHorizontal].LineStyle =
                                                 Word.WdLineStyle.wdLineStyleSingle;
                    wrdTable.Borders[Word.WdBorderType.wdBorderLeft].LineStyle =
                                                 Word.WdLineStyle.wdLineStyleSingle;
                    wrdTable.Borders[Word.WdBorderType.wdBorderRight].LineStyle =
                                                 Word.WdLineStyle.wdLineStyleSingle;


                    FillRow(wrdDoc,1, "Наименование", "Остаток",
                        "Необходимо", "Надо заказать");

                    for (int i = 2; i <= this.metroGrid1.Rows.Count + 1; i++)
                    {
                        if ((Convert.ToInt32(this.metroGrid1[4, i].Value) - Convert.ToInt32(this.metroGrid1[5, i].Value)) >= 0)
                        FillRow(wrdDoc, i, this.metroGrid1[0, i].Value.ToString(), this.metroGrid1[5, i].Value.ToString(),
                       this.metroGrid1[4, i].Value.ToString(), Convert.ToString(Convert.ToInt32(this.metroGrid1[4, i].Value) - Convert.ToInt32(this.metroGrid1[5, i].Value)));
                        else
                            FillRow(wrdDoc, i, this.metroGrid1[0, i].Value.ToString(), this.metroGrid1[5, i].Value.ToString(),
                       this.metroGrid1[4, i].Value.ToString(), "Не требуется");
                    }
                }
            }
            catch(Exception ex) { }
        }
        #endregion

        private void mbPrihod_Click(object sender, EventArgs e)
        {
            InventoryAdd frm = new InventoryAdd();
            frm.Show();
            this.Close();
        }

        private void timerDay_Tick(object sender, EventArgs e)
        {
            d = dates - DateTime.Now;
            mlTime.Text = "Осталось " + d.Days + " д. " + d.Hours + " ч. " + d.Minutes + " мин. " + d.Seconds;
        }
    }
}
