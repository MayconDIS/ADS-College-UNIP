using System;

namespace ConsoleProduto
{
    class Produto
    {
        protected string _nome;
        private int _quantidade;
        private double _preco;

        public Produto()
        {
        }

        public Produto(string nome, int quantidade, double preco)
        {
            _nome = nome;
            _quantidade = quantidade;
            _preco = preco;
        }

        public string GetNome()
        {
            return _nome;
        }
        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 1)
            {
                _nome = nome;
            }

        }
        public double GetPreco()
        {
            return _preco;
        }
        public void SetPreco(double preco)
        {
            _preco = preco;
        }
        public int GetQuantidade()
        {
            return _quantidade;
        }
        public void SetQuantidade(int quantidade)
        {
            _quantidade = quantidade;
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
        public void Exibir()
        {
            Console.WriteLine("Nome do produto " + _nome);
            Console.WriteLine("Quantidade do Produto: " + _quantidade);
            Console.WriteLine("Valor Total em Estoque: " + ValorTotalEmEstoque().ToString("F2"));
        }

        /*       public override string ToString()
               {
                   return "Nome: " + _nome
                       + ", R$"
                       + _preco.ToString("F2")
                       + "\n Quantidade em estoque:"
                       + _quantidade.ToString("F2")
                       + "\n Valor total em estoque: "
                       + ValorTotalEmEstoque().ToString("F2");
               }*/

    }
}