using aula1;

internal class Program
{
    private static void Main(string[] args)
    {
        Pessoa p1 = new Pessoa("Pedro",58,123456789,20);
        p1.Apresentar();
        Pessoa p2 = new Pessoa();
        p2._nome = "João";
        p2._idade = 48;
        p2._cpf = 987654321;
        p2._valid_cpf = 22;
        p2.Apresentar();
    }
}