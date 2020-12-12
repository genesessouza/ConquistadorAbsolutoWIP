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

        public void InicializarReceptor(float poderDeOrigem)
        {
            var poderDistribuido = poderDeOrigem / SubAtributos.Values.Count;
            var atributo = 0;
            for (; atributo < Atributos.Count; atributo++)
            {
                Atributos[atributo].ValorDoAtributo = poderDeOrigem;
            }
            foreach (var subAtributo in SubAtributos)
                subAtributo.Value[atributo].ValorDoAtributo += poderDistribuido;
        }

        public void MostrarAtributos()
        {
            Console.Write("Atributos Principais:");
            var atributoPrincipal = 0;
            for (; atributoPrincipal < SubAtributos.Keys.Count; atributoPrincipal++)
            {

            }
            for (int atributo = 0; atributo < SubAtributos.Keys.Count; atributo++)
            {
                // Console.WriteLine(SubAtributos.ContainsKey(SubAtomeDoAtributo);
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
