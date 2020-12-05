using System.Collections.Generic;
using ConquistadorAbsolutoBiblioteca.Essencia;
using ConquistadorAbsolutoBiblioteca.Essencia.Essencias;
using ConquistadorAbsolutoBiblioteca.Raca.Racas;

namespace ConquistadorAbsolutoBiblioteca.Linhagem.Linhagens
{
    public sealed class Arcanjo
    {
        private static readonly Arcanjo arcanjo = new Arcanjo();
        public static Arcanjo ObterLinhagem { get => arcanjo; }

        public static ILinhagem LinhagemDoArcanjo;

        static Arcanjo() { }

        private Arcanjo()
        {
            LinhagemDoArcanjo = Fabrica.CriarLinhagem();
            LinhagemDoArcanjo.Titulo = "";
            LinhagemDoArcanjo.Nome = "Zalbedon";
            LinhagemDoArcanjo.Raridade = Origem.Grau.Extraordinario;
            LinhagemDoArcanjo.PoderConcedido = 18000f;
            LinhagemDoArcanjo.Condicao = Origem.Estado.Desperto;
            LinhagemDoArcanjo.RacaExigida = Zohar.RacaZohar;
            LinhagemDoArcanjo.RacaIncompativel = Nihitus.RacaNihitus;
            LinhagemDoArcanjo.PopularLista(LinhagemDoArcanjo.EssenciasHerdadas, new List<IEssencia> { Luz.EssenciaDaLuz });
            LinhagemDoArcanjo.PopularLista(LinhagemDoArcanjo.EssenciasIncompativeis, new List<IEssencia> { Treva.EssenciaDaTreva });
            LinhagemDoArcanjo.PopularLista(LinhagemDoArcanjo.LinhagensIncompativeis, new List<ILinhagem> { Diabo.LinhagemDoDiabo });
        }
    }
}
