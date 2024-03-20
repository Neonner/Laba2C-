using System;
using System.IO;
using Newtonsoft.Json;

namespace laba2._2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string path = @"C:/Users/EpicentrK310/source/repos/ConsoleApp6/laba2.2/First.json";

            Variables empt1 = new Variables(path);

            empt1.Display();

            Variables empt2 = new Variables();

            empt2.Display();

            Console.WriteLine();
        }

    }
}