using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PM.BlackJack.Business;
using Action = PM.BlackJack.Business.Action;

namespace PM.BlackJack.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BlackJackController : ControllerBase
    {
        private Game _game;
        public BlackJackController()
        {
            _game = new Game(new Player { Name = "Player Name" });
        }

        [HttpGet]
        public string Play(int action)
        {
            _game.Play((Action)action);
            if (_game.Player.HandValue > 21)
                return "Play Bust. Game Over";

            if (_game.Dealer.HandValue >= 17)
            {
                if (_game.Player.HandValue > _game.Dealer.HandValue)
                    return "Player wins";
                else
                    return "Dealer wins";
            }
            else
                return ("Player keep playing");

        }
    }
}