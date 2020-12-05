using System.Collections.Generic;
using ConquistadorAbsolutoBiblioteca.Essencia;
using ConquistadorAbsolutoBiblioteca.Essencia.Essencias;
using ConquistadorAbsolutoBiblioteca.Linhagem;
using ConquistadorAbsolutoBiblioteca.Linhagem.Linhagens;
using ConquistadorAbsolutoBiblioteca.Origem;

namespace ConquistadorAbsolutoBiblioteca.Raca.Racas
{
    public sealed class Zohar
    {
        private static readonly Zohar _celestial = new Zohar();
        public static IRaca RacaZohar { get; private set; }

        static Zohar() { }

        private Zohar()
        {
            RacaZohar = Fabrica.CriarRaca();
            RacaZohar.Titulo = "Celestiais";
            RacaZohar.Nome = "Zohar";
            RacaZohar.Raridade = Grau.Extraordinario;
            RacaZohar.PoderConcedido = 5400f;
            RacaZohar.Caracteristicas.Add("Alado");
            RacaZohar.Caracteristicas.Add("Pele de bronze");
            RacaZohar.RacaRival = Nihitus.RacaNihitus;

            RacaZohar.PopularLista(RacaZohar.EssenciasDeRaca, new List<IEssencia> { Luz.EssenciaDaLuz, Terra.EssenciaDaTerra });
            RacaZohar.PopularLista(RacaZohar.EssenciasIncompativeis, new List<IEssencia> { Treva.EssenciaDaTreva });
            RacaZohar.PopularLista(RacaZohar.LinhagensDeRaca, new List<ILinhagem> { Arcanjo.LinhagemDoArcanjo });
            RacaZohar.PopularLista(RacaZohar.LinhagensIncompativeis, new List<ILinhagem> { Diabo.LinhagemDoDiabo });
        }
    }
}
