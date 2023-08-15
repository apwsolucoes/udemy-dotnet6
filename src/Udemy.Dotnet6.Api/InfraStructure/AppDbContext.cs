using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        //options.UseSqlServer("Server=localhost,1433;Database=Products;User Id=sa;Password=@Sql2023;MultipleActiveResultSet=true;Encrypt=YES;TrustServerCertificate=YES");
        options.UseSqlServer("Server=localhost,1433;Database=Products;User Id=sa;Password=@Sql2023;");
        base.OnConfiguring(options);
    }
}