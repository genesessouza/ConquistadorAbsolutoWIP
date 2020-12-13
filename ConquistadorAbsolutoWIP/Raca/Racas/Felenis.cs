using System.Collections.Generic;
using ConquistadorAbsolutoBiblioteca.Origem;

namespace ConquistadorAbsolutoBiblioteca.Raca.Racas
{
    public sealed class Felenis
    {
        private static readonly Felenis _felenis = new Felenis();
        public static IRaca RacaFelenis { get; private set; }

        static Felenis() { }

        private Felenis()
        {
            RacaFelenis = Fabrica.CriarRaca();
            RacaFelenis.Titulo = "Raça dos Bestiais Felinos";
            RacaFelenis.Nome = "Felenis";
            RacaFelenis.Raridade = Grau.Unico;
            RacaFelenis.PoderConcedido = 7200f;
            RacaFelenis.RacaRival = Klishna.RacaKlishna;

            RacaFelenis.PopularLista
            (
                RacaFelenis.Caracteristicas, new string[] { "Peludo", "Juba", "Força Monstruosa", "Instintos e reflexos anormais" }
            );
        }
    }
}
