using ConquistadorAbsolutoWIP.Raca;
using System.Collections.Generic;

namespace ConquistadorAbsolutoWIP.Entidade
{
    public interface IEntidade
    {
        string Nome { get; set; }
        float Poder { get; set; }
        Entidade.Alinhamento Alinhamento { get; set; }
        IRaca Casta { get; set; }
        List<Essencia.IEssencia> EssenciasPossuidas { get; set; }
        List<Linhagem.ILinhagem> LinhagensHerdadas { get; set; }

        void MostrarEntidade();
    }
}
