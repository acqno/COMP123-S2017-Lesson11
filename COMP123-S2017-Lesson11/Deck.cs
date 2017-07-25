using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* 
 * Name: Alvin Quijano
 * Date: July 25, 2017
 * Desc: This is the deck class which inherits from the list generic collection
 * This class creates a new List type - Card
 * Ver: 0.1 - Created the Deck class 
 */

namespace COMP123_S2017_Lesson11
{
    public class Deck:List<Card>
    {
        // PRIVATE INSTANCE VARIABLES 

        // PUBLIC PROPERTIES 

        // CONSTRUCTOR
        /// <summary>
        /// This is the main constructor for the deck class
        /// </summary>
        public Deck()
        {
            this._initialize();
        }

        // PRIVATE METHODS 
        /// <summary>
        /// This is the private _initialize method that loads the deck with 52 cards 
        /// </summary>
        private void _initialize()
        {
            for (int suit = 0; suit <= (int)Suit.Spades; suit++)
            {
                for (int face = 0; face <= (int)Face.King; face++)
                {
                    this.Add(new Card((Face)face, (Suit)suit));
                }
            }

            
        }

        // PUBLIC METHODS 
        /// <summary>
        /// This method overrides the built in ToString method and outputs the contents of the deck
        /// </summary>
        public override string ToString()
        {
            string outputString = "";

            foreach (Card card in this)
            {
                outputString += "The " + card.Face + " of " + card.Suit + "\n";
            }

            return outputString;
        }
    }
}