using System.Collections.Generic;
using ConquistadorAbsolutoBiblioteca.Origem.Receptor;

namespace ConquistadorAbsolutoBiblioteca.Entidade.Origem
{
    /// <summary>
    /// Cuida das funções destinadas a origem,
    /// recebendo-a através do núcleo e dividindo para os receptores.
    /// </summary>
    public sealed class BaseDeNucleo : INucleo
    {
        /// <summary>
        /// Receptores de Origem.
        /// <br/>Recebem a origem distribuida pelo núcleo e fortalecem suas respectivas áreas.
        /// </summary>
        public List<IReceptor> Receptores { get; private set; }

        /// <summary>
        /// Inicializa os receptores e os adiciona à lista
        /// </summary>
        public BaseDeNucleo()
        {
            // Adiciona os receptores
            Receptores = new List<IReceptor>();
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
            Receptores.Add(Corpo.Fisico);
            // Poder total distribuido para todos os receptores
            var poderDeOrigemDividido = poderDeOrigemRecebido / receptores.Count;

            // Seleciona o receptor escolhido pelo núcleo para receber a origem 

            for (int receptor = 0; receptor < Receptores.Count; receptor++)
            {
                Receptores[receptor].InicializarReceptor(poderDeOrigemDividido);
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
                receptor.MostrarAtributos();
            }
        }
    }
}
