namespace MyMvcApiProject.Models
{
public class Order
{
public int OrderId { get; set; }
public int ProductId { get; set; }
public int CustomerId { get; set; }
public DateTime OrderDate { get; set; }

// Constructor aan lahayn parameters
public Order() { }

// Constructor leh parameters si loo abuuro object-ka xog leh
public Order(int orderId, int productId, int customerId, DateTime orderDate)
{
    OrderId = orderId;
     ProductId = productId;
     CustomerId = customerId;
OrderDate = orderDate;
        }
    }
}
