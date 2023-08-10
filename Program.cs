using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rumfanget
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Presenting what the program does, afterwards asking the user for desired input.
            Console.Write("This program can calculate the volume of a box. \nPlease enter the height of the box: \n");
            double height = double.Parse(Console.ReadLine());
            Console.Write("Height saved, please write width of the box: \n");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Width saved, please write length of the box: \n");
            double length = double.Parse(Console.ReadLine());
            // Calculating Volume result and writing result.
            Console.Write("This is the volume of the box you entered: " + height * width * length);
        }
    }
}
