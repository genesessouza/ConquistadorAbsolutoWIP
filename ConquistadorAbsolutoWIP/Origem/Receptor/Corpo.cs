using System.Collections.Generic;
using ConquistadorAbsolutoBiblioteca.Origem.Receptor.Atributo;

namespace ConquistadorAbsolutoBiblioteca.Origem.Receptor
{
    /// <summary>
    /// <para> Cria atributos e sub-atributos físicos e distribui o Poder de Origem recebido entre eles.
    /// <br/>Além de mostrar seus valores.</para>
    /// </summary>
    public sealed class Corpo
    {
        private static readonly Corpo _corpo = new Corpo();
        public static IReceptor Fisico { get; private set; }

        static Corpo() { }

        private Corpo()
        {
            Fisico = Fabrica.CriarReceptor();
            Fisico.Nome = "Receptáculo do Corpo";

            Fisico.Atributos.Add
            (
                new BaseDeAtributo("Força", 0f), new List<IAtributo> 
                {
                    new BaseDeAtributo("Ataque Físico", 0f),
                }
            );

            Fisico.Atributos.Add
            (
                new BaseDeAtributo("Resistência", 0f), new List<IAtributo> 
                {
                    new BaseDeAtributo("Defesa", 0f),
                    new BaseDeAtributo("Vitalidade", 0f)
                }
            );

            Fisico.Atributos.Add
            (
                new BaseDeAtributo("Agilidade", 0f), new List<IAtributo>
                {
                    new BaseDeAtributo("Reflexos", 0f),
                    new BaseDeAtributo("Destreza", 0f),
                    new BaseDeAtributo("Velocidade", 0f)
                }
            );
        }
    }
}
