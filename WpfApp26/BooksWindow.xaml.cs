using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    /// Логика взаимодействия для projectInfoWindow.xaml
    /// </summary>
    public partial class BooksWindow : Window
    {
       
        public BooksWindow()
        {
            InitializeComponent();
            MainWindow.db.Books.Load();
            BooksTable.ItemsSource = MainWindow.db.Books.Local;
        }

        private void Button_Back_Click(object sender, RoutedEventArgs e)
        {
            navWindow nav = new navWindow();
            nav.Show();
            Close();
        }

        private void Button_Search_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Button_Add_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Delete_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = (Books)BooksTable.SelectedItem;
            MainWindow.db.Books.Remove(selectedItem);
            MainWindow.db.SaveChanges();
        }
    }
}
