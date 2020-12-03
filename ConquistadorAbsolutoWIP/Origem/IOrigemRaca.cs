using System.Collections.Generic;

namespace ConquistadorAbsolutoBiblioteca.Origem
{
    /// <summary>
    /// Gênese de todas as linhagens, essências e raças.
    /// Força mãe de onde tudo isso se origina.
    /// </summary>
    public interface IOrigemRaca
    {
        /// <summary>
        /// Nome próprio da raça. Ex: Zohar, Nihirun, Mortus.
        /// </summary>
        string Nome { get; set; }
        /// <summary>
        /// Titulo categorizador da raça. Ex: Raça Celeste, Raça Demoníaca.
        /// </summary>
        string Titulo { get; set; }
        TipoDeOrigem Tipo { get; }
        /// <summary>
        /// Determina a qualidade e capacidade da origem. Ex: fraca, média, etc.
        /// </summary>
        Grau Raridade { get; set; }
        float PoderConcedido { get; set; }

        void MostrarAtributos();
        void PopularLista<T>(List<T> lista, List<T> valores);
    }
}
