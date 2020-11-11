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
        public static Model_Library db = new Model_Library();
        public navWindow()
        {
            InitializeComponent();
        }

        private void Button_Books_Table_Click(object sender, RoutedEventArgs e)
        {
            BooksWindow BookTable = new BooksWindow();
            BookTable.Show();
            Close();
        }
        private void Button_Readers_Table_Click(object sender, RoutedEventArgs e)
        {
            ReadersWindow ReadersTable = new ReadersWindow();
            ReadersTable.Show();
            Close();
        }

        private void Button_Instance_Table_Click(object sender, RoutedEventArgs e)
        {
            InstanceWindow InstanceTable = new InstanceWindow();
            InstanceTable.Show();
            Close();
        }
    }
}
