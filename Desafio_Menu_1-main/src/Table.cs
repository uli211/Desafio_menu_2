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
            order = new Order(); // Inicializa una nueva orden.
        }

        public void Occupy()
        {
            IsOccupied = true; // Marca la mesa como ocupada.
        }

        public void Free()
        {
            IsOccupied = false; // Libera la mesa.
            order = new Order(); // Reinicia la orden al liberar la mesa.
        }

        public void AddToOrder(Dish dish)
        {
            if (IsOccupied) // Asegurarse de que la mesa esté ocupada antes de agregar un platillo.
            {
                order.AddDish(dish); // Agregar el platillo a la orden.
            }
        }

        public double GetTotal()
        {
            return order.GetTotal(); // Delegar el cálculo a la clase Order.
        }

        public void ShowOrder()
        {
            order.ShowOrder(); // Mostrar el resumen de la orden.
        }
    }
}