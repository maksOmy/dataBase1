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
using System.Windows.Shapes;

namespace WpfApp26
{
    /// <summary>
    /// Логика взаимодействия для navWindow.xaml
    /// </summary>
    public partial class navWindow : Window
    {
        Model_Quadro db = new Model_Quadro();
        public navWindow()
        {
            InitializeComponent();
        }

        private void Button_Project_Table_Click(object sender, RoutedEventArgs e)
        {
            projectInfoWindow projectTable = new projectInfoWindow();
            projectTable.Show();
            Close();
        }
        private void Button_Worker_Table_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Button_Customer_Table_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
