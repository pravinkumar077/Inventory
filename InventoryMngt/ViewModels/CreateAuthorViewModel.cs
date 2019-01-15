
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using InventoryMngt.Models.Entity;

namespace InventoryMngt.ViewModels
{
    public class CreateAuthorViewModel
    {
        [Required]
        public Author Author { get; set; }
        public string Referer { get; set; }
    }
}
