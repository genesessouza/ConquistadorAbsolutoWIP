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
        string Nome { get; }
        /// <summary>
        /// Poder de origem atual.
        /// </summary>
        float PoderDeOrigem { get; }
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
    }
}
