using System;
using System.Collections.Generic;
using System.Text;

namespace ConquistadorAbsolutoBiblioteca
{
    /// <summary>
    /// <br/> Usada para criar e manipular cada atributo da respectiva existência.
    /// </summary>
    public sealed class Atributo
    {
        /// <summary>
        /// Nome do atributo
        /// </summary>
        public string NomeDoAtributo { get; set; }
        /// <summary>
        /// Valor do atributo
        /// </summary>
        public float ValorDoAtributo { get; set; }

        /// <summary>
        /// Construtor do atributo
        /// </summary>
        /// <param name="nomeDoAtributo">Nome do atributo a ser criado</param>
        /// <param name="valorDoAtributo">Valor do atributo a ser criado</param>
        public Atributo(string nomeDoAtributo, float valorDoAtributo)
        {
            this.NomeDoAtributo = nomeDoAtributo;
            this.ValorDoAtributo = valorDoAtributo;
        }
    }
}
