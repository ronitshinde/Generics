using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Finding maximum of three numbers");
            MaxOfNumbers integer = new MaxOfNumbers();
            int maximumNum = integer.MaxInteger(31, 21, 11);
            Console.WriteLine("Maximum Number is :" + maximumNum);
            Console.ReadLine();
        }
    }
}
