using System.Collections.Generic;
using ConquistadorAbsolutoBiblioteca.Origem;

namespace ConquistadorAbsolutoBiblioteca.Raca.Racas
{
    public sealed class Gurokus
    {
        private static readonly Gurokus _gurokus = new Gurokus();
        public static IRaca RacaGurokus { get; private set; }

        static Gurokus() { }

        private Gurokus()
        {
            RacaGurokus = Fabrica.CriarRaca();
            RacaGurokus.Titulo = "Herdeiros da Terra";
            RacaGurokus.Nome = "Gurokus";
            RacaGurokus.Raridade = Grau.Raro;
            RacaGurokus.PoderConcedido = 9880f;

            RacaGurokus.PopularLista
            (
                RacaGurokus.Caracteristicas, new string[] { "Cascudo", "Seco", "Duro", "Lento e pesado", "Força Devastadora" }
            );
        }
    }
}
