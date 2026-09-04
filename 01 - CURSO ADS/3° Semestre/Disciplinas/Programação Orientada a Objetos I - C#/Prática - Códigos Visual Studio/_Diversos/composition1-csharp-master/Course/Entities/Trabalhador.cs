using Course.Entities.Enums;
using System.Collections.Generic;//classe List

namespace Course.Entities
{
    class Trabalhador
    {
        public string Nome { get; set; }
        public NivelTrabalhador Nivel { get; set; }
        public double BaseSalarial { get; set; }
        public Departamento Departamento { get; set; } // composição com departamento
        public List<HorasContrato> Contratos { get; private set; } = new List<HorasContrato>();

        public Trabalhador()// construtor vazio
        {
        }
        public Trabalhador(string nome, NivelTrabalhador nivel, double baseSalarial, Departamento departamento)// construtor argumentos não passo a lista
        {
            Nome = nome;
            Nivel = nivel;
            BaseSalarial = baseSalarial;
            Departamento = departamento;
            Contratos = new List<HorasContrato>();
        }
        public void AddContract(HorasContrato contrato)
        {
            Contratos.Add(contrato); // adiciona o contrato a lista de contratos
        }

        public void RemoveContract(HorasContrato contrato)
        {
            Contratos.Remove(contrato);
        }
        public double Income(int ano, int mes)//ganho do trabalhador
        {
            double sum = BaseSalarial; // todo trabalhador tem uma base de contrato
            foreach (HorasContrato contract in Contratos) // para cada contrato na lista de contratos fazer o if abaixo
            {
                if (contract.Data.Year == ano && contract.Data.Month == mes)// o mês e o ano for igual a data, fará parte da soma
                {
                    sum += contract.TotalValue();// retorna o valor do contrato daquele ano e mês especificado.
                }
            }
            return sum;
        }
    }
}
