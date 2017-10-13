namespace Coursera.Patterns.NullObject
{
    public class DescontoPercentual : IDesconto
    {
        private readonly double _valor;

        public DescontoPercentual(double valor)
        {
            _valor = valor;
        }

        public double DarDesconto(double valorOriginal) => valorOriginal - valorOriginal * (_valor / 100);
    }
}