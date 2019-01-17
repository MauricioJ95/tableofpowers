using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablesofpowers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            do
            {
                int n, square, cube;
                Console.WriteLine("please enter a number");
                string userNum = Console.ReadLine();
                n = int.Parse(userNum);
                Console.WriteLine("\tNumber\tSquare\tCube"); 
                Console.WriteLine("\t=======\t=======\t======");
                for (int number = 1; number <= n; number++)
                {
                    square = number * number;
                    cube = square * number;
                    Console.WriteLine("\t{0}\t{1}\t{2}", number, square, cube);
                }
                Console.WriteLine("Continue? y/n");
                input = Console.ReadLine();
            } while (input == "y");
        }
    }
}
