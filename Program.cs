using RestaurantManagementSystem.Data;
using RestaurantManagementSystem.Models;

var context = new AppDbContext();

context.Database.EnsureDeleted();
context.Database.EnsureCreated();

// Клієнти
var customers = new List<Customer>();
for (int i = 1; i <= 15; i++)
{
    customers.Add(new Customer
    {
        Name = $"Customer {i}",
        Profile = new Profile { Phone = $"1000{i}" }
    });
}

context.Customers.AddRange(customers);

// Страви
var dishes = new List<Dish>
{
    new Dish { Name = "Pizza" },
    new Dish { Name = "Burger" },
    new Dish { Name = "Pasta" }
};

context.Dishes.AddRange(dishes);
context.SaveChanges();

// Замовлення
var orders = new List<Order>();

for (int i = 0; i < 15; i++)
{
    orders.Add(new Order
    {
        CustomerId = customers[i].Id,
        OrderDishes = new List<OrderDish>
        {
            new OrderDish { DishId = dishes[0].Id },
            new OrderDish { DishId = dishes[1].Id }
        }
    });
}

context.Orders.AddRange(orders);
context.SaveChanges();

Console.WriteLine("Готово!");
Console.WriteLine($"Customers: {context.Customers.Count()}");
Console.WriteLine($"Orders: {context.Orders.Count()}");
Console.WriteLine($"Dishes: {context.Dishes.Count()}");
