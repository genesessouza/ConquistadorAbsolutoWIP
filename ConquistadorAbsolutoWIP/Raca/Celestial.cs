using ConquistadorAbsolutoWIP.Essencia;
using ConquistadorAbsolutoWIP.Essencia.Essencias;
using ConquistadorAbsolutoWIP.Linhagem;
using ConquistadorAbsolutoWIP.Linhagem.Linhagens;
using ConquistadorAbsolutoWIP.Origem;
using System.Collections.Generic;

namespace ConquistadorAbsolutoWIP.Raca
{
    public sealed class Celestial
    {
        private static readonly Celestial _celestial = new Celestial();
        public static Celestial ObterRaca { get => _celestial; }

        public static IRaca Celeste;

        static Celestial() { }

        private Celestial()
        {
            Celeste = Fabrica.CriarRaca();
            Celeste.Titulo = "Raça Celestial";
            Celeste.Nome = "Zohar";
            Celeste.Raridade = Grau.Raro;
            Celeste.PoderConcedido = 5400f;
            Celeste.Caracteristicas.Add("Alado");
            Celeste.Caracteristicas.Add("Pele cor-de-bronze");
            Celeste.PopularLista(Celeste.EssenciasDeRaca, new List<IEssencia> { Luz.EssenciaDaLuz });
            Celeste.PopularLista(Celeste.EssenciasIncompativeis, new List<IEssencia> { Treva.EssenciaDaTreva });
            Celeste.PopularLista(Celeste.LinhagensDeRaca, new List<ILinhagem> { Arcanjo.LinhagemDoArcanjo });
            Celeste.PopularLista(Celeste.LinhagensIncompativeis, new List<ILinhagem> { Diabo.LinhagemDoDiabo });
        }
    }
}
