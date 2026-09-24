
namespace AreaRetanguloTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {

            Triangulo t = new Triangulo();
            t.InformarValores();
            t.Exibir();
            Console.ReadLine();
        }
    }
}



/*
 * Triangulo x = new Triangulo();
Retangulo r = new Retangulo();
double area;
Console.WriteLine();
Console.WriteLine("Entre com as medidas do triângulo X:");
x.A = double.Parse(Console.ReadLine());
x.B = double.Parse(Console.ReadLine());
x.C = double.Parse(Console.ReadLine());
//double  q  = x.SemiPerimetro();
area = x.AreaTriangulo();
Console.WriteLine("Área de X = " + area.ToString("F2"));
Console.WriteLine("Entre com as medidas do triângulo X:");
x.A = double.Parse(Console.ReadLine());
x.B = double.Parse(Console.ReadLine());
x.C = double.Parse(Console.ReadLine());
//         ############### RETANGULO ####################
Console.WriteLine("Entre com as medidas do RETANGULO R:");
r.A = double.Parse(Console.ReadLine());
r.B = double.Parse(Console.ReadLine());
area = r.AreaRetangulo();
r.SemiPerimetro();
Console.WriteLine("Área de r = " + area.ToString("F3"));
//Console.WriteLine("Semi perímetro r = " + q.ToString("F2"));
Console.ReadKey();

}

}
}*/
