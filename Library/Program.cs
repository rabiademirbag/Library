
using Library;

class Program
{
    public static void Main(string[] args)
    {
        //New keywordu ile yeni nesne oluştururuz
        Book book1 = new Book();
        Book book2= new Book("Adı Aylin","Ayşe","Kulin",398,"Remzi Kitabevi");
        book1.DisplayBookInfo();
        book2.DisplayBookInfo();
    }
}