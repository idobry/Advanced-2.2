using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApp
{
    class Program
    {
        [Key]
        public struct myKey
        {
            public int num;
        }//Key

        public struct myString
        {
            public string str;

            public override string ToString()
            {
                return str;
            }
        }//myString

        private static void Main(string[] args)
        {
            var multiDictionary = new MultiDictionary<myKey, myString>();

            myKey number;
            number.num = 1;
            myString myStr;
            myStr.str = "One";

            myKey number2;
            number2.num = 1;
            myString myStr2;
            myStr2.str = "ich";

            multiDictionary.Add(number, myStr);
            multiDictionary.Add(number2, myStr2);

            DisplayDictionary(multiDictionary);
            multiDictionary.Remove(number);
            DisplayDictionary(multiDictionary);
        }

        private static void DisplayDictionary(MultiDictionary<myKey, myString> multiDictionary)
        {
            if (multiDictionary.Count != 0)
            {
                foreach (var key in multiDictionary)
                {
                    foreach (var value in key.Value)
                    {
                        Console.WriteLine($"Key: {key.Key.num}, Value: {value}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Dictionary Empty");
            }
        }
    }
}

