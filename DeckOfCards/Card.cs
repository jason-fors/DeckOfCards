namespace DeckOfCards
{
    public class Card
    {

        public Suit Suit { get; set; }
        public Rank Rank { get; set; }

        public override string ToString()
        {
            return string.Format("{0} of {1}", Rank, Suit);             // Custom ToString method for displaying a card's rank and value.
        }

    }

    // Using enums here for simplicity. Using default values (index).
    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }

    public enum Rank                                            
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
}
