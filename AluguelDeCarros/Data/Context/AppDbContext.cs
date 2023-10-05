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

            builder.Entity<Carros>().HasData(

                new Carros {Id = 1, Name = "Celta", Marca= Enum.Brand.Chevrolet},
                new Carros {Id = 2, Name = "Uno", Marca= Enum.Brand.Fiat},
                new Carros {Id = 3, Name = "Palio", Marca= Enum.Brand.Fiat},
                new Carros {Id = 4, Name = "Fusion", Marca= Enum.Brand.Ford},
                new Carros {Id = 5, Name = "C4 Lounge", Marca= Enum.Brand.Citroen},
                new Carros {Id = 6, Name = "Civic lxr", Marca= Enum.Brand.Honda},
                new Carros {Id = 7, Name = "Dodge Ram", Marca= Enum.Brand.Dodge},
                new Carros {Id = 8, Name = "Corvette C7 Stingray", Marca= Enum.Brand.Chevrolet},
                new Carros {Id = 9, Name = "C63", Marca= Enum.Brand.Mercedez},
                new Carros {Id = 10, Name = "Gol", Marca= Enum.Brand.Volkswagen},
                new Carros {Id = 11, Name = "Prius", Marca= Enum.Brand.Toyota},
                new Carros {Id = 12, Name = "Corolla 2017", Marca= Enum.Brand.Toyota},
                new Carros {Id = 13, Name = "Yaris", Marca= Enum.Brand.Toyota}


                );



            base.OnModelCreating(builder);
        }
    }
}
