using System;
using System.Collections.Generic;
using ConquistadorAbsolutoBiblioteca.Essencia;
using ConquistadorAbsolutoBiblioteca.Linhagem;
using ConquistadorAbsolutoBiblioteca.Origem;

namespace ConquistadorAbsolutoBiblioteca.Raca
{
    public sealed class BaseDeRaca : IRaca
    {
        public string Titulo { get; set; }
        public string Nome { get; set; }
        public TipoDeOrigem Tipo { get; private set; }
        public Grau Raridade { get; set; }
        public float PoderConcedido { get; set; }
        public List<string> Caracteristicas { get; set; }
        public List<IEssencia> EssenciasDeRaca { get; set; }
        public List<IEssencia> EssenciasIncompativeis { get; set; }
        public List<ILinhagem> LinhagensDeRaca { get; set; }
        public List<ILinhagem> LinhagensIncompativeis { get; set; }

        /// <summary>
        /// Construtor para a inicialização estática.
        /// </summary>
        public BaseDeRaca()
        {
            Tipo = TipoDeOrigem.Raca;
            Caracteristicas = new List<string>();
            EssenciasDeRaca = new List<IEssencia>();
            EssenciasIncompativeis = new List<IEssencia>();
            LinhagensDeRaca = new List<ILinhagem>();
            LinhagensIncompativeis = new List<ILinhagem>();
        }

        public void MostrarAtributos()
        {
            Console.Write($"\n-----------------------Raça-----------------------\n");
            Console.Write($"<{Nome}> Titulo: <{Titulo}> Raridade: <{Raridade}> Poder Concedido: <{PoderConcedido}>\n");

            if (Caracteristicas == null) throw new NullReferenceException("As características da raça estão nulas!");

            var car = string.Empty;
            foreach (var caracteristica in Caracteristicas)
                car += $"<{caracteristica}>";

            Console.Write($"Características da raça: <{car}>\n");

            if (EssenciasDeRaca == null) throw new NullReferenceException("As essências da raça estão nulas!");

            var essencia = string.Empty;
            foreach (var essenciaDaRaca in EssenciasDeRaca)
                essencia += $"<{essenciaDaRaca.Nome}>";

            Console.Write($"Essências da raça: <{essencia}>\n");

            var essenciasRejeitadas = string.Empty;
            foreach (var essenciaRejeitada in EssenciasIncompativeis)
                essenciasRejeitadas += $"<{essenciaRejeitada.Nome}>";

            Console.Write($"Essências incompatíveis: <{essenciasRejeitadas}>\n");

            if (LinhagensDeRaca == null) throw new NullReferenceException("As linhagens da raça estão nulas!");

            var linhagem = string.Empty;
            foreach (var linhagemDaRaca in LinhagensDeRaca)
                linhagem += $"<{linhagemDaRaca.Nome}>";

            Console.Write($"Linhagens da raça: <{linhagem}>\n");

            var linhagensRejeitadas = string.Empty;
            foreach (var linhagemRejeitada in LinhagensIncompativeis)
                linhagensRejeitadas += $"<{linhagemRejeitada.Nome}>";

            Console.Write($"Linhagens incompatíveis: <{linhagensRejeitadas}>\r\n");

        }

        public void PopularLista<T>(List<T> receptor, List<T> valores)
        {
            GenesesSouza.CSharpUtils.Collections.PopulateCollection(receptor, valores);
        }
    }
}
