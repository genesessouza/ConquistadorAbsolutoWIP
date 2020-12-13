using System.Collections.Generic;
using ConquistadorAbsolutoBiblioteca.Origem.Receptor.Atributo;

namespace ConquistadorAbsolutoBiblioteca.Origem.Receptor
{
    /// <summary>
    /// Parte da entidade responsável por receber o poder da origem.
    /// </summary>
    public interface IReceptor
    {
        /// <summary>
        /// Nome do receptor.
        /// </summary>
        string Nome { get; set; }
        /// <summary>
        /// Poder de origem atual.
        /// </summary>
        float PoderDeOrigem { get; set; }
        List<IAtributo> Atributos { get; set; }
        Dictionary<IAtributo, List<IAtributo>> SubAtributos { get; set; }
        /// <summary>
        /// Configura e preenche todos os valores.
        /// </summary>
        void InicializarReceptor(float poderDeOrigem);
        /// <summary>
        /// Retorna o valor dos atributos principais de cada fonte de origem.
        /// </summary>
        void MostrarAtributos();
        /// <summary>
        /// Retorna os sub-atributos de cada atributo de todas as fontes de origem
        /// </summary>
        void MostrarSubAtributos();

        void PopularLista<T>(List<T> lista, List<T> valores);
    }
}
