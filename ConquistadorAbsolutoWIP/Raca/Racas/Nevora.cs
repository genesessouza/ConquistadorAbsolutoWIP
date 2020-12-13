using System.Collections.Generic;
using ConquistadorAbsolutoBiblioteca.Essencia;
using ConquistadorAbsolutoBiblioteca.Essencia.Essencias;
using ConquistadorAbsolutoBiblioteca.Linhagem;
using ConquistadorAbsolutoBiblioteca.Linhagem.Linhagens;
using ConquistadorAbsolutoBiblioteca.Origem;

namespace ConquistadorAbsolutoBiblioteca.Raca.Racas
{
    public sealed class Nevora
    {
        private static readonly Nevora _nevora = new Nevora();
        public static IRaca RacaNevora { get; private set; }

        static Nevora() { }

        private Nevora()
        {
            RacaNevora = Fabrica.CriarRaca();
            RacaNevora.Titulo = "Filhos das Trevas";
            RacaNevora.Nome = "Nevora";
            RacaNevora.Descricao = "";
            RacaNevora.Historia = "";
            RacaNevora.Raridade = Grau.Unico;
            RacaNevora.PoderConcedido = 17600f;
            RacaNevora.RacaRival = Zohar.RacaZohar;

            RacaNevora.PopularLista
            (
                RacaNevora.Caracteristicas,
                new string[] { "Alado", "Pele acinzentada", "Olhos negros", "Lábios e unhas arroxeados", "auréola negra sobre a cabeça" }
            );

            RacaNevora.PopularLista(RacaNevora.EssenciasDeRaca, new IEssencia[] { Treva.EssenciaDaTreva });
            RacaNevora.PopularLista(RacaNevora.EssenciasIncompativeis, new IEssencia[] { Luz.EssenciaDaLuz });
            RacaNevora.PopularLista(RacaNevora.LinhagensDeRaca, new ILinhagem[] { Diabo.LinhagemDoDiabo });
            RacaNevora.PopularLista(RacaNevora.LinhagensIncompativeis, new ILinhagem[] { Arcanjo.LinhagemDoArcanjo });
        }
    }
}
