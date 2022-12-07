using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using GoFish.Models;

namespace GoFish.Tests
{
  [TestClass]
  public class DeckTests
  {
    
    [DataTestMethod]
    public void DeckConstructor_CreatesInstanceOfDeck_Deck()
    {
      Decks newDeck = new Decks();
      ColllectionAssert.AreEqual(typeof(Deck), newDeck.GetType());
    }
    
  }
}