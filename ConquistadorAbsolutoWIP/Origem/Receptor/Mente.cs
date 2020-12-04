using System.Collections.Generic;

namespace ConquistadorAbsolutoBiblioteca.Origem.Receptor
{
    /// <summary>
    /// <para>
    /// Cria atributos e sub-atributos mentais e distribui o Poder de Origem recebido entre eles, 
    /// <br/>além de mostrar seus valores.
    /// </para>
    /// </summary>
    public sealed class Mente : IReceptor
    {
        public string Nome { get; private set; }
        public float PoderDeOrigem { get; private set; }
        /// <summary>
        /// Atributos principais da mente.
        /// </summary>
        private string[] AtributosPrincipais => new string[] { "Inteligência", "Sabedoria" };
        /// <summary>
        /// Sub-atributos principais da inteligência.
        /// </summary>
        private string[] SubAtributosDaInteligencia => new string[] { "Raciocínio", "Criatividade", "Aprendizado" };
        /// <summary>
        /// Sub-atributos principais da sabedoria.
        /// </summary>
        private string[] SubAtributosDaSabedoria => new string[] { "Intuição" };

        // Lista dos atributos mentais principais e dos sub-atributos
        private List<Atributo> AtributosDaMente = new List<Atributo>();
        private List<Atributo> AtributosDaInteligencia = new List<Atributo>();
        private List<Atributo> AtributosDaSabedoria = new List<Atributo>();

        // Construtor vazio para caso de não haver origem.
        public Mente()
        {
            Nome = "Mente";
        }

        /// <summary>
        /// Construtor para enviar a origem à mente.
        /// </summary>
        /// <param name="poderDeOrigemMental">Origem mental recebida pelo núcleo.</param>
        public Mente(float poderDeOrigemMental)
        {
            Nome = "Mente";
            PoderDeOrigem = poderDeOrigemMental;
        }

        /// <summary>
        /// Distribui a origem recebida entre os atributos principais
        /// e cada atributo principal distribui para os sub-atributos.
        /// </summary>
        public void InicializarReceptor(float poderDeOrigem)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            // Distribui a origem para dois(número de atributos) e adiciona a lista principal
            var metadeDoPoderTotal = (float)System.Math.Round(poderDeOrigem / 2f);
            foreach (string atributoPrincipal in AtributosPrincipais)
                AtributosDaMente.Add(new Atributo(atributoPrincipal, metadeDoPoderTotal));

            // Distribui uma metade para cada sub-atributo da inteligência e os adiciona a lista
            var PoderDeOrigemDaInteligencia = (float)System.Math.Round(metadeDoPoderTotal / SubAtributosDaInteligencia.Length);
            foreach (string subAtributoDaInteligencia in SubAtributosDaInteligencia)
                AtributosDaInteligencia.Add(new Atributo(subAtributoDaInteligencia, PoderDeOrigemDaInteligencia));

            // Distribui a outra metade para cada sub-atributo da sabedoria e os adiciona a lista
            var PoderDeOrigemDaSabedoria = (float)System.Math.Round(metadeDoPoderTotal / SubAtributosDaSabedoria.Length);
            foreach (string subAtributoDaSabedoria in SubAtributosDaSabedoria)
                AtributosDaSabedoria.Add(new Atributo(subAtributoDaSabedoria, PoderDeOrigemDaSabedoria));

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            // System.Console.WriteLine($"Tempo de Execução [Inicializar Fonte]: {elapsedMs}");
        }

        /// <summary>
        /// Mostra todos os atributos principais da mente e seus valores totais.
        /// </summary>
        public void MostrarAtributos()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            System.Console.Write("Atributos Principais:");

            Atributo atribPrinc = null;
            foreach (Atributo atributoPrincipal in AtributosDaMente)
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
        /// Mostra os sub-atributos de cada atributo principal da mente organizamente.
        /// </summary>
        public void MostrarSubAtributos()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            System.Console.Write("Sub-Atributos da Inteligência:");

            Atributo subAtribInt = null;
            foreach (Atributo subAtributoDaInteligencia in AtributosDaInteligencia)
            {
                subAtribInt = new Atributo(subAtributoDaInteligencia.NomeDoAtributo, subAtributoDaInteligencia.ValorDoAtributo);
                System.Console.Write($" {subAtribInt.NomeDoAtributo}: <{subAtribInt.ValorDoAtributo}>");
            }

            System.Console.Write("\nSub-Atributos da Sabedoria:");

            Atributo subAtribSab = null;
            foreach (Atributo subAtributoDaSabedoria in AtributosDaSabedoria)
            {
                subAtribSab = new Atributo(subAtributoDaSabedoria.NomeDoAtributo, subAtributoDaSabedoria.ValorDoAtributo);
                System.Console.Write($" {subAtribSab.NomeDoAtributo}: <{subAtribSab.ValorDoAtributo}>");
            }

            System.Console.WriteLine("\n");
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            // System.Console.WriteLine($"Tempo de Execução [Mostrar Sub-Atributos]: {elapsedMs}");
        }
    }
}
