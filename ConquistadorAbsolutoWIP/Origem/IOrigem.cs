using System.Collections.Generic;
using ConquistadorAbsolutoBiblioteca.Essencia;

namespace ConquistadorAbsolutoBiblioteca.Origem
{
    /// <summary>
    /// Gênese de todas as linhagens, essências e raças.
    /// Força mãe de onde tudo isso se origina.
    /// </summary>
    public interface IOrigem
    {
        /// <summary>
        /// Titulo categorizador da origem. Ex: Essência do Vento, etc.
        /// </summary>
        string Titulo { get; set; }
        /// <summary>
        /// Nome próprio da origem. Ex: Neftera, Oglodun, etc.
        /// </summary>
        string Nome { get; set; }
        /// <summary>
        /// Marca o grupo ao qual pertence a origem. Ex: Essência, raça, etc.
        /// </summary>
        TipoDeOrigem Tipo { get; }
        /// <summary>
        /// Determina a qualidade e capacidade da origem. Ex: fraca, média, etc.
        /// </summary>
        Grau Raridade { get; set; }
        float PoderConcedido { get; set; }
        float Poder { get; }
        Entidade.IEntidade Portador { get; set; }
        Entidade.Alinhamento AlinhamentoExigido { get; set; }
        float PoderExigido { get; set; }
        Raca.IRaca RacaExigida { get; set; }
        Raca.IRaca RacaIncompativel { get; set; }
        List<IEssencia> EssenciasExigidas { get; set; }
        List<IEssencia> EssenciasIncompativeis { get; set; }
        List<Linhagem.ILinhagem> LinhagensExigidas { get; set; }
        List<Linhagem.ILinhagem> LinhagensIncompativeis { get; set; }

        void MostrarAtributos();
        void PopularLista<T>(List<T> lista, List<T> valores);
    }
}
