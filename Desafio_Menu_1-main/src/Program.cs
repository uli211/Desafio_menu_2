using System;
using Ucu.Poo.Restaurant;

namespace Ucu.Poo.RestaurantApp

{
    /// <summary>
    /// Clase principal que contiene el punto de entrada del programa.
    /// Permite gestionar el menú, las mesas, los pedidos en mesa y para llevar
    /// en un restaurante mediante una interfaz de consola.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Método principal que se ejecuta al iniciar el programa.
        /// Contiene el ciclo principal del menú interactivo para el restaurante.
        /// </summary>
        /// <param name="args">Argumentos de la línea de comandos (no utilizados).</param>
        static void Main(string[] args)
        {
            // Crear un menú y agregar algunos platillos
            Menu menu = new Menu();
            menu.AddDish(new Dish("Spaghetti", 10.50, false));
            menu.AddDish(new Dish("Salad", 5.75, true));
            menu.AddDish(new Dish("Pizza", 12.00, false));

            // Crear un mozo
            Waiter waiter = new Waiter("John");

            // Crear una mesa
            Table table1 = new Table(1);
            waiter.AssignTable(table1);

            bool running = true;

            // Ciclo principal del programa
            while (running)
            {
                Console.WriteLine("\n--- Menú del Restaurante ---");
                Console.WriteLine("1. Mostrar menú");
                Console.WriteLine("2. Ocupiar mesa");
                Console.WriteLine("3. Tomar pedido en mesa");
                Console.WriteLine("4. Tomar pedido para llevar");
                Console.WriteLine("5. Mostrar total de la orden");
                Console.WriteLine("6. Liberar mesa");
                Console.WriteLine("7. Salir");
                Console.Write("Selecciona una opción: ");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.WriteLine("\n--- Menú ---");
                        menu.ShowMenu();
                        break;

                    case "2":
                        table1.Occupy();
                        Console.WriteLine("La mesa ha sido ocupada.");
                        break;

                    case "3":
                        if (!table1.IsOccupied)
                        {
                            Console.WriteLine("La mesa no está ocupada. Ocupa la mesa primero.");
                            break;
                        }

                        string moreOrders;
                        do
                        {
                            Console.Write("Ingresa el nombre del platillo: ");
                            string dishName = Console.ReadLine();
                            Dish dish = menu.GetDishByName(dishName);

                            if (dish != null)
                            {
                                waiter.TakeOrder(table1, dish);
                                Console.WriteLine($"Platillo '{dish.Name}' agregado a la orden.");
                            }
                            else
                            {
                                Console.WriteLine("Platillo no encontrado en el menú.");
                            }

                            Console.Write("¿Quieres agregar otro platillo? (s/n): ");
                            moreOrders = Console.ReadLine();
                        } while (moreOrders.Equals("s", StringComparison.OrdinalIgnoreCase));

                        break;

                    case "4":
                        string moreTakeoutOrders;
                        Order takeoutOrder = new Order(true); // Crear una nueva orden para llevar
                        do
                        {
                            Console.Write("Ingresa el nombre del platillo para llevar: ");
                            string takeoutDishName = Console.ReadLine();
                            Dish takeoutDish = menu.GetDishByName(takeoutDishName);

                            if (takeoutDish != null)
                            {
                                takeoutOrder.AddDish(takeoutDish);
                                Console.WriteLine($"Platillo '{takeoutDish.Name}' agregado a la orden para llevar.");
                            }
                            else
                            {
                                Console.WriteLine("Platillo no encontrado en el menú.");
                            }

                            Console.Write("¿Quieres agregar otro platillo para llevar? (s/n): ");
                            moreTakeoutOrders = Console.ReadLine();
                        } while (moreTakeoutOrders.Equals("s", StringComparison.OrdinalIgnoreCase));

                        Console.WriteLine($"Total de la orden para llevar: ${takeoutOrder.GetTotal()}");
                        takeoutOrder.ShowOrder(); // Mostrar el resumen de la orden para llevar
                        break;

                    case "5":
                        double total = table1.GetTotal();
                        Console.WriteLine($"Total de la orden en la mesa {table1.Number}: ${total}");
                        break;

                    case "6":
                        table1.Free();
                        Console.WriteLine("La mesa ha sido liberada.");
                        break;

                    case "7":
                        running = false;
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Intenta de nuevo.");
                        break;
                }
            }
        }
    }
}