using System;

namespace Coursera.Patterns.Composite
{
    public class TrechoAereoComEscala : ITrechoAereo
    {
        private readonly ITrechoAereo _trechoInicial;
        private readonly ITrechoAereo _trechoFinal;

        public TrechoAereoComEscala(ITrechoAereo trechoInicial, ITrechoAereo trechoFinal)
        {
            if (trechoInicial.Destino != trechoFinal.Origem)
            {
                throw new ArgumentException();
            }

            _trechoInicial = trechoInicial;
            _trechoFinal = trechoFinal;
        }

        public string Origem => _trechoInicial.Origem;

        public string Destino => _trechoFinal.Destino;

        public virtual int Custo => _trechoInicial.Custo + _trechoFinal.Custo;

        public int Distancia => _trechoInicial.Distancia + _trechoFinal.Distancia;
    }
}