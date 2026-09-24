using System;
namespace ConsoleProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();
            Produto p2 = new Produto("Geladeira", 50);
            Produto p3 = new Produto("Fogão", 50, 120.00);
            Console.WriteLine("Entre com o valor do produto2");
            p2.SetPreco(double.Parse(Console.ReadLine()));
            Console.WriteLine(p);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
            Console.ReadKey();
            /*
            string nome = Console.ReadLine();
            p2.SetNome(nome);
            Console.WriteLine(p2);
            
            
            Console.WriteLine("Entre com os dados do produto");
            Console.Write("Nome: ");
            //  p.Nome = Console.ReadLine();
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
             //  p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //  Console.Write("Quantidade no estoque: ");
            //  p.Quantidade = int.Parse(Console.ReadLine());
            Produto p = new Produto(nome, preco);
            // Console.WriteLine("Dados do Produto: "+p.Nome+" R$"+p.Preco);
            //Console.WriteLine("Dados do Produto: " + p);
            Console.WriteLine("Dados do Produto: " + p);
            Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Produto p2 = new Produto("Panela", 100, 12.00);
            Console.WriteLine("\nDados atualizados: " + p2);
            Console.ReadKey();
            */
        }
    }
}
