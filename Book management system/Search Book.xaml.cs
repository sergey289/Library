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
    /// Interaction logic for Search_Book.xaml
    /// </summary>
    public partial class Search_Book : Window
    {
        public Search_Book()
        {
            InitializeComponent();
        }


        Book_manager meneg = new Book_manager();

        private void btn_search_Click(object sender, RoutedEventArgs e)
        {

            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {

                    (window as MainWindow).data_grid.ItemsSource = meneg.SearchBook(txt_title.Text, txt_author.Text, txt_publisher.Text, txt_isbn.Text);

                    (window as MainWindow).data_grid.Items.Refresh();
                }
            }

            

        }

        

        private void btn_cencel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }


}