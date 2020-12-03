using System.Collections.Generic;

namespace ConquistadorAbsolutoBiblioteca.Origem.Receptor
{
    /// <summary>
    /// <para> Cria atributos e sub-atributos físicos e distribui o Poder de Origem recebido entre eles.
    /// <br/>Além de mostrar seus valores.</para>
    /// </summary>
    public sealed class Corpo : IReceptor
    {
        public string Nome { get; private set; }
        public float PoderDeOrigem { get; private set; }
        /// <summary>
        /// Atributos principais do corpo.
        /// </summary>
        private string[] AtributosPrincipais => new string[] { "Forca", "Resistencia", "Agilidade" };
        /// <summary>
        /// Sub-atributos da força.
        /// </summary>
        private string[] SubAtributosDaForca => new string[] { "Ataque Fisico" };
        /// <summary>
        /// Sub-atributos da resistência.
        /// </summary>
        private string[] SubAtributosDaResistencia => new string[] { "Defesa Fisica", "Saude Fisica" };
        /// <summary>
        /// Sub-atributos da agilidade.
        /// </summary>
        private string[] SubAtributosDaAgilidade => new string[] { "Reflexos", "Velocidade", "Destreza" };

        // Lista dos atributos físicos principais e dos sub-atributos
        private List<Atributo> AtributosDoCorpo
            = new List<Atributo>();
        private List<Atributo> AtributosDaForca
            = new List<Atributo>();
        private List<Atributo> AtributosDaResistencia
            = new List<Atributo>();
        private List<Atributo> AtributosDaAgilidade
            = new List<Atributo>();

        // Poder de Origem enviada para o corpo através do núcleo.
        // Construtor vazio para caso de não haver origem.
        public Corpo()
        {
            Nome = "Corpo";
        }

        /// <summary>
        /// Construtor para enviar a origem ao corpo.
        /// </summary>
        /// <param name="poderDeOrigemCorporal">Origem física recebida pelo núcleo.</param>
        public Corpo(float poderDeOrigemCorporal)
        {
            Nome = "Corpo";
            PoderDeOrigem = poderDeOrigemCorporal;
        }

        /// <summary>
        /// Distribui a origem recebida entre os atributos principais
        /// e cada atributo principal distribui para os sub-atributos.
        /// </summary>
        public void InicializarReceptor()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            // Distribui a origem para três(número de atributos) e adiciona a lista principal
            var umTercoDoPoderTotal = (float)System.Math.Round(PoderDeOrigem / 3f);
            foreach (string atributoPrincipal in AtributosPrincipais)
                AtributosDoCorpo.Add(new Atributo(atributoPrincipal, umTercoDoPoderTotal));

            // Distribui uma parte do terço para cada sub-atributo da força e os adiciona a lista
            var PoderDeOrigemDaForca = (float)System.Math.Round(umTercoDoPoderTotal / SubAtributosDaForca.Length);
            foreach (string subAtributoDaForca in SubAtributosDaForca)
                AtributosDaForca.Add(new Atributo(subAtributoDaForca, PoderDeOrigemDaForca));

            // Distribui a outra parte do terço para cada sub-atributo da resistência e os adiciona a lista
            var PoderDeOrigemDaResistencia = (float)System.Math.Round(umTercoDoPoderTotal / SubAtributosDaResistencia.Length);
            foreach (string subAtributoDaResistencia in SubAtributosDaResistencia)
                AtributosDaResistencia.Add(new Atributo(subAtributoDaResistencia, PoderDeOrigemDaResistencia));

            // Distribui a última parte do terço para cada sub-atributo da agilidade e os adiciona a lista
            var PoderDeOrigemDaAgilidade = (float)System.Math.Round(umTercoDoPoderTotal / SubAtributosDaAgilidade.Length);
            foreach (string subAtributoDaAgilidade in SubAtributosDaAgilidade)
                AtributosDaAgilidade.Add(new Atributo(subAtributoDaAgilidade, PoderDeOrigemDaAgilidade));

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            // System.Console.WriteLine($"Tempo de Execução [Inicializar Fonte]: {elapsedMs}");
        }

        /// <summary>
        /// Mostra todos os atributos principais do corpo e seus valores totais.
        /// </summary>
        public void MostrarAtributos()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            System.Console.Write("Atributos Principais:");

            Atributo atribPrinc = null;
            foreach (Atributo atributoPrincipal in AtributosDoCorpo)
            {
                atribPrinc = new Atributo(atributoPrincipal.NomeDoAtributo, atributoPrincipal.ValorDoAtributo);
                System.Console.Write($" {atribPrinc.NomeDoAtributo}: <{atribPrinc.ValorDoAtributo}>");
            }

            System.Console.Write("\n");

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            // System.Console.WriteLine($"Tempo de Execução [Mostrar Atributos]: {elapsedMs}");

        }

        /// <summary>
        /// Mostra os sub-atributos de cada atributo principal do corpo organizamente.
        /// </summary>
        public void MostrarSubAtributos()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            System.Console.Write("Sub-Atributos da Força:");

            Atributo subAtribForc = null;
            foreach (Atributo subAtributoDaForca in AtributosDaForca)
            {
                subAtribForc = new Atributo(subAtributoDaForca.NomeDoAtributo, subAtributoDaForca.ValorDoAtributo);
                System.Console.Write($" {subAtribForc.NomeDoAtributo}: <{subAtribForc.ValorDoAtributo}>");
            }

            System.Console.Write("\nSub-Atributos da Resistência:");
            Atributo subAtribRes = null;
            foreach (Atributo subAtributoDaResistencia in AtributosDaResistencia)
            {
                subAtribRes = new Atributo(subAtributoDaResistencia.NomeDoAtributo, subAtributoDaResistencia.ValorDoAtributo);
                System.Console.Write($" {subAtribRes.NomeDoAtributo}: <{subAtribRes.ValorDoAtributo}>");
            }

            System.Console.Write("\nSub-Atributos da Agilidade:");

            Atributo subAtribAgi = null;
            foreach (Atributo subAtributoDaAgilidade in AtributosDaAgilidade)
            {
                subAtribAgi = new Atributo(subAtributoDaAgilidade.NomeDoAtributo, subAtributoDaAgilidade.ValorDoAtributo);
                System.Console.Write($" {subAtribAgi.NomeDoAtributo}: <{subAtribAgi.ValorDoAtributo}>");
            }

            System.Console.WriteLine("\n");
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            // System.Console.WriteLine($"Tempo de Execução [Mostrar Sub-Atributos]: {elapsedMs}");
        }
    }
}
