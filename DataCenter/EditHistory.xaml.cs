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
    /// Логика взаимодействия для EditHistory.xaml
    /// </summary>
    public partial class EditHistory : Page
    {
        Ремонт ремонт1 { get; set; }
        public EditHistory(Ремонт ремонт)
        {
            InitializeComponent();
            ремонт1 = ремонт;

            cmbClient.ItemsSource = DataCenterEntities.GetContext().Клиент.ToList();
            cmbClient.SelectedValuePath = "id_Клиент";
            cmbClient.DisplayMemberPath = "ФИО";

            cmbDevice.ItemsSource = DataCenterEntities.GetContext().Устройство.ToList();
            cmbDevice.SelectedValuePath = "id_Устройства";
            cmbDevice.DisplayMemberPath = "Наименование";

            cmbDeviceType.ItemsSource = DataCenterEntities.GetContext().Тип_ремонта.ToList();
            cmbDeviceType.DisplayMemberPath = "Тип_ремонта1";
            cmbDevice.SelectedValuePath = "id_Тип_ремонта";

            cmbEmployee.ItemsSource = DataCenterEntities.GetContext().Сотрудник.ToList();
            cmbEmployee.DisplayMemberPath = "ФИО";
            cmbEmployee.SelectedValuePath = "id_Сотрудник";


            if (ремонт != null)
            {
                txtCost.Text = ремонт.Стоимость.ToString();
                txtDescription.Text = ремонт.Описание;
                cmbEmployee.SelectedValue = ремонт.id_Сотрудник;
                cmbDeviceType.SelectedValue = ремонт.id_Тип_ремонта;
                cmbDevice.SelectedValue = ремонт.id_Устройство;
                cmbClient.SelectedValue = ремонт.id_Клиент;

            }
            else
                titlePage.Text = "Добавление записи";
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            publicFrame.mainFrame.Navigate(new History());
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (txtCost.Text != null && txtDescription.Text != null)
            {
                if (MessageBox.Show("Вы уверены что хотите сохранить?", "Уведомление", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    if (ремонт1 != null)
                    {
                        Ремонт ремонт = DataCenterEntities.GetContext().Ремонт.Find(ремонт1.id_Ремонт);
                        ремонт.id_Клиент = (int)cmbClient.SelectedValue;
                        ремонт.id_Сотрудник = (int)cmbEmployee.SelectedValue;
                        ремонт.id_Тип_ремонта = (int)cmbDeviceType.SelectedValue;
                        ремонт.id_Устройство = (int)cmbDevice.SelectedValue;
                        ремонт.Описание = txtDescription.Text;
                        ремонт.Стоимость = decimal.Parse(txtCost.Text);

                        DataCenterEntities.GetContext().SaveChanges();

                        MessageBox.Show("Сохранение прошло успешно.", "Уведомление");

                    }
                    else
                    {
                        Ремонт ремонт = new Ремонт()
                        {
                            id_Клиент = (int)cmbClient.SelectedValue,
                            id_Сотрудник = (int)cmbEmployee.SelectedValue,
                            id_Тип_ремонта = (int)cmbDeviceType.SelectedValue,
                            id_Устройство = (int)cmbDevice.SelectedValue,
                            Описание = txtDescription.Text,
                            Стоимость = decimal.Parse(txtCost.Text)
                        };

                        DataCenterEntities.GetContext().Ремонт.Add(ремонт);
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
