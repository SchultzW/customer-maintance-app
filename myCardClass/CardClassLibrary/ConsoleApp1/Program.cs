using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardClassLibrary;


namespace card_console_app
{
    class Program
    {
        static void Main(string[] args)
        {
            TestCardConstructors();
            TestCardSetter();
            TestCardGetter();
            TestIsDiamond();
            TestIsSpade();
            TestIsAce();
        }
        
        static void TestCardConstructors()
        {
            Card c = new Card();
            Card c1 = new Card("club", "five");
            Console.WriteLine("testing both constructors");
            Console.WriteLine("deafult constructor, expecitng deafult values." + c.GetDisplayText(""));
            Console.WriteLine("overload constructor, expecting 'five of clubs'" + c1.GetDisplayText(""));
            Console.WriteLine("");
        }
        static void TestCardSetter()
        {
            Card c1 = new Card("club", "five");
            Console.WriteLine("testing card setter, expecting five and clubs");
            Console.WriteLine(c1.Suit);
            Console.WriteLine(c1.CardValue);


        }
        
        static void TestCardGetter()
        {
            Card c1 = new Card("club", "five");
            Console.WriteLine("testing getters");
            Console.WriteLine("club    :" + c1.Suit);
            Console.WriteLine("five:  " + c1.CardValue);
        }
        
        static void TestIsDiamond()
        {
            Card c = new Card("diamond", "seven");
            Card c1 = new Card("spade", "ace");
            Console.WriteLine("testing isdiamond");
            Console.WriteLine("expecting true for seven of diamond:");
            Console.WriteLine(c.Suit + "/t" + c.CardValue + "/t" + c.IsDiamond(c.Suit));
            Console.WriteLine("expecting false for ace of spades");
            Console.WriteLine(c1.Suit +"/t"+ c1.CardValue + "/t" + c.IsDiamond(c.Suit));

        }
        static void TestIsSpade()
        {
            Card c = new Card("diamond", "seven");
            Card c1 = new Card("spade", "ace");
            Console.WriteLine("testing isdiamond");
            Console.WriteLine("expecting false for seven of diamond:");
            Console.WriteLine(c.Suit + "/t" + c.CardValue + "/t" + c.IsSpade(c.Suit));
            Console.WriteLine("expecting true for ace of spades");
            Console.WriteLine(c1.Suit + "/t" + c1.CardValue + "/t" + c.IsSpade(c.Suit));
        }
        static void TestIsAce()
        {
            Card c = new Card("diamond", "seven");
            Card c1 = new Card("spade", "ace");
            Console.WriteLine("testing isdiamond");
            Console.WriteLine("expecting false for seven of diamond:");
            Console.WriteLine(c.Suit + "/t" + c.CardValue + "/t" + c.IsAce(c.CardValue));
            Console.WriteLine("expecting true for ace of spades");
            Console.WriteLine(c1.Suit + "/t" + c1.CardValue + "/t" + c.IsAce(c.CardValue));
        }
        

    }
}
