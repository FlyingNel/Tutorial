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
    /// Логика взаимодействия для SelectionTest.xaml
    /// </summary>
    public partial class SelectionTest : Page
    {
        private int _testID;
        private diplomEntities _context;
        public SelectionTest(int testID)
        {
            InitializeComponent();
            _testID = testID;
            _context = new diplomEntities();
            LoadQuestions();
        }
        private void LoadQuestions()
        {
            var questions = _context.Questions.Where(q => q.TestID == _testID).ToList();
            foreach (var question in questions)
            {
                question.Answers = _context.Answers.Where(a => a.QuestionID == question.QuestionID).ToList();
            }
            QuestionsItemsControl.ItemsSource = questions;
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            int score = 0;

            foreach (var item in QuestionsItemsControl.Items)
            {
                var container = QuestionsItemsControl.ItemContainerGenerator.ContainerFromItem(item) as ContentPresenter;
                if (container != null)
                {
                    var listBox = container.ContentTemplate.FindName("AnswersList", container) as ListBox;
                    if (listBox != null && listBox.SelectedItem != null)
                    {
                        var selectedAnswer = listBox.SelectedItem as Answer;
                        if (selectedAnswer != null && selectedAnswer.IsCorrect)
                        {
                            score++;
                        }
                    }
                }
            }
            MessageBox.Show($"Вы набрали {score} очков");
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.GoBack();
        }
    }
}
