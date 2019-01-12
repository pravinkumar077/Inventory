using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Core.Common
{
    public class BaseEntity
    {
        public Int64 Id { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
