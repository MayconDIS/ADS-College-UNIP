namespace Course.Entities{
    class ContaPoupanca : ContaComum    {
        public double TaxaDeJuros { get; set; }
        public ContaPoupanca()
        {
        }
        public ContaPoupanca(int numero, string titular, double saldo, double taxaDeJuros)
            : base(numero, titular, saldo)
        {
            TaxaDeJuros = taxaDeJuros;
        }
        public void AtualizaSaldo()
        {
            Saldo += Saldo * TaxaDeJuros;
        }
        public override void Saque(double quantia)
        {
            base.Saque(quantia);
            Saldo -= 2.0;
        }
    }
}
