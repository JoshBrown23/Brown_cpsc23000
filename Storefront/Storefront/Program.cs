/*
 * https://www.geeksforgeeks.org/sorteddictionary-implementation-in-c-sharp/
 * I used this website to learn how to implement dictionary sorting
 * You must include the System.Collections.Generic namespace
 * You define the SortedDictionary just like any other dictionary, 
 * of course, you must use SortedDictionary instead.
 * The default constructor for this dictionary uses IComparer to sort
 * the keys of the dictionary.
 */

using static System.Console;
using System.Collections.Generic;
namespace Storefront
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintBanner();
            Dictionary<string, double> inventory = new Dictionary<string, double>();
            SortedDictionary<string, int> cart = new SortedDictionary<string, int>();
            Write("Enter the name of the grocery items file: ");
            string path = ReadLine();
            string line;
            string[] parts;
            string product;
            double price;
            string itemName;
            int quantity;
            double totalCost = 0;
            bool qtyFlag = false;

            try
            {
                if (File.Exists(path))
                {
                    using (StreamReader sr = new StreamReader(path))
                    {

                        while (!sr.EndOfStream)
                        {
                            line = sr.ReadLine().Trim();
                            if (line.Length == 0)
                            {
                                continue;
                            }
                            parts = line.Split("\t");
                            product = parts[0];
                            price = double.Parse(parts[1]);
                            inventory.Add(product, price);
                        }
                    }

                }else
                {
                    WriteLine("That file doesn't exist.");
                }
            }
            catch (Exception ex)
            {
                WriteLine("Could not read file. Exiting.");
                return;
            }

            do
            {
                WriteLine("What would you like to buy?");
                foreach (var inv in inventory)
                {
                    WriteLine($"{inv.Key,-20}{inv.Value,10:C2}");
                }
                WriteLine();
                Write("Enter item name, or 'quit' to end: ");
                itemName = ReadLine();
                if (inventory.ContainsKey(itemName))
                {
                        while (qtyFlag == false)
                        { 
                            try
                            {
                                Write("How many do you want? ");
                                quantity = int.Parse(ReadLine());
                                if (cart.ContainsKey(itemName))
                                {
                                    cart[itemName] = cart[itemName] + quantity;
                                    qtyFlag = true;
                                }
                                else
                                {
                                    cart.Add(itemName, quantity);
                                    qtyFlag = true;
                                }

                                WriteLine($"You added {itemName}, quantity {quantity}, to your cart.");
                                WriteLine();
                            }
                            catch (Exception ex)
                            {
                                WriteLine("You must enter a number for the quantity. Try again.");
                            }
                        }
                }
                else if (itemName == "quit")
                {
                    WriteLine("Here is what you bought:");
                }
                else 
                {
                    WriteLine("We don't carry that. Try again.");
                    WriteLine();
                    continue;
                }

            } while (itemName != "quit");
            
            foreach (var item in cart)
            {
                WriteLine($"{item.Key, -20}{item.Value, 10}");
                totalCost = totalCost + item.Value * inventory[item.Key];
            }
            WriteLine();
            WriteLine($"Your total for today: {totalCost, 8:C2}");
            WriteLine();
            WriteLine("Thank you for shopping with us!");

            /*
 * do {
 *      show the inventory menu
 *      ask their choice
 *      if choise is in the inventory {
 *              ask for quantity
 *              add item and quantity to cart
 *                  if the item is already in the cart, add to its quantity
 *      }       
 *      else {
 *              tell them not in stock
 *      }
 * } while not quitting
 * 
 * totalCost = 0
 * foreach (var item in cart) 
 *      print item.Key and item.Value (item and qty)
 *      totalCost = totalCost + item.Value * inventory[item.Key]
 * }
 * print totalCost
 * on the receipt, sort the items alphabetically 
 */
        }

        static void PrintBanner()
        {
            WriteLine(new string('*', 51));
            WriteLine($"{"STOREFRONT V1.0", 33}");
            WriteLine(new string('*', 51));
        }
    }
}
