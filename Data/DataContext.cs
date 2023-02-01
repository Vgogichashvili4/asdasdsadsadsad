using Microsoft.EntityFrameworkCore;
using webApi1.Models;

namespace WebAPI.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }
    public DbSet<DeviceModel> DeviceModels { get; set; }
    public DbSet<OrderModel> Orders { get; set; }
    public DbSet<OrderHistory> OrderHistory { get; set; }
    public DbSet<ListenerModel> ListenerModels { get; set; }
}

    
