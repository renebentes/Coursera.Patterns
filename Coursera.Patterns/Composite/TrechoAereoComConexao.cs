namespace Coursera.Patterns.Composite
{
    public class TrechoAereoComConexao : TrechoAereoComEscala
    {
        private readonly int _tarifa;

        public TrechoAereoComConexao(ITrechoAereo trechoInicial, ITrechoAereo trechoFinal, int tarifa)
            : base(trechoInicial, trechoFinal)
        {
            _tarifa = tarifa;
        }

        public override int Custo => base.Custo + _tarifa;
    }
}