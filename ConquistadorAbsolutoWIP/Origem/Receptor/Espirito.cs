using System.Collections.Generic;
using ConquistadorAbsolutoBiblioteca.Origem.Receptor.Atributo;

namespace ConquistadorAbsolutoBiblioteca.Origem.Receptor
{
    /// <summary>
    /// <para> Cria atributos e sub-atributos espirituais e distribui o Poder de Origem recebido entre eles.
    /// <br/>Além de mostrar seus valores.</para>
    /// </summary>
    public sealed class Espirito : IReceptor
    {
        public string Nome { get; private set; }
        public float PoderDeOrigem { get; private set; }
        /// <summary>
        /// Atributos principais do espírito.
        /// </summary>
        private string[] AtributosPrincipais => new string[] { "Carisma", "Existencia" };
        /// <summary>
        /// Sub-atributos do carisma.
        /// </summary>
        private string[] SubAtributosDoCarisma => new string[] { "Atracao", "Sociabilidade", "Persuasao" };

        string IReceptor.Nome { get; set; }
        float IReceptor.PoderDeOrigem { get; set; }
        public List<IAtributo> Atributos { get; set; }
        public Dictionary<IAtributo, List<IAtributo>> SubAtributos { get; set; }

        /// <summary>
        /// Sub-atributos da existência espiritual.
        /// </summary>
        private string[] SubAtributosDaExistencia = new string[]
        {
           "Ataque Magico", "Defesa Magica", "Afinidade Magica", "Absorcao Magica", "Producao Magica"
        };

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