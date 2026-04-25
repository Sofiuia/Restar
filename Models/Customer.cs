namespace RestaurantManagementSystem.Models;

public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }

    public Profile Profile { get; set; }
    public List<Order> Orders { get; set; }
}