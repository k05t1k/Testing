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
using System.Windows.Shapes;

namespace TestCreator
{
    /// <summary>
    /// Логика взаимодействия для Testing.xaml
    /// </summary>
    public partial class Testing : Window
    {
        public Testing()
        {
            InitializeComponent();
            TestFrame.Content = File.Exists("C:\\Users\\cutec\\OneDrive\\Рабочий стол\\Test.json") ?
                new TestPage() : new EmptyTestPage();
        }
    }
}
