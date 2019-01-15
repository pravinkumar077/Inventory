using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryMngt.Models.Entity;

namespace InventoryMngt.Models.Interfaces
{
    public interface IBookRepository : IRepository<Book>
    {
        IEnumerable<Book> GetAllWithAuthor();
        IEnumerable<Book> FindWithAuthor(Func<Book, bool> predicate);
        IEnumerable<Book> FindWithAuthorAndBorrower(Func<Book, bool> predicate);
    }
}
