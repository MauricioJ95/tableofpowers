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
                Console.WriteLine("\tNumber\tSquare\tCube"); //lining up the numbers, squares, and cubes with \t
                Console.WriteLine("\t=======\t=======\t======");
                for (int number = 1; number <= n;//number is 1; number is less than or equal to n; n++(n+1)
                    number++)
                {
                    square = number * number;//the equation for squares
                    cube = square * number;//the equation for cubes
                    Console.WriteLine("\t{0}\t{1}\t{2}", number, square, cube);//making sure they stay in that order of numbers,squares, and cubes
                }
                Console.WriteLine("Continue? y/n");
                input = Console.ReadLine();//continue y/n
            } while (input == "y");
        }
    }
}
