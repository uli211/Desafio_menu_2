using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa una mesa en el restaurante.
    /// </summary>
    public class Table
    {
        /// <summary>
        /// Número identificador de la mesa.
        /// </summary>
        public int Number { get; }

        /// <summary>
        /// Indica si la mesa está ocupada.
        /// </summary>
        public bool IsOccupied { get; private set; }

        private Order order;

        /// <summary>
        /// Inicializa una nueva mesa con su número.
        /// </summary>
        /// <param name="number">Número de la mesa.</param>
        public Table(int number)
        {
            Number = number;
            IsOccupied = false;
            order = new Order();
        }

        /// <summary>
        /// Ocupa la mesa.
        /// </summary>
        public void Occupy()
        {
            IsOccupied = true;
        }

        /// <summary>
        /// Libera la mesa y reinicia la orden.
        /// </summary>
        public void Free()
        {
            IsOccupied = false;
            order = new Order();
        }

        /// <summary>
        /// Agrega un platillo a la orden de la mesa.
        /// </summary>
        /// <param name="dish">Platillo a agregar.</param>
        public void AddToOrder(Dish dish)
        {
            if (IsOccupied)
            {
                order.AddDish(dish);
            }
        }

        /// <summary>
        /// Obtiene el total de la orden de la mesa.
        /// </summary>
        /// <returns>Total en formato double.</returns>
        public double GetTotal()
        {
            return order.GetTotal();
        }

        /// <summary>
        /// Muestra los detalles de la orden en consola.
        /// </summary>
        public void ShowOrder()
        {
            order.ShowOrder();
        }
    }
}