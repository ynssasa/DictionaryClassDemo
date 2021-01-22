using System;

namespace DictionaryClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "Adana");
            myDictionary.Add(31, "Hatay");
            myDictionary.Add(34, "İstanbul");
            Console.WriteLine(myDictionary.GetValue(1));
            Console.WriteLine(myDictionary.GetValue(31));
            Console.WriteLine(myDictionary.GetValue(34));
            Console.WriteLine(myDictionary.GetKey("Adana"));
            Console.WriteLine(myDictionary.GetKey("Hatay"));
            Console.WriteLine(myDictionary.GetKey("İstanbul"));
            
        }
    }
}
