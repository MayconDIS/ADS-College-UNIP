using System;
using System.Text;
using System.Globalization;
using System.Collections.Generic;
using Course.Entities.Enums;

namespace Course.Entities
{
    class Compra
    {
        public DateTime Moment { get; set; }
        public EstadoCompra Status { get; set; }
        public Cliente Cliente { get; set; }
        public List<ItemCompra> Items { get; set; } = new List<ItemCompra>();

        public Compra()
        {
        }

        public Compra(DateTime moment, EstadoCompra status, Cliente client)
        {
            Moment = moment;
            Status = status;
            Cliente = client;
        }

        public void AddItem(ItemCompra item)
        {
            Items.Add(item);
        }

        public void RemoveItem(ItemCompra item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double sum = 0.0;
            foreach (ItemCompra item in Items) {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Momento da compra: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Status da compra: " + Status);
            sb.AppendLine("Cliente: " + Cliente);
            sb.AppendLine("Items da compra:");
            foreach (ItemCompra item in Items)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Preço Total : $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
