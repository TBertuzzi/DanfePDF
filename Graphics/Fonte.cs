﻿using pcf = org.pdfclown.documents.contents.fonts;
using System;

namespace DanfePDF.Graphics
{
    /// <summary>
    /// Define uma fonte do PDF Clown e um tamanho. 
    /// </summary>
    internal class Fonte
    {
        private float _Tamanho;

        /// <summary>
        /// Fonte do PDF Clown.
        /// </summary>
        public pcf.Font FonteInterna { get; private set; }

        public Fonte(pcf.Font font, float tamanho)
        {
            FonteInterna = font ?? throw new ArgumentNullException(nameof(font));
            Tamanho = tamanho;
        }

        /// <summary>
        /// Tamanho da fonte.
        /// </summary>
        public float Tamanho
        {
            get => _Tamanho;
            set
            {
                if (value <= 0) throw new InvalidOperationException("O tamanho deve ser maior que zero.");
                _Tamanho = value;
            }
        }

        /// <summary>
        /// Mede a largura ocupada por uma string.
        /// </summary>
        /// <param name="str">String</param>
        /// <returns>Largura em mm.</returns>
        public float MedirLarguraTexto(String str)
        {
            if (String.IsNullOrEmpty(str)) return 0;
            return (float)FonteInterna.GetWidth(str, Tamanho).ToMm();
        }

        /// <summary>
        /// Mese a largura ocupada por um Char.
        /// </summary>
        /// <param name="c">Char</param>
        /// <returns>Largura em mm.</returns>
        public float MedirLarguraChar(char c) => (float)FonteInterna.GetWidth(c, Tamanho).ToMm();
        
        /// <summary>
        /// Medida da altura da linha.
        /// </summary>
        public float AlturaLinha => (float)FonteInterna.GetLineHeight(Tamanho).ToMm();

        public Fonte Clonar() => new Fonte(FonteInterna, Tamanho);

    }
}
