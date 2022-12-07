using System.Collections.Generic;
using GoFish.Models;
using System.Linq;
using System.Text;
using System;

namespace GoFish.Models
{
  public class Decks
  {
    private Card[] cards;
    private static Random random = new Random();

    public Deck()
    {
      Array suits = Enum.GetValues(typeof(Suit));
      Array suits = Enum.GetValues(typeof(Rank));

      int size = suits.Length * ranks.Length;
      cards = new Card[size];

      int i = 0;
      foreach (Suit suit in suits)
      {
        Card card = new Card(suit, rank);
        cards[i++] = card;
      }
    }
    
    public int Size()
    {
      return cards.Length;
    }

    public void Shuffle()
    {
      if (Size() == 0) return;
      for (int i = 0; i < Size(); i++)
      {
        int j = random.Next(i, Size());

        Card c = cards[i];
        cards[i] = cards[j];
        cards[j] = c;
      }
    }
    
    public Card DealCard()
    {
      if(Size() == 0) return null;

      Card card = cards[Size() - 1];
      Array.Resize(ref cards, Size() - 1);

      return card;
    }
  }
}