using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using GoFish.Models;

namespace Gofish.Tests
{
  [TestClass]
  public class CardTests
  {

    [TestMethod]
    public void CardConstructor_CreatesNewInstanceOfCard_Card()
    {
      Card newCard = new Card("test card"); 
      Assert.AreEqual(typeof(Card), newCard.GetType());
    }
  }
}