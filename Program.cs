// Author: Eric Chen
using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck d = new Deck();
            d.shuffle();
            Console.WriteLine(d);
            for (int i = 0; i < 51; i++)
            {
                d.deal_one_card();
            }
            Console.WriteLine(d);
            d.shuffle();
            Console.WriteLine(d);
            d.deal_one_card();
            Console.WriteLine(d);
            d.shuffle();
            Console.WriteLine(d);
            for (int i = 0; i < 51; i++)
            {
                d.deal_one_card();
            }
            Console.WriteLine(d);
        }
    }
}
