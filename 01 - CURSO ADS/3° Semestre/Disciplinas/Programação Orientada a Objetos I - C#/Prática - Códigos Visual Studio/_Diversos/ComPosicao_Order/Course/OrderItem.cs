using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    class OrderItem
    {
        private int _quantidade;
        private double _preco;
        public int SubTotal(int total)
        {
            return total = total - _quantidade;
        }
    }
}
