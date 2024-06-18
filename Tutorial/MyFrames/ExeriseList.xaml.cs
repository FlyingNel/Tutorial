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
using Tutorial.MyFrames.SelectionsPages;
using Tutorial.MyFrames.AddPages;

namespace Tutorial.MyFrames
{
    /// <summary>
    /// Логика взаимодействия для ExeriseList.xaml
    /// </summary>
    public partial class ExeriseList : Page
    {
        private List<Exercise> allexercise { get; set; }
        public ExeriseList()
        {
            InitializeComponent();
            allexercise = DbConnect.prObj.Exercises.ToList();
            List<Exercise> sortMaterials = allexercise.OrderBy(x => x.Id).ToList();
            ExeriseListView.ItemsSource = sortMaterials;
            Loaded += LoadExerise;
        }
        private void LoadExerise(object sender, RoutedEventArgs e)
        {
            if (GlobalData.IdRole != 1 && GlobalData.IdRole != 2)
            {
                addex.Visibility = Visibility.Hidden;
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.GoBack();
        }

        private void ExeriseListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListView listView = sender as ListView;
            if (listView.SelectedItem != null)
            {
                Exercise selectedItem = listView.SelectedItem as Exercise;
                MessageBox.Show("Вы выбрали: " + selectedItem.Name);
                FrameApp.frmObj.Navigate(new SelectionExecrise(selectedItem));
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new AddExecrise());
        }
    }
}
