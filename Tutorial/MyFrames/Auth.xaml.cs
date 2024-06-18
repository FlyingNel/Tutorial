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

namespace Tutorial.MyFrames
{
    /// <summary>
    /// Логика взаимодействия для Auth.xaml
    /// </summary>
    public partial class Auth : Page
    {
        public Auth()
        {
            InitializeComponent();
        }


        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = Application.Current.MainWindow as MainWindow;
            try
            {
                var userObj = DbConnect.prObj.Users.FirstOrDefault(x => x.Email == UsernameTextBox.Text && x.Password == PasswordBox.Password);
                if (userObj == null)
                {
                    MessageBox.Show("Такой пользователь не найден!",
                                   "Уведомление",
                                   MessageBoxButton.OK,
                                   MessageBoxImage.Information);
                }
                else
                {
                    GlobalData.CurrentUser = userObj; // Сохранение текущего пользователя

                    switch (userObj.Role.Id)
                    {
                        case 1:
                            MessageBox.Show("Здравствуйте, Администратор " + userObj.Name + "!",
                               "Уведомление",
                               MessageBoxButton.OK,
                               MessageBoxImage.Information);
                            FrameApp.frmObj.Navigate(new Menu());
                            GlobalData.IdRole = 1;
                            break;
                        case 2:
                            MessageBox.Show("Здравствуйте, учитель " + userObj.Name + "!",
                               "Уведомление",
                               MessageBoxButton.OK,
                               MessageBoxImage.Information);
                            FrameApp.frmObj.Navigate(new Menu());
                            GlobalData.IdRole = 2;
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Критический сбой в работе предложения: " + ex.Message.ToString(),
                                "Уведомление",
                                MessageBoxButton.OK,
                                MessageBoxImage.Warning);
            }
        }
        private void GuestLoginButton_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new Menu());
            GlobalData.IdRole = 3;
        }
    }
}
