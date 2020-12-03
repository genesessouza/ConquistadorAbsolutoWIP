using System;
using System.Collections.Generic;
using ConquistadorAbsolutoBiblioteca.Essencia;
using ConquistadorAbsolutoBiblioteca.Linhagem;
using ConquistadorAbsolutoBiblioteca.Raca;

namespace ConquistadorAbsolutoBiblioteca.Entidade
{
    public sealed class BaseDeEntidade : IEntidade

    {
        public string Nome { get; set; }
        public Alinhamento Alinhamento { get; set; }
        public float Poder { get; set; }
        public IRaca Casta { get; set; }
        public List<IEssencia> EssenciasPossuidas { get; set; }
        public List<ILinhagem> LinhagensHerdadas { get; set; }

        public BaseDeEntidade()
        {
            Casta = Fabrica.CriarRaca();
            EssenciasPossuidas = new List<IEssencia>();
            LinhagensHerdadas = new List<ILinhagem>();
        }

        public void VerOrigens()
        {
            Console.Write("\n-----------------------Essências-----------------------\n");
            foreach (var essencia in EssenciasPossuidas)
                essencia.MostrarAtributos();

            Console.Write("\n-----------------------Linhagens---------------------\n");
            foreach (var linhagem in LinhagensHerdadas)
                linhagem.MostrarAtributos();
        }

        public void MostrarEntidade()
        {
            Console.Write
            (
                $"\n--------------------------------------Informações sobre a Entidade--------------------------------------\n" +
                $"Nome: <{Nome}> Raça: <{Casta.Nome}> Titulos: <> Poder de Origem: <{Poder}> Alinhamento: <{Alinhamento}>\r\n"
            );
            Casta.MostrarAtributos();
            VerOrigens();
        }
    }
}
