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
    /// Логика взаимодействия для Contents.xaml
    /// </summary>
    public partial class Contents : Page
    {
        private diplomEntities _context;
        public Contents()
        {
            InitializeComponent();
            _context = new diplomEntities();
            var allSelections = _context.Selections.ToList();
            var sortedSelections = allSelections.OrderBy(x => x.Id).ToList();
            ContentList.ItemsSource = sortedSelections;
            Loaded += LoadSelections;
        }
        private void LoadSelections(object sender, RoutedEventArgs e)
        {
            if (GlobalData.IdRole != 1 && GlobalData.IdRole != 2)
            {
                addsection.Visibility = Visibility.Hidden;
            }
        }
        private void ContentList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ContentList.SelectedItem is Selection selectedItem)
            {
                MessageBox.Show("Вы выбрали: " + selectedItem.Name);
                FrameApp.frmObj.Navigate(new SelectionsPages.SelectionContent(selectedItem));
            }
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.GoBack();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new AddContent());
        }
    }
}
