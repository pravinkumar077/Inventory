using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryMngt.Models;
using InventoryMngt.Models.Entity.ResOrder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InventoryMngt.Controllers.Resturent
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly ApplicationContext db;

        // GET: api/Employee
        public IQueryable<Employee> GetEmployees()
        {
            var data = db.Employees;
            return data;

        }


        // PUT: api/Employee/5
        
        //public IHttpActionResult PutEmployee(int id, Employee employee)
        //{

        //    if (id != employee.EmployeeID)
        //    {
        //        return BadRequest();
        //    }

        //    db.Entry(employee).State = EntityState.Modified;

        //    try
        //    {
        //        db.SaveChanges();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!EmployeeExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return StatusCode(HttpStatusCode.NoContent);
        //}

        // POST: api/Employee
        [HttpPost]
        public void PostEmployee(Employee employee)
        {
            db.Employees.Add(employee);
            db.SaveChanges();

            
        }

        // DELETE: api/Employee/5
       [HttpPost]
        public void DeleteEmployee(int id)
        {
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                //return NotFound();
            }

            db.Employees.Remove(employee);
            db.SaveChanges();

            
        }

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        private bool EmployeeExists(int id)
        {
            return db.Employees.Count(e => e.EmployeeID == id) > 0;
        }
    }
}
