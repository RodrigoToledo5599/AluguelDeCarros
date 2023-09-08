using AluguelDeCarros.Models;
using Microsoft.EntityFrameworkCore;

namespace AluguelDeCarros.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { } 

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Carros> Carros { get; set; }





        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Usuario>().HasData(
                new Usuario { Id = 1, Name="Rodrigo",Email= "ddd@gmail.com" }
                
                    

                );




            base.OnModelCreating(builder);
        }
    }
}
