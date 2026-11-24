using Microsoft.EntityFrameworkCore;

public class OrdersAPIContext(DbContextOptions<OrdersAPIContext> options) : DbContext(options)
{
    public DbSet<OrdersAPI.Order> Order { get; set; } = default!;
}
