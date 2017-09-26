namespace Coursera.Patterns.NullObject
{
    public class DescontoAbsoluto : IDesconto
    {
        private readonly double _valor;

        public DescontoAbsoluto(double valor)
        {
            _valor = valor;
        }

        public double DarDesconto(double valorOriginal) => valorOriginal - _valor;
    }
}