
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using InventoryMngt.Models.Entity;

namespace InventoryMngt.ViewModels
{
    public class BookEditViewModel
    {
        public Book Book { get; set; }

        public IEnumerable<Author> Authors { get; set; }
    }
}
