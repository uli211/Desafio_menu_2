namespace Ucu.Poo.Restaurant.Tests;

[TestFixture]
public class TableTests
{
    [Test]
    public void Constructor_WithValidParameters_SetsProperties()
    {
        const int number = 1;
        Table table = new Table(number);

        Assert.That(table.Number, Is.EqualTo(number));
    }
    
    [Test]
    public void IsOccupied_WithOccupiedTable_ReturnsTrue()
    {
        Table table = new Table(1);
        
        table.Ocupy();
        
        Assert.That(table.IsOccupied, Is.True);
    }

    [Test]
    public void HasOrders_BeforeAddOrder_ReturnsFalse()
    {
        Table table = new Table(1);
        
        Assert.That(table.HasOrders(), Is.False);
    }

    [Test]
    public void HasOrders_AfterAddOrder_ReturnsTrue()
    {
        Table table = new Table(1);
        table.Ocupy();
        Dish dish = new Dish("Salad", 5.99, true);
        
        table.AddToOrder(dish);
        
        Assert.That(table.HasOrders(), Is.True);
    }
    
    [Test]
    public void Free_WithOccupiedTable_SetsIsOccupiedToFalseAndEmptiesOrder()
    {
        Table table = new Table(1);
        table.Ocupy();
        Dish dish = new Dish("Salad", 5.99, true);
        table.AddToOrder(dish);
        
        table.Free();
        
        Assert.That(table.IsOccupied, Is.False);
        Assert.That(table.HasOrders(), Is.False);
    }
}