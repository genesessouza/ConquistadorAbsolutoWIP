using System.Collections.Generic;
using ConquistadorAbsolutoBiblioteca.Origem.Receptor;

namespace ConquistadorAbsolutoBiblioteca.Entidade.Origem
{
    /// <summary>
    ///Cuida das funções destinadas a origem,
    ///recebendo-a através do núcleo e dividindo para os receptores.
    /// </summary>
    public sealed class NucleoDeOrigem : INucleoDeOrigem
    {
        /// <summary>
        /// Receptores de Origem.
        /// <br/>Recebem a origem distribuida pelo núcleo e fortalecem suas respectivas áreas.
        /// </summary>
        public List<IReceptor> Receptores { get; private set; }
        public Corpo OrigemCorporal { get; private set; }
        public Mente OrigemMental { get; private set; }
        public Espirito OrigemEspiritual { get; private set; }

        /// <summary>
        /// Inicializa os receptores e os adiciona à lista
        /// </summary>
        public NucleoDeOrigem()
        {
            // Cria instância dos receptores
            OrigemCorporal = new Corpo();
            OrigemMental = new Mente();
            OrigemEspiritual = new Espirito();

            // Adiciona os receptores
            Receptores = new List<IReceptor>
            {
                OrigemCorporal,
                OrigemMental,
                OrigemEspiritual
            };
        }

        /// <summary>
        /// <para> Inicializa o Núcleo de Origem através do envio
        /// de poder de origem, que o distribui para o(s) 
        /// receptor(es) escolhido(os).</para>
        /// </summary>
        /// <param name="poderDeOrigemRecebido">Poder enviado para o Núcleo de Origem.</param>
        /// <param name="receptores">Receptor do poder (corpo, mente, espírito).</param>
        public void EnviarOrigem(float poderDeOrigemRecebido, List<IReceptor> receptores)
        {
            // Poder total distribuido para todos os receptores
            var poderDeOrigemDividido = poderDeOrigemRecebido / receptores.Count;

            // Seleciona o receptor escolhido pelo núcleo para receber a origem 
            foreach (var receptor in receptores)
            {
                receptor.InicializarReceptor(poderDeOrigemDividido);
            }
        }

        /// <summary>
        /// Mostra os atributos e os sub-atributos de cada receptor.
        /// </summary>
        public void MostrarTodosOsAtributos()
        {
            System.Console.Write
            (
                $"\n--------------------Receptores de Origem da Entidade--------------------\n"
            );
            foreach (var receptor in Receptores)
            {
                // Mostra os nomes de cada uma delas
                System.Console.Write
                (
                    $"<{receptor.Nome}> Poder de Origem: <{receptor.PoderDeOrigem}>\n"
                );
                receptor.MostrarAtributos();
                receptor.MostrarSubAtributos();
            }
        }
    }
}
