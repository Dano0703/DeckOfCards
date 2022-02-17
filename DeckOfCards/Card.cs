using System;

namespace DeckOfCards
{
    class Card
    {
        private string Suit { get; } // Hearts, Diamonds, Clubs, Spades.
        private string Face { get; } // Cards' face (Ace, Deuce, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King.

        //two parameter constructor initializes card's Face and Suit
        public Card (string face, string suit)
        {
            Face = face; // initializes face of card
            Suit = suit; // initializes suit of card
        }

        //return string representaion of Card
        public override string ToString() => $"{Face} of {Suit}";
        
    }
}
