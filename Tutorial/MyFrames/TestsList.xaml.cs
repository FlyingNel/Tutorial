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


namespace Tutorial.MyFrames
{
    /// <summary>
    /// Логика взаимодействия для TestsList.xaml
    /// </summary>
    public partial class TestsList : Page
    {
        private diplomEntities _context;
        public TestsList()
        {
            InitializeComponent();
            _context = new diplomEntities();
            LoadTests();
        }
        private void LoadTests()
        {
            TestListView.ItemsSource = _context.Tests.ToList();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.GoBack();
        }

        private void TestListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (TestListView.SelectedItem is Test selectedTest)
            {
                FrameApp.frmObj.Navigate(new SelectionTest(selectedTest.TestID));
            }
        }
    }
}
