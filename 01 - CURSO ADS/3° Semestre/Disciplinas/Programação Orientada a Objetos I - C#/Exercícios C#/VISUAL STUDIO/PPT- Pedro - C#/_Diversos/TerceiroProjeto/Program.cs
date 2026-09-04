using TerceiroProjeto;

Console.WriteLine("Terceiro Código em C#");

Classe1 p = new Classe1();

p.SetAtb1(12.35444);
Console.WriteLine("Entre com o Atributo2:");
p.SetAtb2(int.Parse(Console.ReadLine()));
//int atributo2 = int.Parse(Console.ReadLine());
//p.SetAtb2(atributo2);
p.SetAtb3("Produto UM");


Console.WriteLine("\n############CW Program################\n");
Console.WriteLine("Atributo1: " + p.GetAtb1());
Console.WriteLine("Atributo2: " + p.GetAtb2());
Console.WriteLine("Atributo3: " + p.GetAtb3());
Console.WriteLine("\n############CW Exibir##################\n");
p.Exibir();
Console.WriteLine("\n##############################\n");
p = new Classe1(32.521, 13, "Produto DOIS");
p.Exibir();

Console.WriteLine("\n############Entradas Teclado##################\n");
