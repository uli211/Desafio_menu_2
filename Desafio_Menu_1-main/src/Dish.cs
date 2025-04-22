namespace Ucu.Poo.Restaurant;

/// <summary>
/// Representa un platillo individual en el menú del restaurante.
/// </summary>
public class Dish
{
    // Propiedades de solo lectura.
    public string Name { get; }
    public double Price { get; }
    public bool IsVegetarian { get; }

    // Constructor para inicializar las propiedades.
    public Dish(string name, double price, bool isVegetarian)
    {
        this.Name = name;
        this.Price = price;
        this.IsVegetarian = isVegetarian;
    }

    // Método para mostrar la información del platillo.
    public override string ToString()
    {
        return $"{Name} - ${Price} - {(IsVegetarian ? "Vegetariano" : "No Vegetariano")}";
    }
}