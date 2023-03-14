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
using static SI_Task_4.Core.Core;

namespace SI_Task_4.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage1.xaml
    /// </summary>
    public partial class MainPage1 : Page
    {
        public MainPage1()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyCore?.Navigate(new MainPage());
        }

        private void BTN1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BTN2_Click(object sender, RoutedEventArgs e)
        {

        }
        private void BTN3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BTN4_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BTN5_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BTN6_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BTN7_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BTN8_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BTN9_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BTN10_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BTN11_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BTN12_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BTN13_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BTN14_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BTN_Answer1(object sender, RoutedEventArgs e)
        {
            int a = Convert.ToInt32(TBa.Text);
            int b = Convert.ToInt32(TBb.Text);
            int[] M = new int[b - a];
            int[] D = new int[b - a];

            for (a = a; a < b; a++)
            {
                if (a == 0)
                    D[a] = M[a];
                if (M[a] < M[a - 1])
                    D[a] = M[a - 1];
                if (M[a] > M[a - 1])
                    D[a] = M[a];
            }
            foreach (int el  in D)
                MessageBox.Show($"{D[el]}");
        }

        private void BTN_Answer2(object sender, RoutedEventArgs e)
        {

        }

        private void BTN_Answer3(object sender, RoutedEventArgs e)
        {

        }

        private void BTN_Answer4(object sender, RoutedEventArgs e)
        {

        }

        private void BTN_Answer5(object sender, RoutedEventArgs e)
        {

        }

        private void BTN_Answer6(object sender, RoutedEventArgs e)
        {

        }

        private void BTN_Answer7(object sender, RoutedEventArgs e)
        {

        }

        private void BTN_Answer8(object sender, RoutedEventArgs e)
        {

        }

        private void BTN_Answer9(object sender, RoutedEventArgs e)
        {

        }
    }
}
