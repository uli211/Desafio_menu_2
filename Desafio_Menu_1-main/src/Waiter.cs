using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa a un mozo del restaurante.
    /// </summary>
    public class Waiter
    {
        /// <summary>
        /// Nombre del mozo.
        /// </summary>
        public string Name { get; }

        private List<Table> assignedTables = new List<Table>();

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Waiter"/>.
        /// </summary>
        /// <param name="name">Nombre del mozo.</param>
        public Waiter(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Asigna una mesa al mozo.
        /// </summary>
        /// <param name="table">Mesa a asignar.</param>
        public void AssignTable(Table table)
        {
            if (!assignedTables.Contains(table))
            {
                assignedTables.Add(table);
            }
        }

        /// <summary>
        /// Toma un pedido para una mesa asignada.
        /// </summary>
        /// <param name="table">Mesa del pedido.</param>
        /// <param name="dish">Platillo solicitado.</param>
        public void TakeOrder(Table table, Dish dish)
        {
            if (assignedTables.Contains(table) && table.IsOccupied)
            {
                table.AddToOrder(dish);
            }
        }
    }
}