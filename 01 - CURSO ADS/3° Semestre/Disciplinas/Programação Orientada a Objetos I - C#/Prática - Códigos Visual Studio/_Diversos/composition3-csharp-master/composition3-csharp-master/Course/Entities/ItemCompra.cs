using System.Globalization;

namespace Course.Entities
{
    class ItemCompra
    {
        public int Quantidade { get; set; }
        public double PrecoQde { get; set; }
        public Produto Produto { get; set; }

        public ItemCompra()
        {
        }

        public ItemCompra(int quantity, double price, Produto product)
        {
            Quantidade = quantity;
            PrecoQde = price;
            Produto = product;
        }

        public double SubTotal()
        {
            return PrecoQde * Quantidade;
        }

        public override string ToString()
        {
            return Produto.Nome
                + ", $"
                + PrecoQde.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantidade: "
                + Quantidade
                + ", Subtotal: $"
                + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
