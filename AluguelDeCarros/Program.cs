using System.Text;
using AluguelDeCarros.Data.Context;
using AluguelDeCarros.Data.Repo;
using AluguelDeCarros.Data.Repo.IRepo;
using AluguelDeCarros.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using AluguelDeCarros.Utils.User;

namespace AluguelDeCarros
{
    public class Program
    {
        private readonly AppDbContext _db;
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            // Add services to the container.

            builder.Services.AddAuthorization();
            //builder.Services.AddAuthentication("Bearer").AddJwtBearer();


            var connectionString = builder.Configuration.GetConnectionString("Default");
            var context = builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(connectionString));
            
            
            //UTILS ------------------------------------------------------------------------------------------------------------------
            builder.Services.AddScoped<IUserUtils, UserUtils>();
            //------------------------------------------------------------------------------------------------------------------------





            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
            builder.Services.AddIdentity<Usuario, IdentityRole>()
                .AddEntityFrameworkStores<AppDbContext>()
                .AddDefaultTokenProviders();
             
            builder.Services.AddAuthorization();
            builder.Services.AddEndpointsApiExplorer();


            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "AluguelDeCarros", Version = "v1" });
            });

            builder.Services.AddAutoMapper(typeof(Profiles.Profiles));
            builder.Services.AddControllers();
            builder.Services.AddRazorPages();

            

            var app = builder.Build();



            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "AluguelDeCarros");
            });
            


            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseCors(builder => builder
                .AllowAnyHeader()
                .AllowAnyMethod()
                .AllowAnyOrigin()
    );
            app.UseAuthentication();
            app.UseAuthorization();
            app.MapControllers();

            app.Run();
        }
    }
}