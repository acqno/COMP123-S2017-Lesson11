using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* 
 * Name: Alvin Quijano
 * Date: July 25, 2017
 * Desc: This is the Card class to be used in the card shuffling and dealing simulation
 * Ver: 0.2 - Added the cloneable interface
 */

namespace COMP123_S2017_Lesson11
{
    public class Card : ICloneable
    {
        // PRIVATE INSTANCE VARIABLES
        private Face _face;
        private Suit _suit;

        // PUBLIC PROPERTIES 
        public Face Face
        {
            get
            {
                return this._face;
            }
            set
            {
                this._face = value;
            }
        }

        public Suit Suit
        {
            get
            {
                return this._suit;
            }
            set
            {
                this._suit = value;
            }
        }

        // CONSTRUCTORS
        /// <summary>
        /// This is the main constructor for the card class
        /// It takes two parameters - face (Face) - suit (Suit)
        /// </summary>
        /// <param name="face"></param>
        /// <param name="suit"></param>
        public Card(Face face, Suit suit)
        {
            this.Face = face;
            this.Suit = suit;
        }



        // PRIVATE METHODS 

        // PUBLIC METHODS 
        /// <summary>
        /// Returns a copy of the current card 
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return new Card(this.Face, this.Suit);
        }
    }
}