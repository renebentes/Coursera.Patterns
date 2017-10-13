namespace Coursera.Patterns.Composite
{
    public class TrechoAereoComConexao : TrechoAereoComEscala
    {
        private readonly int _taxa;

        public TrechoAereoComConexao(TrechoAereoSimples trechoInicial, TrechoAereoSimples trechoFinal, int taxa)
            : base(trechoInicial, trechoFinal)
        {
            _taxa = taxa;
        }

        public override int Custo => base.Custo + _taxa;
    }
}