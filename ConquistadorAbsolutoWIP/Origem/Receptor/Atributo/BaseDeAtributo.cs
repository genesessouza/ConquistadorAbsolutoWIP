namespace ConquistadorAbsolutoBiblioteca.Origem.Receptor.Atributo
{
    public sealed class BaseDeAtributo : IAtributo
    {
        public string NomeDoAtributo { get; set; }
        public float ValorDoAtributo { get; set; }

        public BaseDeAtributo(string NomeDoAtributo, float ValorDoAtributo)
        {

        }
    }
}