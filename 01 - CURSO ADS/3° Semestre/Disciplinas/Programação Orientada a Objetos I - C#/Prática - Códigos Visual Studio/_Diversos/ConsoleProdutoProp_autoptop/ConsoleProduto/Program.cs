using System;

namespace ConsoleProduto
{
    class Program
    { 
     static void Main(string[] args)
    {
        Produto p = new Produto();      
        p.SetNome("Fogão");
        p.SetQuantidade(10);
        p.SetPreco(120.00);
        p.Exibir();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(p.GetNome());
        Console.WriteLine(p.GetPreco());
        Console.WriteLine(p.GetQuantidade());

        Product p2 = new Product(1300.00); //construtor
            p2.Nome = Console.ReadLine(); // properties
            p2.Quantity = int.Parse(Console.ReadLine()); //funciona sem o private
            p2.Exibir();
        Console.WriteLine();
        Console.WriteLine();

        
        //p2.Price = double.Parse(Console.ReadLine()); //não funciona
        
        Console.WriteLine(p2.Nome);
        Console.WriteLine(p2.Price);
        Console.WriteLine(p2.Quantity);

        Console.ReadKey();
        /*
        Console.WriteLine("Entre com o nome do 2o. produto:");
        p2.Nome(Console.ReadLine());            
        Console.WriteLine("Entre com o valor do 2o. produto:");            
        p2.Preco(double.Parse(Console.ReadLine()));
        Console.WriteLine("Entre com a quantidade do 2o. produto:");
        p2.Quantidade(int.Parse(Console.ReadLine()));
        //Console.WriteLine("Nome do produto: " + p2.GetNome());
        p2.Exibir();
        Console.ReadKey();
        */
        // Console.WriteLine("Valor: " + p.GetPreco());
        //  Console.WriteLine("Quantidade: " + p.GetQuantidade());
        //  Console.WriteLine(); Console.WriteLine();
        //p.AdicionarProdutos(10);


        /*
        p.Nome = Console.ReadLine();            
        Console.Write("Preço: ");
        p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Quantidade no estoque: ");
        p.Quantidade = int.Parse(Console.ReadLine());
        Console.WriteLine("Dados do Produto: "+p.Nome+" R$"+p.Preco);
        Console.WriteLine("Dados do Produto: " + p.Quantidade);

        Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque: ");
        int qte = int.Parse(Console.ReadLine());
        p.AdicionarProdutos(qte);
        Console.WriteLine();
        Console.WriteLine("Dados atualizados: " + p.Quantidade);
        Console.WriteLine();
        Console.WriteLine("Digite o número de produtos a ser removido do estoque: ");
        qte = int.Parse(Console.ReadLine());
        p.RemoverProdutos(qte);
        Console.WriteLine();
        Console.WriteLine("Dados atualizados: " + p.Quantidade);
        Produto p2 = new Produto("Panela", 100, 12.00);
        p2.Exibir();
        Console.ReadKey();
        */
    }
}
}
