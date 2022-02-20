namespace zNpgsqlClient
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get;set; }
        public int Price { get; set; }
        public List<Event> Event { get; set; } = null!;
        public int CategoryForeignKey { get; set; }
        public Category Category { get; set; } = new Category();
        public List<Stock> Stock { get; set; } = null!;
    }
}