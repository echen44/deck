// Author: Eric Chen
namespace myApp
{
  public enum Suit
  {
    Hearts,
    Diamonds,
    Clubs,
    Spades
  }

  public class Card
  {
    public Card(Suit suit, int rank)
    {
      Suit = suit;
      Rank = rank;
    }
    
    public Suit Suit { get; }

    public int Rank { get; }

    public override string ToString()
    {
      return Suit.ToString() + Rank.ToString();
    }
  }
}