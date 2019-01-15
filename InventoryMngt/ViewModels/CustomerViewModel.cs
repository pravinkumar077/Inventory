
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryMngt.Models.Entity;

namespace InventoryMngt.ViewModels
{
    public class CustomerViewModel
    {
        public Customer Customer { get; set; }
        public int BookCount { get; set; }
    }
}
