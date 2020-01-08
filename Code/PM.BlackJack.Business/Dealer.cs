using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PM.BlackJack.Business
{
    public class Dealer : BasePlayer
    {
        public IDeck Deck { get; set; } // using this to illustrate can use DI for all

        public Dealer(IDeck deck)
        {
            Deck = deck;
        }

        public void DealCard(BasePlayer player, int numberCards = 1)
        {
            for (var i = 0; i < numberCards; i++)
            {
                player.Hand.Cards.Add(Deck.DrawCard());
            }
        }
    }
}
