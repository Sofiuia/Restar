namespace RestaurantManagementSystem.Models;

public class Dish
{
    public int Id { get; set; }
    public string Name { get; set; }

    public List<OrderDish> OrderDishes { get; set; }
}