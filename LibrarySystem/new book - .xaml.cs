using Book_management_system.Classes;
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

namespace Book_management_system
{
    /// <summary>
    /// Interaction logic for new_book.xaml
    /// </summary>
    public partial class new_book : Window
    {
        public new_book()
        {
            InitializeComponent();
        }


        Book book = new Book();

        public void AddBook()
        {

            book.AddNewBook(txt_title.Text, txt_author.Text, txt_publisher.Text, comb_genre.SelectedItem.ToString(), txt_descr.Text, txt_isbn.Text, double.Parse(txt_price.Text));

            MessageBox.Show("Book added successfully");
        }

        private void btn_ok_Click(object sender, RoutedEventArgs e)
        {
            AddBook();

            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {

                    (window as MainWindow).RefreshData();
                }
            }


            this.Close();
        }
    }
}
