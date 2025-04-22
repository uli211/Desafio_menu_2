namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa un platillo individual en el menú del restaurante.
    /// </summary>
    public class Dish
    {
        /// <summary>
        /// Nombre del platillo.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Precio del platillo.
        /// </summary>
        public double Price { get; }

        /// <summary>
        /// Indica si el platillo es vegetariano.
        /// </summary>
        public bool IsVegetarian { get; }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Dish"/>.
        /// </summary>
        /// <param name="name">Nombre del platillo.</param>
        /// <param name="price">Precio del platillo.</param>
        /// <param name="isVegetarian">True si es vegetariano, False en caso contrario.</param>
        public Dish(string name, double price, bool isVegetarian)
        {
            this.Name = name;
            this.Price = price;
            this.IsVegetarian = isVegetarian;
        }

        /// <summary>
        /// Devuelve una cadena que representa al objeto actual.
        /// </summary>
        /// <returns>Descripción del platillo.</returns>
        public override string ToString()
        {
            return $"{Name} - ${Price} - {(IsVegetarian ? "Vegetariano" : "No Vegetariano")}";
        }
    }
}