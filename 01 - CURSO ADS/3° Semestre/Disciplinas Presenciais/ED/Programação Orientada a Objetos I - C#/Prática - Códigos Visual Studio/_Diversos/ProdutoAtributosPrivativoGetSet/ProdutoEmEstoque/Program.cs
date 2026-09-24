


using System;
using System.Globalization;

namespace ProdutoEmEstoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("Geladeira", 15);
            p.SetNome("T");
            //p.SetPreco(1200.00);
            Console.WriteLine(p.GetNome());
            Console.WriteLine(p.GetPreco());
            Console.WriteLine(p.GetQuantidade());
            /*
                        Console.WriteLine("Entre os dados do produto:");
                        Console.Write("Nome: ");
                       // p.Nome = Console.ReadLine(); utilizando o construtor
                       string nome = Console.ReadLine();
                        Console.Write("Preço: ");
                        //  p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);utilizando o construtor
                        double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        //Console.Write("Quantidade no estoque: ");
                        // p.Quantidade = int.Parse(Console.ReadLine());utilizando o construtor
                       // int quantidade = int.Parse(Console.ReadLine());
                      //  Produto p = new Produto(nome, preco, quantidade);// instanciando utilizando o construtor
                        Produto p = new Produto(nome, preco);// iniciando o construtor de 2 argumentos
                        Console.WriteLine();
                        Console.WriteLine("Dados do produto: " + p);
                        Console.WriteLine();
                        Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
                        int qte = int.Parse(Console.ReadLine());
                        p.AdicionarProdutos(qte);
                        Console.WriteLine();
                        Console.WriteLine("Dados atualizados: " + p);
                        Console.WriteLine();
                        Console.Write("Digite o número de produtos a ser removido do estoque: ");
                        qte = int.Parse(Console.ReadLine());
                        p.RemoverProdutos(qte);
                        Console.WriteLine();
                        Console.WriteLine("\nDados atualizados: " + p);
                        Console.WriteLine();
                        Produto p2 = new Produto("Geladeira", 1500.00, 120);
                        Console.WriteLine("\nDados atualizados: " + p2);
                        */
            Console.WriteLine("Aperte uma tecla para sair");
            Console.ReadLine();

        }
    }
}