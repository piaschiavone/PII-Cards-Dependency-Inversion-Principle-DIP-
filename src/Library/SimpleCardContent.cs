namespace Ucu.Poo.Cards
{
    /// <summary>
    /// Representa el contenido de una carta de póker con un formato simple.
    /// </summary>
    public class SimpleCardContent : ICardContent
    {
        private Card card;
        public SimpleCardContent(Card card)
        {
            this.card = card;
        }
        public string GetTextToPrint()
        {
            return $"{this.card.Rank} of {this.card.Suit}";
        }
    }
}