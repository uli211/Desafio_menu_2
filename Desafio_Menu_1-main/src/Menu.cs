namespace Ucu.Poo.Restaurant;

using System.Collections;
/// <summary>
/// Representa el conjunto de platillos disponibles en el restaurante.
/// </summary>
public class Menu
{
    private ArrayList dishes = new ArrayList();

    /// <summary>
    /// Agrega un platillo al menú.
    /// </summary>
    /// <param name="dish">Platillo a agregar.</param>
    public void AddDish(Dish dish)
    {
        this.dishes.Add(dish);
    }

    /// <summary>
    /// Elimina un platillo del menú.
    /// </summary>
    /// <param name="dish">Platillo a eliminar.</param>
    public void RemoveDish(Dish dish)
    {
        this.dishes.Remove(dish);
    }

    /// <summary>
    /// Obtiene un platillo del menú por su nombre.
    /// </summary>
    /// <param name="name">Nombre del platillo.</param>
    /// <returns>Platillo encontrado o null si no existe.</returns>
    public Dish GetDishByName(string name)
    {
        foreach (Dish dish in dishes)
        {
            if (dish.Name == name)
            {
                return dish;
            }
        }
        return null;
    }

    /// <summary>
    /// Muestra todos los platillos en el menú por consola.
    /// </summary>
    public void ShowMenu()
    {
        foreach (Dish dish in dishes)
        {
            Console.WriteLine(dish.ToString());
        }
    }
}