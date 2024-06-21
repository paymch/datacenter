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
    /// Логика взаимодействия для EditKlient.xaml
    /// </summary>
    public partial class EditKlient : Page
    {
        Клиент клиент1;
        public EditKlient(Клиент клиент)
        {
            InitializeComponent();

            клиент1 = клиент;

            if (клиент != null)
            {
                txtFullName.Text = клиент.ФИО;
                txtPhoneNumber.Text = клиент.Телефон;

            }
            else
                titlePage.Text = "Добавление клиента";
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            publicFrame.mainFrame.Navigate(new Klient());
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {

            if (txtFullName.Text != null && txtPhoneNumber.Text != null )
            {
                if (MessageBox.Show("Вы уверены что хотите сохранить?", "Уведомление", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    if (клиент1 != null)
                    {
                        Клиент клиент = DataCenterEntities.GetContext().Клиент.Find(клиент1.id_Клиент);

                        клиент.Телефон = txtPhoneNumber.Text;
                        клиент.ФИО = txtFullName.Text;

                        DataCenterEntities.GetContext().SaveChanges();

                        MessageBox.Show("Сохранение прошло успешно.", "Уведомление");

                    }
                    else
                    {
                        Клиент клиент = new Клиент()
                        {
                            Телефон = txtPhoneNumber.Text,
                            ФИО = txtFullName.Text

                        };

                        DataCenterEntities.GetContext().Клиент.Add(клиент);
                        DataCenterEntities.GetContext().SaveChanges();
                        MessageBox.Show("Сохранение прошло успешно.", "Уведомление");
                    }

                }

            }
            else
                MessageBox.Show("Проверьте заполненность всех полей", "Ошибка");

        }
    }
}
