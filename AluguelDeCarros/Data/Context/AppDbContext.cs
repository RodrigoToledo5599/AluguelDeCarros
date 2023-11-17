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
        public DbSet<DmMarcas> DmMarcas { get; set; }





        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Usuario>().HasData(
                new Usuario { Id = Guid.NewGuid().ToString(), Name="Rodrigo",Email= "ddd@gmail.com",Senha= "123" },
                new Usuario { Id = Guid.NewGuid().ToString(), Name="Adm",Email= "adm@gmail.com", Senha= "123", Role = Enum.Roles.Admin }
                
                    

                );

            builder.Entity<DmMarcas>().HasData(

                new DmMarcas { Id = 1, Name = "Volkswagen", Marca = Enum.Brand.Volkswagen},
                new DmMarcas { Id = 2, Name = "Fiat", Marca = Enum.Brand.Fiat},
                new DmMarcas { Id = 3, Name = "Chevrolet", Marca = Enum.Brand.Chevrolet},
                new DmMarcas { Id = 4, Name = "Ford", Marca = Enum.Brand.Ford},
                new DmMarcas { Id = 5, Name = "Honda", Marca = Enum.Brand.Honda},
                new DmMarcas { Id = 6, Name = "Suzuki", Marca = Enum.Brand.Suzuki},
                new DmMarcas { Id = 7, Name = "Toyota", Marca = Enum.Brand.Toyota},
                new DmMarcas { Id = 8, Name = "Bmw", Marca = Enum.Brand.Bmw},
                new DmMarcas { Id = 9, Name = "Renault", Marca = Enum.Brand.Renault},
                new DmMarcas { Id = 10, Name = "Citroen", Marca = Enum.Brand.Citroen},
                new DmMarcas { Id = 11, Name = "Dodge", Marca = Enum.Brand.Dodge},
                new DmMarcas { Id = 12, Name = "Mercedez", Marca = Enum.Brand.Mercedez}
                );

            builder.Entity<Carros>().HasData(

                new Carros {Id = 1, Name = "Celta", MarcaId= ((int)Enum.Brand.Chevrolet), ValorDia=30},
                new Carros {Id = 2, Name = "Uno", MarcaId= ((int)Enum.Brand.Fiat), ValorDia = 30 },
                new Carros {Id = 3, Name = "Palio", MarcaId = ((int)Enum.Brand.Fiat), ValorDia = 30 },
                new Carros {Id = 4, Name = "Fusion", MarcaId = ((int)Enum.Brand.Ford), ValorDia = 80 },
                new Carros {Id = 5, Name = "C4 Lounge", MarcaId = ((int)Enum.Brand.Citroen), ValorDia = 70 },
                new Carros {Id = 6, Name = "Civic lxr", MarcaId = ((int)Enum.Brand.Honda), ValorDia = 50 },
                new Carros {Id = 7, Name = "Dodge Ram", MarcaId = ((int)Enum.Brand.Dodge), ValorDia = 140 },
                new Carros {Id = 8, Name = "Corvette C7 Stingray", MarcaId = ((int)Enum.Brand.Chevrolet), ValorDia = 390 },
                new Carros {Id = 9, Name = "C63", MarcaId = ((int)Enum.Brand.Mercedez), ValorDia = 200 },
                new Carros {Id = 10, Name = "Gol", MarcaId = ((int)Enum.Brand.Volkswagen), ValorDia = 50 },
                new Carros {Id = 11, Name = "Prius", MarcaId = ((int)Enum.Brand.Toyota), ValorDia = 40 },
                new Carros {Id = 12, Name = "Corolla 2017", MarcaId = ((int)Enum.Brand.Toyota), ValorDia = 45 },
                new Carros {Id = 13, Name = "Yaris", MarcaId = ((int)Enum.Brand.Toyota), ValorDia = 45 },
                new Carros {Id = 14, Name = "Ford Gt 2017", MarcaId = ((int)Enum.Brand.Ford), ValorDia = 500 },
                new Carros {Id = 15, Name = "Bmw M8", MarcaId = ((int)Enum.Brand.Bmw), ValorDia = 360 },
                new Carros {Id = 16, Name = "Fluence", MarcaId = ((int)Enum.Brand.Renault), ValorDia = 55}




                );



            base.OnModelCreating(builder);
        }
    }
}
