namespace Ucu.Poo.Restaurant;

using System.Collections;

/// <summary>
/// Representa el conjunto de platillos <see cref="Dish"/> disponibles en el restaurante.
/// </summary>
public class Menu
{
    private ArrayList dishes = new ArrayList();

    // Método para agregar un platillo al menú.
    public void AddDish(Dish dish)
    {
        this.dishes.Add(dish);
    }

    // Método para eliminar un platillo del menú.
    public void RemoveDish(Dish dish)
    {
        this.dishes.Remove(dish);
    }

    // Método para obtener un platillo por su nombre.
    public Dish GetDishByName(string name)
    {
        foreach (Dish dish in dishes)
        {
            if (dish.Name == name)
            {
                return dish;
            }
        }
        return null; // Retorna null si no encuentra el platillo.
    }

    // Método para mostrar todos los platillos en el menú.
    public void ShowMenu()
    {
        foreach (Dish dish in dishes)
        {
            Console.WriteLine(dish.ToString());
        }
    }
}