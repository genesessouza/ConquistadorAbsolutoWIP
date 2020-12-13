using System;
using System.Collections.Generic;
using ConquistadorAbsolutoBiblioteca.Entidade;
using ConquistadorAbsolutoBiblioteca.Linhagem;
using ConquistadorAbsolutoBiblioteca.Origem;
using ConquistadorAbsolutoBiblioteca.Raca;

namespace ConquistadorAbsolutoBiblioteca.Essencia
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

        /// <summary>
        /// Confere os requisitos e, em caso de cumprimento, adiciona a essência.<br/>
        /// Caso contrário, reverte o processo e///ou aplica penalidades de origem.
        /// </summary>
        public void ConferirRequisitos()
        {
            var a = false;
            if (Portador.Alinhamento == AlinhamentoExigido | AlinhamentoExigido == Entidade.Alinhamento.Indefinido)
            {
                Console.Write($"Alinhamento compatível com <{Nome}> confere.\n");
                a = true;
            }
            else
            {
                Console.Write($"Alinhamento incompatível com <{Nome}>.\n");
                a = false;
            }

            var b = false;
            if (PoderExigido < 1 | Portador.Poder >= PoderExigido)
            {
                Console.Write($"Poder de Origem exigido por <{Nome}> confere.\n");
                b = true;
            }
            else
            {
                Console.Write($"Poder de Origem exigido por <{Nome}> não confere.\n");
                b = false;
            }

            if (RacaExigida == null) throw new NullReferenceException("Raça exigida está nula!");
            var c = false;
            if (Portador.Casta == RacaExigida)
            {
                Console.Write($"Raça exigida por <{Nome}> confere.\n");
                c = true;
            }
            else
            {
                Console.Write($"Raça exigida por <{Nome}> não foi encontrada.\n");
                c = false;
            }

            if (RacaIncompativel == null) throw new NullReferenceException("Raça rejeitada está nula!");
            var d = false;
            if (Portador.Casta != RacaIncompativel)
            {
                Console.Write($"A raça rejeitada por <{Nome}> não foi encontrada.\n");
                d = true;
            }
            else
            {
                Console.Write($"Raça incompatível com<{Nome}>.\n");
                d = false;
            }

            if (EssenciasExigidas == null) throw new NullReferenceException("A lista de essências exigidas está nula!");
            var e = false;
            if (EssenciasExigidas.Count < 1) e = true;
            foreach (IEssencia essenciaExigida in EssenciasExigidas)
            {
                if (Portador.EssenciasPossuidas.Contains(essenciaExigida))
                {
                    Console.Write($"Essencias exigidas por <{Nome}> encontradas.\n");
                    e = true;
                }
                else
                {
                    Console.Write($"Essencias exigidas por <{Nome}> não encontradas.\n");
                    e = false;
                }
            }

            if (EssenciasIncompativeis == null) throw new NullReferenceException("A lista de essências rejeitadas está nula!");
            var f = false;
            if (EssenciasIncompativeis.Count < 1) f = true;
            foreach (IEssencia essenciaRejeitada in EssenciasIncompativeis)
            {
                if (!Portador.EssenciasPossuidas.Contains(essenciaRejeitada))
                {
                    Console.Write($"Essencias incompatíveis com <{Nome}> não foram encontradas.\n");
                    f = true;
                }
                else
                {
                    Console.Write($"Essencias incompatíveis com <{Nome}> foram encontradas.\n");
                    f = false;
                }
            }

            if (LinhagensExigidas == null) throw new NullReferenceException("A lista de linhagens exigidas está nula!");
            var g = false;
            if (LinhagensExigidas.Count < 1) g = true;
            foreach (ILinhagem linhagem in LinhagensExigidas)
            {
                if (Portador.LinhagensHerdadas.Contains(linhagem))
                {
                    Console.Write($"Linhagens exigidas por <{Nome}> encontradas.\n");
                    g = true;
                }
                else
                {
                    Console.Write($"Linhagens exigidas por <{Nome}> não encontradas.\n");
                    g = false;
                }
            }

            if (LinhagensIncompativeis == null) throw new NullReferenceException("A lista de linhagens rejeitadas está nula!");
            var h = false;
            if (LinhagensIncompativeis.Count < 1) h = true;
            foreach (ILinhagem linhagemRejeitada in LinhagensIncompativeis)
            {
                if (!Portador.LinhagensHerdadas.Contains(linhagemRejeitada))
                {
                    Console.WriteLine($"Linhagens incompatíveis com <{Nome}> não encontradas.\n");
                    h = true;
                }
                else
                {
                    Console.WriteLine($"Linhagens incompatíveis com <{Nome}> encontradas.\n");
                    h = false;
                }
            }
            Console.WriteLine($"A: {a}, B: {b}, C: {c}, D: {d}, E: {e}, F: {f}, G: {g}, H: {h}");
            if (a & b & c & d & e & f & g & h)
            {
                Console.WriteLine($"Cumpriu todos os requisitos. Adicionou origem <{Nome}>.\n");
                Portador.EssenciasPossuidas.Add(this);
            }
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

        public void PopularLista<T>(List<T> lista, T[] valores)
        {
            GenesesSouza.CSharpUtils.CollectionsUtils.PopulateCollection(lista, valores);
        }
    }
}