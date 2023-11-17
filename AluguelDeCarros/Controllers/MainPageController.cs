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
        public readonly IUnitOfWork _db;
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
            

            List<CarrosDto> CarrosRemap = new List<CarrosDto>();

            foreach (var car in listaDeCarros)
            {
                var carroRemapAtual = _mapper.Map<CarrosDto>(car);
                int idNumber = car.Id;
                DmMarcas marca = new DmMarcas();
                marca = await _db.Marcas.getMarcaFromCarro(idNumber);
                carroRemapAtual.Marca = marca.Marca.ToString();
                CarrosRemap.Add(carroRemapAtual);

            }
            return Ok(CarrosRemap);
            
            
        }
        
        [HttpGet("GetSomeOfTheCars")]
        public async Task<IActionResult> ListCars(int inicio, int fim)
        {
            var listaDeCarros = await _db.Carros.GetIntervalo(inicio,fim);
            List<CarrosDto> CarrosRemap = new List<CarrosDto>();

            foreach (var car in listaDeCarros)
            {
                var carroRemapAtual = _mapper.Map<CarrosDto>(car);
                int idNumber = car.Id;
                DmMarcas marca = new DmMarcas();
                marca = await _db.Marcas.getMarcaFromCarro(idNumber);
                carroRemapAtual.Marca = marca.Marca.ToString();
                CarrosRemap.Add(carroRemapAtual);
            }
            return Ok(CarrosRemap);
        }

        [HttpGet("ReturnCarById")]
        public async Task<IActionResult> GetCarById(int id) 
        {
            Carros carro  = new Carros();
            CarrosDto result = new CarrosDto();
            int idNumber = 0;
            try
            {
                carro = await _db.Carros.GetById(c => c.Id == id);
                result = _mapper.Map<CarrosDto>(carro);
            }
            catch (Exception ex)
            {
                return BadRequest("Esse carro nao existe");
            }

            idNumber = carro.Id;
            
            DmMarcas marca = new DmMarcas();


            // nao sei pq mas o meu banco ainda nao deixou a categoria de marcas na table de carros como nao nullable, entao por enquanto essa validação abaixo nao serve pra nada.
            try
            {
                marca = await _db.Marcas.getMarcaFromCarro(idNumber);
                result.Marca = marca.Marca.ToString();
            }
            catch (Exception ex)
            {
                result.Marca = "";
            }
            
            return Ok(result);
        }
        


    }
}
