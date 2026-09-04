
namespace Veiculo
{
    internal class Veiculo
    {
        protected string modelo;
        protected double velocidade;
        protected int passageiro;
        protected string combustivel;

        public Veiculo()
        {
        }
        public Veiculo(string Mod, double Veloc, int Passag, string comb)
        {
            modelo = Mod;
            velocidade = Veloc;
            passageiro = Passag;
            combustivel = comb;
        }

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        public double Velocidade
        {
            get { return velocidade; }
            set { velocidade = value; }
        }
        public int Passageiro
        {
            get { return passageiro; }
            set { passageiro = value; }
        }
        public string Combustivel
        {
            get { return combustivel; }
            set { combustivel = value; }
        }
        public void Exibir()
        {
            Console.WriteLine("####### Classe Veiculo #############");
            Console.WriteLine("Modelo: " + modelo);
            Console.WriteLine("Velocidade: " + velocidade);
            Console.WriteLine("Passageiro: " + passageiro);
            Console.WriteLine("Combustivel: " + combustivel);
            Console.WriteLine("####################");
        }
    }
}
