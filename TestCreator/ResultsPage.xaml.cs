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

namespace TestCreator
{
    /// <summary>
    /// Логика взаимодействия для ResultsPage.xaml
    /// </summary>
    public partial class ResultsPage : Page
    {
        //public GlobalVars globalVars = new();

        public ResultsPage()
        {
            InitializeComponent();
            
            //if (globalVars.correct > 1)
            //{
            //    Congrats.Text = "Поздравляем, вы прошли тест! ( ﾉ ﾟｰﾟ)ﾉ";
            //    CorrectAnswer.Text = $"Правильных ответов: {globalVars.correct}";
            //    IncorrectAnswer.Text = $"Неправильных ответов: {globalVars.incorrect}";

            //}
            //else
            //{
            //    Congrats.Text = "Сожалеем, вы не прошли тест X﹏X";
            //    CorrectAnswer.Text = $"Правильных ответов: {globalVars.correct}";
            //    IncorrectAnswer.Text = $"Неправильных ответов: {globalVars.incorrect}";
            //}
        }

        private void ExitButton(object sender, RoutedEventArgs e)
        {
            //Testing testing = new Testing();
            //MessageBox.Show("Возвращайтесь (づ￣ 3￣)づ");
            //testing.Close();
        }
    }
}
