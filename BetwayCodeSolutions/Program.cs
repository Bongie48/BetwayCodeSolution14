using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetwayCodeSolutions
{
    //Question 14 : Magic Potion Identifier
    internal class Program
    {
        static void Main(string[] args)
        {
            long power = 132651201231;
            string result = IsMagicalPotion(power) ? "YES" : "NO";
            Console.WriteLine(result);
            Console.ReadLine();
        }
        static bool IsMagicalPotion(long power)
        {
            if (power < 1)
            {
                return false; 
            }
            double cubeRoot = Math.Round(Math.Pow(power, 1.0 / 3));
            return Math.Pow(cubeRoot, 3) == power;
        }

    }
}
