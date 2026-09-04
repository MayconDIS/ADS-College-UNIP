
namespace TerceiroProjeto
{
   internal class Classe1
    {
        private double _atb1;
        private int _atb2 ;
        private string _atb3;

        public Classe1()
        {

        }
        public Classe1(double atb1, int atb2, string atb3)
        {
            _atb1 = atb1;
            _atb2 = atb2;
            _atb3 = atb3;
        }

        public double GetAtb1()
        {
            return _atb1;
        }
        public int GetAtb2()
        {
            return _atb2;
        }
        public string GetAtb3()
        {
            return _atb3;
        }
        public void SetAtb1(double atributo1)
        {
            _atb1 = atributo1;
        }
        public void SetAtb2(int atributo2)
        {
            _atb2 = atributo2;
           // _atb2 = int.Parse(Console.ReadLine());
        }
        public void SetAtb3(string atributo3)
        {
            _atb3 = atributo3;
        }
        public void Exibir()//método Exibir
        {
            Console.WriteLine("Atributo1: " + _atb1);
            Console.WriteLine("Atributo2: " + _atb2);
            Console.WriteLine("Atributo3: " + _atb3);
        }
    }
}
