using Npgsql;
using Dapper;

public class OrderService
{
    private string _connectionString = "Server=127.0.0.1;Port=5432;Database=Examm;User Id=postgres;Password=sqlj123;";
    public List<Orders> GetOrders()
    {
        using (var connection = new NpgsqlConnection(_connectionString))
        {
            string sql = "SELECT * FROM Products";
            var result = connection.Query<Orders>(sql).ToList();
            return result;
        }
    }

    public int InsertOrders(Orders order)
    {
        using (var connection = new NpgsqlConnection(_connectionString))
        {
            string sql = $"Insert into Orders (ProductId, CustomerId, CreatedAt, Count, Price) Values {order.ProductId}, {order.CustomerId}, {order.CreatedAt}, {order.Count}, {order.Price}";
            var result = connection.Execute(sql);
            return result;
        }
    }
    public int UpdateOrder(Orders order)
    {
        using (var connection = new NpgsqlConnection(_connectionString))
        {
             string sql = $"Update Orders Set" +
            $"ProductId = {order.ProductId}, " +
            $"CustomerId = {order.CustomerId}, " +
            $"CreatedAt = {order.CreatedAt}, " +
            $"Count = {order.Count}, " +
            $"Price = {order.Price}" +
            $"Where id = {order.Id}"; 

            var result = connection.Execute(sql);

            return result;
        }
    }
     public int DeleteOrder(int id)
    {
        using (var connection = new NpgsqlConnection(_connectionString))
        {
            var sql = $"Delete from Orders Where id = {id}";
            var result = connection.Execute(sql);
            return result;
        }
    }
}