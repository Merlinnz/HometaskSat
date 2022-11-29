using Npgsql;
using Dapper;

public class ProductService
{
     private string _connectionString = "Server=127.0.0.1;Port=5432;Database=Examm;User Id=postgres;Password=sqlj123;";
     public List<Products> GetProducts()
     {
        using (var connection = new NpgsqlConnection(_connectionString))
        {
            string sql = "SELECT * FROM Products";
            var result = connection.Query<Products>(sql).ToList();
            return result;
        }
     }

    public int InsertProduct(Products product)
    {
        using (var connection = new NpgsqlConnection(_connectionString))
        {
            string sql = $"INSERT INTO Products (ProductName, Company, ProductCount, Price) Values ('{product.ProductName}', '{product.Company}', '{product.ProductCount}', '{product.Price}')";
            var result = connection.Execute(sql);
            return result;
        }
    }

    public int UpdateProduct(Products product)
    {
        using (var connection = new NpgsqlConnection(_connectionString))
        {
             string sql = $"Update Products Set" +
            $"ProductName = '{product.ProductName}', " +
            $"Company = '{product.Company}', " +
            $"ProductCount = {product.ProductCount}, " +
            $"Price = {product.Price}, " +
            $"Where id = {product.Id}";

            var result = connection.Execute(sql);

            return result;
        }
    }

    public int DeleteProduct(int id)
    {
        using (var connection = new NpgsqlConnection(_connectionString))
        {
            var sql = $"Delete from Products Where id = {id}";
            var result = connection.Execute(sql);
            return result;
        }
    }

}
