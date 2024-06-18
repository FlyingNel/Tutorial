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
using Tutorial.MyFrames;

namespace Tutorial.MyFrames
{
    /// <summary>
    /// Логика взаимодействия для Menu.xaml
    /// </summary>
    public partial class Menu : Page
    {
        public Menu()
        {
            InitializeComponent();
            Loaded += Menu_Loaded;
        }
        private void Menu_Loaded(object sender, RoutedEventArgs e)
        {
            if (GlobalData.IdRole != 1)
            {
                adminbutton.Visibility = Visibility.Hidden;
            }
        }

        private void Contents_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new Contents());
        }

        private void Exercises_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new ExeriseList());
        }

        private void Quizzes_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new TestsList());
        }

        private void Profile_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new Profile());
        }

        private void Support_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new Support());
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new AboutProgram());
        }

        private void UsersPages_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new UsersPage());
        }
    }
}
