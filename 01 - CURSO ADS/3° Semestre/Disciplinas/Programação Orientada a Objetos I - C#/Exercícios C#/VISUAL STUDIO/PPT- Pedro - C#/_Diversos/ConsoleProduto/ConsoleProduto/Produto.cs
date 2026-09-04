using System.Globalization;

namespace ConsoleProduto
{
    class Produto
    {
        private string _nome;
        private int _quantidade;
        private double _preco;
        public Produto()
        {
        }
        public Produto(string nome, int quantidade)
        {
            _nome = nome;
            _quantidade = quantidade;
        }
        public Produto(string nome, int quantidade, double preco)
        {
            _nome = nome;
            _quantidade = quantidade;
            _preco = preco;
        }
        public void SetNome(string nome)
        {
             _nome = nome;
        }
        public void SetPreco(double preco)
        {
            _preco = preco;
        }

        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }
          public int AdicionarProdutos(int quantity)
          {
            return _quantidade = _quantidade + quantity;
          }
          public int RemoverProdutos(int quantity)
          {
            return _quantidade = _quantidade - quantity;
        }
        public override string ToString()
        {
            return _nome 
                + ": R$" 
                + _preco.ToString("F2")
                + "\nQuantidade em estoque:"
                + _quantidade.ToString("F2")
                + "\nValor total em estoque: "
                + ValorTotalEmEstoque().ToString("F2")
                + "\n########################";
        }

    }
}
