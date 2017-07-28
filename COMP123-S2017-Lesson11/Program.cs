using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
 * Name: Alvin Quijano
 * Date: July 25, 2017
 * Desc: Demo for lesson 11
 * Ver: 0.4 - Tested the deal5 method and HighestCards method
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

            hand = deck.Deal5(); // Deals 5 cards to the hand container 
            Console.WriteLine(hand.ToString()); // outputs the cards in Hand 

            hand.HighestCards(); // Sorts the cards in Hand by highest value 

        }
    }
}
