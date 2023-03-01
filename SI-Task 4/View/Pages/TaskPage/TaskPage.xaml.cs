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

namespace SI_Task_4.View.Pages.TaskPage
{
    /// <summary>
    /// Логика взаимодействия для TaskPage.xaml
    /// </summary>
    public partial class TaskPage : Page
    {
        public TaskPage()
        {
            InitializeComponent();
        }
            private void BtnBack_Click(object sender, RoutedEventArgs e)
            {
                CoreNavigate.MyCore?.Navigate(new MainPage());
            }


        private void MBTN1_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
