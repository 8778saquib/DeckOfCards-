using System;

namespace ObjectOrientedPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            DeckOfCards deckOfCards = new DeckOfCards();
            deckOfCards.Shuffle();
            deckOfCards.Display();
        }
    }
}
