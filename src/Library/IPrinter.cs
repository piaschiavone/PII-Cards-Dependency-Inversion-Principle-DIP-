//------------------------------------------------------------------------------
// <copyright file="IPrinter.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

namespace Ucu.Poo.Cards
{
    /// <summary>
    /// Representa una impresora de cartas.
    /// </summary>
    public interface IPrinter
    {
        /// <summary>
        /// Imprime una carta.
        /// </summary>
        /// <param name="card">La carta a imprimir.</param>
        void PrintCard(Card card);
    }
}
