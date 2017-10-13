namespace Coursera.Patterns.Composite
{
    public class TrechoAereoSimples : ITrechoAereo
    {
        private readonly string _origem;
        private readonly string _destino;
        private readonly int _custo;
        private readonly int _distancia;
        public TrechoAereoSimples(string origem, string destino, int custo, int distancia)
        {
            _origem = origem;
            _destino = destino;
            _custo = custo;
            _distancia = distancia;
        }

        public string Origem => _origem;

        public string Destino => _destino;

        public int Custo => _custo;

        public int Distancia => _distancia;
    }
}