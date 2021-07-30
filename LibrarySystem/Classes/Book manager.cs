using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Forms;

namespace Book_management_system.Classes
{
    public class Book_manager:Book
    {
       
        public void AddNewBook(string title, string author, string publisher, Category genre, string description, string isbn, double price, int quantity, DateTime publish_date)
        {
            Book newbook = new Book(title, author, publisher, genre, description, isbn, price,quantity,publish_date);

            BookLib.Books.Add(newbook);


        }

        public void ChangeDetailsOfBook(int bookid, string title, string author, string publisher, Category genre, string description, string isbn, double price,int quantity,DateTime publish_date)
        {

            foreach (Book bk in BookLib.Books)
            {


                if (bk.Bookid == bookid)
                {

                    bk.Title = title;
                    bk.Author = author;
                    bk.Publisher = publisher;
                    bk.Genre = genre;
                    bk.Description = description;
                    bk.Isbn = isbn;
                    bk.Price = price;
                    bk.Quantity = quantity;
                    bk.PublishDate = String.Format("{0:d}", publish_date); ;


                }



            }





        }

        public void Remove(int BookID)
        {

            int index = BookLib.Books.FindIndex(a => a.Bookid == BookID);

            BookLib.Books.RemoveAt(index);

          


        }

        public BindingSource FilterBookbyGenre(Category val)
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

            foreach (Book item in BookLib. Books)
            {

                if (item.Genre.Equals(val))
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

            BindingSource bind = new BindingSource();

            bind.DataSource = dt;

            return bind;
        }

        public BindingSource SearchBook(string title,string author,string publisher,string isbn)
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
              
                if (item.Title.Equals(title) || item.Author.Equals(author) || item.Publisher.Equals(publisher) || item.Isbn.Equals(isbn) || item.Title.Equals(title) && item.Author.Equals(author) || item.Title.Equals(title) && item.Author.Equals(author) && item.Publisher.Equals(publisher) || item.Author.Equals(author) && item.Publisher.Equals(publisher))
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

             BindingSource bind = new BindingSource();

             bind.DataSource = dt;

             return bind;
        }

        
    }
}
