using System.Collections.Generic;
using GoFish.Models;
using System;


namespace GoFish.Models
{
  public enum Suit 
  { 
    Clubs, 
    Daimonds, 
    Hearts, 
    Spades, 
  }

  public enum Rank
  {
    Ace,
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
    King
  }

  public class Card
  {
    public Suit Suit { get; set; }
    public Rank Rank { get; set; }

    public Card(Suit suit, Rank rank)
    {
      Suit = suit;
      Rank = rank;
    }

    public string Name
    {
      get { return Rank.ToS}
    }
  }
}