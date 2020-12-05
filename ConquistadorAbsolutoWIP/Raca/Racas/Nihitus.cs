using System.Collections.Generic;
using ConquistadorAbsolutoBiblioteca.Essencia;
using ConquistadorAbsolutoBiblioteca.Essencia.Essencias;
using ConquistadorAbsolutoBiblioteca.Origem;

namespace ConquistadorAbsolutoBiblioteca.Raca.Racas
{
    /// <summary>
    /// Raça dos Demônios inferiores.
    /// </summary>
    public sealed class Nihitus
    {
        private static readonly Nihitus _infernal = new Nihitus();
        public static IRaca RacaNihitus { get; private set; }

        static Nihitus() { }

        private Nihitus()
        {
            RacaNihitus = Fabrica.CriarRaca();
            RacaNihitus.Titulo = "Raça dos Demônios";
            RacaNihitus.Nome = "Nihitus";
            RacaNihitus.Descricao = "";
            RacaNihitus.Historia = "";
            RacaNihitus.Raridade = Grau.Raro;
            RacaNihitus.PoderConcedido = 6100f;
            RacaNihitus.RacaRival = Zohar.RacaZohar;

            RacaNihitus.PopularLista
            (
                RacaNihitus.Caracteristicas,
                new List<string> { "Alado", "Pele avermelhada", "Chifres na testa", "Aparência bestial", "Garras afiadas e longas" }
            );

            RacaNihitus.PopularLista(RacaNihitus.EssenciasDeRaca, new List<IEssencia> { Fogo.EssenciaDoFogo });
            RacaNihitus.PopularLista(RacaNihitus.EssenciasIncompativeis, new List<IEssencia> { Luz.EssenciaDaLuz });
        }
    }
}
