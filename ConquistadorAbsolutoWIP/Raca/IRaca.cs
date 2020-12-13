using System.Collections.Generic;
using ConquistadorAbsolutoBiblioteca.Origem;

namespace ConquistadorAbsolutoBiblioteca.Raca
{
    public interface IRaca
    {
        /// <summary>
        /// Nome próprio da raça. Ex: Zohar, Nihirun, Mortus.
        /// </summary>
        string Nome { get; set; }
        /// <summary>
        /// Titulo categorizador da raça. Ex: Raça Celeste, Raça Demoníaca.
        /// </summary>
        string Titulo { get; set; }
        /// <summary>
        /// Detalhes da raça.
        /// </summary>
        string Descricao { get; set; }
        /// <summary>
        /// Passado, origem da raça.
        /// </summary>
        string Historia { get; set; }
        /// <summary>
        /// Inimigos jurados; destinados a se odiarem da mesma forma que anjos odeiam demônios.
        /// </summary>
        IRaca RacaRival { get; set; }
        TipoDeOrigem Tipo { get; }
        /// <summary>
        /// Determina a qualidade e capacidade da origem. Ex: fraca, média, etc.
        /// </summary>
        Grau Raridade { get; set; }
        float PoderConcedido { get; set; }
        List<string> Caracteristicas { get; set; }
        List<Essencia.IEssencia> EssenciasDeRaca { get; set; }
        List<Essencia.IEssencia> EssenciasIncompativeis { get; set; }
        List<Linhagem.ILinhagem> LinhagensDeRaca { get; set; }
        List<Linhagem.ILinhagem> LinhagensIncompativeis { get; set; }


        void MostrarAtributos();
        void PopularLista<T>(List<T> lista, T[] valores);
    }
}
