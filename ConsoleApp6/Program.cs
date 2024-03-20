using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int var1 = 10;
            int var2 = 20;

            Variables empt1 = new Variables(var1, var2);
            empt1.Display();

            Variables empt2 = new Variables();
            empt2.Display();

            Console.WriteLine();
        }

    }
}
