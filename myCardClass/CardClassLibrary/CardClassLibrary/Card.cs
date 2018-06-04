using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardClassLibrary;

namespace CardClassLibrary
{
    public class Card
    {
        private string suit;
        private string cardValue;

        public Card() { }

        public Card(string suit,string cardValue)
        {
            this.Suit = suit;
            this.CardValue = cardValue;
        }
        public string Suit
        {
            //get
            //{
            //    return suit;

            //}
            //set
            //{
            //    suit = value;
            //}
            get;set;

        }

        public string CardValue
        {
            //get
            //{
            //    return cardValue;
            //}
            //set
            //{
            //    cardValue = value;
            //}
            get;set;
        }
        
        public string GetDisplayText(string sep)
        {
            return cardValue+sep+"of"+sep + suit;
        }
        public string ToString()
        {
            return GetDisplayText("\t");
        }
        
        
        public bool IsAce(string value)
        {
            if (value == "Ace")
                return true;
            else
                return false;
        }
        public bool IsSpade(string value)
        {
            if (value == "spade")
                return true;
            else
                return false;
              
        }
        public bool IsClub(string value)
        {
            if (value == "club")
                return true;
            else
                return false;
        }
        public bool IsDiamond(string value)
        {
            if (value == "diamond")
                return true;
            else
                return false;
        }
        

    }
}
