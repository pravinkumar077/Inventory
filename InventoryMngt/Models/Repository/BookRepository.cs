﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryMngt.Models.Entity;
using InventoryMngt.Models.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace InventoryMngt.Models.Repository
{
    public class BookRepository: Repository<Book>, IBookRepository
    {
        public BookRepository(ApplicationContext context) : base(context) { }
        public IEnumerable<Book> FindWithAuthor(Func<Book, bool> predicate)
        {
            return _context.Books
                .Include(a => a.Author)
                .Where(predicate);
        }

        public IEnumerable<Book> FindWithAuthorAndBorrower(Func<Book, bool> predicate)
        {
            return _context.Books
                .Include(a => a.Author)
                .Include(a => a.Borrower)
                .Where(predicate);
        }

        public IEnumerable<Book> GetAllWithAuthor()
        {
            return _context.Books.Include(a => a.Author);
        }

    }
}
