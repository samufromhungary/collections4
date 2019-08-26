using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace GenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> dict = new Dictionary<int,string>();


            dict[44] = "United Kingdom";
            dict[33] = "France";
            dict[31] = "Netherlands";
            dict[55] = "Brazil";

            Console.WriteLine("Code 31: {0}", dict[31]);

            foreach(KeyValuePair<int,string> i in dict)
            {
                int code = i.Key;
                string country = i.Value;
                Console.WriteLine("{0} - {1}", code, country);
            }

            Console.ReadKey();
        }
    }
}
