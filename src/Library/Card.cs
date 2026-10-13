//------------------------------------------------------------------------------
// <copyright file="Card.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

namespace Ucu.Poo.Cards
{
    /// <summary>
    /// Representa un naipe de póker.
    /// </summary>
    public class Card
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Card"/>.
        /// </summary>
        /// <param name="rank">El valor del naipe.</param>
        /// <param name="suit">El palo del naipe.</param>
        public Card(Rank rank, Suit suit)
        {
            this.Rank = rank;
            this.Suit = suit;
        }

        /// <summary>
        /// Obtiene el valor del naipe.
        /// </summary>
        public Rank Rank { get; private set; }

        /// <summary>
        /// Obtiene el palo del naipe.
        /// </summary>
        public Suit Suit { get; private set; }

        /// <summary>
        /// Obtiene el texto para imprimir el naipe.
        /// </summary>
        /// <returns>El texto del naipe.</returns>
        public string GetTextToPrint()
        {
            return $"{this.Rank} of {this.Suit}";
        }
    }
}
