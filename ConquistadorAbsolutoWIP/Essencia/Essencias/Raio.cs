using System.Collections.Generic;
using ConquistadorAbsolutoBiblioteca.Origem;

namespace ConquistadorAbsolutoBiblioteca.Essencia.Essencias
{
    public sealed class Raio
    {
        private static readonly Raio _raio = new Raio();
        public static IEssencia EssenciaDoRaio { get; private set; }

        static Raio() { }

        private Raio()
        {
            EssenciaDoRaio = Fabrica.CriarEssencia();
            EssenciaDoRaio.Titulo = "";
            EssenciaDoRaio.Nome = "Essência do Raio";
            EssenciaDoRaio.Raridade = Grau.Unico;
            EssenciaDoRaio.Estado = Estado.Desperto;
            EssenciaDoRaio.Potencializador = EnergiaPropulsora.Impulsividade;
            EssenciaDoRaio.PoderExigido = 3780f;
            EssenciaDoRaio.PoderConcedido = 6600f;

            EssenciaDoRaio.PopularLista
            (
                EssenciaDoRaio.Propriedades, new string[] { "Eletrizante", "Paralisante", "Aceleradora", "Propagadora", "Cegante" }
            );

            EssenciaDoRaio.PopularLista
            (
                EssenciaDoRaio.EssenciasExigidas, new IEssencia[] { Fogo.EssenciaDoFogo }
            );
            EssenciaDoRaio.PopularLista
            (
                EssenciaDoRaio.EssenciasIncompativeis, new IEssencia[] { Treva.EssenciaDaTreva, Agua.EssenciaDaAgua }
            );
        }
    }
}
