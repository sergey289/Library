using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_management_system.Classes
{
   public class Journal:Print_edition
    {

        static int id = 0;
        private int journalid;
        private string yearOfPublishing;
        private string mounthOfPublishing;
        private string annotation;
        private JournCategory category;
        private string isbn;


        public Journal()
        {
            journalid = 0;
            yearOfPublishing = "";
            mounthOfPublishing = "";
            annotation = "";
            journCategory = default;
            isbn = "";


        }



        public Journal(string yearOfPublishing, string mounthOfPublishing, string annotation, JournCategory category, string isbn, string title, string publisher, double price, int quantity, DateTime publish_date) : base(title, publisher, price, quantity, publish_date)
        {

            Journalid = id++;
            YearOfPublishing = yearOfPublishing;
            MounthOfPublishing = mounthOfPublishing;
            Annotation = annotation;
            journCategory = category;
            Isbn = isbn;

        }

        public int Journalid
        {

            get { return journalid; }
            set {journalid=value; }

        }

        public string YearOfPublishing
        {
            get { return yearOfPublishing; }
            set { yearOfPublishing = value; }
        }

        public string MounthOfPublishing
        {

            get { return mounthOfPublishing; }
            set { mounthOfPublishing = value; }
        }

        public string Annotation
        {

            get { return annotation; }
            set { annotation = value; }
        }

        public JournCategory journCategory
        {

            get { return category; }
            set { category = value; }

        }

        public string Isbn
        {

            get { return isbn; }
            set { isbn = value; }
        }



    }

   public enum JournCategory { sport, Phisiology, Biology }

}
