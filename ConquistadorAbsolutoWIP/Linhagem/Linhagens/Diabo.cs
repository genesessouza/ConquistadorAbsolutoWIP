using ConquistadorAbsolutoBiblioteca.Essencia.Essencias;
using ConquistadorAbsolutoBiblioteca.Raca;

namespace ConquistadorAbsolutoBiblioteca.Linhagem.Linhagens
{
    public sealed class Diabo
    {
        private static readonly Diabo diabo = new Diabo();
        public static Diabo ObterLinhagem { get => diabo; }

        public static ILinhagem LinhagemDoDiabo;

        static Diabo() { }

        private Diabo()
        {
            LinhagemDoDiabo = Fabrica.CriarLinhagem();
            LinhagemDoDiabo.Nome = "Linhagem do Diabo";
            LinhagemDoDiabo.PoderConcedido = 27000f;
            LinhagemDoDiabo.RacaExigida = Infernal.RacaInfernal;
            LinhagemDoDiabo.EssenciasHerdadas.Add(Treva.EssenciaDaTreva);
            LinhagemDoDiabo.LinhagensIncompativeis.Add(Arcanjo.LinhagemDoArcanjo);
        }
    }
}
