using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* 
 * Name: Alvin Quijano
 * Date: July 27, 2017
 * Desc: This is the abstract super class CardList
 * It inherits from the built-in List generic collection and consumes the Card class
 * Ver: 0.1 - Created the CardList class
 */

namespace COMP123_S2017_Lesson11
{
    public abstract class CardLIst : List<Card>
    {
        // PRIVATE INSTANCE VARIABLES 

        // PUBLIC PROPERTIES 

        // CONSTRUCTORS 
        public CardLIst()
        {
            this._initialize();
        }

        // PRIVATE METHODS 
        protected abstract void _initialize()
        {

        }
        // PUBLIC METHODS 
    }
}