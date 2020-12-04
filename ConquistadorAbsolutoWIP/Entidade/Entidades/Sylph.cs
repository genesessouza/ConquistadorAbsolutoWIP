using ConquistadorAbsolutoBiblioteca.Essencia.Essencias;
using ConquistadorAbsolutoBiblioteca.Raca;

namespace ConquistadorAbsolutoBiblioteca.Entidade.Entidades
{
    public sealed class Sylph
    {
        private static readonly Sylph _sylph = new Sylph();
        public static IEntidade EspiritoDoVento { get; private set; }

        static Sylph() { }

        private Sylph()
        {
            EspiritoDoVento = Fabrica.CriarEntidade();
            EspiritoDoVento.Nome = "Sylph";
            EspiritoDoVento.Alinhamento = Alinhamento.CaoticoNeutro;
            EspiritoDoVento.Casta = Celestial.Celeste;
            EspiritoDoVento.Poder = 14500f + EspiritoDoVento.Casta.PoderConcedido;
            EspiritoDoVento.NucleoDeOrigem.EnviarOrigem(EspiritoDoVento.Poder, EspiritoDoVento.NucleoDeOrigem.Receptores);
            EspiritoDoVento.EssenciasPossuidas.Add(Vento.EssenciaDoVento);
            AssinalarPortador();
        }

        private static void AssinalarPortador()
        {
            foreach (var essencia in EspiritoDoVento.EssenciasPossuidas)
                essencia.Portador = EspiritoDoVento;
            foreach (var linhagem in EspiritoDoVento.LinhagensHerdadas)
                linhagem.Portador = EspiritoDoVento;
        }

        static void Main(string[] args)
        {
            EspiritoDoVento.MostrarEntidade();
        }
    }
}
