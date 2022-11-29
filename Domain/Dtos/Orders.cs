public class Orders
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public int CustomerId { get; set; }
    public DateTime CreatedAt { get; set; }
    public int Count { get; set; }
    public int Price { get; set; }
}