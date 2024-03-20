using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2._2
{
    public class Variables
    {
        public int Var1;
        public int Var2;
        public string path { get; set; }
        public void Deserialize(string path)
        {
            var json = File.ReadAllText(path);
            var data = JsonConvert.DeserializeObject<Variables>(json);
            Var1 = data.Var1;
            Var2 = data.Var2;
        }
        public Variables(string path)
        {
            Deserialize(path);
        }

        public Variables()
        {

        }
        public void Display()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Variable1: " + Var1);
            Console.WriteLine("Variable2: " + Var2);
        }
        public void SaveToJson()
        {
            var filePath = @"C:/Users/EpicentrK310/source/repos/ConsoleApp6/laba2.2/Second.json";
            string json = JsonConvert.SerializeObject(this);
            File.WriteAllText(filePath, json);
        }
        ~Variables()
        {

            Console.WriteLine("Objects have been deleted");

        }

    }
}
