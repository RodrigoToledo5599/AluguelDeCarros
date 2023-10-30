using AluguelDeCarros.Models;
using Microsoft.EntityFrameworkCore;

namespace AluguelDeCarros.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { } 

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Carros> Carros { get; set; }
        public DbSet<AluguelAtivo> AluguelAtivos { get; set; }





        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Usuario>().HasData(
                new Usuario { Id = 1, Name="Rodrigo",Email= "ddd@gmail.com",Senha= "123" },
                new Usuario { Id = 2, Name="Adm",Email= "adm@gmail.com", Senha= "123", Role = Enum.Roles.Admin }
                
                    

                );

            builder.Entity<Carros>().HasData(

                new Carros {Id = 1, Name = "Celta", Marca= Enum.Brand.Chevrolet, ValorDia=30},
                new Carros {Id = 2, Name = "Uno", Marca= Enum.Brand.Fiat, ValorDia = 30 },
                new Carros {Id = 3, Name = "Palio", Marca= Enum.Brand.Fiat, ValorDia = 30 },
                new Carros {Id = 4, Name = "Fusion", Marca= Enum.Brand.Ford, ValorDia = 80 },
                new Carros {Id = 5, Name = "C4 Lounge", Marca= Enum.Brand.Citroen, ValorDia = 70 },
                new Carros {Id = 6, Name = "Civic lxr", Marca= Enum.Brand.Honda, ValorDia = 50 },
                new Carros {Id = 7, Name = "Dodge Ram", Marca= Enum.Brand.Dodge, ValorDia = 140 },
                new Carros {Id = 8, Name = "Corvette C7 Stingray", Marca= Enum.Brand.Chevrolet, ValorDia = 390 },
                new Carros {Id = 9, Name = "C63", Marca= Enum.Brand.Mercedez, ValorDia = 200 },
                new Carros {Id = 10, Name = "Gol", Marca= Enum.Brand.Volkswagen, ValorDia = 50 },
                new Carros {Id = 11, Name = "Prius", Marca= Enum.Brand.Toyota, ValorDia = 40 },
                new Carros {Id = 12, Name = "Corolla 2017", Marca= Enum.Brand.Toyota, ValorDia = 45 },
                new Carros {Id = 13, Name = "Yaris", Marca= Enum.Brand.Toyota, ValorDia = 45 },
                new Carros {Id = 14, Name = "Ford Gt 2017", Marca= Enum.Brand.Ford, ValorDia = 500 },
                new Carros {Id = 15, Name = "Bmw M8", Marca= Enum.Brand.Bmw, ValorDia = 360 },
                new Carros {Id = 16, Name = "Fluence", Marca= Enum.Brand.Renault, ValorDia = 55}




                );



            base.OnModelCreating(builder);
        }
    }
}
