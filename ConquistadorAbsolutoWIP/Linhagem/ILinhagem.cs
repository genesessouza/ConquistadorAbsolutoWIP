using System.Collections.Generic;
using ConquistadorAbsolutoBiblioteca.Origem;
using ConquistadorAbsolutoBiblioteca.Raca;

namespace ConquistadorAbsolutoBiblioteca.Linhagem
{
    public interface ILinhagem : IOrigemRaca
    {
        Estado Condicao { get; set; }
        float Poder { get; }
        Entidade.IEntidade Portador { get; set; }
        IRaca RacaExigida { get; set; }
        IRaca RacaIncompativel { get; set; }
        List<Essencia.IEssencia> EssenciasHerdadas { get; set; }
        List<Essencia.IEssencia> EssenciasIncompativeis { get; set; }
        List<ILinhagem> LinhagensCompativeis { get; set; }
        List<ILinhagem> LinhagensIncompativeis { get; set; }
    }
}
