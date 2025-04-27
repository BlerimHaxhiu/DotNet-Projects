using System.Windows;

namespace GraphPathfinder
{
    public partial class InputBox : Window
    {
        public string Answer { get; set; }

        public InputBox(string question, string defaultAnswer = "")
        {
            InitializeComponent();
            QuestionTextBlock.Text = question;
            AnswerTextBox.Text = defaultAnswer;
            Answer = defaultAnswer;
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            Answer = AnswerTextBox.Text;
            DialogResult = true;
            Close();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}