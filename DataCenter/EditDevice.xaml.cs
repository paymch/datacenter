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
    /// Логика взаимодействия для EditDevice.xaml
    /// </summary>
    public partial class EditDevice : Page
    {
        Устройство устр;
        public EditDevice(Устройство устройство)
        {
           
            InitializeComponent();

            устр = устройство;

            cmbDeviceType.ItemsSource = DataCenterEntities.GetContext().Вид_техники.ToList();
            cmbDeviceType.SelectedValuePath = "id_Вид_техники";
            cmbDeviceType.DisplayMemberPath = "Вид_техники1";

            if (устройство != null)
            {
                txtDeviceName.Text = устройство.Наименование;
                txtSerialNumber.Text = устройство.Серийный_номер;
                cmbDeviceType.SelectedValue = устройство.id_Вид_техники;

            }
            else
                titlePage.Text = "Добавление утсройства";
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (txtDeviceName.Text != null && txtSerialNumber.Text != null)
            {
                if (MessageBox.Show("Вы уверены что хотите сохранить?", "Уведомление", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    if (устр != null)
                    {
                        Устройство устройство = DataCenterEntities.GetContext().Устройство.Find(устр.id_Устройства);
                        устройство.Наименование = txtDeviceName.Text;
                        устройство.Серийный_номер = txtSerialNumber.Text;
                        устройство.id_Вид_техники = (int)cmbDeviceType.SelectedValue;


                        DataCenterEntities.GetContext().SaveChanges();
                        MessageBox.Show("Сохранение прошло успешно.", "Уведомление");


                    }
                    else
                    {

                        Устройство устройство = new Устройство()
                        {
                            id_Вид_техники = (int)cmbDeviceType.SelectedValue,
                            Серийный_номер = txtSerialNumber.Text,
                            Наименование = txtDeviceName.Text

                        };

                        DataCenterEntities.GetContext().Устройство.Add(устройство);
                        DataCenterEntities.GetContext().SaveChanges();
                       
                    }

                }

            }
            else
                MessageBox.Show("Проверьте заполненность всех полей", "Ошибка");
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            publicFrame.mainFrame.Navigate(new devices());
        }
    }
}
