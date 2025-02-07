using static System.Console;
namespace FunWithFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Write("Enter the path of the file you want to print to the screen: ");
            string path = ReadLine();
            Write("Enter the path where you want to backup the first file: ");
            string backupPath = ReadLine();
            try
            {
                if (File.Exists(path))
                {
                    using (StreamWriter sw = new StreamWriter(backupPath))
                    {
                        using (StreamReader sr = new StreamReader(path))
                        {
                            string line;
                            while (!sr.EndOfStream)
                            {
                                line = sr.ReadLine();
                                WriteLine(line);
                                sw.WriteLine(line);
                            }
                        }

                    }
                }
                else
                {
                    WriteLine("That file does not exist!");
                }
            }
            catch (Exception ex) {
                WriteLine("An error occured...");
            }

        }
    }
}
