using System;


namespace SegundoProjeto
{
    class Classe1
    {
        private double _atb1;
        private int _atb2;
        private string _atb3;
        public Classe1()//contrutor vazio
        {
        }
        public Classe1(double atb1, int atb2, string atb3)// contrutor com 3 parâmetros
        {
            _atb1 = atb1;
            _atb2 = atb2;
            _atb3 = atb3;
        }
        public void Exibir()//método Exibir
        {
            Console.WriteLine("Atributo1: " + _atb1);
            Console.WriteLine("Atributo2: " + _atb2);
            Console.WriteLine("Atributo3: " + _atb3);
        }
    }

}
