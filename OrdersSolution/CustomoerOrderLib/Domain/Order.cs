using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomoerOrderLib.Domain
{
    public class Order:DomainEntity
    {
       
        private readonly string _name;
        private readonly DateTime _date;
        private readonly List<OrderItem> _basketItems;
        public Order(string id, string name, DateTime date):base(id)
        {
            
            _name = name;
            _date = date;
            _basketItems = new List<OrderItem>();
        }

        public void AddOrderItem(OrderItem item)
        {
            _basketItems.Add(item);
        }

        public List<OrderItem> GetOrderItems() {
           
                return _basketItems;
            
        }

        public string Name {
            get {
                return _name;
            }
        }

        public DateTime Date { 
          get { return _date; }
        }

        public double CheckOutPrice() {
            double price = 0;
            foreach (OrderItem item in _basketItems)
            {
                price += item.CalcuateTotal();
            
            }
            return price;
        }

    }
}
