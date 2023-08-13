public static class ProductRepository
{
    public static List<Product> Products { get; set; } = Products = new List<Product>();

    public static void Init(IConfiguration configuration){
        var products = configuration.GetSection("Products").Get<List<Product>>();
        Products = products;
    }

    public static List<Product> GetAll() => Products.OrderBy(o => o.Code).ToList();
    public static void Add(Product product)
    {
        if(Products == null)
            Products = new List<Product>();

        Products.Add(product);
    }

    public static Product GetByCode(string code) 
        => Products.First(f => f.Code == code);
    
    public static void Delete(Product product) 
        => Products.Remove(product);
}