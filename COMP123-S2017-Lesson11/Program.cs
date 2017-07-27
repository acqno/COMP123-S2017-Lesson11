using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
 * Name: Alvin Quijano
 * Date: July 25, 2017
 * Desc: Demo for lesson 11
 * Ver: 0.3 - Tested the deal1 method 
 */


namespace COMP123_S2017_Lesson11
{
    class Program
    {
        static void Main(string[] args)
        {
            Hand hand = new Hand(); // new empty hand container

            Deck deck = new Deck();
            Console.WriteLine(deck.ToString());
            Console.WriteLine();
            deck.Shuffle();
            Console.WriteLine(deck.ToString());

            hand.Add(deck.Deal1()); // deak ibe card from the top of the deck 
            Console.WriteLine(hand.ToString());
        }
    }
}
