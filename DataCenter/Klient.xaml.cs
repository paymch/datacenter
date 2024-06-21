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
    /// Логика взаимодействия для Klient.xaml
    /// </summary>
    public partial class Klient : Page
    {
        public Klient()
        {
            InitializeComponent();

            dataGridClients.ItemsSource = DataCenterEntities.GetContext().Клиент.ToList();


        }

        private void Filter() 
        {
            List<Клиент> клиент = DataCenterEntities.GetContext().Клиент.ToList();

            if (txtFilter.Text != null) 
            {
                клиент = клиент.Where(x => x.ФИО.Contains(txtFilter.Text)).ToList();
                
            }

            dataGridClients.ItemsSource = клиент;
        }

        private void txtFilter_TextChanged(object sender, TextChangedEventArgs e)
        {
            Filter();
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtFilter.Text = null;
            dataGridClients.ItemsSource = DataCenterEntities.GetContext().Клиент.ToList();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            publicFrame.mainFrame.Navigate(new EditKlient(null));
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            publicFrame.mainFrame.Navigate(new MENU());
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            publicFrame.mainFrame.Navigate(new EditKlient((sender as Button).DataContext as Клиент));
        }
    }
}
