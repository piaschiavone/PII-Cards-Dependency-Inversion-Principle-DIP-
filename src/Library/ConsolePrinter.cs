//------------------------------------------------------------------------------
// <copyright file="ConsolePrinter.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using System;

namespace Ucu.Poo.Cards
{
    /// <summary>
    /// Imprime cartas en la consola.
    /// </summary>
    public class ConsolePrinter : IPrinter
    {
        /// <summary>
        /// Imprime una carta en la consola.
        /// </summary>
        /// <param name="card">La carta a imprimir.</param>
        public void PrintCard(Card card)
        {
            ArgumentNullException.ThrowIfNull(card);
            Console.WriteLine(card.GetTextToPrint());
        }
    }
}
