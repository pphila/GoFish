using System.Collections.Generic;
using GoFish.Models;
using System.Linq;
using System.Text;
using System;


namespace GoFish.Models
{
  // public enum Suit 
  // { 
  //   Clubs, 
  //   Daimonds, 
  //   Hearts, 
  //   Spades, 
  // }

  // public enum Rank
  // {
  //   Ace,
  //   Two,
  //   Three,
  //   Four,
  //   Five,
  //   Six,
  //   Seven,
  //   Eight,
  //   Nine,
  //   Ten,
  //   Jack,
  //   Queen,
  //   King
  // }

  public class Card
  {
    public string Suit { get; set; }
    // public int Rank { get; set; }

    public Card(string suit)
    {
      Suit = suit;
      // Rank = rank;
    }

    // public string Name
    // {
    //   // get { return Rank.ToString(); + " of " + Suit.ToString(); }
    // }

  }
}