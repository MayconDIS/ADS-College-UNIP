using Course.Entities;
using Course.Entities.Enums;
using System;
using System.Globalization;
using static System.Console;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Entre com o nome do Departamento: ");
            string nomeDept = Console.ReadLine();
            Console.WriteLine("Entre com os dados do  trabalhador:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Nível: (Junior/MidLevel/Senior): ");
            NivelTrabalhador nivelT = Enum.Parse<NivelTrabalhador>(Console.ReadLine());
            Console.Write("Base salarial: ");
            double baseSalarial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Departamento dept = new Departamento(nomeDept);
            Trabalhador trabalhador = new Trabalhador(nome, nivelT, baseSalarial, dept);
            Console.Write("Quantos contratos possui o trabalhador? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Entre  dados do contrato:#{i}");
                Console.Write("Data (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Valor por hora: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duração (houras): ");
                int hours = int.Parse(Console.ReadLine());
                HorasContrato contract = new HorasContrato(date, valuePerHour, hours);// instanciando o contrato
                trabalhador.AddContract(contract);
            }
            Console.WriteLine();
            Console.Write("Entre com o mês e ano para calcular o ganho (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));// corta duas posiçoes a partir da zero (0 e 1)
            int year = int.Parse(monthAndYear.Substring(3,4));// corta 4 a partir da posiçao 3
            Console.WriteLine("Nome : " + trabalhador.Nome);
            Console.WriteLine("Departamento: " + trabalhador.Departamento.Nome);// acesso o trabalhador; depois o departamento e o nome do departamento
            Console.WriteLine("Ganho para " + monthAndYear + ": " 
                + trabalhador.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}
