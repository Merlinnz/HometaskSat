using Microsoft.AspNetCore.Mvc;
[ApiController]
[Route("[controller]")]

public class OrderController 
{
    private OrderService _orderService;
    public OrderController()
    {
        _orderService = new OrderService();
    }
    
    [HttpGet]
    public List<Orders> GetOrders()
    {
        return _orderService.GetOrders();
    }

     [HttpPost("Insert")]
    public int InsertOrders(Orders order)
        {
            return _orderService.InsertOrders(order);
        }
    [HttpPut("Update")]

    public int UpdateOrder(Orders order)
    {
        return _orderService.UpdateOrder(order);
    }

    [HttpDelete("Delete")]    
        public int DeleteOrder(int id)
        {
            return _orderService.DeleteOrder(id);
        }
}