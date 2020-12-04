using System.Collections.Generic;

namespace ConquistadorAbsolutoBiblioteca.Origem.Receptor
{
    /// <summary>
    /// <para> Cria atributos e sub-atributos espirituais e distribui o Poder de Origem recebido entre eles.
    /// <br/>Além de mostrar seus valores.</para>
    /// </summary>
    public sealed class Espirito : IReceptor
    {
        public string Nome { get; private set; }
        public float PoderDeOrigem { get; private set; }
        /// <summary>
        /// Atributos principais do espírito.
        /// </summary>
        private string[] AtributosPrincipais => new string[] { "Carisma", "Existencia" };
        /// <summary>
        /// Sub-atributos do carisma.
        /// </summary>
        private string[] SubAtributosDoCarisma => new string[] { "Atracao", "Sociabilidade", "Persuasao" };
        /// <summary>
        /// Sub-atributos da existência espiritual.
        /// </summary>
        private string[] SubAtributosDaExistencia = new string[]
        {
           "Ataque Magico", "Defesa Magica", "Afinidade Magica", "Absorcao Magica", "Producao Magica"
        };

        // Lista dos atributos espirituais principais e dos sub-atributos
        private List<Atributo> AtributosDoEspirito = new List<Atributo>();
        private List<Atributo> AtributosDaExistencia = new List<Atributo>();
        private List<Atributo> AtributosDoCarisma = new List<Atributo>();

        // Construtor vazio para caso de não haver origem.
        public Espirito()
        {
            Nome = "Espirito";
        }

        /// <summary>
        /// Construtor para enviar a origem ao espírito.
        /// </summary>
        /// <param name="poderDeOrigemEspiritual">Origem espiritual recebida pelo núcleo.</param>
        public Espirito(float poderDeOrigemEspiritual)
        {
            Nome = "Espirito";
            PoderDeOrigem = poderDeOrigemEspiritual;
        }

        /// <summary>
        /// Distribui a origem recebida entre os atributos espirituais 
        /// principais e cada atributo principal distribui para os sub-atributos.
        /// </summary>
        public void InicializarReceptor(float poderDeOrigem)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            // Distribui a origem para dois(número de atributos) e adiciona a lista principal.
            var metadeDoPoderTotal = (float)System.Math.Round(poderDeOrigem / 2f);
            foreach (string atributoPrincipal in AtributosPrincipais)
                AtributosDoEspirito.Add(new Atributo(atributoPrincipal, metadeDoPoderTotal));

            // Distribui a metade para cada sub-atributo do carisma e os adiciona a lista
            var PoderDeOrigemDoCarisma = (float)System.Math.Round(metadeDoPoderTotal / SubAtributosDoCarisma.Length);
            foreach (string subAtributoDoCarisma in SubAtributosDoCarisma)
                AtributosDoCarisma.Add(new Atributo(subAtributoDoCarisma, PoderDeOrigemDoCarisma));

            // Distribui a outra metade para cada sub-atributo da existencia espiritual e os adiciona a lista
            var PoderDeOrigemDaExistencia = (float)System.Math.Round(metadeDoPoderTotal / SubAtributosDaExistencia.Length);
            foreach (string subAtributoDaExistencia in SubAtributosDaExistencia)
                AtributosDaExistencia.Add(new Atributo(subAtributoDaExistencia, PoderDeOrigemDaExistencia));

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            // System.Console.WriteLine($"Tempo de Execução [Inicializar Fonte]: {elapsedMs}");
        }

        /// <summary>
        /// Mostra todos os atributos principais do espírito e seus valores totais.
        /// </summary>
        public void MostrarAtributos()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            System.Console.Write("Atributos Principais:");

            Atributo atribPrinc = null;
            foreach (Atributo atributoPrincipal in AtributosDoEspirito)
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
        /// Mostra os sub-atributos de cada atributo principal do espírito organizamente.
        /// </summary>
        public void MostrarSubAtributos()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            System.Console.Write("Sub-Atributos do Carisma:");

            Atributo subAtribCar = null;
            foreach (Atributo subAtributoDoCarisma in AtributosDoCarisma)
            {
                subAtribCar = new Atributo(subAtributoDoCarisma.NomeDoAtributo, subAtributoDoCarisma.ValorDoAtributo);
                System.Console.Write($" {subAtribCar.NomeDoAtributo}: <{subAtribCar.ValorDoAtributo}>");
            }

            System.Console.Write("\nSub-Atributos da Existência:");

            Atributo subAtribEx = null;
            foreach (Atributo subAtributoDaExistencia in AtributosDaExistencia)
            {
                subAtribEx = new Atributo(subAtributoDaExistencia.NomeDoAtributo, subAtributoDaExistencia.ValorDoAtributo);
                System.Console.Write($" {subAtribEx.NomeDoAtributo}: <{subAtribEx.ValorDoAtributo}>");
            }

            System.Console.Write("\r\n");
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            // System.Console.WriteLine($"Tempo de Execução [Mostrar Sub-Atributos]: {elapsedMs}");
        }
    }
}
