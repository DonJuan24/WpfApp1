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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Работу выполнил студент группы ИСП-31 - Сазонов Иван Александрович \n" +
                "Найти максимум из n целых случайных чисел X, распределенных в диапазоне от 0 \n" +
                "до n. Вывести на экран на одной строке сгенерированные числа, на другой строке \n" +
                "результат.");
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void Enter(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(Input.Text, out int n))
            {
                if (n <= 0)
                {
                    MessageBox.Show("НЕ НАДО ДЯДЯ");
                    return;
                }
                Results.Text = Lib_8.Class1.GetMax(n, out List<int> generated).ToString();
                
                Generate.Text = string.Join(';', generated);
            }
        }

        private void Clear(object sender, RoutedEventArgs e)
        {
            Results.Clear();
            Generate.Clear();
        }
    }
}
