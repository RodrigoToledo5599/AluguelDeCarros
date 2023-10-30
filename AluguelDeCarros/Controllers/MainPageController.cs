using AluguelDeCarros.Data.Context;
using AluguelDeCarros.Data.Repo.IRepo;
using AluguelDeCarros.Models;
using Microsoft.AspNetCore.Mvc;

namespace AluguelDeCarros.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MainPageController : ControllerBase
    {
        //private readonly AppDbContext _db;
        private readonly ICarrosRepository _carRepo;
        public MainPageController(ICarrosRepository db)
        {
            _carRepo = db;
        }


        [HttpGet]
        public IActionResult ListCars()
        {
            var listaDeCarros = _carRepo.GetAll();
            return Ok(listaDeCarros);
        }
        
        [HttpGet("{id}",Name="ReturnCarById")]
        public IActionResult GetCarById(int id) 
        {
            Carros carro = _carRepo.GetById(c => c.Id ==  id);
            return Ok(carro);
        }
        


    }
}
