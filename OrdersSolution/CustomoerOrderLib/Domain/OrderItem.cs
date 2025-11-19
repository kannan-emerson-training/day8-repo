using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomoerOrderLib.Domain
{
    public class OrderItem:DomainEntity
    {
        private string _name;
        private double _unitPrice;
        private double _quanity;

        public OrderItem(string id,string name,double unitPrice,double quantity) :base(id){ 
        
            _name = name;
            _unitPrice = unitPrice;
            _quanity = quantity;

        }

        public double CalcuateTotal() { 
        
          return  _quanity* _unitPrice; 
        }
        public string Name { get { return _name;  } }

        public double UnitPrice { get { return _unitPrice; } }
        public double Quanity { get { return _quanity; } }



    }
}
