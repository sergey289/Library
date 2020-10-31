using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_management_system.Classes
{
    public class Book:Print_edition
    {
       static int id = 0;
       private  int bookid;
       private string author;
       private Category genre;
       private string description;
       private string isbn;
      

       public Book()
       {
            bookid = 0;
            Author = "";
            Genre = default;
            Description = "";
            Isbn = "";


       }



        public Book(string title,string author,string publisher, Category genre,string description,string isbn,double price,int quantity,DateTime publish_date):base(title,publisher,price,quantity,publish_date)
        {

            bookid = id++;
            Author = author;
            Genre = genre;
            Description = description;
            Isbn = isbn;

        }

        public int Bookid
        {

            get { return bookid; }

        }

        public string Author
        {
            get { return author; }

            set { author = value; }
        }

        public Category Genre
        {

            get { return genre; }

            set { genre = value; }
        }

        public string Description
        {

            get { return description; }

            set { description = value; }
        }

        public string Isbn
        {

            get { return isbn; }

            set { isbn = value; }
        }

       

        

    }

   public enum Category {Fantasy,Romance,Adventure,Mystery }
}
