namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float temp = 0;
            Console.Write("Enter a temperature: ");
            temp = float.Parse(Console.ReadLine());
            Console.Write("Convert to C or F? ");
            string choice = Console.ReadLine();
            if (choice == "C")
            {
                Console.WriteLine(ConvertToCelsius(temp));

            }
            else
            {
                Console.WriteLine(ConvertToFarenheit(temp));
            }
        }

        public static float ConvertToCelsius(float temp)
        {
            return (temp - 32) * 5 / 9;
        }

        public static float ConvertToFarenheit(float temp)
        {

            return (temp * 9 / 5) + 32;
        }
    }
}
