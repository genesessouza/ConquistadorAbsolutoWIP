using System.Collections.Generic;
using ConquistadorAbsolutoBiblioteca.Linhagem;
using ConquistadorAbsolutoBiblioteca.Linhagem.Linhagens;
using ConquistadorAbsolutoBiblioteca.Origem;

namespace ConquistadorAbsolutoBiblioteca.Essencia.Essencias
{
    public sealed class Vento
    {
        private static readonly Vento _vento = new Vento();
        public static IEssencia EssenciaDoVento { get; private set; }

        static Vento() { }

        private Vento()
        {
            EssenciaDoVento = Fabrica.CriarEssencia();
            EssenciaDoVento.Nome = "Essência do Vento";
            EssenciaDoVento.Raridade = Grau.Incomum;
            EssenciaDoVento.PoderConcedido = 6500f;
            EssenciaDoVento.Potencializador = EnergiaPropulsora.Instabilidade;
            EssenciaDoVento.Estado = Estado.Desperto;
            EssenciaDoVento.PoderExigido = 2750f;
            EssenciaDoVento.AlinhamentoExigido = Entidade.Alinhamento.Indefinido;

            EssenciaDoVento.PopularLista
            (
                EssenciaDoVento.Propriedades, new string[]
                {
                    "Impulsionante", "Cortante", "Gravitacional", "Explosiva", "Restringente", "Comprimente"
                }
            );

            EssenciaDoVento.PopularLista(EssenciaDoVento.EssenciasIncompativeis, new IEssencia[] { Treva.EssenciaDaTreva });
            EssenciaDoVento.PopularLista(EssenciaDoVento.LinhagensIncompativeis, new ILinhagem[] { Diabo.LinhagemDoDiabo });
        }
    }
}
