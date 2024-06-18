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
    /// Логика взаимодействия для AddContent.xaml
    /// </summary>
    public partial class AddContent : Page
    {
        public AddContent()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            {
                string sectionName = SectionNameTextBox.Text;

                TextRange textRange = new TextRange(SectionRichTextBox.Document.ContentStart, SectionRichTextBox.Document.ContentEnd);
                string sectionContent = textRange.Text;

                if (string.IsNullOrEmpty(sectionName) || string.IsNullOrEmpty(sectionContent))
                {
                    MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                try
                {
                    using (var context = DbConnect.prObj)
                    {
                        var newSection = new Selection
                        {
                            Name = sectionName,
                            Description = sectionContent
                        };

                        context.Selections.Add(newSection);
                        context.SaveChanges();
                    }

                    MessageBox.Show("Раздел успешно сохранен.", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Произошла ошибка при сохранении раздела: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
        private void ClearFields()
        {
            SectionNameTextBox.Text = string.Empty;
            SectionRichTextBox.Document.Blocks.Clear();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.GoBack();
        }
    }
}
