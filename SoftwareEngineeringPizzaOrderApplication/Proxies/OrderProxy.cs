using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineeringPizzaOrderApplication
{
    class OrderProxy
    {
        PizzaApplicationDatabaseDataSetTableAdapters.OrderTableAdapter orderTableAdapter;
        PizzaApplicationDatabaseDataSetTableAdapters.OrderItemTableAdapter orderItemTableAdapter;

        public OrderProxy()
        {
            this.orderTableAdapter = new PizzaApplicationDatabaseDataSetTableAdapters.OrderTableAdapter();
            this.orderItemTableAdapter = new PizzaApplicationDatabaseDataSetTableAdapters.OrderItemTableAdapter();
        }

        public void validateOrder(Order order)
        {
            if (order.customer == null || order.customer == "")
            {
                throw new Exception("Order must have a customer!");
            }

            if (order.time == null)
            {
                throw new Exception("Order must have a time!");
            }

            if (order.OrderItems == null || order.OrderItems.Count < 1)
            {
                throw new Exception("Orders must contain at least one order item!");
            }

            if (order.price <= 0)
            {
                throw new Exception("Order must have a price greater than 0!");
            }
        }

        public Order saveOrder(Order order)
        {
            validateOrder(order);

            object id = orderTableAdapter.InsertAndReturnOrderIdQuery(
                order.price,
                order.customer,
                order.time,
                order.completed);

            foreach (OrderItem orderItem in order.OrderItems)
            {
                orderItemTableAdapter.Insert(
                    Decimal.ToInt32((decimal)id),
                    orderItem.item,
                    orderItem.quantity);
            }

            return order;
        }

    }
}
