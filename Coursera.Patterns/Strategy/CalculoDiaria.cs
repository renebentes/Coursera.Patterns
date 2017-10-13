using System;

namespace Coursera.Patterns.Strategy
{
    public class CalculoDiaria : ICalculo
    {
        private readonly int _valorDiaria;

        public CalculoDiaria(int valorDiaria)
        {
            _valorDiaria = valorDiaria;
        }

        public int CalcularTarifa(int quantidadeHora) => _valorDiaria * (int)Math.Ceiling(quantidadeHora / 24.0);
    }
}