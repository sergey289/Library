using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_management_system.Classes
{
    public class BookLib
    {

        public static List<Book> Books = new List<Book>();

        public static List<Journal> Journal = new List<Journal>();

       

        Book book1 = new Book("harry potter", "J. K. Rowling", "Bloomsbury Publishing", Category.Adventure, "Unknown", "13: 9780545010221",25,5,DateTime.Now);
        Book book2 = new Book("Elton John Official Autobiography", "Elton John", "Henry Holt", Category.Adventure, "Unknown", "B07PK1ZF4K", 14.99,25,DateTime.Parse("28/08/2020"));
        Book book3 = new Book("Eternity Springs", "Emily March", "St. Martin's Paperbacks ", Category.Romance, "Unknown", "B07SCTC5Q3", 5.69,9, DateTime.Parse("15/08/2020"));


        public void DefultBooks()
        {
            Books.Add(book1);
            Books.Add(book2);
            Books.Add(book3);



        }

        public  BindingSource DesplayBook()
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

            foreach (Book item in Books)
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
                row["Price"] = item.Price+"$";

                dt.Rows.Add(row);


            }

            BindingSource bind = new BindingSource();

            bind.DataSource = dt;

           


            return bind;


        }


    }





 }
