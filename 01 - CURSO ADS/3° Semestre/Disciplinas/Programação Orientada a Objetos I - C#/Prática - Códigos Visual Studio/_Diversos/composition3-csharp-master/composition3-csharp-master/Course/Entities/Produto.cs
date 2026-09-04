namespace Course.Entities
{
    class Produto
    {
        public string Nome { get; set; }
        public double PrecoItem { get; set; }

        public Produto()
        {
        }

        public Produto(string name, double price)
        {
            Nome = name;
            PrecoItem = price;
        }
    }
}
