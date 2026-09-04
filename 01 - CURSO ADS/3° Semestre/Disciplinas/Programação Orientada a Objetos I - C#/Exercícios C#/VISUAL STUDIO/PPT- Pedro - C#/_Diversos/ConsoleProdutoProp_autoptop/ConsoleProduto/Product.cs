using System;


namespace ConsoleProduto
{
    class Product
    {
        private string _name;
        public int Quantity {get;  set;}//autoproperties
        public double Price{ get;  private set; }

        public Product()
        {
        }

        public Product(string nome, int quantidade, double preco)
        {
            _name = nome;
            Quantity = quantidade;
            Price = preco;
        }
        public Product (double preco)
        {
            //  Quantity = quantidade;
            Price = preco;
        }
    public string Nome //PROPERTIES
        {
            get { return _name; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _name = value;
                }
            }
        }

        /*
       public string GetNome()
       {
           return _name;
       }
       public void SetNome(string nome)
       {
           if (nome != null && nome.Length > 1)
           {
               _name = nome;
           }
*/
        /* public double Preco
         {
             get { return _price; }
             set { _price = value; }
         }*/
        /*
        public double GetPreco()
        {
            return _price;
        }
        public void SetPreco(double preco)
        {
            _price = preco;
        }
        */
        /*
        public int Quantidade
        {
            get { return _quantity; }
            set { _quantity = value; }
        }
        */
        /*
        public int GetQuantidade()
        {
            return _quantity;
        }
        
        public void SetQuantidade(int quantidade)
        {
            _quantity = quantidade;
        }
        */

        public double ValorTotalEmEstoque()
        {
            return Price * Quantity;
        }

        public int AdicionarProdutos(int quantity)
        {
            return Quantity = Quantity + quantity;
        }
        public int RemoverProdutos(int quantity)
        {
            return Quantity = Quantity - quantity;
        }
        public void Exibir()
        {
            Console.WriteLine("Nome do produto " + _name);
            Console.WriteLine("Quantidade do Produto: " + Quantity);
            Console.WriteLine("Valor Total em Estoque: " + ValorTotalEmEstoque().ToString("F2"));
        }

        /*       public override string ToString()
               {
                   return "Nome: " + _nome
                       + ", R$"
                       + _preco.ToString("F2")
                       + "\n Quantidade em estoque:"
                       + _quantidade.ToString("F2")
                       + "\n Valor total em estoque: "
                       + ValorTotalEmEstoque().ToString("F2");
               }*/

    }
}