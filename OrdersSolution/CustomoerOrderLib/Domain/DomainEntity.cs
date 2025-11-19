using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomoerOrderLib.Domain
{
    public abstract class DomainEntity
    {
        private readonly string _id;

        public DomainEntity(string id)
        { 
         _id = id;  
        }

        public string Id
        {
            get
            {
                return _id;
            }
        }
    }
}
