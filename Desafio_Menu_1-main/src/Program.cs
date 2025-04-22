using System;
using Ucu.Poo.Restaurant;

namespace Ucu.Poo.RestaurantApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear algunos platillos
            Dish dish1 = new Dish("Spaghetti", 10.50, false);
            Dish dish2 = new Dish("Salad", 5.75, true);
            Dish dish3 = new Dish("Pizza", 12.00, false);

            // Crear un menú y agregar los platillos
            Menu menu = new Menu();
            menu.AddDish(dish1);
            menu.AddDish(dish2);
            menu.AddDish(dish3);

            // Crear una mesa y asignarla a un mozo
            Table table1 = new Table(1);
            Waiter waiter = new Waiter("John");
            waiter.AssignTable(table1);

            // Ocupamos la mesa y tomamos pedidos
            table1.Occupy();
            waiter.TakeOrder(table1, dish1);
            waiter.TakeOrder(table1, dish2);

            // Mostrar el total de la orden
            Console.WriteLine($"Total de la orden en la mesa {table1.Number}: ${table1.GetTotal()}");

            // Liberar la mesa
            table1.Free();
            Console.WriteLine($"La mesa {table1.Number} está ocupada: {table1.IsOccupied}");
        }
    }
}