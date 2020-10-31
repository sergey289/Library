using Book_management_system.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace Book_management_system
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       

        public MainWindow()
        {
            InitializeComponent();

            libery.DefultBooks();

            DisplayData();



        }

        BookLib libery = new BookLib();

        Book_manager meneg = new Book_manager();


        public void DisplayData()
       {
            data_grid.ItemsSource = libery.DesplayBook();
  
       }


        public void RefreshData()
        {
            data_grid.Items.Refresh();

            DisplayData();
        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            new_book newbook = new new_book();
            newbook.Show();

           
        }


        private void btn_change_Click(object sender, RoutedEventArgs e)
        {
            try
            {

            Change_book_details change = new Change_book_details();

            DataRowView drv = (DataRowView)data_grid.SelectedItem;


           

            if (drv == null)
            {
                throw new Exception("error: No object was selected to change");
                }
                else
                {

                    int index = 0;

                    string ganre = (drv[5]).ToString();

                    if (ganre.Equals("Fantasy"))
                    {
                        index = 0;


                    }
                    else if (ganre.Equals("Romance"))
                    {


                        index = 1;


                    }
                    else if (ganre.Equals("Adventure"))
                    {

                        index = 2;

                    }
                    else if (ganre.Equals("Mystery"))
                    {
                        index = 3;

                    }


                    int founds = (drv[9]).ToString().IndexOf("$");
                    string price = (drv[9]).ToString().Remove(founds);

                    Change_book_details.IDBook = int.Parse((drv[0]).ToString());
                    change.txt_title.Text = (drv[1]).ToString();
                    change.txt_author.Text = (drv[2]).ToString();
                    change.txt_publisher.Text = (drv[3]).ToString();
                    change.pic_publish_date.Text = (drv[4]).ToString();
                    change.comb_genre.SelectedIndex = index;
                    change.txt_quantitu.Text = (drv[6]).ToString();
                    change.txt_descr.Text = (drv[7]).ToString();
                    change.txt_isbn.Text = (drv[8]).ToString();
                    change.txt_price.Text = price;

                    change.ShowDialog();

                   data_grid.SelectedItem = null;


                }

            }
            catch (Exception ex)
            {
                File.WriteAllText("ErorrLog.txt", ex.Message);

                MessageBox.Show("error: No object was selected to change");

            }
           

            




           

           

           

            
           

           

        }

        private void btn_remove_Click(object sender, RoutedEventArgs e)
        {


            try
            {


              DataRowView drv = (DataRowView)data_grid.SelectedItem;

             meneg.Remove(int.Parse((drv[0]).ToString()));

             RefreshData();

             MessageBox.Show("the book was successfully deleted");


            }
            catch(NullReferenceException ex)
            {

                File.WriteAllText("ErorrLog.txt", ex.Message);

                MessageBox.Show("No object was selected for removing!");


            }
            catch (InvalidCastException ex)
            {
                File.WriteAllText("ErorrLog.txt", ex.Message);

                MessageBox.Show("Wrong object was selected for removing!");

            }


           






        }

        private void btn_filtter_Click(object sender, RoutedEventArgs e)
        {
            ContextMenu cm = this.FindName("cc") as ContextMenu;
            cm.PlacementTarget = sender as Button;
            cm.IsOpen = true;

        }

        

        private void item2_Click(object sender, RoutedEventArgs e)
        {

            data_grid.ItemsSource = meneg.FilterBookbyGenre(Category.Romance);

            data_grid.Items.Refresh();

        }

        private void item1_Click(object sender, RoutedEventArgs e)
        {

            data_grid.ItemsSource = meneg.FilterBookbyGenre(Category.Fantasy);

            data_grid.Items.Refresh();

        }

        private void item3_Click(object sender, RoutedEventArgs e)
        {

            data_grid.ItemsSource = meneg.FilterBookbyGenre(Category.Adventure);

            data_grid.Items.Refresh();


        }

        private void item4_Click(object sender, RoutedEventArgs e)
        {
            data_grid.ItemsSource = meneg.FilterBookbyGenre(Category.Mystery);

            data_grid.Items.Refresh();
        }

        private void item5_Click(object sender, RoutedEventArgs e)
        {

            DisplayData();

        }

        private void btn_search_Click(object sender, RoutedEventArgs e)
        {
            Search_Book sercbk = new Search_Book();

            sercbk.ShowDialog();
        }

        private void btn_raport_Click(object sender, RoutedEventArgs e)
        {

            Generates_Reports rap = new Generates_Reports();

            rap.Show();

           
        }
    }


 }

