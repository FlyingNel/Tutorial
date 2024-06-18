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
using Tutorial.MyFrames.AddPages;

namespace Tutorial.MyFrames.SelectionsPages
{
    /// <summary>
    /// Логика взаимодействия для SelectionContent.xaml
    /// </summary>
    public partial class SelectionContent : Page
    {
        private Selection selectedSection;
        public SelectionContent(Selection section)
        {
            InitializeComponent();
            selectedSection = section;
            LoadContent();
        }
        private void LoadContent()
        {
            if (selectedSection != null)
            {
                SelectionList.ItemsSource = new List<Selection> { selectedSection };
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.GoBack();
        }


    }
}
