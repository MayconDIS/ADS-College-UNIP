


using System;
using System.Globalization;

namespace ProdutoEmEstoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("Geladeira", 1300.00, 120);
            p.Nome = "TV" ;
            //p.Preco = 100.00;
            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
            Console.WriteLine(p.Quantidade);
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine("Aperte uma tecla para sair");
            Console.ReadLine();



            /*        Console.WriteLine("Entre os dados do produto:");
                    Console.Write("Nome: ");
                   // p.Nome = Console.ReadLine(); utilizando o construtor
                   
                    Console.Write("Preço: ");
                    //  p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);utilizando o construtor
                    double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    //Console.Write("Quantidade no estoque: ");
                    // p.Quantidade = int.Parse(Console.ReadLine());utilizando o construtor
                    int quantidade = int.Parse(Console.ReadLine());
                    ProdutoAutoProp p = new ProdutoAutoProp(nome, preco, quantidade);// instanciando utilizando o construtor
                 //   Produto p = new Produto(nome, preco);// iniciando o construtor de 2 argumentos
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
                    ProdutoAutoProp p2 = new ProdutoAutoProp("Geladeira", 1500.00, 120);
                    Console.WriteLine("\nDados atualizados: " + p2);
                 */


        }
    }
}