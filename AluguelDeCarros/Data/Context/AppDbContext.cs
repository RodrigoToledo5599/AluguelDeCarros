using AluguelDeCarros.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AluguelDeCarros.Data.Context
{
    public class AppDbContext : IdentityDbContext<Usuario>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { } 

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Carros> Carros { get; set; }





        protected override void OnModelCreating(ModelBuilder builder)
        {





            base.OnModelCreating(builder);
        }
    }
}
