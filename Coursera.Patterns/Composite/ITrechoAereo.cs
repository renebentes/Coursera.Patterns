namespace Coursera.Patterns.Composite
{
    public interface ITrechoAereo
    {
        string Origem { get; }
        string Destino { get; }
        int Custo { get; }
        int Distancia { get; }
    }
}