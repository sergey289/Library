using Book_management_system.Classes;
using Book_management_system.ReportGenerator.CrystalReport;
using Book_management_system.ReportGenerator.DataSet;
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
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Book_management_system
{
    /// <summary>
    /// Interaction logic for Generates_Reports.xaml
    /// </summary>
    public partial class Generates_Reports : Window
    {
        public Generates_Reports()
        {
            InitializeComponent();

            comb_genre.ItemsSource = Enum.GetValues(typeof(Category));
        }

       
        public  void Report()
        {
            DataTable dt = new DataTable();

            if (comb_genre.SelectedItem != null)
            {

            dt.Columns.Add("Book iD");
            dt.Columns.Add("Title");
            dt.Columns.Add("Author");
            dt.Columns.Add("Publisher");
            dt.Columns.Add("Date Publish");
            dt.Columns.Add("Genre");
            dt.Columns.Add("Quantity");
            dt.Columns.Add("Description");
            dt.Columns.Add("Isbn");
            dt.Columns.Add("Price");

            foreach (Book item in BookLib.Books)
            {

                    

                if (item.Genre.Equals((Category)Enum.Parse(typeof(Category), comb_genre.SelectedItem.ToString(), true)))
               {

                    

                var row = dt.NewRow();

                row["Book iD"] = item.Bookid;
                row["Title"] = item.Title;
                row["Author"] = item.Author;
                row["Publisher"] = item.Publisher;
                row["Date Publish"] = item.PublishDate;
                row["Genre"] = item.Genre;
                row["Quantity"] = item.Quantity;
                row["Description"] = item.Description;
                row["Isbn"] = item.Isbn;
                row["Price"] = item.Price + "$";

                dt.Rows.Add(row);


                }



             }




            }else if (pic_publish_date_start.SelectedDate != null)
            {



                dt.Columns.Add("Book iD");
                dt.Columns.Add("Title");
                dt.Columns.Add("Author");
                dt.Columns.Add("Publisher");
                dt.Columns.Add("Date Publish");
                dt.Columns.Add("Genre");
                dt.Columns.Add("Quantity");
                dt.Columns.Add("Description");
                dt.Columns.Add("Isbn");
                dt.Columns.Add("Price");

                foreach (Book item in BookLib.Books)
                {

                    if ((DateTime)pic_publish_date_start.SelectedDate<=DateTime.Parse(item.PublishDate))
                    {



                        var row = dt.NewRow();

                        row["Book iD"] = item.Bookid;
                        row["Title"] = item.Title;
                        row["Author"] = item.Author;
                        row["Publisher"] = item.Publisher;
                        row["Date Publish"] = item.PublishDate;
                        row["Genre"] = item.Genre;
                        row["Quantity"] = item.Quantity;
                        row["Description"] = item.Description;
                        row["Isbn"] = item.Isbn;
                        row["Price"] = item.Price + "$";

                        dt.Rows.Add(row);


                    }



                }



            }else if(comb_genre.SelectedItem != null && pic_publish_date_start.SelectedDate != null)
            {




                dt.Columns.Add("Book iD");
                dt.Columns.Add("Title");
                dt.Columns.Add("Author");
                dt.Columns.Add("Publisher");
                dt.Columns.Add("Date Publish");
                dt.Columns.Add("Genre");
                dt.Columns.Add("Quantity");
                dt.Columns.Add("Description");
                dt.Columns.Add("Isbn");
                dt.Columns.Add("Price");

                foreach (Book item in BookLib.Books)
                {

                    if ((DateTime)pic_publish_date_start.SelectedDate <= DateTime.Parse(item.PublishDate) && item.Genre.Equals(comb_genre.SelectionBoxItem.ToString()))
                    {



                        var row = dt.NewRow();

                        row["Book iD"] = item.Bookid;
                        row["Title"] = item.Title;
                        row["Author"] = item.Author;
                        row["Publisher"] = item.Publisher;
                        row["Date Publish"] = item.PublishDate;
                        row["Genre"] = item.Genre;
                        row["Quantity"] = item.Quantity;
                        row["Description"] = item.Description;
                        row["Isbn"] = item.Isbn;
                        row["Price"] = item.Price + "$";

                        dt.Rows.Add(row);


                    }



                }



















            }



            ReportBooks crsrap = new ReportBooks();

            crsrap.Database.Tables["Books"].SetDataSource(dt);


            raport_view.ViewerCore.ReportSource = crsrap;

        }


        private void btn_prev_Click(object sender, RoutedEventArgs e)
        {

            Report();

        }

        private void btn_listofBook_Click(object sender, RoutedEventArgs e)
        {
            DataTable dt = new DataTable();


            dt.Columns.Add("Book iD");
            dt.Columns.Add("Title");
            dt.Columns.Add("Author");
            dt.Columns.Add("Publisher");
            dt.Columns.Add("Date Publish");
            dt.Columns.Add("Genre");
            dt.Columns.Add("Quantity");
            dt.Columns.Add("Description");
            dt.Columns.Add("Isbn");
            dt.Columns.Add("Price");

            foreach (Book item in BookLib.Books)
            {
                var row = dt.NewRow();

                row["Book iD"] = item.Bookid;
                row["Title"] = item.Title;
                row["Author"] = item.Author;
                row["Publisher"] = item.Publisher;
                row["Date Publish"] = item.PublishDate;
                row["Genre"] = item.Genre;
                row["Quantity"] = item.Quantity;
                row["Description"] = item.Description;
                row["Isbn"] = item.Isbn;
                row["Price"] = item.Price + "$";

                dt.Rows.Add(row);

            }


            ReportBooks crsrap = new ReportBooks();

            crsrap.Database.Tables["Books"].SetDataSource(dt);

            raport_view.ViewerCore.ReportSource = crsrap;

        }
    }
}
