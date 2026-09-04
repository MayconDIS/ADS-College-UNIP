using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Veiculo
{
    internal class VeiculoAutoproperty
    {
            public string Modelo { get;  set; }
            public double Velocidade { get;  set; }
            public int Passageiro { get; set; }
            public string Combustivel { get; set; }

        public void Exibir()
        {
            Console.WriteLine("####### Classe VeiculoAutoproperty #############");
            Console.WriteLine("Modelo: " + Modelo);
            Console.WriteLine("Velocidade: " + Velocidade);
            Console.WriteLine("Passageiro: " + Passageiro);
            Console.WriteLine("Combustivel: " + Combustivel);
            Console.WriteLine("####################");
        }

    }
}
