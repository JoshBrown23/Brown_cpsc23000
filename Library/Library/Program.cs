using static System.Console;
namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book(1234, "The Best Book Ever", "The title says it all", 2025, "Joe Schmoe");
            WriteLine(book);
            WriteLine();
            book.ReserverHolding();
            WriteLine(book);
        }
    }
}






/*
 * Holding superclass, book and periodical subclasses (inheritance)
 * Library class that stores Holding objects (ownership)
 * 
 * Menu driven access to manage a variety of Holdings
 * 
 * List holdings
 * Add book
 * Add periodical
 * Reserve a holding
 * return a holding
 * see stats
 * quit
 * 
 * Holding, Book, Periodical, Library (model classes)
 * HoldingWriter (view class)
 * Main (controller class)
 */
