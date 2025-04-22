using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    public class Waiter
    {
        public string Name { get; }
        private List<Table> assignedTables = new List<Table>();

        public Waiter(string name)
        {
            Name = name;
        }

        public void AssignTable(Table table)
        {
            if (!assignedTables.Contains(table))
            {
                assignedTables.Add(table);
            }
        }

        public void TakeOrder(Table table, Dish dish)
        {
            if (assignedTables.Contains(table))
            {
                table.AddToOrder(dish);
            }
        }

        public double GetTotal(Table table)
        {
            if (assignedTables.Contains(table))
            {
                return table.GetTotal();
            }
            return 0;
        }
    }
}