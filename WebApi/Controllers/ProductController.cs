using Microsoft.AspNetCore.Mvc;
[ApiController]
[Route("[controller]")]

public class ProductController 
{
    private ProductService _productService;
    public ProductController()
    {
        _productService = new ProductService();
    }
    
    [HttpGet]
    public List<Products> GetProducts()
    {
        return _productService.GetProducts();
    }

     [HttpPost("Insert")]
    public int InsertProduct(Products product)
        {
            return _productService.InsertProduct(product);
        }
    [HttpPut("Update")]

    public int UpdateProduct(Products product)
    {
        return _productService.UpdateProduct(product);
    }

    [HttpDelete("Delete")]    
        public int DeleteCourse(int id)
        {
            return _productService.DeleteProduct(id);
        }
}