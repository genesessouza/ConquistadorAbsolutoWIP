using ConquistadorAbsolutoWIP.Linhagem;
using ConquistadorAbsolutoWIP.Linhagem.Linhagens;
using ConquistadorAbsolutoWIP.Origem;
using System.Collections.Generic;

namespace ConquistadorAbsolutoWIP.Essencia.Essencias
{
    public sealed class Vento
    {
        private static readonly Vento _vento = new Vento();
        public static Vento ObterEssencia { get => _vento; }
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
                EssenciaDoVento.Propriedades, new List<string>
                {
                    "Impulsionante", "Cortante", "Gravitacional", "Explosiva", "Restringente", "Comprimente"
                }
            );

            EssenciaDoVento.PopularLista(EssenciaDoVento.EssenciasIncompativeis, new List<IEssencia> { Treva.EssenciaDaTreva });
            EssenciaDoVento.PopularLista(EssenciaDoVento.LinhagensIncompativeis, new List<ILinhagem> { Diabo.LinhagemDoDiabo });
        }
    }
}
