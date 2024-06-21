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
    /// Логика взаимодействия для devices.xaml
    /// </summary>
    public partial class devices : Page
    {
        public devices()
        {
            InitializeComponent();

            dgDevices.ItemsSource = DataCenterEntities.GetContext().Устройство.ToList();

            cmbDeviceType.ItemsSource = DataCenterEntities.GetContext().Вид_техники.ToList();
            cmbDeviceType.SelectedValuePath = "id_Вид_техники";
            cmbDeviceType.DisplayMemberPath = "Вид_техники1";
        }

        private void Filter() 
        { 
            List<Устройство> устройство = DataCenterEntities.GetContext().Устройство.ToList();

            if (txtNameFilter.Text != null) 
            { 
                устройство = устройство.Where(x => x.Наименование.Contains(txtNameFilter.Text)).ToList();
            
            }

            if (txtSerialNumberFilter.Text != null) 
            { 
              устройство = устройство.Where(x => x.Серийный_номер.Contains(txtSerialNumberFilter.Text)).ToList();
            }

            if (cmbDeviceType.SelectedValue != null) 
            {
                int idUstr = (int)cmbDeviceType.SelectedValue;
                устройство = устройство.Where(x => x.id_Вид_техники == idUstr).ToList();
            }

            dgDevices.ItemsSource = устройство;

        }

        private void txtNameFilter_TextChanged(object sender, TextChangedEventArgs e)
        {
            Filter();
        }

        private void txtSerialNumberFilter_TextChanged(object sender, TextChangedEventArgs e)
        {
            Filter();
        }

        private void cmbDeviceType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Filter();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            txtNameFilter.Text = null;
            txtSerialNumberFilter.Text = null;
            cmbDeviceType.SelectedValue = null;

            dgDevices.ItemsSource = DataCenterEntities.GetContext().Устройство.ToList();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            publicFrame.mainFrame.Navigate(new EditDevice(null));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            publicFrame.mainFrame.Navigate(new MENU());
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            publicFrame.mainFrame.Navigate(new EditDevice((sender as Button).DataContext as Устройство));
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {


            Устройство устройство = (sender as Button).Content as Устройство;

            if (MessageBox.Show($"Удалить запись - №{устройство.id_Устройства}?", "Уведомление", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                DataCenterEntities.GetContext().Устройство.Remove(устройство);
                DataCenterEntities.GetContext().SaveChanges();
                MessageBox.Show($"Устройство удаленно!", "Уведомление", MessageBoxButton.OK);
            }
        }
    }
}
