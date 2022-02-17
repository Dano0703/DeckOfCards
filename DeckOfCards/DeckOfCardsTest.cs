using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    class DeckOfCardsTest
    {
        // Exacute app
        static void Main()
        {
            var myDeckOfCards = new DeckOfCards();
            myDeckOfCards.Shuffle(); // place Cards in random order
            for(var i = 0; i< 52; i++)
            {
                Console.Write($"{myDeckOfCards.DealOneCard(),-19 }");
                if ((i + 1) % 4 == 0)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
