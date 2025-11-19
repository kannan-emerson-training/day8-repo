using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsAndGenericsApp.Domain
{
     class OrderItem
    {
        
        public int Id { get; set; }//property
        public string Name { get;set; }

        public int Quantity { get; set; }
        public double UnitPrice { get; set; }

        public double TotalCost() {
            return Quantity * UnitPrice;
        }

        public override int GetHashCode()
        {
            return Id;
        }

        public override bool Equals(object second)
        {
            OrderItem other = second as OrderItem;
            return (this.Id == other.Id && this.Name==other.Name);
        }
    }
}
