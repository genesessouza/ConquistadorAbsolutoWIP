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
            Atributos = new List<IAtributo>
            {
                new BaseDeAtributo("Atributo-A", 100f), new BaseDeAtributo("Atributo-B", 90f), new BaseDeAtributo("Atributo-C", 60f)
            };
            foreach (var atrib in Atributos)
                SubAtributos = new Dictionary<IAtributo, List<IAtributo>>
                {
                    {
                        atrib, new List<IAtributo>
                        {
                            new BaseDeAtributo("SubAtributo-A", 100f), new BaseDeAtributo("SubAtributo-B", 45f), new BaseDeAtributo("SubAtributo-C", 30f)
                        }
                    }
                };
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
            foreach (var atributo in SubAtributos)
            {
                Console.Write($" {atributo.Key.NomeDoAtributo}: <{atributo.Key.ValorDoAtributo}>");
            }
            Console.Write("\nSub-Atributos: ");
            var subAtributo = 0;
            for (; subAtributo < SubAtributos.Values.Count; subAtributo++) ;

            foreach (var subAtrib in SubAtributos)
                Console.Write($"{subAtrib.Value[subAtributo].NomeDoAtributo}: <{subAtrib.Value[subAtributo].ValorDoAtributo}>");
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
