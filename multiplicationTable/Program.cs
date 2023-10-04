using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, result;
            Console.Write("Enter the number : ");
            x = Convert.ToInt32(Console.ReadLine());
            for (int i=0; i<11; i++)
            {
                result = x * i;
                Console.WriteLine("{0} * {1} = {2}", x, i, result);
                Console.ReadKey();

            }
        }
    }
}
