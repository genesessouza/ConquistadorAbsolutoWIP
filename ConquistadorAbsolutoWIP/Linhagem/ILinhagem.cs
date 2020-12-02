using ConquistadorAbsolutoWIP.Origem;
using ConquistadorAbsolutoWIP.Raca;
using System.Collections.Generic;

namespace ConquistadorAbsolutoWIP.Linhagem
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
