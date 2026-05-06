using Microsoft.EntityFrameworkCore;
using SliderCrud.Models;

namespace SliderCrud.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Slider> Sliders { get; set; }
    }
}
