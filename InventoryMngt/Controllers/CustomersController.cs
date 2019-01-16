using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryMngt.Models.Interfaces;
using InventoryMngt.ViewModels;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InventoryMngt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowSpecificOrigin")]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerRepository _repository;
        private readonly IBookRepository _bookRepository;

        public CustomersController(ICustomerRepository repository, IBookRepository bookRepository)
        {
            _repository = repository;
            _bookRepository = bookRepository;
        }
        [HttpGet]
        public IEnumerable<CustomerViewModel> GetAllCustomer()
        {
            List<CustomerViewModel> customerVM = new List<CustomerViewModel>();
            var customers = _repository.GetAll();
            foreach (var customer in customers)
            {
                customerVM.Add(new CustomerViewModel
                {
                    Customer = customer,
                    BookCount = _bookRepository.Find(x => x.BorrowerId == customer.CustomerId).Count()
                });
            }
            return customerVM;            
        }

    }
}