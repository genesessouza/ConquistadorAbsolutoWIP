using System.Collections.Generic;
using ConquistadorAbsolutoBiblioteca.Origem;

namespace ConquistadorAbsolutoBiblioteca.Essencia.Essencias
{
    public sealed class Terra
    {
        private static readonly Terra _terra = new Terra();
        public static IEssencia EssenciaDaTerra { get; private set; }

        static Terra() { }

        private Terra()
        {
            EssenciaDaTerra = Fabrica.CriarEssencia();
            EssenciaDaTerra.Titulo = "";
            EssenciaDaTerra.Nome = "Essência da Terra";
            EssenciaDaTerra.Raridade = Grau.Raro;
            EssenciaDaTerra.Estado = Estado.Desperto;
            EssenciaDaTerra.Potencializador = EnergiaPropulsora.Coragem;
            EssenciaDaTerra.PoderConcedido = 37000f;
            EssenciaDaTerra.PoderExigido = 19800f;

            EssenciaDaTerra.PopularLista(EssenciaDaTerra.EssenciasExigidas, new IEssencia[] { Agua.EssenciaDaAgua });
            EssenciaDaTerra.PopularLista(EssenciaDaTerra.Propriedades, new string[] { "Endurecedora", "Fortalecedora", "Moldadora" });
            EssenciaDaTerra.PopularLista(EssenciaDaTerra.EssenciasIncompativeis, new IEssencia[] { Treva.EssenciaDaTreva });
        }
    }
}
