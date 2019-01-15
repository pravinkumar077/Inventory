using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryMngt.Models.Entity;
using InventoryMngt.Models.Interfaces;

namespace InventoryMngt.Models.Repository
{
    public class CustomerRepository: Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(ApplicationContext context) : base(context) { }
        public override void Delete(Customer entity)
        {
            _context.Books.Where(b => b.Borrower == entity)
                .ToList()
                .ForEach(a =>
                {
                    a.Borrower = null;
                    a.BorrowerId = 0;
                });

            base.Delete(entity);
        }
    }
}
