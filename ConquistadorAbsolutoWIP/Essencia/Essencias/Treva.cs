using System.Collections.Generic;
using ConquistadorAbsolutoBiblioteca.Linhagem;
using ConquistadorAbsolutoBiblioteca.Linhagem.Linhagens;
using ConquistadorAbsolutoBiblioteca.Origem;
using ConquistadorAbsolutoBiblioteca.Raca.Racas;

namespace ConquistadorAbsolutoBiblioteca.Essencia.Essencias
{
    public sealed class Treva
    {
        private static readonly Treva _treva = new Treva();
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
            EssenciaDaTreva.PoderExigido = 77000f;
            EssenciaDaTreva.PoderConcedido = 103000f;
            EssenciaDaTreva.RacaExigida = Nevora.RacaNevora;
            EssenciaDaTreva.RacaIncompativel = Zohar.RacaZohar;

            EssenciaDaTreva.PopularLista
            (
                EssenciaDaTreva.Propriedades, new string[]
                {
                    "Aterrorizante", "Corrosiva", "Corruptora", "Devoradora", "Venenosa",
                    "Intimidante", "Necromantica", "Necrotica", "Tentadora"
                }
            );

            EssenciaDaTreva.PopularLista(EssenciaDaTreva.EssenciasIncompativeis, new IEssencia[] { Luz.EssenciaDaLuz });
            EssenciaDaTreva.PopularLista(EssenciaDaTreva.LinhagensIncompativeis, new ILinhagem[] { Arcanjo.LinhagemDoArcanjo });
        }
    }
}