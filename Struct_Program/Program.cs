using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Program
{
    struct Books
    {
        public string title;
        public string author;
        public string subject;
        public int book_id;

        public void getValues(string t, string a, string s, int id)
        {
            title = t;
            author = a;
            subject = s;
            book_id = id;
        }

        public void display()
        {
            Console.WriteLine("Title : {0}", title);
            Console.WriteLine("Author : {0}", author);
            Console.WriteLine("Subject : {0}", subject);
            Console.WriteLine("Book_id :{0}", book_id);
        }
    };

    internal class Program
    {
        static void Main(string[] args)
        {
            Books Book1 = new Books();   /* Declare Book1 of type Book */
            Books Book2 = new Books();   /* Declare Book2 of type Book */

            /* book 1 specification */
            Book1.getValues("Python Programming",
            "Vamsi Kurma", "Python basic to Advance", 9898765);

            /* book 2 specification */
            Book2.getValues("A Promised Land",
            "Obama", "His President's Regime", 7654464);

            /* print Book1 info */
            Book1.display();

            /* print Book2 info */
            Book2.display();

            Console.ReadLine();
        }
    }
}