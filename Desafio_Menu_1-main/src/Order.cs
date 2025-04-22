using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa una orden hecha por una mesa o para llevar.
    /// </summary>
    public class Order
    {
        private List<Dish> dishes = new List<Dish>();

        /// <summary>
        /// Indica si la orden es para llevar.
        /// </summary>
        public bool IsTakeout { get; private set; }

        /// <summary>
        /// Crea una nueva orden.
        /// </summary>
        /// <param name="isTakeout">True si es para llevar.</param>
        public Order(bool isTakeout = false)
        {
            this.IsTakeout = isTakeout;
        }

        /// <summary>
        /// Agrega un platillo a la orden.
        /// </summary>
        /// <param name="dish">Platillo a agregar.</param>
        public void AddDish(Dish dish)
        {
            this.dishes.Add(dish);
        }

        /// <summary>
        /// Calcula el total de la orden.
        /// </summary>
        /// <returns>Total en formato double.</returns>
        public double GetTotal()
        {
            double total = 0;
            foreach (Dish dish in dishes)
            {
                total += dish.Price;
            }

            return total;
        }

        /// <summary>
        /// Muestra los detalles de la orden en consola.
        /// </summary>
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