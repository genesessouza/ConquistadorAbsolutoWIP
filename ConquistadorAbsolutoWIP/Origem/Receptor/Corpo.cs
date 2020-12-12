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
        public static IReceptor Fisico { get; set; }

        static Corpo() { }

        private Corpo()
        {
            Fisico = Fabrica.CriarReceptor();
            Fisico.Nome = "Receptáculo do Corpo";

            Fisico.Atributos = new List<IAtributo> { new BaseDeAtributo("Força", 0f) };
            Fisico.Atributos = new List<IAtributo> { new BaseDeAtributo("Resistência", 0f) };
            Fisico.Atributos = new List<IAtributo> { new BaseDeAtributo("Agilidade", 0f) };

            Fisico.SubAtributos.Add(Fisico.Atributos[0], new List<IAtributo> { new BaseDeAtributo("Poder", 0f) });
            Fisico.SubAtributos.Add(Fisico.Atributos[1], new List<IAtributo> { new BaseDeAtributo("Resistência", 0f) });
            Fisico.SubAtributos.Add(Fisico.Atributos[1], new List<IAtributo> { new BaseDeAtributo("Vitalidade", 0f) });
            Fisico.SubAtributos.Add(Fisico.Atributos[2], new List<IAtributo> { new BaseDeAtributo("Destreza", 0f) });
        }
    }
}
