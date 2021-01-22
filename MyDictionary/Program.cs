using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictonary<int, string> books = new Dictonary<int, string>();

            books.Add(01, "Kürk Mantolu Madonna");
            books.Add(02, "Bizim Büyük Çaresizliğimiz");
            books.Add(03, "Hayat Cesurlara Torpir Gecer");
            books.Add(04, "Serenad");
            books.Add(05, "Mutluluk");
            books.Add(06, "Elif Gibi Sevmek");
            books.Add(07, "Aşk");
            books.Add(08, "Baba ve Piç");
        


            foreach (var number in books.Keys)
            {
                Console.WriteLine(number);
            }

            foreach (var book in books.Values)
            {
                Console.WriteLine(book);
            }

        }
    }
}
