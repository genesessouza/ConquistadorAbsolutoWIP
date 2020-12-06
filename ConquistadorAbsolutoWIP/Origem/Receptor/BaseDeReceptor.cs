using System;
using System.Collections.Generic;
using ConquistadorAbsolutoBiblioteca.Origem.Receptor.Atributo;

namespace ConquistadorAbsolutoBiblioteca.Origem.Receptor
{
    public sealed class BaseDeReceptor : IReceptor
    {
        public string Nome { get; }
        public float PoderDeOrigem { get; }
        public List<string> NomesDeAtributo { get; }
        public List<IAtributo> Atributos { get; set; }

        public void InicializarReceptor(float poderDeOrigem)
        {
            var poderDividido = (float)Math.Round(poderDeOrigem / Atributos.Count);
            foreach (var atrib in NomesDeAtributo)
            {
                Atributos.Add(new BaseDeAtributo(atrib, poderDividido));
            }
        }

        public void MostrarAtributos()
        {

        }

        public void MostrarSubAtributos()
        {

        }
    }
}
