using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    public class Table
    {
        public int Number { get; }
        public bool IsOccupied { get; private set; }
        private Order order;

        public Table(int number)
        {
            Number = number;
            IsOccupied = false;
            order = new Order();
        }

        public void Occupy()
        {
            IsOccupied = true;
        }

        public void Free()
        {
            IsOccupied = false;
            order = new Order(); // Crear una nueva instancia de Order al liberar la mesa.
        }

        public void AddToOrder(Dish dish)
        {
            order.AddDish(dish);
        }

        public double GetTotal()
        {
            return order.GetTotal(); // Delegar el cálculo a la clase Order.
        }

        public bool HasOrders()
        {
            return order.HasDishes(); // Verifica si hay platillos en la orden.
        }
    }
}