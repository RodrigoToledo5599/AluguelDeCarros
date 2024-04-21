using AluguelDeCarros.Data.Context;
using AluguelDeCarros.Data.Repo.IRepo;
using AluguelDeCarros.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AluguelDeCarros.Controllers
{
    /*
    */
    [ApiController]
    [Route("api/[controller]")]
    public class AluguelController : ControllerBase
    {
        public readonly IUnitOfWork _db;
        public AluguelController(IUnitOfWork db)
        {
            _db = db;
        }
        [HttpPost("AlugarCarro")]
        [Authorize]
        public async Task<IActionResult> AlugarCarro (int CarroId, string UsuarioId, int valor, int valorDiarioDoCarro)
        {
            Aluguel aluguel = new Aluguel();

            int diasDeAluguel = (int)(valor / valorDiarioDoCarro);

            aluguel.CarroId = CarroId;
            aluguel.UsuarioId = UsuarioId;
            aluguel.CarroPego = DateTime.Now;
            aluguel.DataDeEntrega = DateTime.Now.AddDays(diasDeAluguel);
            aluguel.Finalizado = false;

            var result = await _db.Aluguel.Alugar(aluguel);

            return Ok(result);


        }
        /*
        public IActionResult MostrarCarrosAlugadosDoUsuario()
        {
            return Ok("AllCars");
        }

        public IActionResult MostrarTodosOsCarrosAlugados()
        {
            return Ok("AllCars");
        }

        public IActionResult AumentarTempoDeAluguel()
        {
            return Ok("AllCars");
        }

        public IActionResult DevolverCarro()
        {
            return Ok("AllCars");
        }
        */
    }
}
