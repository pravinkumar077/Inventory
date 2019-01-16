using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryMngt.Models.Entity;

namespace InventoryMngt.Models.Entity.ResOrder
{
  public class Customer
{
    
    public Customer()
    {
        this.Orders = new HashSet<Order>();
    }

    public int CustomerID { get; set; }
    public string Name { get; set; }

    
    public virtual ICollection<Order> Orders { get; set; }
}
}
