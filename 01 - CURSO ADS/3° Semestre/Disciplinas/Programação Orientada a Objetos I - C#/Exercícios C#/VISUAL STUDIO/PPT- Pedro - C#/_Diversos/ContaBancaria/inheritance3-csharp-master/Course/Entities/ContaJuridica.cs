namespace Course.Entities{
    class ContaJuridica : ContaComum    {
        public double LimitEmprestimo { get; set; }
        public ContaJuridica()
        {
        }
        public ContaJuridica(int numero, string titular, double saldo, double limitEmprestimo) 
            : base(numero, titular, saldo)
        {
            LimitEmprestimo = limitEmprestimo;
        }
        public void Emprestimo(double quantia)
        {
            if (quantia <= LimitEmprestimo)
            {
                Saldo += quantia;
            }
        }
    }
}
