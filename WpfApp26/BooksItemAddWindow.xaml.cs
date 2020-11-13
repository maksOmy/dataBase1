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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class BooksItemAddWindow : Window
    {
        public BooksItemAddWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openImageFile = new OpenFileDialog();
            openImageFile.Filter = "Image files (*.jpg)|*.jpg|Image files (*.jpeg)|*.jpeg|Image files (*.bmp)|*.bmp|Image files (*.png)|*.png|All files (*.*)|*.*";
            if (openImageFile.ShowDialog() == true)
            {
                ImagePathTextBox.Text = openImageFile.FileName;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ModelDBCodeFirst.ModelChatalZalCodeFirst dbAdd = new ModelDBCodeFirst.ModelChatalZalCodeFirst();
            Books books = new Books();
            books.ISBN = ISBNTB.Text;
            books.NameOfBook = NameBookTB.Text;
            books.AutorOfBook = AutorBookTB.Text;
            books.IzdatelOfBook = PublisherTB.Text;
            books.SpaceIzdatOfBook = SpaceOfIzdatTB.Text;
            books.YearsOfBook = Convert.ToInt32(YearIzdatelTB.Text);
            books.CountPageOfBook = Convert.ToInt32(CountPageTB.Text);
            books.ImageOfBook = File.ReadAllBytes(ImagePathTextBox.Text);
            dbAdd.Books.Add(books);
            dbAdd.SaveChanges();
            MainWindowCodeFirst win = new MainWindowCodeFirst();
            win.Show();
            this.Close();
        }
    }
}
