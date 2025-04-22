namespace Ucu.Poo.Restaurant.Tests;

[TestFixture]
public class MenuTests
{
    [Test]
    public void AddDish_WithValidDish_AddsDish()
    {
        const string name = "Salad";
        Dish dish = new Dish(name, 5.99, true);
        Menu menu = new Menu();

        menu.AddDish(dish);

        Dish foundDish = menu.GetDishByName(name);
        Assert.That(foundDish, Is.EqualTo(dish));
    }
    
    [Test]
    public void RemoveDish_WithValidDish_RemovesDish()
    {
        const string name = "Salad";
        Dish dish = new Dish(name, 5.99, true);
        Menu menu = new Menu();

        menu.AddDish(dish);
        menu.RemoveDish(dish);

        Dish foundDish = menu.GetDishByName(name);
        Assert.That(foundDish, Is.Null);
    }
    
    [Test]
    public void GetDishByName_WithInvalidDish_ReturnsNull()
    {
        const string name = "Salad";
        Dish dish = new Dish(name, 5.99, true);
        Menu menu = new Menu();
        menu.AddDish(dish);

        Dish foundDish = menu.GetDishByName("Burger");
        
        Assert.That(foundDish, Is.Null);
    }
}