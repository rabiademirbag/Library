using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    // Class: Çeşitli özellikleri olan ve nesneler üzerinden kullanılabilen bir yapıdır.
    public class Book
    {
        //Property: Nesneye ait özellikleri tutan ve get ile oluşturulup set ile değiştirilebilen yapıdır.
        public string Name
        {
            get; set;
        }
        public string AuthorName
        {
            get; set;
        }
        public string AuthorSurname
        {
            get; set;
        }
        public int NumberOfPages
        {
            get; set;
        }
        public string Publisher
        {
            get; set;
        }
        public DateTime Date
        {
            get; private set;
        }

        //Sınıfa ait bir nesne oluşturduğumuzda nesnenin ilk durumunu tutan yapıdır.
        //Boş constructorun default değerlerini ben veririm çünkü dışarıdan parametre almaz
        public Book()
        {
            Name = "Körlük";
            AuthorName = "Jose";
            AuthorSurname = "Saramago";
            NumberOfPages = 368;
            Publisher = "Can Yayınları";
            Date = DateTime.Now.Date;
        }
        //Parametre alıp nesneyi o parametreye uygun oluşturur.
        public Book(string name, string authorName, string authorSurname, int numberOfPages, string publisher)
        {
            Name = name;
            AuthorName = authorName;
            AuthorSurname = authorSurname;
            NumberOfPages = numberOfPages;
            Publisher = publisher;
            Date=DateTime.Now.Date;
        }
        public void DisplayBookInfo()
        {
            Console.WriteLine("Book name: "+Name+","+" Author name: "+AuthorName+" "+AuthorSurname+","+"Number Of Pages: "+NumberOfPages+","+"Publisher: "+Publisher+","+"Date: "+Date.ToString("dd.MM.yyyy"));
        }

    }
}
