using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    class DeckOfCards
    {
        // create one Random object to share among DeckOfCards objects
        private static Random randomNumbers = new Random();

        private const int NumberOfCards = 52; // Number of cards in a deck
        private Card[] deck = new Card[NumberOfCards];
        private int currentCard = 0; // Index of next Card to be dealt

        //Constructor, fills the deck of cards
        public DeckOfCards()
        {
            string[] faces = { "Ace", "Duece", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
            string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };

            // Populates deck with card objects
            for (var count = 0; count < deck.Length; ++count)
            {
                deck[count]=new Card(faces[count % 13], suits [count / 13]);
            }

        }
        //shuffles deck of cards with one-pass algorithm
        public void Shuffle()
        {
            //after shuffling, dealing should start at deck[0] again
            currentCard = 0; // reinitialize currentcard

            // for each Card, pick another random Card and swap them
            for(var first = 0; first < deck.Length; ++first)
            {
                var second = randomNumbers.Next(NumberOfCards);

                // swap current Card with randomly selected card
                Card temp = deck[first];
                deck[second] = temp;
            }
        }
        //deal one card
        public Card DealOneCard()
        {
            //determin whether Cards remain to be dealt
            if (currentCard < deck.Length)
            {
                return deck[currentCard++];
            }
            else
            {
                return null; // indicate that all cards have been dealt
            }
        }
    }
}
