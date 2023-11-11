using AluguelDeCarros.Data.Context;
using AluguelDeCarros.Data.DTO.Carros;
using AluguelDeCarros.Data.Repo;
using AluguelDeCarros.Data.Repo.IRepo;
using AluguelDeCarros.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Extensions;

namespace AluguelDeCarros.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MainPageController : ControllerBase
    {
        private readonly IUnitOfWork _db;
        private readonly IMapper _mapper;
        public MainPageController(IUnitOfWork db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }


        /// <summary>
        /// Retorna todos os Carros
        /// </summary>
        /// <returns></returns>

        [HttpGet("GetAllCars")]
        public async Task<IActionResult> ListCars()
        {
            var listaDeCarros = await _db.Carros.GetAll();
            /*
            List<CarrosDto> CarrosRemap = new List<CarrosDto>();

            foreach (var car in listaDeCarros)
            {
                var carroRemapAtual = _mapper.Map<CarrosDto>(car);
                CarrosRemap.Add(carroRemapAtual);
            }
            return Ok(CarrosRemap);
            */
            return Ok(listaDeCarros);
        }
        
        [HttpGet("GetSomeOfTheCars")]
        public async Task<IActionResult> ListCars(int inicio, int fim)
        {
            var listaDeCarros = await _db.Carros.GetIntervalo(inicio,fim);
            List<CarrosDto> CarrosRemap = new List<CarrosDto>();

            foreach (var car in listaDeCarros)
            {
                var carroRemapAtual = _mapper.Map<CarrosDto>(car);
                CarrosRemap.Add(carroRemapAtual);
            }
            return Ok(CarrosRemap);
        }

        [HttpGet("ReturnCarById")]
        public async Task<IActionResult> GetCarById(int id) 
        {

            Carros carro = await _db.Carros.GetById(c => c.Id == id);
            return Ok(carro);
        }
        


    }
}
