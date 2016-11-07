namespace eRestaurant.Entities.Pocos
{
    /// <summary>
    /// POCO is short for "Plain Ol' C# Objects."
    /// </summary>
    public class MenuItem
    {
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int? Calories { get; set; }
        public string Comment { get; set; }
    }
}
