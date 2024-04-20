using AluguelDeCarros.Data.DTO.Carros;
using AluguelDeCarros.Data.Repo.IRepo;
using AluguelDeCarros.Models;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AluguelDeCarros.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
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

        //[Authorize(AuthenticationSchemes ="Bearer")]
        //[Authorize]
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
            Carros? carro  = new Carros();
            CarrosDto? result = new CarrosDto();
            
            carro = await _db.Carros.GetById(c => c.Id == id);
            
            if(carro != null)
            {
                result = _mapper.Map<CarrosDto>(carro);
                return Ok(result);
            }
            else
            {
                return BadRequest("Esse carro nao existe");
            }

        }
    }
}