using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using GoFish.Models;

namespace GoFish.Tests
{
  [TestClass]
  public class DeckTests
  {
    
    [TestMethod]
    public void DeckConstructor_CreatesInstanceOfDeck_Deck()
    {
      Deck newDeck = new Deck("test");
      Assert.AreEqual(typeof(Deck), newDeck.GetType());
    }
    
  }
}