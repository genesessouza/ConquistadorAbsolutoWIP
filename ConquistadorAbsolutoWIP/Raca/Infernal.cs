using ConquistadorAbsolutoWIP.Linhagem.Linhagens;

namespace ConquistadorAbsolutoWIP.Raca
{
    public sealed class Infernal
    {
        private static readonly Infernal infernal = new Infernal();
        public static Infernal ObterRaca { get => infernal; }

        public static IRaca RacaInfernal;

        static Infernal() { }

        private Infernal()
        {
            RacaInfernal = Fabrica.CriarRaca();
            RacaInfernal.Nome = "Raça Infernal";
            RacaInfernal.PoderConcedido = 6300f;
            // RacaInfernal.EssenciasDeRaca.Add();
            RacaInfernal.LinhagensDeRaca.Add(Diabo.LinhagemDoDiabo);
        }
    }
}
