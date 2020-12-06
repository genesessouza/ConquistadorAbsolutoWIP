using ConquistadorAbsolutoBiblioteca.Entidade;
using ConquistadorAbsolutoBiblioteca.Entidade.Origem;
using ConquistadorAbsolutoBiblioteca.Essencia;
using ConquistadorAbsolutoBiblioteca.Linhagem;
using ConquistadorAbsolutoBiblioteca.Origem.Receptor;
using ConquistadorAbsolutoBiblioteca.Raca;

namespace ConquistadorAbsolutoBiblioteca
{
    public static class Fabrica
    {
        public static IEssencia CriarEssencia()
        {
            return new BaseDeEssencia();
        }

        public static IRaca CriarRaca()
        {
            return new BaseDeRaca();
        }

        public static ILinhagem CriarLinhagem()
        {
            return new BaseDeLinhagem();
        }

        public static IEntidade CriarEntidade()
        {
            return new BaseDeEntidade();
        }

        public static INucleo CriarNucleoDeOrigem()
        {
            return new BaseDeNucleo();
        }

        public static IReceptor CriarReceptor()
        {
            return new BaseDeReceptor();
        }
    }
}
