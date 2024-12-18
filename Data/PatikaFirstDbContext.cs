using Microsoft.EntityFrameworkCore;
using PatikaFirstDbContext.Models;

namespace PatikaFirstDbContext.Data;

public class PatikaFirstDbContext : DbContext
{
    public PatikaFirstDbContext(DbContextOptions<PatikaFirstDbContext> options) 
        : base(options)
    {
    }

    public DbSet<Movie> Movies { get; set; }
    public DbSet<Game> Games { get; set; }
} 