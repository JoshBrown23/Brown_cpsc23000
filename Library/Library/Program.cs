using static System.Console;
namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            PrintHeading();
            WriteLine();
            PrintInstructions();
            WriteLine();

            int option = 0;
            string title, description, author, date;
            int id = 0, copyrightYear = 2000;
            do
            {
                PrintOptions();
                Write("Enter the number of you choice: ");
                option = int.Parse(ReadLine());

                switch(option)
                {
                    case 1:
                        {
                            WriteLine();
                            WriteLine("Here are the library's holdings:");
                            WriteLine();

                            library.ListAll();
                            break;
                        }
                    case 2:
                        {
                            try
                            {
                                Write("Enter the ID number: ");
                                id = int.Parse(ReadLine());
                            }
                            catch (Exception ex)
                            {
                                WriteLine("You must enter a number...");
                            }
                            
                            Write("Enter the title: ");
                            title = ReadLine();
                            
                            Write("Enter the description: ");
                            description = ReadLine();

                            try
                            {
                                Write("Enter the copyright year: ");
                                copyrightYear = int.Parse(ReadLine());
                            }
                            catch (Exception ex)
                            {
                                WriteLine("You must enter a year");
                            }

                            Write("Enter the author: ");
                            author = ReadLine();

                            try
                            {
                                Book book = new Book(id, title, description, copyrightYear, author);
                                library.AddHolding(book);
                            }
                            catch (Exception ex) {
                                WriteLine("You must enter valid information...");
                            }

                            WriteLine();
                            break;
                        }
                    case 3:
                        {
                            try
                            {
                                Write("Enter the ID number: ");
                                id = int.Parse(ReadLine());
                            } catch (Exception ex)
                            {
                                WriteLine("You must enter a number...");
                            } 

                            Write("Enter the title: ");
                            title = ReadLine();
                            
                            Write("Enter the description: ");
                            description = ReadLine();
                            
                            Write("Enter the publication date: ");
                            date = ReadLine();

                            Periodical periodical = new Periodical(id, title, description, date);
                            library.AddHolding(periodical);
                            WriteLine();
                            break;
                        }
                    case 4:
                        {
                            Write("Enter the ID number of the holding you wish to reserve: ");
                            id = int.Parse(ReadLine());

                            if (library.CheckOut(id))
                            {
                                WriteLine("You have successfully checked out that holding!");
                                WriteLine();
                            }
                            else
                            {
                                WriteLine("The holding with that ID can not be checked out...");
                                WriteLine();
                            }

                            break;
                        }
                    case 5:
                        {
                            Write("Enter the ID number of the holding you wish to return: ");
                            id = int.Parse(ReadLine());

                            if (library.CheckIn(id))
                            {
                                WriteLine("You have successfully checked in that holding!");
                                WriteLine();
                            }
                            else
                            {
                                WriteLine("The holding with that ID can not be checked in...");
                                WriteLine();
                            }
                            break;
                        }
                    case 6:
                        {
                            WriteLine("Here are the library's stats:");
                            WriteLine(library.GetStats());
                            WriteLine();
                            break;
                        }
                    case 7:
                        {
                            WriteLine();
                            WriteLine("Thank you for using this program");
                            break;
                        }
                    default:
                        {
                            WriteLine("That is not a valid option. Please try again.");
                            WriteLine();
                            break;
                        }
                }
            } while (option != 7);
        }

        public static void PrintHeading()
        {
            WriteLine(new string('*', 57));
            WriteLine($"{"Library Management System Version 1.0", 47}");
            WriteLine(new string('*', 57));
        }

        public static void PrintInstructions()
        {
            WriteLine("This tool helps you manage a library's collections." +
                "\nPlease use the menu to choose what you want to do.");
        }

        public static void PrintOptions()
        {
            WriteLine("Here are your options:" +
                "\n1. List Holdings\n2. Add a book" +
                "\n3. Add a periodical\n4. Reserve a holding" +
                "\n5. Return a holding\n6. See statistics" +
                "\n7. Quit");
        }
    }
}