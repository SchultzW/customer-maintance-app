using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardClassLib
{
    public class Card

    {
        private string cardValue;
        private string suit;

        public Card() { }

        public Card(string suit1, string cardValue1)
        {
            cardValue = cardValue1;
            suit = suit1;
        }
        public string Suit
        {
            get
            {
                return suit;
            }
            set
            {
                suit = value;
            }
        }
        public string CardValue
        {
            get
            {
                return cardValue;
            }
            set
            {
                cardValue = value;
            }
        }
        public string GetDisplayText(string sep)
        {
            return cardValue + sep + "of" + sep + suit;
        }
        public bool IsAce(string cardValue)
        {
            if (cardValue == "Ace")
                return true;
            else
                return false;
        }


        public static bool IsSpade(string cardSuit)
        {
            if (cardSuit == "Spade")
                return true;
            else
                return false;
        }
        public static bool IsFaceCard(string cardValue)
        {
            if (cardValue == "King" || cardValue == "Queen" || cardValue == "Jack")
                return true;
            else
                return false;

        }
        public static bool SameSuit(string card1Suit,string card2Suit)
        {
            if (card1Suit == card2Suit)
                return true;
            else
                return false;
        }
        public static bool SameValue(string card1Value, string card2Value)
        {
            if (card1Value == card2Value)
                return true;
            else
                return false;
        }
    }
}
