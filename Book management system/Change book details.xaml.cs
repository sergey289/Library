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
    /// Interaction logic for Change_book_details.xaml
    /// </summary>
    public partial class Change_book_details : Window
    {
        public Change_book_details()
        {
            InitializeComponent();

            comb_genre.ItemsSource = Enum.GetValues(typeof(Category));
        }

        public static int IDBook;

        Book_manager meneg = new Book_manager();

        private void ChangeDetailsOfBook()
        {
            meneg.ChangeDetailsOfBook(IDBook, txt_title.Text, txt_author.Text, txt_publisher.Text, (Category)Enum.Parse(typeof(Category),comb_genre.Text, true), txt_descr.Text, txt_isbn.Text, double.Parse(txt_price.Text),int.Parse(txt_quantitu.Text),(DateTime)pic_publish_date.SelectedDate);

            MessageBox.Show("the changes were successfully committed");

            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {

                    (window as MainWindow).RefreshData();
                }
            }

            this.Close();
        }

        private void btn_ok_Click(object sender, RoutedEventArgs e)
        {
            ChangeDetailsOfBook();

        }

        private void btn_cencel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void txt_price_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "0123456789 ,".IndexOf(e.Text) < 0;
        }

        private void txt_quantitu_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "0123456789".IndexOf(e.Text) < 0;
        }
    }
}
