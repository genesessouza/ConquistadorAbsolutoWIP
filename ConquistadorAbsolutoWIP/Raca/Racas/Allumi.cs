using System.Collections.Generic;
using ConquistadorAbsolutoBiblioteca.Origem;

namespace ConquistadorAbsolutoBiblioteca.Raca.Racas
{
    public sealed class Allumi
    {
        private static readonly Allumi _allumi = new Allumi();
        public static IRaca RacaAllumi { get; private set; }

        static Allumi() { }

        private Allumi()
        {
            RacaAllumi = Fabrica.CriarRaca();
            RacaAllumi.Titulo = "Habitantes das Águas";
            RacaAllumi.Nome = "Allumi";
            RacaAllumi.Raridade = Grau.Unico;
            RacaAllumi.PoderConcedido = 5390f;
            RacaAllumi.RacaRival = Leneha.RacaLeneha;

            RacaAllumi.PopularLista
            (
                RacaAllumi.Caracteristicas, new string[] { "Peludo", "Juba", "Força Monstruosa", "Instintos e reflexos anormais" }
            );
        }
    }
}
