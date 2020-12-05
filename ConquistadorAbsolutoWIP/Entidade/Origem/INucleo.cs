using System.Collections.Generic;
using ConquistadorAbsolutoBiblioteca.Origem.Receptor;

namespace ConquistadorAbsolutoBiblioteca.Entidade.Origem
{
    /// <summary>
    /// Núcleo de Origem da Entidade.
    /// <br/> Armazena
    /// </summary>
    public interface INucleo
    {
        List<IReceptor> Receptores { get; }
        Corpo OrigemCorporal { get; }
        Espirito OrigemEspiritual { get; }
        Mente OrigemMental { get; }

        void EnviarOrigem(float poderRecebido, List<IReceptor> receptores);
        void MostrarTodosOsAtributos();
    }
}