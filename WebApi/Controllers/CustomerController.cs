using Microsoft.AspNetCore.Mvc;
[ApiController]
[Route("[controller]")]

public class CustomerController 
{
    private CustomerService _customerService;
    public CustomerController()
    {
        _customerService = new CustomerService();
    }
    
    [HttpGet]
    public List<Customers> GetOrders()
    {
        return _customerService.GetCustomers();
    }

     [HttpPost("Insert")]
    public int InsertOrders(Customers customer)
        {
            return _customerService.InsertCustomer(customer);
        }
    [HttpPut("Update")]

    public int UpdateOrder(Customers customer)
    {
        return _customerService.UpdateCustomer(customer);
    }

    [HttpDelete("Delete")]    
        public int DeleteCustomer(int id)
        {
            return _customerService.DeleteCustomer(id);
        }
}