namespace ConquistadorAbsolutoBiblioteca.Raca.Racas
{
    public sealed class Klishna
    {
        private static readonly Klishna _klishna = new Klishna();
        public static IRaca RacaKlishna { get; set; }

        static Klishna() { }

        private Klishna()
        {
            RacaKlishna = Fabrica.CriarRaca();
            RacaKlishna.Titulo = "Raça dos Humanos";
            RacaKlishna.Nome = "Klishna";
            RacaKlishna.PoderConcedido = 1100f;
        }
    }
}
