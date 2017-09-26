namespace Coursera.Patterns.NullObject
{
    public class Item
    {
        private readonly IDesconto _desconto = new SemDesconto();
        private readonly string _nome;
        private readonly double _valor;

        public Item(string nome, double valor)
        {
            _nome = nome;
            _valor = valor;
        }

        public Item(string nome, double valor, IDesconto desconto) : this(nome, valor)
        {
            _desconto = desconto;
        }

        public double PrecoQuantidade(int quantidade) => _desconto.DarDesconto(_valor) * quantidade;

        public override string ToString() => $"{_nome} R${_desconto.DarDesconto(_valor)}";
    }
}