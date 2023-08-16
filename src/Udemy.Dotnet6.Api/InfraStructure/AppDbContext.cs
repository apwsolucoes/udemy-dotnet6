using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<Product> Product { get; set; }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Product>()
            .Property(p => p.Description).HasMaxLength(500).IsRequired(false);
        builder.Entity<Product>()
            .Property(p => p.Name).HasMaxLength(120).IsRequired(false);
        builder.Entity<Product>()
            .Property(p => p.Code).HasMaxLength(20).IsRequired(false);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer("Server=X;Database=Products;User Id=Y;Password=Z;Encrypt=False");
        base.OnConfiguring(options);
    }
}