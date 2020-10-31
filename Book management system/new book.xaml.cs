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
    partial class new_book : Window
    {
        public new_book()
        {
            InitializeComponent();

            comb_genre.ItemsSource = Enum.GetValues(typeof(Category));
        }


        Book_manager menag = new Book_manager();

        public void AddBook()
        {
            if (txt_publisher.Text.Length == 0)
            {
                txt_publisher.Text ="Unknown";
            }

            if (txt_descr.Text.Length == 0)
            {

                txt_descr.Text ="Unknown";
            }

            if (txt_isbn.Text.Length == 0)
            {
                txt_isbn.Text = "Unknown";
            }

            if (pic_publish_date.SelectedDate == null)
            {

                pic_publish_date.SelectedDate = DateTime.Now;

            }

            menag.AddNewBook(txt_title.Text, txt_author.Text, txt_publisher.Text, (Category)comb_genre.SelectionBoxItem, txt_descr.Text, txt_isbn.Text, double.Parse(txt_price.Text),int.Parse(txt_quantitu.Text),(DateTime)pic_publish_date.SelectedDate);

            MessageBox.Show("Book added successfully");

            this.Close();
        }

        public void CheckForFillingRequiredFields()
        {



            if (txt_title.Text.Length==0 ||txt_author.Text.Length==0 ||txt_quantitu.Text.Length==0 || txt_price.Text.Length==0 || comb_genre.SelectedItem == null)
            {


                MessageBox.Show("error: make sure the required fields have been filled !");

                
            }else if(txt_title.Text.Length != 0 && txt_author.Text.Length != 0 && txt_quantitu.Text.Length != 0 && txt_price.Text.Length != 0 && comb_genre.SelectedItem != null)
            {

                AddBook();


            }
           


        }

        public void FillDataGrid()
        {
            CheckForFillingRequiredFields();

        }


        private void btn_ok_Click(object sender, RoutedEventArgs e)
        {
            FillDataGrid();

            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {

                    (window as MainWindow).RefreshData();
                }
            }

        }

        private void txt_title_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txt_title.Text.Length != 0)
            {
                lab_title.Foreground= Brushes.Black;

            }
            else
            {
                lab_title.Foreground = Brushes.Red;

            }
        }

        private void txt_author_TextChanged(object sender, TextChangedEventArgs e)
        {

            if (txt_author.Text.Length != 0)
            {
               lab_author.Foreground = Brushes.Black;

            }
            else
            {
                lab_author.Foreground = Brushes.Red;

            }


        }

        private void txt_quantitu_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txt_quantitu.Text.Length != 0)
            {
                lab_quntity.Foreground = Brushes.Black;

            }
            else
            {
                lab_quntity.Foreground = Brushes.Red;

            }
        }

        private void txt_price_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txt_price.Text.Length != 0)
            {
                lab_price.Foreground = Brushes.Black;

            }
            else
            {
                lab_price.Foreground = Brushes.Red;

            }

        }

        private void comb_genre_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comb_genre.SelectedItem!=null)
            {
                lab_ganre.Foreground = Brushes.Black;

            }
            else
            {
                lab_ganre.Foreground = Brushes.Red;

            }
        }

        private void btn_cancel_Click(object sender, RoutedEventArgs e)
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

        private void DatePicker_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
           
        }
    }
}
