using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> myDictionary = new MyDictionary<string, string>();
            myDictionary.Add("Türkiye","İstanbul");
            myDictionary.Add("Kanada","Ottawa");
            myDictionary.Add("Bulgaristan","Sofya");
            foreach (var anahtar in myDictionary.Anahtar)
            {
                Console.WriteLine("Ülke:" +" "+anahtar);
            }
            foreach (var deger in myDictionary.Deger)
            {
                Console.WriteLine("Başkent"+" "+deger);
            }
        }
    }
}
