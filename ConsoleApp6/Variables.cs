using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2._1
{
    internal class Variables
    {
        public int Var1 { get; set; }
        public int Var2 { get; set; }

        public Variables(int var1, int var2)
        {
            Var1 = var1;
            Var2 = var2;
        }
        public Variables()
        {

        }
        public void Display()
        {
            Console.WriteLine("Variable1: " + Var1);
            Console.WriteLine("Variable2: " + Var2);
        }
        ~Variables()
        {

            Console.WriteLine("Objects have been deleted");

        }
    }
}
