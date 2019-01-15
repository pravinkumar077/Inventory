using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryMngt.Models.Entity;

namespace InventoryMngt.Models.Interfaces
{
    public interface IAuthorRepository : IRepository<Author>
    {
        IEnumerable<Author> GetAllWithBooks();
        Author GetWithBooks(int id);
    }
}
