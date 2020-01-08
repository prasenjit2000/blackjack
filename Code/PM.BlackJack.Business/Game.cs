using System;
using System.Collections.Generic;
using System.Text;

namespace PM.BlackJack.Business
{
    public class Game
    {
        public Dealer Dealer { get; set; }
        public Player Player { get; set; }

        public Game(Player player)
        {
            Dealer = new Dealer(new Deck()); // Can use DI to inject instance of deck
            Player = player;
            StartGame();
        }

        public void Play(Action action)
        {
            if (action == Action.Hit)
                Dealer.DealCard(Player);
            else if (action == Action.Stick)
                Dealer.DealCard(Dealer);
        }


        private void StartGame()
        {
            Dealer.DealCard(Player, 2);
            Dealer.DealCard(Dealer, 2);
        }


    }
}
