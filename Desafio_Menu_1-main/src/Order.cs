using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    public class Order
    {
        private List<Dish> dishes = new List<Dish>();
        public bool IsTakeout { get; private set; }

        public Order(bool isTakeout = false)
        {
            this.IsTakeout = isTakeout;
        }

        public void AddDish(Dish dish)
        {
            this.dishes.Add(dish);
        }

        public double GetTotal()
        {
            double total = 0;
            foreach (Dish dish in dishes)
            {
                total += dish.Price;
            }
            return total;
        }

        public bool HasDishes()
        {
            return dishes.Count > 0;
        }
    }
}