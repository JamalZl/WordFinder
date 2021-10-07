using System;

namespace WordFinding
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Salam necesen Nurkhan";
            string word = "malas";
            Console.WriteLine(str.EasyFind(word));
        }
    }
}
