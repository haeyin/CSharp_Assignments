using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twentyone
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime yearofBirth = new DateTime(1991, 4, 18, 8, 32, 45);
            //DateTime yearOfGraduation = new DateTime(2015, 5, 23, 11, 30, 0);

            //TimeSpan ageAtGraduation = yearOfGraduation - yearofBirth;
            //ageAtGraduation.

            //string text = "here is some text.";
            //File.WriteAllText(@"C:\\Users\\seatt\\Desktop\\C#_Projects\\log.txt", text);



            //Card card = new Card() { Face = "King", Suit = "Spades" }; //is easy way to create objects
            //Game game = new TwentyOneGame(); // polymorphism example

            //Player<Card> player = new Player<Card>();
            //player.Hand = new List<Card>();


            Deck deck = new Deck();

            //int count = deck.Cards.Count(x => x.Face == Face.Ace);
            //List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList();


            deck.Shuffle(3);
 
            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }
        //public enum DaysOfTheWeek
        //{
        //    Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
        //}
    }
}
