using System;
using System.Collections.Generic;
using ConquistadorAbsolutoBiblioteca.Origem.Receptor.Atributo;

namespace ConquistadorAbsolutoBiblioteca.Origem.Receptor
{
    public sealed class BaseDeReceptor : IReceptor
    {
        public string Nome { get; set; }
        public float PoderDeOrigem { get; set; }
        public Dictionary<IAtributo, List<IAtributo>> Atributos { get; set; }

        public BaseDeReceptor()
        {
            Atributos = new Dictionary<IAtributo, List<IAtributo>>();
        }

        public void InicializarReceptor(float poderDeOrigem)
        {
            var poderDistribuido = poderDeOrigem / Atributos.Values.Count;

            var atributo = 0;
            for (; atributo < Atributos.Values.Count; atributo++) ;

            foreach (var atrib in Atributos.Keys)
                atrib.ValorDoAtributo += poderDeOrigem;

            foreach (var atrib in Atributos.Values) ;
                // atrib[atributo].ValorDoAtributo += poderDistribuido;
        }

        public void MostrarAtributos()
        {
            Console.Write("Atributos Principais:");
            foreach (var atributoPrincipal in Atributos)
            {
                Console.Write($"{atributoPrincipal.Key.NomeDoAtributo}: <{atributoPrincipal.Key.ValorDoAtributo}>");
            }
            foreach (var atributoSecundario in Atributos.Values)
            {
               // Console.Write($"{atributoSecundario[atributo].NomeDoAtributo}: <{atributoSecundario[atributo].ValorDoAtributo}>");
            }
        }

        public void MostrarSubAtributos()
        {

        }

        public void PopularLista<T>(List<T> lista, T[] valores)
        {
            GenesesSouza.CSharpUtils.CollectionsUtils.PopulateCollection(lista, valores);
        }
    }
}
