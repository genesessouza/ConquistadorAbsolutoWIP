using ConquistadorAbsolutoWIP.Essencia.Essencias;
using ConquistadorAbsolutoWIP.Linhagem.Linhagens;
using ConquistadorAbsolutoWIP.Raca;

namespace ConquistadorAbsolutoWIP.Entidade.Entidades
{
    public sealed class Sylph
    {
        private static readonly Sylph sylph = new Sylph();
        public static Sylph ObterEntidade { get => sylph; }

        public static IEntidade EspiritoDoVento;

        static Sylph() { }

        private Sylph()
        {
            EspiritoDoVento = Fabrica.CriarEntidade();
            EspiritoDoVento.Nome = "Sylph";
            EspiritoDoVento.Alinhamento = Alinhamento.CaoticoNeutro;
            EspiritoDoVento.Casta = Celestial.Celeste;
            EspiritoDoVento.Poder = 14500f + EspiritoDoVento.Casta.PoderConcedido;
            EspiritoDoVento.EssenciasPossuidas.Add(Vento.EssenciaDoVento);
            EspiritoDoVento.EssenciasPossuidas.Add(Luz.EssenciaDaLuz);
            EspiritoDoVento.EssenciasPossuidas.Add(Treva.EssenciaDaTreva);
            EspiritoDoVento.LinhagensHerdadas.Add(Arcanjo.LinhagemDoArcanjo);
            EspiritoDoVento.LinhagensHerdadas.Add(Diabo.LinhagemDoDiabo);
            foreach (var essencia in EspiritoDoVento.EssenciasPossuidas)
                essencia.Portador = EspiritoDoVento;
            foreach (var linhagem in EspiritoDoVento.LinhagensHerdadas)
                linhagem.Portador = EspiritoDoVento;
        }

        static void Main(string[] args)
        {
            Sylph.EspiritoDoVento.MostrarEntidade();
        }
    }
}
