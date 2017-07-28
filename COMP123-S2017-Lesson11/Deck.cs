using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* 
 * Name: Alvin Quijano
 * Date: July 25, 2017
 * Desc: This is the deck class which inherits from the list generic collection
 * This class creates a new List type - Card
 * Ver: 0.6 - Added the deal5 method that creates a new Hand object and deals 5 cards. 
 */

namespace COMP123_S2017_Lesson11
{
    public class Deck : CardLIst
    {
        // PRIVATE INSTANCE VARIABLES 
        private Random _random;

        // PRIVATE PROPERTY
        private Random Random
        {
            get
            {
                return this._random;
            }
        }

        // PUBLIC PROPERTIES 

        // CONSTRUCTOR

        // PRIVATE METHODS 
        /// <summary>
        /// This is the private _initialize method that loads the deck with 52 cards 
        /// This method also initializes other class variables
        /// </summary>
        protected override void _initialize()
        {
            // initialize the random object 
            this._random = new Random();

            // load the list with cards 
            for (int suit = 0; suit <= (int)Suit.Spades; suit++)
            {
                for (int face = 1; face <= (int)Face.King; face++)
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
            outputString += "The Deck contains:\n";
            outputString += "===================================================\n";

            foreach (Card card in this)
            {
                outputString += "The " + card.Face + " of " + card.Suit + "\n";
            }

            return outputString;
        }

        /// <summary>
        /// This method shuffles the deck 
        /// </summary>
        public void Shuffle()
        {
            int firstCard, secondCard;
            Card tempCard;


            for (int i = 0; i < this.Count; i++)
            {
                firstCard = this.Random.Next(0, 52);
                secondCard = this.Random.Next(0, 52);

                tempCard = (Card)this[secondCard].Clone();
                this[secondCard].Face = this[firstCard].Face;
                this[secondCard].Suit = this[firstCard].Suit;
                this[firstCard].Face = tempCard.Face;
                this[firstCard].Suit = tempCard.Suit;
                
            }

        }
        /*
        public Card Deal1()
        {
            Card firstCard = (Card)this[0].Clone();
            this.RemoveAt(0); // Removes the top card 
            return firstCard;
        }*/

        public Hand Deal5()
        {
            Hand fiveCards = new Hand();

            for (int i = 0; i < 5; i++)
            {
                fiveCards.Add(this[i]);
            }

            return fiveCards;
        }

    }
}