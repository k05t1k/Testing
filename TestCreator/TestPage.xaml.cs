using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace TestCreator
{
    /// <summary>
    /// Логика взаимодействия для TestPage.xaml
    /// </summary>
    public partial class TestPage : Page
    {
        public int counter = 0;
        public int correct = 0;
        public int incorrect = 0;
        
        public List<Question> questionList = new List<Question>();

        public TestPage()
        {
            InitializeComponent();
            string result = File.ReadAllText("C:\\Users\\cutec\\OneDrive\\Рабочий стол\\Test.json");
            questionList = JsonConvert.DeserializeObject<List<Question>>(result);

            SetName();
        }

        private void SetName()
        {
            if (counter == 3)
            {
                if (correct > 1)
                    MessageBox.Show( 
                        $"Правильных ответов: {correct}\nНеправильных ответов: {incorrect}",
                        "Поздравляем, вы прошли тест!"
                        );
                else
                    MessageBox.Show(
                        $"Правильных ответов: {correct}\nНеправильных ответов: {incorrect}",
                        "Сожалеем, вы не прошли тест"
                        );
                Testing testing = new Testing();
                testing.Close();
                return;
            }
            QuestionName.Text = questionList[counter].NameQuestion;
            DescriptionQuestion.Text = questionList[counter].Descriptions;
            FirstButton.Content = questionList[counter].FirstVariation;
            SecondButton.Content = questionList[counter].SecondVariation;
            ThirdButton.Content = questionList[counter].ThirdVariation;            
        }

        private void FirstVar(object sender, RoutedEventArgs e)
        {
            if (questionList[counter].RightAnswer == RightAnswer_T.First)
                correct++;
            else
                incorrect++;
            counter++;
            SetName();
        }

        private void SecondVar(object sender, RoutedEventArgs e)
        {
            if (questionList[counter].RightAnswer == RightAnswer_T.Second)
                correct++;
            else
                incorrect++;
            counter++;
            SetName();
        }

        private void ThirdVar(object sender, RoutedEventArgs e)
        {
            if (questionList[counter].RightAnswer == RightAnswer_T.Third)
                correct++;
            else
                incorrect++;
            counter++;
            SetName();
        }
    }
}
