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

namespace tritri
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        void Calculate()
        {
            double a = 0;
            int num = int.Parse(boxN.Text);
            int x = int.Parse(boxX.Text);
            int b = 1;

            while (num > 0)
            {
                a = x * Math.Cos(b * Math.PI / 4);
                x *= x;
                b++;
                num--;
            }

            Result.Text = a.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Calculate();
        }

        private void box_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
