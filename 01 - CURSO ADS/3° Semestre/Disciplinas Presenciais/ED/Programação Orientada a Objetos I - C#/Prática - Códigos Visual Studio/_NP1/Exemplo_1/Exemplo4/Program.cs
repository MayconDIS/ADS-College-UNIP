using Exemplo4;
// Carro
// OBJETO = Carro físico produzido na fábrica

Carro meuCarro = new Carro("Fusca", "Azul");   // Objeto 1
Carro seuCarro = new Carro("Uno", "Vermelho"); // Objeto 2 (instância independente!)
Console.Write(meuCarro.Modelo);
Console.Write(" " );
Console.WriteLine(meuCarro.Cor);
Console.Write( seuCarro.Modelo);
Console.Write(" ");
Console.WriteLine(seuCarro.Cor);
