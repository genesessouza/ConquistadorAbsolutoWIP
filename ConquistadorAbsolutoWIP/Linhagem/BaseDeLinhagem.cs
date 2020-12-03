using System;
using System.Collections.Generic;
using ConquistadorAbsolutoBiblioteca.Entidade;
using ConquistadorAbsolutoBiblioteca.Essencia;
using ConquistadorAbsolutoBiblioteca.Origem;
using ConquistadorAbsolutoBiblioteca.Raca;

namespace ConquistadorAbsolutoBiblioteca.Linhagem
{
    public sealed class BaseDeLinhagem : ILinhagem
    {
        public string Titulo { get; set; }
        public string Nome { get; set; }
        public TipoDeOrigem Tipo { get; set; }
        public Estado Condicao { get; set; }
        public Grau Raridade { get; set; }
        public float PoderConcedido { get; set; }
        public float Poder { get => PoderConcedido + Portador.Poder; }
        public IEntidade Portador { get; set; }
        public Alinhamento AlinhamentoExigido { get; set; }
        public IRaca RacaExigida { get; set; }
        public IRaca RacaIncompativel { get; set; }
        public List<IEssencia> EssenciasHerdadas { get; set; }
        public List<IEssencia> EssenciasIncompativeis { get; set; }
        public List<ILinhagem> LinhagensCompativeis { get; set; }
        public List<ILinhagem> LinhagensIncompativeis { get; set; }

        public BaseDeLinhagem()
        {
            Tipo = TipoDeOrigem.Linhagem;
            Condicao = Estado.Adormecido;
            AlinhamentoExigido = Alinhamento.Indefinido;
            RacaExigida = Fabrica.CriarRaca();
            RacaIncompativel = Fabrica.CriarRaca();
            EssenciasHerdadas = new List<IEssencia>();
            EssenciasIncompativeis = new List<IEssencia>();
            LinhagensCompativeis = new List<ILinhagem>();
            LinhagensIncompativeis = new List<ILinhagem>();
        }

        public void MostrarAtributos()
        {
            Console.Write
            (
                $"Nome: <{Nome}> Titulo: <{Titulo}> Raridade: <{Raridade}> Estado: <{Condicao}> " +
                $"\nPoder Concedido: <{PoderConcedido}> Raça Exigida: <{RacaExigida.Titulo}> " +
                $"Raça Incompatível: <{RacaIncompativel.Titulo}> Poder Total: <{Poder}> Alinhamento Exigido: <{AlinhamentoExigido}>"
            );

            if (EssenciasHerdadas == null) return;

            var essenciasHerdadas = string.Empty;
            foreach (var essenciaHerdada in EssenciasHerdadas)
                essenciasHerdadas += $"<{essenciaHerdada.Nome}>";

            Console.Write($"\nEssências Herdadas: <{essenciasHerdadas}>\n");

            if (EssenciasIncompativeis == null) return;

            var essenciasRejeitadas = string.Empty;
            foreach (var essenciaRejeitada in EssenciasIncompativeis)
                essenciasRejeitadas += $"<{essenciaRejeitada.Nome}>";

            Console.Write($"Essências incompatíveis: <{essenciasRejeitadas}>\n");

            if (LinhagensCompativeis == null) return;

            var linhagensCompativeis = string.Empty;
            foreach (var linhagemCompativel in LinhagensCompativeis)
                linhagensCompativeis += $"<{linhagemCompativel.Nome}>";

            Console.Write($"Linhagens compatíveis: <{linhagensCompativeis}>\n");

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
