using Microsoft.AspNetCore.Mvc;
using MyMvcApiProject.Models;
using System.Collections.Generic;
using System.Linq;

namespace MyMvcApiProject.Controllers
{
    [ApiController]
[Route("api/[controller]")]
public class CustomerController : ControllerBase
{
private static List<Customer> customers = new List<Customer>
{
    new Customer { CustomerId = 1, FullName = "Abdihakim Mohamed Hassan", Email = "Ahakimxor@gmail.com" },
new Customer { CustomerId = 2, FullName = "Mohamed Hassan Xoor", Email = "Mxoor@gmail.com" }
        };

// GET: api/customer
[HttpGet]
public ActionResult<List<Customer>> GetCustomers()
{
    return Ok(customers);
        }

// POST: api/customer
[HttpPost]
public ActionResult AddCustomer(Customer newCustomer)
{
    customers.Add(newCustomer);
return CreatedAtAction(nameof(GetCustomers), new { id = newCustomer.CustomerId }, newCustomer);
        }

// PUT: api/customer/{id}
[HttpPut("{id}")]
public ActionResult UpdateCustomer(int id, Customer updatedCustomer)
{
    var customer = customers.FirstOrDefault(c => c.CustomerId == id);
if (customer == null)
{
    return NotFound(); 
            }


customer.FullName = updatedCustomer.FullName;
customer.Email = updatedCustomer.Email;

return NoContent();
        }
    }
}
