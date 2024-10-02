using Microsoft.AspNetCore.Mvc;
using MyMvcApiProject.Models;
using System.Collections.Generic;
using System.Linq;

namespace MyMvcApiProject.Controllers
{
    [ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
private static List<Product> products = new List<Product>
{
 new Product { ProductId = 1, Name = "Iphone14", Price = 1200 },
new Product { ProductId = 2, Name = "SamsungA24Ultra", Price = 800 }
        };

//GET: api / product
[HttpGet]
public ActionResult<List<Product>> GetProducts()
{
    return Ok(products);
}

// POST: api/product
[HttpPost]
public ActionResult AddProduct(Product newProduct)
{
    products.Add(newProduct);
return CreatedAtAction(nameof(GetProducts), new { id = newProduct.ProductId }, newProduct);
        }

//DELETE: api / product /{ id}
[HttpDelete("{id}")]
public ActionResult DeleteProduct(int id)
{
    var product = products.FirstOrDefault(p => p.ProductId == id);
if (product == null)
{
    return NotFound();
}

products.Remove(product);
return NoContent();
        }
    }
}

