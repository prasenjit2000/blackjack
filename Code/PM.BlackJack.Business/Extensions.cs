using System;
using System.Collections.Generic;
using System.Text;

namespace PM.BlackJack.Business
{
    public static class Extensions
    {
        public static int GetCardValue(this CardFaceValue cardValue) =>
            cardValue switch
            {
                var x when
                    x == CardFaceValue.Jack ||
                    x == CardFaceValue.Queen ||
                    x == CardFaceValue.King ||
                    x == CardFaceValue.Ace => 10,
                _ => (int)cardValue
            };
    }
}
