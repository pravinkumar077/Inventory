using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryMngt.Models.Entity
{
    public  class Item
    {
        
        public Item()
        {
            this.OrderItems = new HashSet<OrderItem>();
        }

        public int ItemID { get; set; }
        public string Name { get; set; }
        public Nullable<decimal> Price { get; set; }

        
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
