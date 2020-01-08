using System;
using System.Collections.Generic;
using System.Text;

namespace PM.BlackJack.Business
{
    public interface IDeck
    {
        List<Card> Cards { get; set; }
        void ShuffleDeck();
        Card DrawCard();
    }
}
