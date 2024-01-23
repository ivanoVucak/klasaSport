using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasaSport
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sport sport = new sport("Nogoomet", "Da", 11);
            sport sport2 = new sport("Vaterpolo", "Da", 7);
            sport sport3 = new sport("Curling", "Ne", 1);

            Console.WriteLine(sport.ToString());
            Console.WriteLine(sport2.ToString());
            Console.WriteLine(sport3.ToString());

            Console.ReadKey();
        }
    }
}
