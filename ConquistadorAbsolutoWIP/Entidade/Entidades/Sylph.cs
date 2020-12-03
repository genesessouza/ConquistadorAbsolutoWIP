using ConquistadorAbsolutoBiblioteca.Essencia.Essencias;
using ConquistadorAbsolutoBiblioteca.Linhagem.Linhagens;
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
            EspiritoDoVento.EssenciasPossuidas.Add(Vento.EssenciaDoVento);
            EspiritoDoVento.EssenciasPossuidas.Add(Agua.EssenciaDaAgua);
            EspiritoDoVento.EssenciasPossuidas.Add(Terra.EssenciaDaTerra);
            EspiritoDoVento.EssenciasPossuidas.Add(Fogo.EssenciaDoFogo);
            EspiritoDoVento.EssenciasPossuidas.Add(Raio.EssenciaDoRaio);
            EspiritoDoVento.EssenciasPossuidas.Add(Treva.EssenciaDaTreva);
            EspiritoDoVento.EssenciasPossuidas.Add(Luz.EssenciaDaLuz);
            EspiritoDoVento.LinhagensHerdadas.Add(Arcanjo.LinhagemDoArcanjo);
            EspiritoDoVento.LinhagensHerdadas.Add(Diabo.LinhagemDoDiabo);
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
            Sylph.EspiritoDoVento.MostrarEntidade();
        }
    }
}
