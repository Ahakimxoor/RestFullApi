using Microsoft.AspNetCore.Mvc;
using MyMvcApiProject.Models;
using System.Collections.Generic;
using System.Linq;
namespace MyMvcApiProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private static List<Order> orders = new List<Order>
        {
            new Order { OrderId = 1, ProductId = 1, CustomerId = 1, OrderDate = System.DateTime.Now },
            new Order { OrderId = 2, ProductId = 2, CustomerId = 2, OrderDate = System.DateTime.Now },
        };

        // GET: api/order
        [HttpGet]
        public ActionResult<List<Order>> GetOrders()
        {
            return Ok(orders);
        }

        // POST: api/order
        [HttpPost]
        public ActionResult AddOrder(Order newOrder)
        {
            orders.Add(newOrder);
            return CreatedAtAction(nameof(GetOrders), new { id = newOrder.OrderId }, newOrder);
        }

        // DELETE: api/order/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteOrder(int id)
        {
            var order = orders.FirstOrDefault(o => o.OrderId == id);
            if (order == null)
            {
                return NotFound();
            }

            orders.Remove(order);
            return NoContent();
        }
    }
}