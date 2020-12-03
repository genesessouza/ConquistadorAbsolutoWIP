namespace ConquistadorAbsolutoBiblioteca.Raca
{
    public sealed class Humano
    {
        private static readonly Humano humano = new Humano();
        public static Humano ObterRaca { get => humano; }

        public static IRaca Humana;

        static Humano() { }

        private Humano()
        {
            Humana = Fabrica.CriarRaca();
            Humana.Nome = "Raça Humana";
            Humana.PoderConcedido = 1100f;
            // Humana.EssenciasDeRaca.Add();
        }
    }
}
