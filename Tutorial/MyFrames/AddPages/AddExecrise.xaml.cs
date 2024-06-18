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

namespace Tutorial.MyFrames.AddPages
{
    /// <summary>
    /// Логика взаимодействия для AddExecrise.xaml
    /// </summary>
    public partial class AddExecrise : Page
    {
        private diplomEntities _context;
        public AddExecrise()
        {
            InitializeComponent();
            _context = new diplomEntities();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var newExercise = new Exercise
                {
                    Name = ExerciseNameTextBox.Text,
                    Task = QuestionTextBox.Text,
                    Answer = CorrectAnswerTextBox.Text
                };
                _context.Exercises.Add(newExercise);
                _context.SaveChanges();

                MessageBox.Show("Упражнение успешно сохранено.", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при сохранении упражнения: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            FrameApp.frmObj.GoBack();
        }
    }
}
