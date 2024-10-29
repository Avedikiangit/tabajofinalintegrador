namespace Negocio
{
    public class ApiProducts
    {
        public ApiProducts()
        {
           
        }
        public ApiProducts(int id, string? title, decimal price, string? description, string? category)
        {
            Id = id;
            Title = title;
            Price = price;
            Description = description;
            Category = category;
        }

        public int Id { get; set; }
        public string? Title { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public string? Category { get; set; }


        
    }
}