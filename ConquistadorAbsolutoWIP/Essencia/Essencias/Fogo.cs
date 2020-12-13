using System.Collections.Generic;
using ConquistadorAbsolutoBiblioteca.Origem;

namespace ConquistadorAbsolutoBiblioteca.Essencia.Essencias
{
    public sealed class Fogo
    {
        private static readonly Fogo _fogo = new Fogo();
        public static IEssencia EssenciaDoFogo { get; private set; }

        static Fogo() { }

        private Fogo()
        {
            EssenciaDoFogo = Fabrica.CriarEssencia();
            EssenciaDoFogo.Titulo = "";
            EssenciaDoFogo.Nome = "Essência do Fogo";
            EssenciaDoFogo.Raridade = Grau.Raro;
            EssenciaDoFogo.Estado = Estado.Desperto;
            EssenciaDoFogo.Potencializador = EnergiaPropulsora.Explosividade;
            EssenciaDoFogo.PoderConcedido = 87400f;
            EssenciaDoFogo.PoderExigido = 59000f;

            EssenciaDoFogo.PopularLista
            (
                EssenciaDoFogo.Propriedades, new List<string> { "Ardente", "Brilhante", "Explosiva", "Impulsiva", "Amplificadora" }
            );

            EssenciaDoFogo.PopularLista(EssenciaDoFogo.EssenciasExigidas, new List<IEssencia> { Terra.EssenciaDaTerra });

            EssenciaDoFogo.PopularLista
            (
                EssenciaDoFogo.EssenciasIncompativeis,
                new List<IEssencia> { Treva.EssenciaDaTreva, Agua.EssenciaDaAgua }
            );
        }
    }
}
