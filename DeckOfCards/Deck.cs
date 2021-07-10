using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    public class Deck
    {
        public List<Card> Cards { get; set; }

        public Deck()                                               // Constructor for class
        {

            Cards = new List<Card>();                             

            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Card card = new Card
                    {
                        Rank = (Rank)i,                             // Casting enum
                        Suit = (Suit)j                              // Casting enum
                    };
                    Cards.Add(card);
                }
            }

        }

        // Method for displaying cards in the deck.
        public void seeDeck()
        {
            foreach (Card card in Cards)
            {
                Console.WriteLine(card.ToString());
            };
        }

        // Method for shuffling the deck.
        public void Shuffle()                                      
        {
            List<Card> TempList = new List<Card>();
            Random random = new Random();                           // Creating random object so we can use random methods


            while (Cards.Count > 0)                                 // Iterates through deck until it is empty
            {
                int randomIndex = random.Next(0, Cards.Count);      // Choose a random index from 0 to the number of cards in the deck.
                TempList.Add(Cards[randomIndex]);                   // Select the card at that index from the TempList and add it to the new deck
                Cards.RemoveAt(randomIndex);                        // Remove the selected card from the deck
            }

            Cards = TempList;                                       // Makes re-ordered list the Cards attribute in deck object. Now it is a shuffled deck.

        }


        // Method for dealing a card off of the deck.
        public Card deal_one_card()                                 // Takes a deck object and number of shuffles as parameters
        {

            if (Cards.Count > 0)
            {
                Card dealtCard = Cards[0];
                Console.WriteLine(Cards[0].ToString());             // Displays dealt card to user
                Cards.RemoveAt(0);                                  // Remove the selected card from the deck
                return dealtCard;
            }

            else
            {
                Console.WriteLine("There are no cards left in the deck.");
                return null;                                        // In case this is not dealt with at the function call.
            }

        }
    }
}



