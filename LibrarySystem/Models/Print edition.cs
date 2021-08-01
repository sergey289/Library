using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_management_system.Classes
{
    public abstract class Print_edition
    {

       private string title;
       private string publisher;
       private double price;
       private int quantity;
       private string publish_date;

        protected Print_edition()
        {
            title = "";
            publisher = "";
            price = 0;
            quantity = 0;

        }


        protected Print_edition(string title, string publisher, double price,int quantity, DateTime publish_date)
        {
            Title = title;
            Publisher = publisher;
            Price = price;
            Quantity = quantity;
            PublishDate = String.Format("{0:d}",publish_date);
        }


      public string Title
        {

            get { return title; }
            set { title = value; }
        }

      public string Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }

      public double Price
        {
            get { return price; }
            set { price = value; }
        }

      public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }


     public  string PublishDate
        {

            get { return publish_date; }
            set { publish_date = value; }


        }


    }
}
