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
    /// Логика взаимодействия для authorization.xaml
    /// </summary>
    public partial class authorization : Page
    {
        public authorization()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try 
            { 
                var user = DataCenterEntities.GetContext().Сотрудник.FirstOrDefault(x => x.Логин == login.Text && x.Пароль == password.Password);
                if (user != null)
                {
                    publicUser.сотрудник = user;
                    MessageBox.Show( $"Добро пожаловать! {user.ФИО}.","Уведомление");
                    publicFrame.mainFrame.Navigate(new MENU());

                }
                else 
                {
                    MessageBox.Show("Неверный логин или пароль. Попробуйте еще раз.", "Уведомление");
                
                }
            
            }
            catch 
            { 
            
            
            }
        }
    }
}
