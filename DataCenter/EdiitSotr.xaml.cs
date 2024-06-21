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
    /// Логика взаимодействия для EdiitSotr.xaml
    /// </summary>
    public partial class EdiitSotr : Page
    {
        Сотрудник sotru;
        public EdiitSotr(Сотрудник sotr)
        {
            InitializeComponent();

            sotru = sotr;

            cmbPosition.ItemsSource = DataCenterEntities.GetContext().Должность.ToList();
            cmbPosition.DisplayMemberPath = "Должность1";
            cmbPosition.SelectedValuePath = "id_Должность";



            if (sotr != null) 
            {
                titlePage.Text = "Редактирование сотрудника";

                txtFullName.Text = sotr.ФИО;

                Адрес_сотрудника адрес = DataCenterEntities.GetContext().Адрес_сотрудника.FirstOrDefault(x => x.id_Адрес_сотрудника == sotr.id_Адрес_сотрудника);

                txtCity.Text = DataCenterEntities.GetContext().Город.FirstOrDefault(x => x.id_Город == адрес.id_Город)?.Город1;
                txtStreet.Text = DataCenterEntities.GetContext().Улица.FirstOrDefault(x => x.id_Улица == адрес.id_Улица)?.Улица1;
                txtHouseNumber.Text = DataCenterEntities.GetContext().Дом.FirstOrDefault(x => x.id_Дом == адрес.id_Дом)?.Дом1;


                txtPassword.Text = sotr.Пароль;
                txtLogin.Text = sotr.Логин;

                txtEmail.Text = sotr.Почта;
                txtPhoneNumber.Text = sotr.Телефон;

                cmbPosition.SelectedValue = sotr.id_Должность;

                
                
            }
            else
                titlePage.Text = "Добавление сотрудника";
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (txtCity.Text != null && txtStreet.Text != null && txtHouseNumber.Text != null && txtPassword.Text != null && txtEmail.Text != null) 
            {
                if (MessageBox.Show("Вы уверены что хотите сохранить?", "Уведомление", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    if (sotru != null)
                    {

                        Сотрудник сотрудник = DataCenterEntities.GetContext().Сотрудник.Find(sotru.id_Сотрудник);
                        сотрудник.Логин = txtLogin.Text;
                        сотрудник.Пароль = txtPassword.Text;
                        сотрудник.id_Должность = (int)cmbPosition.SelectedValue;
                        сотрудник.Телефон = txtPhoneNumber.Text;
                        сотрудник.ФИО = txtFullName.Text;

                        Адрес_сотрудника адрес = DataCenterEntities.GetContext().Адрес_сотрудника.Find(sotru.id_Адрес_сотрудника);
                        Дом дом = DataCenterEntities.GetContext().Дом.Find(адрес.id_Дом);
                        Улица улица = DataCenterEntities.GetContext().Улица.Find(адрес.id_Улица);
                        Город город = DataCenterEntities.GetContext().Город.Find(адрес.id_Город);

                        дом.Дом1 = txtHouseNumber.Text;
                        улица.Улица1 = txtStreet.Text;
                        город.Город1 = txtCity.Text;


                        DataCenterEntities.GetContext().SaveChanges();
                        MessageBox.Show("Сохранение прошло успешно.", "Уведомление");
                    }
                    else
                    {
                        Дом дом = new Дом()
                        {
                            Дом1 = txtHouseNumber.Text
                        };

                        Улица улица = new Улица()
                        {

                            Улица1 = txtStreet.Text
                        };

                        Город город = new Город()
                        {
                            Город1 = txtCity.Text
                        };

                        DataCenterEntities.GetContext().Город.Add(город);
                        DataCenterEntities.GetContext().Дом.Add(дом);
                        DataCenterEntities.GetContext().Улица.Add(улица);
                        DataCenterEntities.GetContext().SaveChanges();

                        Адрес_сотрудника адрес = new Адрес_сотрудника()
                        {
                            id_Город = город.id_Город,
                            id_Дом = дом.id_Дом,
                            id_Улица = улица.id_Улица
                        };
                        DataCenterEntities.GetContext().Адрес_сотрудника.Add(адрес);
                        DataCenterEntities.GetContext().SaveChanges();

                        Сотрудник сотрудник = new Сотрудник()
                        {
                            Логин = txtLogin.Text,
                            Пароль = txtPassword.Text,
                            id_Адрес_сотрудника = адрес.id_Адрес_сотрудника,
                            id_Должность = (int)cmbPosition.SelectedValue,
                            Почта = txtEmail.Text,
                            ФИО = txtFullName.Text,
                            Телефон = txtPhoneNumber.Text,
                            Зарплата = 0

                        };

                        DataCenterEntities.GetContext().Сотрудник.Add(сотрудник);
                        DataCenterEntities.GetContext().SaveChanges();

                        MessageBox.Show("Сохранение прошло успешно.", "Уведомление");
                    }

                }

            }
            else
                MessageBox.Show("Проверьте заполненность всех полей", "Ошибка");


        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            publicFrame.mainFrame.Navigate(new Sotrudnik());
        }
    }
}
