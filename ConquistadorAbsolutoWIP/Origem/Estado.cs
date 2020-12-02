namespace ConquistadorAbsolutoWIP.Origem
{
    /// <summary>
    /// Condição da essência.
    /// </summary>
    public enum Estado
    {
        /// <summary>
        /// Gera origem a partir energia propulsora.
        /// Habilidades e capacidades liberadas.
        /// </summary>
        Desperto,
        /// <summary>
        /// Não gera poder de origem ou recebe energia propulsora.
        /// Habilidades e capacidades inativas até re-despertar.
        /// </summary>
        Adormecido,
        /// <summary>
        /// <para> Incapaz de ter sua origem desgranhada da entidade.
        /// Habilidades e capacidades perdidas permanentemente.
        /// <br/>Entidade terá sequelas deixadas em seu núcleo de origem. </para>
        /// </summary>
        Destruido
    }
}
