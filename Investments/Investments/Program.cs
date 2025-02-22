using System.Xml.Serialization;
using static System.Console;
namespace Investments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Define variables for the checking account and CD info
            string name, id, date;
            double balance, overdraftFee, interestRate, amount;


            //The user's response will be stored in the response variable,
            //which will then be split into the corresponding checking or cd array
            string response;
            string[] checkingParts;
            string[] cdParts;

            //Define the Checking and CD objects
            CheckingAccount checking = null;
            CD cd = null;
            //The objects will be stored in this list
            List<Investment> investments = new List<Investment>();
            
            //Variable to store the user's choice when interacting with the investment management menu
            int choice = 0;
            
            //Print the program header along with a brief introduction to the program
            PrintHeader();
            PrintInstructions();

            WriteLine("At this bank, you have one CD and one checking account");
            WriteLine();
            Write("Enter your name: ");
            name = ReadLine();

            while (checking == null)
            {
                try
                {
                    WriteLine();
                    WriteLine("I'll ask you about the checking account first.");
                    WriteLine();
                    WriteLine("Enter the ID for the checking account, the date you opened it, the starting balance, and the overdraft fee:");
                    response = ReadLine();
                    checkingParts = response.Split(" ");
                    
                    //Using the split parts stored in the array, assign them to the proper variables, parsing when necessary.
                    id = checkingParts[0];
                    date = checkingParts[1];
                    balance = double.Parse(checkingParts[2]);
                    overdraftFee = double.Parse(checkingParts[3]);

                    checking = new CheckingAccount(id, name, balance, date, overdraftFee);
                } 
                catch (Exception ex)
                {
                    WriteLine("You need to enter valid information.");
                    checking = null;
                }
            }

            //Attempt to the CD object
            //If improper information is given, continue while loop until successful
            while( cd == null)
            {
                try
                {
                    WriteLine();
                    WriteLine("Now I'll ask you about the CD.");
                    WriteLine();
                    WriteLine("Enter the ID for the CD, the date you opened it, the starting balance, and the interest rate:");
                    response = ReadLine();
                    cdParts = response.Split(" ");

                    //Using the split parts stored in the array, assign them to the proper variables, parsing when necessary.
                    id = cdParts[0];
                    date = cdParts[1];
                    balance = double.Parse(cdParts[2]);
                    interestRate = double.Parse(cdParts[3]);

                    cd = new CD(id, name, balance, date, interestRate);
                }
                catch (Exception ex)
                {
                    WriteLine("You need to enter valid information.");
                    cd = null;
                }
            }

            //Add the Investment objects to the list
            investments.Add(checking);
            investments.Add(cd);

            WriteLine();
            WriteLine("Now that your accounts have been created, let's manage them.");
            WriteLine();

            //Start of investment management menu:
            //User will be given various choices that allow them to
            //withdraw, deposit, accrue interest, or charge overdraft fees to the corresponding Investment object
            //Continue the do loop until the user chooses to quit
            do
            {
                PrintMenu();
                Write("Enter the number of your choice: ");
                choice = int.Parse(ReadLine());

                switch(choice)
                {
                    case 1: //Withdraw
                        {
                            try
                            {
                                Write("How much do you want to withdraw? ");
                                amount = double.Parse(ReadLine());
                                checking.Withdraw(amount);
                            }
                            catch (Exception ex)
                            {
                                WriteLine("You need to enter a number.");
                            }
                            WriteLine();
                            break;
                        }
                    case 2: //Deposit
                        {
                            try
                            {
                                Write("How much do you want to deposit? ");
                                amount = double.Parse(ReadLine());
                                checking.Deposit(amount);
                            }
                            catch (Exception ex)
                            {
                                WriteLine("You need to enter a number.");
                            }
                            WriteLine();
                            break;
                        }
                    case 3: //Update
                        {
                            WriteLine("The CD accrued interest, and the checking account applied overdraft fees if applicable");
                            foreach (var investment in investments)
                            {
                                investment.ApplyAutomaticAdjustments();
                            }
                            WriteLine();
                            break;
                        }
                    case 4: //List
                        {
                            WriteLine("Here are your investments at our bank:");
                            foreach (var investment in investments)
                            {
                                WriteLine(investment);
                            }
                            WriteLine();
                            break;
                        }
                    case 5: //Quit
                        {
                            WriteLine("Thank you for banking with us!");
                            break;
                        }
                    default:
                        {
                            WriteLine("That is not a valid choice. Please try again.");
                            WriteLine();
                            break;
                        }
                }
            } while (choice != 5);

        }

        //This function prints a neatly formatted header
        public static void PrintHeader()
        {
            WriteLine(new string('*', 50));
            WriteLine($"{"Investment Tracker Version 1.0", 40}");
            WriteLine(new string('*', 50));
        }

        //This function prints some basic information about the program
        public static void PrintInstructions()
        {
            WriteLine();
            WriteLine("This tool helps you manage your investments, both" +
                "\nCDs and checking accounts. CDs accrue interest and" +
                "\nchecking accounts can have overdraft fees.");
            WriteLine();
        }

        //This function prints the various options for the investment management menu
        public static void PrintMenu()
        {
            WriteLine("What would you like to do?");
            WriteLine("1. Withdraw from checking");
            WriteLine("2. Deposit into checking");
            WriteLine("3. Update balances");
            WriteLine("4. List investments");
            WriteLine("5. Quit");
        }
    }
}
