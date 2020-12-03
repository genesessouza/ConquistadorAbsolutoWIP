using System.Collections.Generic;
using ConquistadorAbsolutoBiblioteca.Linhagem;
using ConquistadorAbsolutoBiblioteca.Linhagem.Linhagens;
using ConquistadorAbsolutoBiblioteca.Origem;
using ConquistadorAbsolutoBiblioteca.Raca;

namespace ConquistadorAbsolutoBiblioteca.Essencia.Essencias
{
    public sealed class Luz
    {
        private static readonly Luz _luz = new Luz();
        public static IEssencia EssenciaDaLuz { get; private set; }

        static Luz() { }

        private Luz()
        {
            EssenciaDaLuz = Fabrica.CriarEssencia();
            EssenciaDaLuz.Titulo = "";
            EssenciaDaLuz.Nome = "Essência da Luz";
            EssenciaDaLuz.Raridade = Grau.Incomum;
            EssenciaDaLuz.Estado = Estado.Desperto;
            EssenciaDaLuz.Potencializador = EnergiaPropulsora.Positividade;
            EssenciaDaLuz.AlinhamentoExigido = Entidade.Alinhamento.LealAltruista;
            EssenciaDaLuz.PoderExigido = 21000f;
            EssenciaDaLuz.PoderConcedido = 14000f;
            EssenciaDaLuz.RacaExigida = Celestial.Celeste;
            EssenciaDaLuz.RacaIncompativel = Infernal.RacaInfernal;

            EssenciaDaLuz.PopularLista
            (
                EssenciaDaLuz.Propriedades, new List<string>
                {
                    "Abencoante", "Animadora", "Atraente", "Confortante","Embelezadora",
                    "Purificadora","Protetora","Regenerativa", "Rejuvenescedora"
                }
            );

            EssenciaDaLuz.PopularLista(EssenciaDaLuz.EssenciasIncompativeis, new List<IEssencia> { Treva.EssenciaDaTreva });
            EssenciaDaLuz.PopularLista(EssenciaDaLuz.LinhagensIncompativeis, new List<ILinhagem> { Diabo.LinhagemDoDiabo });
        }
    }
}