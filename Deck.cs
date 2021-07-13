// Author: Eric Chen
using System;
using System.Collections.Generic;

namespace myApp
{
  public class Deck
  {
    LinkedList<Card> Cards;

    public Deck()
    {
      Cards = new LinkedList<Card>();
      foreach (Suit s in Enum.GetValues(typeof(Suit)))
      {
        for (int i = 1; i < 14; i++)
        {
          Cards.AddLast(new Card(s, i));
        }
      }
    }

    Card remove_top_card()
    {
      Card top_card = Cards.First.Value;
      Cards.RemoveFirst();
      return top_card;
    }

    public Card deal_one_card()
    {
      if(Cards.Count == 0)
      {
        return null;
      }
      return remove_top_card();
    }

    public void shuffle()
    {
      Random r = new Random();
      int card_count = Cards.Count;

      // Init list shuffle pile to all null
      List<Card> shuffle_pile = new List<Card>(card_count);
      for (int i  = 0; i < card_count; i++)
      {
        shuffle_pile.Add(null);
      }

      // Pick a random null index
      // Put the top card in that null index
      // Repeat for all cards
      int next_index;
      while(Cards.Count != 0)
      {
        do
        {
          next_index = r.Next(shuffle_pile.Capacity);
        } while(shuffle_pile[next_index] is not null);
        shuffle_pile[next_index] = remove_top_card();
      }

      // Move the now shuffled cards from shuffle pile to deck
      foreach(Card card in shuffle_pile)
      {
        Cards.AddLast(card);
      }
    }

    public override string ToString()
    {
      return string.Join<Card>(", ", Cards);
    }
  }
}