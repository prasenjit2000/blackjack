using Microsoft.VisualStudio.TestTools.UnitTesting;
using PM.BlackJack.Business;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PM.BlackJack.Business.Tests
{
    [TestClass()]
    public class DeckTests
    {
        IDeck _deck;

        public DeckTests()
        {
            _deck = new Deck(); //can implement DI
        }

        [TestMethod()]
        public void DeckTest()
        {
            Assert.IsTrue(_deck.Cards.Count > 0);
        }

        [TestMethod()]
        public void ShuffleDeckTest()
        {
            var current = new List<Card>(_deck.Cards); //clone list
            _deck.ShuffleDeck();

            Assert.AreNotEqual(current, _deck.Cards);
        }

        [TestMethod()]
        public void DrawCardTest()
        {
            var deckCount = _deck.Cards.Count;
            _deck.DrawCard();

            Assert.IsTrue(_deck.Cards.Count < deckCount);
        }
    }
}