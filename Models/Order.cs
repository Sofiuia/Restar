namespace RestaurantManagementSystem.Models;

public class Order
{
    public int Id { get; set; }

    public int CustomerId { get; set; }
    public Customer Customer { get; set; }

    public List<OrderDish> OrderDishes { get; set; }
}