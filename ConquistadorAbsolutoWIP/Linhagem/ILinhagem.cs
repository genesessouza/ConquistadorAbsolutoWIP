using System.Collections.Generic;
using ConquistadorAbsolutoBiblioteca.Entidade;
using ConquistadorAbsolutoBiblioteca.Essencia;
using ConquistadorAbsolutoBiblioteca.Origem;
using ConquistadorAbsolutoBiblioteca.Raca;

namespace ConquistadorAbsolutoBiblioteca.Linhagem
{
    /// <summary>
    /// Olha meu patrão. Falar um bagulho sincero pra ti.
    /// <br/> Parece que saporra vai ser meio inútil pq acompanha o raciocínio aí...:
    /// <br/> Raça --> Linhagem == Raça, que tem uma vertente, que é uma linhagem, certo?
    /// <br/> Porém, já há algumas raças que são mais pika, por exemplo, os Nevora, que são os diabos.
    /// <br/> Esses cara são a evolução dos Nihitus (demônios) e são uma raça também.
    /// <br/> Percebe onde saporra vai dar? Parece que isso aqui vai se tornar inútil.
    /// </summary>
    public interface ILinhagem
    {
        string Titulo { get; set; }
        string Nome { get; set; }
        TipoDeOrigem Tipo { get; set; }
        Grau Raridade { get; set; }
        Estado Condicao { get; set; }
        float PoderConcedido { get; set; }
        float Poder { get; }
        Alinhamento AlinhamentoExigido { get; set; }
        IRaca RacaExigida { get; set; }
        IRaca RacaIncompativel { get; set; }
        List<IEssencia> EssenciasHerdadas { get; set; }
        List<IEssencia> EssenciasIncompativeis { get; set; }
        List<ILinhagem> LinhagensCompativeis { get; set; }
        List<ILinhagem> LinhagensIncompativeis { get; set; }
        IEntidade Portador { get; set; }

        void MostrarAtributos();
        void PopularLista<T>(List<T> lista, List<T> valores);
    }
}