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
        private List<string> AtributosPrincipais = new List<string> { "Forca", "Resistencia", "Agilidade" };
        /// <summary>
        /// Sub-atributos da força.
        /// </summary>
        private List<string> SubAtributosDaForca = new List<string> { "Ataque Fisico" };
        /// <summary>
        /// Sub-atributos da resistência.
        /// </summary>
        private List<string> SubAtributosDaResistencia = new List<string> { "Defesa Fisica", "Saude Fisica" };
        /// <summary>
        /// Sub-atributos da agilidade.
        /// </summary>
        private List<string> SubAtributosDaAgilidade = new List<string> { "Reflexos", "Velocidade", "Destreza" };

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
        public void InicializarReceptor(float poderDeOrigem)
        {
            // Distribui a origem para três(número de atributos) e adiciona a lista principal
            var umTercoDoPoderTotal = (float)System.Math.Round(poderDeOrigem / 3f);
            foreach (string atributoPrincipal in AtributosPrincipais)
                AtributosDoCorpo.Add(new Atributo(atributoPrincipal, umTercoDoPoderTotal));

            // Distribui uma parte do terço para cada sub-atributo da força e os adiciona a lista
            var PoderDeOrigemDaForca = (float)System.Math.Round(umTercoDoPoderTotal / SubAtributosDaForca.Count);
            foreach (string subAtributoDaForca in SubAtributosDaForca)
                AtributosDaForca.Add(new Atributo(subAtributoDaForca, PoderDeOrigemDaForca));

            // Distribui a outra parte do terço para cada sub-atributo da resistência e os adiciona a lista
            var PoderDeOrigemDaResistencia = (float)System.Math.Round(umTercoDoPoderTotal / SubAtributosDaResistencia.Count);
            foreach (string subAtributoDaResistencia in SubAtributosDaResistencia)
                AtributosDaResistencia.Add(new Atributo(subAtributoDaResistencia, PoderDeOrigemDaResistencia));

            // Distribui a última parte do terço para cada sub-atributo da agilidade e os adiciona a lista
            var PoderDeOrigemDaAgilidade = (float)System.Math.Round(umTercoDoPoderTotal / SubAtributosDaAgilidade.Count);
            foreach (string subAtributoDaAgilidade in SubAtributosDaAgilidade)
                AtributosDaAgilidade.Add(new Atributo(subAtributoDaAgilidade, PoderDeOrigemDaAgilidade));
        }

        /// <summary>
        /// Mostra todos os atributos principais do corpo e seus valores totais.
        /// </summary>
        public void MostrarAtributos()
        {
            System.Console.Write("Atributos Principais:");
            foreach (Atributo atributoPrincipal in AtributosDoCorpo)
            {
                System.Console.Write($" {atributoPrincipal.NomeDoAtributo}: <{atributoPrincipal.ValorDoAtributo}>");
            }

            System.Console.Write("\n");
        }

        /// <summary>
        /// Mostra os sub-atributos de cada atributo principal do corpo organizamente.
        /// </summary>
        public void MostrarSubAtributos()
        {
            System.Console.Write("Sub-Atributos da Força:");
            foreach (Atributo subAtributoDaForca in AtributosDaForca)
            {
                System.Console.Write($" {subAtributoDaForca.NomeDoAtributo}: <{subAtributoDaForca.ValorDoAtributo}>");
            }

            System.Console.Write("\nSub-Atributos da Resistência:");
            foreach (Atributo subAtributoDaResistencia in AtributosDaResistencia)
            {
                System.Console.Write($" {subAtributoDaResistencia.NomeDoAtributo}: <{subAtributoDaResistencia.ValorDoAtributo}>");
            }

            System.Console.Write("\nSub-Atributos da Agilidade:");

            foreach (Atributo subAtributoDaAgilidade in AtributosDaAgilidade)
            {
                System.Console.Write($" {subAtributoDaAgilidade.NomeDoAtributo}: <{subAtributoDaAgilidade.ValorDoAtributo}>");
            }

            System.Console.WriteLine("\n");
        }
    }
}
