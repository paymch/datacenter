using DataCenter.DataBase;
using DataCenter.Help_class;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DataCenter
{
    /// <summary>
    /// Логика взаимодействия для History.xaml
    /// </summary>
    public partial class History : Page
    {
        public History()
        {
            InitializeComponent();

            dgRepairs.ItemsSource = DataCenterEntities.GetContext().Ремонт.ToList();
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            dpDateFilter.SelectedDate = null;
            txtClientFilter.Text = null;
            txtEmployeeFilter.Text = null;
            txtEmployeeFilter.Text = null;
            txtRepairTypeFilter.Text = null;

            dgRepairs.ItemsSource = DataCenterEntities.GetContext().Ремонт.ToList();


        }

        private void Filter() 
        {
            List<Ремонт> ремонтs = DataCenterEntities.GetContext().Ремонт.ToList();

            if (dpDateFilter.SelectedDate != null) 
            {
                DateTime date = (DateTime)dpDateFilter.SelectedDate;
                ремонтs = ремонтs.Where(x => x.Дата_начала >= date).ToList();
            
            }

            if (txtClientFilter.Text != null) 
            {
                ремонтs = ремонтs.Where(x => x.Клиент.ФИО.Contains(txtClientFilter.Text)).ToList();
            }

            if (txtDeviceFilter.Text != null)
            {
                ремонтs = ремонтs.Where(x => x.Устройство.Наименование.Contains(txtClientFilter.Text)).ToList();
            }

            if (txtEmployeeFilter.Text != null)
            {
                ремонтs = ремонтs.Where(x => x.Сотрудник.ФИО.Contains(txtClientFilter.Text)).ToList();
            }

            if (txtRepairTypeFilter.Text != null)
            {
                ремонтs = ремонтs.Where(x => x.Тип_ремонта.Тип_ремонта1.Contains(txtClientFilter.Text)).ToList();
            }

            dgRepairs.ItemsSource = ремонтs;
        }

        private void dpDateFilter_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            Filter();
        }

        private void txtClientFilter_TextChanged(object sender, TextChangedEventArgs e)
        {
            Filter();
        }

        private void txtEmployeeFilter_TextChanged(object sender, TextChangedEventArgs e)
        {
            Filter();
        }

        private void txtRepairTypeFilter_TextChanged(object sender, TextChangedEventArgs e)
        {
            Filter();
        }

        private void txtDeviceFilter_TextChanged(object sender, TextChangedEventArgs e)
        {
            Filter();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            publicFrame.mainFrame.Navigate(new MENU());
        }

        private void btnExcel_Click(object sender, RoutedEventArgs e)
        {
            selectDateForExcel excel = new selectDateForExcel();
            excel.ShowDialog();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            publicFrame.mainFrame.Navigate(new EditHistory((sender as Button).DataContext as Ремонт));
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            Ремонт ремонт = (sender as Button).Content as Ремонт;

            if (MessageBox.Show($"Удалить запись - №{ремонт.id_Ремонт}?", "Уведомление", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                DataCenterEntities.GetContext().Ремонт.Remove(ремонт);
                DataCenterEntities.GetContext().SaveChanges();
                MessageBox.Show($"Ремонт удален!", "Уведомление", MessageBoxButton.OK);
            }
        }
    }
}
