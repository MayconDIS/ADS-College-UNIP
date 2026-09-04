using System;
using static System.Console;
namespace EncapsulamentoPublico
{
    class Program
    {
        static void Main(string[] args)
        {
            /*######### Sem construtor ################
            Retangulo r = new Retangulo();
             WriteLine("Informe o comprimento: ");
             r.Comprimento = double.Parse(Console.ReadLine());
             WriteLine("Informe a largura : ");
             r._largura = Convert.ToDouble(Console.ReadLine());
             r.Exibir();
             ReadLine();*/
             WriteLine("Informe o comprimento: ");
           double X = double.Parse(Console.ReadLine());
           WriteLine("Informe a largura : ");
           double Y = Convert.ToDouble(Console.ReadLine());
           Retangulo r = new Retangulo(X, Y);
           r.Exibir();
           ReadLine();

            DateTime d1 = DateTime.Now;
            DateTime d2 = DateTime.UtcNow;
            DateTime d3 = DateTime.Today;
            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            DateTime d4 = new DateTime(2000, 8, 15, 13, 5, 58, 275);
            Console.WriteLine(d4);
            TimeSpan t1 = new TimeSpan();
            TimeSpan t2 = new TimeSpan(900000000L);
            TimeSpan t3 = new TimeSpan(2, 11, 21);
            TimeSpan t4 = new TimeSpan(1, 2, 11, 21);
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            ReadKey();


        }
   }
}
