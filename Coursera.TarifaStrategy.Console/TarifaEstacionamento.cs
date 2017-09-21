namespace Coursera.TarifaStrategy
{
    public class TarifaEstacionamento
    {
        private readonly ICalculo _calculo;
        private readonly int _quantidadeHora;

        public TarifaEstacionamento(int quantidadeHora, ICalculo calculo)
        {
            _quantidadeHora = quantidadeHora;
            _calculo = calculo;
        }

        public int Valor()
        {
            return _calculo.CalcularTarifa(_quantidadeHora);
        }
    }
}