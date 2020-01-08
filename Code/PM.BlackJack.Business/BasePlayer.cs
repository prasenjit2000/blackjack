using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PM.BlackJack.Business
{
    public class BasePlayer 
    {
        public Hand Hand { get; set; } = new Hand();

        public decimal HandValue => Hand.Cards.Sum(x => x.FaceValue.GetCardValue());

    }
}
