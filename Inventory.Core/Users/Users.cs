using System;
using System.Collections.Generic;
using System.Text;
using Inventory.Core.Common;

namespace Inventory.Core.Users
{
    public class Users : BaseEntity
    {
        public string Name { get; set; }
        public string Email{ get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public int Fone { get; set; }
    }
}
