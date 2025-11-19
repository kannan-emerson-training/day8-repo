using CustomoerOrderLib;
using CustomoerOrderLib.Domain;

namespace CustomerConsoleClient
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var customerHemang = new Customer("C1001", "Hemang");
            var orderOfDecember = new Order( id: "Ord1", name: "DecemberOrder",date:DateTime.Now);
            var laptopItem = new OrderItem("bakset1", "Laptop", 20000, 2);
            var smartvItem = new OrderItem("basket2", "Smart Tv", 50000, 1);
            orderOfDecember.AddOrderItem(laptopItem);
            orderOfDecember.AddOrderItem(smartvItem);
            customerHemang.AddOrder(orderOfDecember);
            PrintInfo(customerHemang);


        }

        private static void PrintInfo(Customer customer)
        {
            Console.WriteLine($"id {customer.Id}  and name {customer.Name}");
            Console.WriteLine($"No of orders placed {customer.Orders.Count} ");
            var orders= customer.Orders;
            foreach (Order order in orders)
            {
               
                var basketItems = order.GetOrderItems();

                foreach (OrderItem item in basketItems)
                {
                    Console.WriteLine($"item {item.Id} , {item.Name} ,{item.CalcuateTotal()}");
                }

                Console.WriteLine($"{order.Id} , {order.Name} ,{order.CheckOutPrice()}");
              

            }

        }
    }
}
