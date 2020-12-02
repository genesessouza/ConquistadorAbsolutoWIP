using ConquistadorAbsolutoWIP.Linhagem;
using ConquistadorAbsolutoWIP.Linhagem.Linhagens;
using ConquistadorAbsolutoWIP.Origem;
using ConquistadorAbsolutoWIP.Raca;
using System.Collections.Generic;

namespace ConquistadorAbsolutoWIP.Essencia.Essencias
{
    public sealed class Treva
    {
        private static readonly Treva _treva = new Treva();
        public static Treva ObterEssencia { get => _treva; }
        public static IEssencia EssenciaDaTreva { get; private set; }

        static Treva() { }

        private Treva()
        {
            EssenciaDaTreva = Fabrica.CriarEssencia();
            EssenciaDaTreva.Titulo = "";
            EssenciaDaTreva.Nome = "Essência da Treva";
            EssenciaDaTreva.Raridade = Grau.Extraordinario;
            EssenciaDaTreva.Estado = Estado.Desperto;
            EssenciaDaTreva.Potencializador = EnergiaPropulsora.Negatividade;
            EssenciaDaTreva.AlinhamentoExigido = Entidade.Alinhamento.LealEgoista | Entidade.Alinhamento.LealNeutro;
            EssenciaDaTreva.PoderExigido = 57000f;
            EssenciaDaTreva.PoderConcedido = 33000f;
            EssenciaDaTreva.RacaExigida = Infernal.RacaInfernal;
            EssenciaDaTreva.RacaIncompativel = Celestial.Celeste;

            EssenciaDaTreva.PopularLista
            (
                EssenciaDaTreva.Propriedades, new List<string>
                {
                    "Aterrorizante", "Corrosiva", "Corruptora", "Devoradora", "Venenosa",
                    "Intimidante", "Necromantica", "Necrotica", "Tentadora"
                }
            );

            EssenciaDaTreva.PopularLista(EssenciaDaTreva.EssenciasIncompativeis, new List<IEssencia> { Luz.EssenciaDaLuz });
            EssenciaDaTreva.PopularLista(EssenciaDaTreva.LinhagensIncompativeis, new List<ILinhagem> { Arcanjo.LinhagemDoArcanjo });
        }
    }
}