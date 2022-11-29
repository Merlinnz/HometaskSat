using Npgsql;
using Dapper;

public class CustomerService
{
    private string _connectionString = "Server=127.0.0.1;Port=5432;Database=Examm;User Id=postgres;Password=sqlj123;";
    public List<Customers> GetCustomers()
    {
        using (var connection = new NpgsqlConnection(_connectionString))
        {
            string sql = "SELECT * FROM Customers";
            var result = connection.Query<Customers>(sql).ToList();
            return result;
        }
    }

    public int InsertCustomer(Customers customer)
    {
        using (var connection = new NpgsqlConnection(_connectionString))
        {
            string sql = $"INSERT INTO Customers (FirstName) Values ('{customer.FirstName}')";
            var result = connection.Execute(sql);
            return result;
        }
    }

     public int UpdateCustomer(Customers customer)
    {
        using (var connection = new NpgsqlConnection(_connectionString))
        {
            string sql = $"Update Customers Set" +
            $"Id = {customer.FirstName}, " +
            $"Where id = {customer.Id}"; 

            var result = connection.Execute(sql);

            return result;
        }
    }
     public int DeleteCustomer(int id)
    {
        using (var connection = new NpgsqlConnection(_connectionString))
        {
            var sql = $"Delete from Customers Where id = {id}";
            var result = connection.Execute(sql);
            return result;
        }
    }
}