namespace ConquistadorAbsolutoWIP.Origem
{
    public abstract class ReveladorDaOrigem
    {
        private protected virtual void RevelarAtributos(string nome, string tipo, float poder)
        {
            System.Console.WriteLine($"Nome: <{nome}> Tipo de Origem: <{tipo}> Poder: <{poder}>");
        }
    }
}
