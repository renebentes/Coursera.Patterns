namespace Coursera.TarifaStrategy
{
    public class CalculoHoraValorInicial : ICalculo
    {
        private int _limiteHorasInicial;
        private int _valorHoraExcedente;
        private int _valorInicial;

        public CalculoHoraValorInicial(int valorInicial, int limiteHorasInicial, int valorHoraExcedente)
        {
            _valorInicial = valorInicial;
            _limiteHorasInicial = limiteHorasInicial;
            _valorHoraExcedente = valorHoraExcedente;
        }

        public int CalcularTarifa(int quantidadeHora)
        {
            var valor = _valorInicial;

            if (quantidadeHora > _limiteHorasInicial)
            {
                valor += (quantidadeHora - _limiteHorasInicial) * _valorHoraExcedente;
            }

            return valor;
        }
    }
}