using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* 
 * Name: Alvin Quijano
 * Date: July 27, 2017
 * Desc: This is the Hand class 
 * It inherits from the CardList super class
 * Ver: 0.4 - Created and implemented the HighestCards method that orders the cards in Hand by greatest value
 */

namespace COMP123_S2017_Lesson11
{
    public class Hand : CardLIst
    {
        // PRIVATE INSTANCE VARIABLES 

        // PUBLIC PROPERTIES 

        // CONSTRUCTORS

        // PRIVATE METHODS 
        /// <summary>
        /// This method initializes class variables and other objects
        /// </summary>
        protected override void _initialize()
        {
            
        }

        // PUBLIC METHODS 
        /// <summary>
        /// This method overrides the built-in ToString method 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string outputString = "";
            outputString += "The Hand contains:\n";
            outputString += "===================================================\n";

            foreach (Card card in this)
            {
                outputString += "The " + card.Face + " of " + card.Suit + "\n";
            }

            return outputString;
        }

        public void HighestCards()
        {
            var highestCard =
                from card in this
                orderby card.Face descending
                select card;

            Console.WriteLine("The highest card values in current Hand by descending order:");
            Console.WriteLine("===================================================");
            foreach (var card in highestCard)
            {
                Console.WriteLine("The " + card.Face + " of " + card.Suit);
            }
        }
        
        
    }
}