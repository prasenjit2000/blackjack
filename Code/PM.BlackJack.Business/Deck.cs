using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PM.BlackJack.Business
{
    public class Deck : IDeck
    {
        public List<Card> Cards { get; set; } = new List<Card>();

        public Deck()
        {
            LoadCards();
            ShuffleDeck();
        }

        public void ShuffleDeck()
        {
            var r = new Random();
            Cards = Cards.OrderBy(x => r.Next()).ToList();
        }

        public Card DrawCard()
        {
            var drawn = Cards[Cards.Count - 1];
            Cards.Remove(drawn);
            return drawn;
        }

        private void LoadCards()
        {
            foreach (var suit in Enum.GetValues(typeof(CardSuit)).Cast<CardSuit>())
            {
                foreach (var faceValue in Enum.GetValues(typeof(CardFaceValue)).Cast<CardFaceValue>())
                {
                    Cards.Add(new Card { FaceValue = faceValue, Suit = suit });
                }
            }
        }

    }
}
