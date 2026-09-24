using System;
using System.Globalization;

namespace ProdutoEmEstoque
{
    class Program
    {
        static void Main(string[] args)
        {                      
         Produto2 p = new Produto2("Geladeira", 1300.00,15);
         Console.WriteLine(p.Nome);
         Console.WriteLine(p.Preco);
         Console.WriteLine(p.Quantidade);
         Console.WriteLine("Dados atualizados: " + p);
         Console.WriteLine("Aperte uma tecla para sair");
         Console.ReadLine();
            


/*
            Produto2This p = new Produto2This();
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine(); 
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());          
            
            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProduto2s(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProduto2s(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();
            Console.ReadLine();
  */          //#########UTILIZANDO O CONSTRUTOR #######################################
/*
            Console.WriteLine("Entre com os dados do produto: Nome, Preço e Quantidade");
            string nome  = Console.ReadLine();
            double preco = double.Parse(Console.ReadLine());
            int quantidade = int.Parse(Console.ReadLine());            
            Produto2 p = new Produto2(nome, preco, quantidade);
            Console.WriteLine("Dados atualizados: " + p);
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProduto2s(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProduto2s(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();
            Console.ReadLine();
*/
        }
    }
}