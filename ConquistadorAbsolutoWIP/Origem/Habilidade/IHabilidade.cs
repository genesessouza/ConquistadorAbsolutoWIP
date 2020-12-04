namespace ConquistadorAbsolutoBiblioteca.Origem.Habilidade
{
    /// <summary>
    /// Ainda não sei como fazer isso.
    /// O plano é algo tipo assim:
    /// <br/>**Habilidades:**
    /// <br/>*Nome: [Reerguer] Descricao: [Puxa a alma do morto de volta ao corpo] Duracao: [Permanente]*
    /// </summary>
    public interface IHabilidade
    {
        string Nome { get; set; }
        string Descricao { get; set; }
        float Duracao { get; set; }
        /// <summary>
        /// Se a habiliade gerar poder de origem extra, será esse aqui.
        /// </summary>
        float PoderGerado { get; set; }
        Receptor.IReceptor ReceptorAfetado { get; set; }
    }
}
