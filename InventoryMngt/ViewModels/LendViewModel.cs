
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryMngt.Models.Entity;

namespace InventoryMngt.ViewModels
{
    public class LendViewModel
    {
        public Book Book { get; set; }
        public IEnumerable<Customer> Customers { get; set; }
    }
}
