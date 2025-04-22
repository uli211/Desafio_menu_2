using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    public class Order
    {
        private List<Dish> dishes = new List<Dish>();
        public bool IsTakeout { get; private set; }

        public Order(bool isTakeout = false)
        {
            this.IsTakeout = isTakeout; // Indica si la orden es para llevar.
        }

        public void AddDish(Dish dish)
        {
            this.dishes.Add(dish); // Agregar el platillo a la lista de la orden.
        }

        public double GetTotal()
        {
            double total = 0;
            foreach (Dish dish in dishes)
            {
                total += dish.Price; // Calcular el total de los platillos en la orden.
            }

            return total;
        }

        public void ShowOrder()
        {
            Console.WriteLine("\n--- Resumen de la Orden ---");
            foreach (Dish dish in dishes)
            {
                Console.WriteLine(dish.ToString());
            }

            Console.WriteLine($"Total: ${GetTotal()}");
        }
    }
}