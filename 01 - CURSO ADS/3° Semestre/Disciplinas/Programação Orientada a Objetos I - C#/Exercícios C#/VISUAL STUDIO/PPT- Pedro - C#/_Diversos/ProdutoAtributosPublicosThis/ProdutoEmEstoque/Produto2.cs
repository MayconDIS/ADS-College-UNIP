
namespace ProdutoEmEstoque
{
    class Produto2    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto2()
        {
            Quantidade = 12;
        }
        public Produto2(string nome, double preco) : this()
        {
            Nome = nome;
            Preco = preco;          
        }

        public Produto2(string nome, double preco, int quantidade): this(nome, preco)// criado o construtor
        {
            Quantidade = quantidade;
        }  

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return Nome
            + ", $ "
            + Preco.ToString("F2")
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2");
        }
    }
}
    

