using System;
using System.Data;
using System.Windows.Forms;
using Book_management_system.Classes;
using java.awt.print;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace BookManagementsystem_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        public void AddnewObjectTOlist_List_return_Count_1()
        {
            Book_management_system.Classes.Book_manager men = new Book_management_system.Classes.Book_manager();

            //arrenge

            string title="";
            string author="";
            string publisher="";
            Category genre=default;
            string description="";
            string isbn="";
            double price=0;
            int quantity=0;
            DateTime publish_dat= DateTime.Parse("28.03.2020");
            int expected = 1; // Book_management_system.Classes.BookLib.Books.Count;



            //act

            men.AddNewBook(title, author, publisher, genre, description, isbn, price, quantity, publish_dat);

            int actual = Book_management_system.Classes.BookLib.Books.Count;



            // asert

            Assert.AreEqual(expected, actual);






        }


        [TestMethod]

        public void RemoveObjectFromlist_List_return_Count_2()
        {

            //arrenge

            Book_management_system.Classes.BookLib BookLib = new Book_management_system.Classes.BookLib();

            BookLib.DefultBooks();

            int expected = 2;


            //act

            Book_management_system.Classes.Book_manager meng = new Book_management_system.Classes.Book_manager();

            meng.Remove(1);


            int actual = Book_management_system.Classes.BookLib.Books.Count;

            // asert

            Assert.AreEqual(expected, actual);




        }


        [TestMethod]

        public void ChangeObjectOnlist_List_return_title_Hallow()
        {

            //arrenge

            Book_management_system.Classes.BookLib BookLib = new Book_management_system.Classes.BookLib();

            BookLib.DefultBooks();

            string title = "Hallow";
            string author = "";
            string publisher = "";
            Category genre =default;
            string description = "";
            string isbn = "";
            double price = 0;
            int quantity = 0;
            DateTime publish_dat = DateTime.Parse("28.03.2020");


            string expected = title;

            //act

            Book_management_system.Classes.Book_manager meng = new Book_management_system.Classes.Book_manager();

            meng.ChangeDetailsOfBook(1, title, author, publisher, genre, description, isbn, price, quantity, publish_dat);

            string actual="";

            foreach (Book_management_system.Classes.Book bk in Book_management_system.Classes.BookLib.Books)
            {


                if (bk.Bookid == 1)
                {

                    actual = bk.Title;
                    


                }



            }



            // asert

            Assert.AreEqual(expected, actual);


        }

        [TestMethod]

        public void SearchObjectOnList_List_return_objecByValueInTitle()
        {



           //arrenge

            Book_management_system.Classes.BookLib BookLib = new Book_management_system.Classes.BookLib();

            Book_management_system.Classes.Book_manager meng = new Book_management_system.Classes.Book_manager();

            BookLib.DefultBooks();

            
           var source =meng.SearchBook("harry potter", "","","");

           var table = (DataTable)source.DataSource;

           string expected= "harry potter";

           //act

            string actual = "";

            foreach (DataRow row in table.Rows)
            {

               actual = row["Title"].ToString(); ;

            }

            // asert

            Assert.AreEqual(expected,actual);

            

            }


        [TestMethod]

        public void FillterObjectOnList_List_return_objecByValueInTGenre()
        {


            //arrenge


            Book_management_system.Classes.BookLib BookLib = new Book_management_system.Classes.BookLib();

            Book_management_system.Classes.Book_manager meng = new Book_management_system.Classes.Book_manager();

            BookLib.DefultBooks();

            var source = meng.FilterBookbyGenre(Category.Adventure);

            var table = (DataTable)source.DataSource;

            int expected =2 ;

            //act

            int actual = table.Rows.Count;

            // asert

            Assert.AreEqual(expected, actual);

        }



    }
}
