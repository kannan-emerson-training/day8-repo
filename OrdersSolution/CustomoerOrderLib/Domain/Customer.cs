using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CustomoerOrderLib.Domain
{
    public class Customer:DomainEntity
    {
        
        private readonly string _name;
        private List<Order> _orders;

        public Customer(string id, string name):base(id)
        {
            
            _name = name;
            _orders = new List<Order>();

        }

        public void AddOrder(Order order)
        {
            _orders.Add(order);
        }

        public List<Order> Orders
        {
            get
            {
                return _orders;
            }
        }
       

        public string Name
        {
            get
            {
                return _name;
            }
        }

    }
}
