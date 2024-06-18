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
    /// Логика взаимодействия для Profile.xaml
    /// </summary>
    public partial class Profile : Page
    {
        public Profile()
        {
            InitializeComponent();
            LoadUserData();
        }
        private void LoadUserData()
        {
            if (GlobalData.CurrentUser != null)
            {
                UserNameTxb.Text = $"Имя пользователя: {GlobalData.CurrentUser.Name}";
                UserEmailTxb.Text = $"Электронная почта: {GlobalData.CurrentUser.Email}";
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.GoBack();
        }
    }
}
