using System;
using System.Globalization;
using Course.Entities;
using Course.Entities.Enums;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do cliente: ");
            Console.Write("Nome: ");
            string clientName = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Data de aniversário (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Entre com os dados da compra: ");
            Console.Write("Status: ");
            EstadoCompra status = Enum.Parse<EstadoCompra>(Console.ReadLine());

            Cliente client = new Cliente(clientName, email, birthDate);
            Compra order = new Compra(DateTime.Now, status, client);

            Console.Write("Quantos itens para a compra? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Entre #{i} dados do item:");
                Console.Write("Nome do Produto : ");
                string productName = Console.ReadLine();
                Console.Write("Preço do Produto : ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Produto product = new Produto(productName, price);

                Console.Write("Quantidade: ");
                int quantity = int.Parse(Console.ReadLine());

                ItemCompra orderItem = new ItemCompra(quantity, price, product);

                order.AddItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine("RESUMO DA COMPRA:");
            Console.WriteLine(order);
            Console.ReadKey();
        }
    }
}
