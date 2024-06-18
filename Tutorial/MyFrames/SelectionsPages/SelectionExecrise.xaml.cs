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

namespace Tutorial.MyFrames.SelectionsPages
{
    /// <summary>
    /// Логика взаимодействия для SelectionExecrise.xaml
    /// </summary>
    public partial class SelectionExecrise : Page
    {
        private diplomEntities _context;
        public SelectionExecrise(Exercise exercise)
        {
            InitializeComponent();
            _context = new diplomEntities();
            LoadExercise(exercise);
        }
        private void LoadExercise(Exercise exercise)
        {
            if (exercise != null)
            {
                ExTaskList.ItemsSource = new List<Exercise> { exercise };
            }
            else
            {
                MessageBox.Show("Exercise not found.");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var userObj = _context.Exercises.FirstOrDefault(x => x.Answer == Task_answer.Text);
            if (userObj == null)
            {
                MessageBox.Show("Неверный ответ, попробуйте еще раз",
                           "Уведомление",
                           MessageBoxButton.OK,
                           MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Верный ответ!",
                                  "Уведомление",
                                  MessageBoxButton.OK,
                                  MessageBoxImage.Information);
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.GoBack();
        }
    }
}
