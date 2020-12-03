using System.Collections.Generic;

namespace ConquistadorAbsolutoBiblioteca.Raca
{
    public interface IRaca : Origem.IOrigemRaca
    {
        List<string> Caracteristicas { get; set; }
        List<Essencia.IEssencia> EssenciasDeRaca { get; set; }
        List<Essencia.IEssencia> EssenciasIncompativeis { get; set; }
        List<Linhagem.ILinhagem> LinhagensDeRaca { get; set; }
        List<Linhagem.ILinhagem> LinhagensIncompativeis { get; set; }
    }
}
