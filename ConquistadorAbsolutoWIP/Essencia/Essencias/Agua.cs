using System.Collections.Generic;
using ConquistadorAbsolutoBiblioteca.Origem;

namespace ConquistadorAbsolutoBiblioteca.Essencia.Essencias
{
    public sealed class Agua
    {
        private static readonly Agua _agua = new Agua();
        public static IEssencia EssenciaDaAgua { get; private set; }

        static Agua() { }

        private Agua()
        {
            EssenciaDaAgua = Fabrica.CriarEssencia();
            EssenciaDaAgua.Titulo = "";
            EssenciaDaAgua.Nome = "Essência da Agua";
            EssenciaDaAgua.Raridade = Grau.Raro;
            EssenciaDaAgua.Estado = Estado.Desperto;
            EssenciaDaAgua.Potencializador = EnergiaPropulsora.Serenidade;
            EssenciaDaAgua.PoderExigido = 3780f;
            EssenciaDaAgua.PoderConcedido = 6600f;

            EssenciaDaAgua.PopularLista(EssenciaDaAgua.Propriedades, new string[] { "Limpante", "Molhante", "Curativa", "Maleavel" });

            EssenciaDaAgua.PopularLista
            (
                EssenciaDaAgua.EssenciasIncompativeis,
                new IEssencia[] { Treva.EssenciaDaTreva, Fogo.EssenciaDoFogo, Raio.EssenciaDoRaio }
            );
        }
    }
}