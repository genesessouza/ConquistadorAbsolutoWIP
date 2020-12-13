using System.Collections.Generic;
using ConquistadorAbsolutoBiblioteca.Origem.Receptor.Atributo;

namespace ConquistadorAbsolutoBiblioteca.Origem.Receptor
{
    /// <summary>
    /// <para>
    /// Cria atributos e sub-atributos mentais e distribui o Poder de Origem recebido entre eles, 
    /// <br/>além de mostrar seus valores.
    /// </para>
    /// </summary>
    public sealed class Mente
    {
        public string Nome { get; private set; }
        public float PoderDeOrigem { get; private set; }
        public List<IAtributo> Atributos { get; set; }
        public Dictionary<IAtributo, List<IAtributo>> SubAtributos { get; set; }

        /// <summary>
        /// Atributos principais da mente.
        /// </summary>
        private string[] AtributosPrincipais => new string[] { "Inteligência", "Sabedoria" };
        /// <summary>
        /// Sub-atributos principais da inteligência.
        /// </summary>
        private string[] SubAtributosDaInteligencia => new string[] { "Raciocínio", "Criatividade", "Aprendizado" };
        /// <summary>
        /// Sub-atributos principais da sabedoria.
        /// </summary>
        private string[] SubAtributosDaSabedoria => new string[] { "Intuição" };

        public void InicializarReceptor(float poderDeOrigem)
        {
            throw new System.NotImplementedException();
        }

        public void MostrarAtributos()
        {
            throw new System.NotImplementedException();
        }

        public void MostrarSubAtributos()
        {
            throw new System.NotImplementedException();
        }

        public void PopularLista<T>(List<T> lista, T[] valores)
        {
            throw new System.NotImplementedException();
        }
    }
}