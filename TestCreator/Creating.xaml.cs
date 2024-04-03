using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TestCreator
{
    /// <summary>
    /// Логика взаимодействия для Creating.xaml
    /// </summary>
    public enum RightAnswer_T
    {
        Min,
        First,
        Second,
        Third,
        Max
    }
    public partial class Creating : Window
    {
        public List<Question> Questions = new List<Question>();
        public List<RightAnswer_T> RightAnswers { get; set; } = [RightAnswer_T.First, RightAnswer_T.Second, RightAnswer_T.Third];

        public Creating()
        {
            InitializeComponent();

            Questions.Add(new(null, null, null, null, null, RightAnswer_T.Min));
            Questions.Add(new(null, null, null, null, null, RightAnswer_T.Min));
            Questions.Add(new(null, null, null, null, null, RightAnswer_T.Min));

            QuestionsDgr.ItemsSource = Questions;
        }

        private void QuestionsDgr_RowEditEnding(object sender, DataGridRowEditEndingEventArgs e)
        {

        }

        private void SaveButton(object sender, RoutedEventArgs e)
        {
            if (Questions != null)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (string.IsNullOrWhiteSpace(Questions[i].NameQuestion) ||
                        string.IsNullOrWhiteSpace(Questions[i].FirstVariation) ||
                        string.IsNullOrWhiteSpace(Questions[i].SecondVariation) ||
                        string.IsNullOrWhiteSpace(Questions[i].ThirdVariation) ||
                        RightAnswers[i] == RightAnswer_T.Min)
                    {
                        MessageBox.Show($"Объект { Questions[i] } не заполнен!");
                        return;
                    }
                }
                string json = JsonConvert.SerializeObject(Questions);
                File.WriteAllText("C:\\Users\\cutec\\OneDrive\\Рабочий стол\\Test.json", json);
            }
        }
    }
    public class Question
    {
        public string NameQuestion { get; set; }
        public string Descriptions { get; set; }
        public string FirstVariation { get; set; }
        public string SecondVariation { get; set; }
        public string ThirdVariation { get; set; }
        public RightAnswer_T RightAnswer { get; set; }
        public Question(string nameQuestion, string descriptions, string firstVariation, string secondVariation, string thirdVariation, RightAnswer_T rightAnswer)
        {
            NameQuestion = nameQuestion;
            Descriptions = descriptions;
            FirstVariation = firstVariation;
            SecondVariation = secondVariation;
            ThirdVariation = thirdVariation;
            RightAnswer = rightAnswer;
        }
    }
}
