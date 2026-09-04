namespace Course.Entities
{
    class ContaComum
    {
        public int Numero { get; private set; }
        public string Titular { get; private set; }
        public double Saldo { get; protected set; }

        public ContaComum()
        {
        }
        public ContaComum(int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }
        public virtual void Saque(double quantia)
        {
            Saldo -= quantia ;
        }
        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }
    }
}
