using Ucu.Poo.Cards;
namespace Ucu.Poo.Cards
{
    /// <summary>
    /// Representa el contenido de una carta de póker con un formato bonito.
    /// </summary>
    public class PrettyCardContent : ICardContent
    {
        private Card card;
        public PrettyCardContent(Card card)
        {
            this.card = card;
        }
        public string GetTextToPrint()
        {
            string symbol;
            switch (this.card.Suit)
            {
                case Suit.Hearts:
                    symbol = "♥";
                    break;
                case Suit.Diamonds:
                    symbol = "♦";
                    break;
                case Suit.Clubs:
                    symbol = "♣";
                    break;
                default:
                    symbol = "♠";
                    break;
            }
            return $"{this.card.Rank} of {symbol}";
        }
    }
}