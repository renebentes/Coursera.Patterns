namespace Coursera.TarifaStrategy
{
    public class CalculoHora : ICalculo
    {
        private int _valorHora;

        public CalculoHora(int valorHora)
        {
            _valorHora = valorHora;
        }

        public int CalcularTarifa(int quantidadeHora) => _valorHora * quantidadeHora;
    }
}