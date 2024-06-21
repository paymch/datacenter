using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Aspose.Cells;
using DataCenter.DataBase;
using DataCenter.Help_class;

namespace DataCenter
{
    /// <summary>
    /// Логика взаимодействия для selectDateForExcel.xaml
    /// </summary>
    public partial class selectDateForExcel : Window
    {
        public selectDateForExcel()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            if (dtpEnd.SelectedDate != null && dtpSart.SelectedDate != null)
            {
                DateTime Start = (DateTime)dtpSart.SelectedDate;
                DateTime End = (DateTime)dtpEnd.SelectedDate;
                Print(DataCenterEntities.GetContext().Ремонт.Where(x => x.Дата_начала >= Start && x.Дата_начала <= End).ToList());

            }
            else
                MessageBox.Show("Заполните все поля!", "Ошибка");
        }

        private void Print(List<Ремонт> ремонтs) 
        {
            if (MessageBox.Show("Вы уверены, что хотите создать отчет?\n", "Подтверждение", MessageBoxButton.YesNo) == MessageBoxResult.Yes) 
            {

                var tableForExcel = ремонтs;
                //рабочая книга
                Workbook wbk = new Workbook();
                //Лист
                Worksheet worksheet = wbk.Worksheets[0];
                //Получение всех ячеек
                Cells cells = worksheet.Cells;

                cells.Merge(1, 2, 1, 5);
                //Добваление текста
                worksheet.Cells[1, 2].PutValue("Отчет ремонтных работ");
                //Получение стиля ячейки
                Aspose.Cells.Style style = worksheet.Cells[1, 2].GetStyle();
                Font font = style.Font;
                font.IsBold = true;
                font.Name = "Times New Roman";
                font.Size = 12;
                worksheet.Cells[1, 2].SetStyle(style);
                cells.Merge(2, 1, 1, 3);
                worksheet.Cells[2, 1].PutValue($"ФИО сотрудника: {publicUser.сотрудник.ФИО}");
                cells.Merge(3, 1, 1, 2);
                worksheet.Cells[3, 1].PutValue($"Сформирован от: {DateTime.Now.ToString("dd.MM.yyyy")}");


                worksheet.Cells[5, 1].PutValue("№");
                worksheet.Cells[5, 2].PutValue("Устройство");
                worksheet.Cells[5, 3].PutValue("Тип ремонта");
                worksheet.Cells[5, 4].PutValue("Сотрудник");
                worksheet.Cells[5, 5].PutValue("Клиент");
                worksheet.Cells[5, 6].PutValue("Дата начала");
                worksheet.Cells[5, 7].PutValue("Стоимость");

                int startRow = 6;
                int countRow = 1;

                foreach (Ремонт ремонт in tableForExcel)
                {
                    worksheet.Cells[startRow, 1].PutValue(countRow);
                    worksheet.Cells[startRow, 2].PutValue(DataCenterEntities.GetContext().Устройство.FirstOrDefault(x => x.id_Устройства == ремонт.id_Устройство)?.Наименование);
                    worksheet.Cells[startRow, 3].PutValue(DataCenterEntities.GetContext().Тип_ремонта.FirstOrDefault(x => x.id_Тип_ремонта == ремонт.id_Тип_ремонта)?.Тип_ремонта1);
                    worksheet.Cells[startRow, 4].PutValue(DataCenterEntities.GetContext().Сотрудник.FirstOrDefault(x => x.id_Сотрудник == ремонт.id_Сотрудник)?.ФИО);
                    worksheet.Cells[startRow, 5].PutValue(DataCenterEntities.GetContext().Клиент.FirstOrDefault(x => x.id_Клиент == ремонт.id_Клиент)?.ФИО);
                    DateTime date = (DateTime)ремонт.Дата_начала;
                    worksheet.Cells[startRow, 6].PutValue(date.ToString("dd.MM.yyyy"));
                    worksheet.Cells[startRow, 7].PutValue(ремонт.Стоимость + " р.");
                    startRow++;
                    countRow++;
                }


                worksheet.AutoFitColumns();

                Column column = worksheet.Cells.Columns[2];
                column.Width = 36.0;

                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string filePath = System.IO.Path.Combine(desktopPath, "отчет.xlsx");

                wbk.Save(filePath);

                MessageBox.Show("Отчет сформирован!", "Уведомление");
            }


        }

        private void btnAll_Click(object sender, RoutedEventArgs e)
        {
            Print(DataCenterEntities.GetContext().Ремонт.ToList());
        }
    }
}
