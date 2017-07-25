using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
 * Name: Alvin Quijano
 * Date: July 25, 2017
 * Desc: Demo for lesson 11
 * Ver: 0.2 - Implemented the deck class
 */


namespace COMP123_S2017_Lesson11
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            Console.WriteLine(deck.ToString());
        }
    }
}
