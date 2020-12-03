using System.Collections.Generic;
using ConquistadorAbsolutoBiblioteca.Essencia;
using ConquistadorAbsolutoBiblioteca.Essencia.Essencias;
using ConquistadorAbsolutoBiblioteca.Linhagem;
using ConquistadorAbsolutoBiblioteca.Linhagem.Linhagens;
using ConquistadorAbsolutoBiblioteca.Origem;

namespace ConquistadorAbsolutoBiblioteca.Raca
{
    public sealed class Celestial
    {
        private static readonly Celestial _celestial = new Celestial();

        public static IRaca Celeste;

        static Celestial() { }

        private Celestial()
        {
            Celeste = Fabrica.CriarRaca();
            Celeste.Titulo = "Raça Celestial";
            Celeste.Nome = "Zohar";
            Celeste.Raridade = Grau.Extraordinario;
            Celeste.PoderConcedido = 5400f;
            Celeste.Caracteristicas.Add("Alado");
            Celeste.Caracteristicas.Add("Pele de bronze");

            Celeste.PopularLista(Celeste.EssenciasDeRaca, new List<IEssencia> { Luz.EssenciaDaLuz, Terra.EssenciaDaTerra });
            Celeste.PopularLista(Celeste.EssenciasIncompativeis, new List<IEssencia> { Treva.EssenciaDaTreva });
            Celeste.PopularLista(Celeste.LinhagensDeRaca, new List<ILinhagem> { Arcanjo.LinhagemDoArcanjo });
            Celeste.PopularLista(Celeste.LinhagensIncompativeis, new List<ILinhagem> { Diabo.LinhagemDoDiabo });
        }
    }
}
