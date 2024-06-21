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
    /// Логика взаимодействия для MENU.xaml
    /// </summary>
    public partial class MENU : Page
    {
        public MENU()
        {
            InitializeComponent();

            if (publicUser.сотрудник.id_Должность != 2)
                listWorks.Visibility = Visibility.Collapsed;

        }

        private void listWorks_Click(object sender, RoutedEventArgs e)
        {
            publicFrame.mainFrame.Navigate(new Sotrudnik());
        }

        private void listDevice_Click(object sender, RoutedEventArgs e)
        {
            publicFrame.mainFrame.Navigate(new devices());
        }

        private void historyFix_Click(object sender, RoutedEventArgs e)
        {
            publicFrame.mainFrame.Navigate(new History());
        }

        private void listCustomers_Click(object sender, RoutedEventArgs e)
        {
            publicFrame.mainFrame.Navigate(new Klient());
        }

        private void addWrite_Click(object sender, RoutedEventArgs e)
        {
            publicFrame.mainFrame.Navigate(new EditHistory(null));
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы уверены что хотите выйти?", "Уведомление", MessageBoxButton.YesNo) == MessageBoxResult.Yes) 
            {
                publicFrame.mainFrame.Navigate(new authorization());
            }
            
        }
    }
}
