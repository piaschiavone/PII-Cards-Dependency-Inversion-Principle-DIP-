//------------------------------------------------------------------------------
// <copyright file="FilePrinter.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using System;
using System.IO;

namespace Ucu.Poo.Cards
{
    /// <summary>
    /// Imprime cartas en un archivo.
    /// </summary>
    public class FilePrinter : IPrinter
    {
        /// <summary>
        /// Imprime una carta en el archivo Card.txt.
        /// </summary>
        /// <param name="card">La carta a imprimir.</param>
        public void PrintCard(Card card)
        {
            ArgumentNullException.ThrowIfNull(card);
            File.WriteAllText("Card.txt", card.GetTextToPrint());
        }
    }
}
