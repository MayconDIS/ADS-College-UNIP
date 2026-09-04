using System;
using Course.Entities;
namespace Course{
    class Program    {
        static void Main(string[] args)
        {
            ContaComum acc1 = new ContaComum(1001, "Pedro Carlos", 500.0);
            ContaPoupanca acc2 = new ContaPoupanca(1002, "Felipe ", 500.0, 0.01);
            ContaJuridica acc3 = new ContaJuridica(1003, "Felipe ", 500.0,10000.00);
            //   ContaComum acc2 = new ContaPoupanca(1002, "Felipe ", 500.0, 0.01);
            //   ContaComum acc3 = new ContaJuridica(1003, "Felipe ", 500.0, 10000.00);


            acc1.Saque(10.0);
            acc2.Saque(10.0);
            acc3.Saque(10.0);
            acc2.AtualizaSaldo();

            Console.WriteLine(acc1.Saldo);
            Console.WriteLine(acc2.Saldo);
            Console.WriteLine(acc3.Saldo);
            Console.ReadKey();
        }
    }
}
