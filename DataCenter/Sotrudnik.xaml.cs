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
    /// Логика взаимодействия для Sotrudnik.xaml
    /// </summary>
    public partial class Sotrudnik : Page
    {
        public Sotrudnik()
        {
            InitializeComponent();

            dgEmployees.ItemsSource = DataCenterEntities.GetContext().Сотрудник.ToList();

            cmbPosition.ItemsSource = DataCenterEntities.GetContext().Должность.ToList();
            cmbPosition.DisplayMemberPath = "Должность1";
            cmbPosition.SelectedValuePath = "id_Должность";


        }

        private void Filter() 
        { 
            List<Сотрудник> sotr = DataCenterEntities.GetContext().Сотрудник.ToList();

            if (txbFIO.Text != null) 
            {
                sotr = sotr.Where(x => x.ФИО.Contains(txbFIO.Text)).ToList();
            }

            if (cmbPosition.SelectedItem != null) 
            {
                int select = cmbPosition.SelectedIndex;
                sotr = sotr.Where(x => x.id_Должность == select).ToList();
            }

            dgEmployees.ItemsSource = sotr;

        }

        private void txtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            Filter();
        }

        private void cmbPosition_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Filter();
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txbFIO.Text = null;
            cmbPosition.SelectedItem = null;
            dgEmployees.ItemsSource = DataCenterEntities.GetContext().Сотрудник.ToList();
        }

        private void addSotr_Click(object sender, RoutedEventArgs e)
        {
            publicFrame.mainFrame.Navigate(new EdiitSotr(null));
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            publicFrame.mainFrame.Navigate(new MENU());
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            Сотрудник сотрудник = (sender as Button).Content as Сотрудник;

            if (MessageBox.Show($"Удалить сотрудника - {сотрудник.ФИО}?", "Уведомление", MessageBoxButton.YesNo) == MessageBoxResult.Yes) 
            {
                DataCenterEntities.GetContext().Сотрудник.Remove(сотрудник);
                DataCenterEntities.GetContext().SaveChanges();
                MessageBox.Show($"Сотрудник удален!", "Уведомление", MessageBoxButton.OK);
            }
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            publicFrame.mainFrame.Navigate(new EdiitSotr((sender as Button).DataContext as Сотрудник));


        }
    }
}
