using System.Collections.Generic;
using ConquistadorAbsolutoBiblioteca.Essencia.Essencias;

namespace ConquistadorAbsolutoBiblioteca.Raca.Racas
{
    public sealed class Leneha
    {
        private static Leneha _leneha = new Leneha();
        public static IRaca RacaLeneha { get; private set; }

        private Leneha()
        {
            RacaLeneha = Fabrica.CriarRaca();
            RacaLeneha.Titulo = "";
            RacaLeneha.Nome = "Leneha";
            RacaLeneha.Descricao = "";
            RacaLeneha.Historia = "";
            RacaLeneha.PoderConcedido = 9770f;
            RacaLeneha.Raridade = Origem.Grau.Extraordinario;
            RacaLeneha.RacaRival = Allumi.RacaAllumi;

            RacaLeneha.PopularLista(RacaLeneha.Caracteristicas, new string[] { "Corpo flamejante etéreo", "Explosivo", "Provocável" });
            RacaLeneha.PopularLista(RacaLeneha.EssenciasDeRaca, new Essencia.IEssencia[] { Fogo.EssenciaDoFogo });
            RacaLeneha.PopularLista(RacaLeneha.EssenciasIncompativeis, new Essencia.IEssencia[] { Agua.EssenciaDaAgua });
        }
    }
}
