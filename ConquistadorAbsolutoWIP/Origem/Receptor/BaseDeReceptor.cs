using System;
using System.Collections.Generic;
using ConquistadorAbsolutoBiblioteca.Origem.Receptor.Atributo;

namespace ConquistadorAbsolutoBiblioteca.Origem.Receptor
{
    public sealed class BaseDeReceptor : IReceptor
    {
        public string Nome { get; set; }
        public float PoderDeOrigem { get; set; }
        public List<IAtributo> Atributos { get; set; }
        public Dictionary<IAtributo, List<IAtributo>> SubAtributos { get; set; }

        public BaseDeReceptor()
        {
            Atributos = new List<IAtributo>();
            SubAtributos = new Dictionary<IAtributo, List<IAtributo>>();
        }

        public void InicializarReceptor(float poderDeOrigem)
        {
            var poderDistribuido = (float)Math.Round(poderDeOrigem / Atributos.Count);

            var atrib = 0;
            for (; atrib < Atributos.Count; atrib++)
            {
                Atributos[atrib].ValorDoAtributo += poderDistribuido;
            }
            foreach (var atributo in SubAtributos.Keys)
            {
                atributo.NomeDoAtributo = Atributos[atrib].NomeDoAtributo;
                atributo.ValorDoAtributo = Atributos[atrib].ValorDoAtributo;
            }
        }

        public void MostrarAtributos()
        {
            Console.Write("Atributos Principais: ");
            foreach (var atributoSecundario in Atributos)
            {
                Console.Write($" {atributoSecundario.NomeDoAtributo}: <{atributoSecundario.ValorDoAtributo}>");
            }
        }

        public void MostrarSubAtributos()
        {

        }

        public void PopularLista<T>(List<T> lista, List<T> valores)
        {
            GenesesSouza.CSharpUtils.CollectionsUtils.PopulateCollection(lista, valores);
        }
    }
}
