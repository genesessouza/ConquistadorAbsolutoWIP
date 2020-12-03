using System.Collections.Generic;
using ConquistadorAbsolutoBiblioteca.Essencia;
using ConquistadorAbsolutoBiblioteca.Essencia.Essencias;
using ConquistadorAbsolutoBiblioteca.Linhagem;
using ConquistadorAbsolutoBiblioteca.Linhagem.Linhagens;
using ConquistadorAbsolutoBiblioteca.Origem;

namespace ConquistadorAbsolutoBiblioteca.Raca
{
    public sealed class Infernal
    {
        private static readonly Infernal infernal = new Infernal();
        public static Infernal ObterRaca { get => infernal; }

        public static IRaca RacaInfernal { get; private set; }

        static Infernal() { }

        private Infernal()
        {
            RacaInfernal = Fabrica.CriarRaca();
            RacaInfernal.Titulo = "Raça Demoníaca";
            RacaInfernal.Nome = "Nihitus";
            RacaInfernal.Raridade = Grau.Raro;
            RacaInfernal.PoderConcedido = 6100f;
            RacaInfernal.Caracteristicas.Add("Alado");
            RacaInfernal.Caracteristicas.Add("Pele acinzentada");

            RacaInfernal.PopularLista(RacaInfernal.EssenciasDeRaca, new List<IEssencia> { Fogo.EssenciaDoFogo });
            RacaInfernal.PopularLista(RacaInfernal.EssenciasIncompativeis, new List<IEssencia> { Luz.EssenciaDaLuz });
            RacaInfernal.PopularLista(RacaInfernal.LinhagensDeRaca, new List<ILinhagem> { Diabo.LinhagemDoDiabo });
            RacaInfernal.PopularLista(RacaInfernal.LinhagensIncompativeis, new List<ILinhagem> { Arcanjo.LinhagemDoArcanjo });
        }
    }
}
