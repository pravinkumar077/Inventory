using System;
using System.Collections.Generic;
using System.Text;
using Inventory.Core.Users;
using Microsoft.EntityFrameworkCore;

namespace Inventory.EntityFramwork.EntityFramwork
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions opts) : base(opts)
        {
        }
        public DbSet<Users> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }
    }
}
