using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.Write("Digite a data de nascimento (dd/MM/yyyy): ");
        string entrada = Console.ReadLine();

        // Tenta converter a string para DateTime no formato brasileiro
        if (DateTime.TryParseExact(entrada, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataNascimento))
        {
            DateTime hoje = DateTime.Today;
            int idade = hoje.Year - dataNascimento.Year;

            // Se ainda não fez aniversário este ano, subtrai 1
            if (hoje < dataNascimento.AddYears(idade))
            {
                idade--;
            }

            // Validação para data futura
            if (idade < 0)
            {
                Console.WriteLine("Data de nascimento inválida (data no futuro).");
            }
            else
            {
                Console.WriteLine($"A idade da pessoa é: {idade} anos.");
            }
        }
        else
        {
            Console.WriteLine("Data inválida! Use o formato dd/MM/yyyy.");
        }

        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
