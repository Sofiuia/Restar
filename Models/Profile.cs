namespace RestaurantManagementSystem.Models;

public class Profile
{
    public int Id { get; set; }
    public string Phone { get; set; }

    public int CustomerId { get; set; }
    public Customer Customer { get; set; }
}