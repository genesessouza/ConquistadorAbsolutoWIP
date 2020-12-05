using System.Collections.Generic;
using ConquistadorAbsolutoBiblioteca.Entidade.Origem;
using ConquistadorAbsolutoBiblioteca.Raca;

namespace ConquistadorAbsolutoBiblioteca.Entidade
{
    public interface IEntidade
    {
        string Nome { get; set; }
        INucleo NucleoDeOrigem { get; set; }
        float Poder { get; set; }
        Alinhamento Alinhamento { get; set; }
        IRaca Casta { get; set; }
        List<Essencia.IEssencia> EssenciasPossuidas { get; set; }
        List<Linhagem.ILinhagem> LinhagensHerdadas { get; set; }

        void MostrarEntidade();
    }
}
