
namespace Veiculo
{
    internal class Aeronave : Veiculo
    {
        private string _matricula;
        private string _tipo;
        private string _uso;
        public string Matricula
        {
            get { return _matricula; }
            set { _matricula = value; }
        }
        public string Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }
        public string Uso
        {
            get { return _uso; }
            set { _uso = value; }
        }
        public void ExibirAeronave()
        {
            Console.WriteLine("########Aeronave###########");             
             Console.WriteLine("Modelo: " + modelo);
             Console.WriteLine("Velocidade: " + velocidade);
             Console.WriteLine("Passageiro: " + passageiro);
             Console.WriteLine("Combustivel: " + combustivel);            
            Console.WriteLine("Matrícula: " + _matricula);
            Console.WriteLine("Tipo: " + _tipo);
            Console.WriteLine("Uso: " + _uso);            

        }
    }
}
