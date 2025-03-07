using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class HoldingsWriter
    {
        public static void WriteHoldingsToScreen(List<Holding> holdings)
        {
            foreach (Holding holding in holdings)
            {
                Console.WriteLine(holding.ToString());
            }
        }
    }
}
