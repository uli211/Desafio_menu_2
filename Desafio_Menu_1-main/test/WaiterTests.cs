namespace Ucu.Poo.Restaurant.Tests;

[TestFixture]
public class WaiterTests
{
    [Test]
    public void Constructor_WithValidParameters_SetsProperties()
    {
        const string name = "John Doe";
        Waiter waiter = new Waiter(name);

        Assert.That(waiter.Name, Is.EqualTo(name));
    }

    [Test]
    public void TakeOrder_WithValidParameters_TakesOrder()
    {
        Waiter waiter = new Waiter("Jane Doe");
        Table table = new Table(1);
        waiter.AssignTable(table);
        Dish dish = new Dish("Salad", 5.99, true);
        table.Ocupy();
        
        waiter.TakeOrder(table, dish);
        
        Assert.That(table.HasOrders(), Is.True);
    }
}