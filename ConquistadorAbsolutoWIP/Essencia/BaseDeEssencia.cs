using ConquistadorAbsolutoWIP.Entidade;
using ConquistadorAbsolutoWIP.Linhagem;
using ConquistadorAbsolutoWIP.Origem;
using ConquistadorAbsolutoWIP.Raca;
using System;
using System.Collections.Generic;

namespace ConquistadorAbsolutoWIP.Essencia
{
    public class BaseDeEssencia : IEssencia
    {
        public string Titulo { get; set; }
        public string Nome { get; set; }
        public TipoDeOrigem Tipo { get; set; }
        public Grau Raridade { get; set; }
        public List<string> Propriedades { get; set; }
        public Estado Estado { get; set; }
        public EnergiaPropulsora Potencializador { get; set; }
        public float PoderExigido { get; set; }
        public float PoderConcedido { get; set; }
        public float Poder { get => PoderConcedido + Portador.Poder; }
        public IEntidade Portador { get; set; }
        public Alinhamento AlinhamentoExigido { get; set; }
        public IRaca RacaExigida { get; set; }
        public IRaca RacaIncompativel { get; set; }
        public List<IEssencia> EssenciasExigidas { get; set; }
        public List<IEssencia> EssenciasIncompativeis { get; set; }
        public List<ILinhagem> LinhagensExigidas { get; set; }
        public List<ILinhagem> LinhagensIncompativeis { get; set; }

        public BaseDeEssencia()
        {
            Tipo = TipoDeOrigem.Essencia;
            Propriedades = new List<string>();
            Estado = Estado.Adormecido;
            Potencializador = EnergiaPropulsora.Indefinido;
            Portador = Fabrica.CriarEntidade();
            AlinhamentoExigido = Alinhamento.Indefinido;
            RacaExigida = Fabrica.CriarRaca();
            RacaIncompativel = Fabrica.CriarRaca();
            EssenciasExigidas = new List<IEssencia>();
            EssenciasIncompativeis = new List<IEssencia>();
            LinhagensExigidas = new List<ILinhagem>();
            LinhagensIncompativeis = new List<ILinhagem>();
        }

        public void MostrarAtributos()
        {
            Console.Write
            (
                $"Nome: <{Nome}> Titulo: <{Titulo}> Raridade: <{Raridade}> Estado: <{Estado}> " +
                $"Fortificador: <{Potencializador}>\nPoder Concedido: <{PoderConcedido}> " +
                $"Raça Exigida: <{RacaExigida.Titulo}> Raça Incompatível: <{RacaIncompativel.Titulo}> " +
                $"Poder Total: <{Poder}> Alinhamento Exigido: <{AlinhamentoExigido}>"
            );

            var prop = string.Empty;
            foreach (string propriedade in Propriedades)
                prop += $"<{propriedade}>";

            Console.Write($"\nPropriedades: <{prop}>\n");

            if (EssenciasExigidas == null) return;

            var essenciasRequisitadas = string.Empty;
            foreach (var essenciaExigida in EssenciasExigidas)
                essenciasRequisitadas += $"<{essenciaExigida.Nome}>";

            Console.Write($"Essências pré-requisitadas: <{essenciasRequisitadas}>\n");

            if (EssenciasIncompativeis == null) return;

            var essenciasRejeitadas = string.Empty;
            foreach (var essenciaRejeitada in EssenciasIncompativeis)
                essenciasRejeitadas += $"<{essenciaRejeitada.Nome}>";

            Console.Write($"Essências incompatíveis: <{essenciasRejeitadas}>\n");

            if (LinhagensExigidas == null) return;

            var linhagensExigidas = string.Empty;
            foreach (var linhagemExigida in LinhagensExigidas)
                linhagensExigidas += $"<{linhagemExigida.Nome}>";

            Console.Write($"Linhagens pré-requisitadas: <{linhagensExigidas}>\n");

            if (LinhagensIncompativeis == null) return;

            var linhagensRejeitadas = string.Empty;
            foreach (var linhagemRejeitada in LinhagensIncompativeis)
                linhagensRejeitadas += $"<{linhagemRejeitada.Nome}>";

            Console.Write($"Linhagens incompatíveis: <{linhagensRejeitadas}>\n");

            Console.Write("\r\n");
        }

        public void PopularLista<T>(List<T> lista, List<T> valores)
        {
            GenesesSouza.CSharpUtils.Collections.PopulateCollection(lista, valores);
        }
    }
}