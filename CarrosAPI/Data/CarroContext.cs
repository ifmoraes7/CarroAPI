using CarrosAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CarrosAPI.Data;

public class CarroContext : DbContext
{
    public CarroContext(DbContextOptions<CarroContext> opts) : base(opts)
    {
                    
    }

    public DbSet<Carro> Carros { get; set; }
}
