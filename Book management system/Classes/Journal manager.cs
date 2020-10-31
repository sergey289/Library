using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_management_system.Classes
{
    class Journal_manager:Journal
    {

        public void AddNewJournal(string title, string publisher, double price, int quantity, DateTime publish_date,string yearOfPublishing, string mounthOfPublishing, string annotation, JournCategory category, string isbn)
        {
            Journal newbook = new Journal(yearOfPublishing, mounthOfPublishing, annotation,category, isbn, title, publisher, price, quantity, publish_date);

            BookLib.Journal.Add(newbook);


        }

        public void ChangeDetailsOfjournal(int Journalid, string title, string publisher, double price, int quantity, DateTime publish_date, string yearOfPublishing, string mounthOfPublishing, string annotation,string category, string isbn)
        {

            foreach (Journal bk in BookLib.Journal)
            {


                if (bk.Journalid == Journalid)
                {

                    bk.Title = title;
                    bk.Publisher = publisher;
                    bk.Price = price;
                    bk.Quantity = quantity;
                    bk.PublishDate = String.Format("{0:d}", publish_date);
                    bk.YearOfPublishing = yearOfPublishing;
                    bk.MounthOfPublishing = mounthOfPublishing;
                    bk.Annotation = annotation;
                    bk.journCategory= (JournCategory)Enum.Parse(typeof(JournCategory),category, true);

                    bk.Isbn = isbn;


                }



            }





        }

        public void Remove(int Journalid)
        {

            int index = BookLib.Journal.FindIndex(a => a.Journalid == Journalid);

            BookLib.Books.RemoveAt(index);




        }

      



    }
}
