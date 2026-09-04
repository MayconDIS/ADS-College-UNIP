using System;
using Course.Entities.Enums;



namespace Course.Entities {
    class Order {
        private DateTime _moment;
        private OrderStatus status;


        public int AddItem(OrderItem quantidade, OrderItem preco)
        {
            
        }
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }        

        public override string ToString() {
            return Id
                + ", "
                + Moment
                + ", "
                + Status;
        }
    }
}
