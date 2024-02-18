using Microsoft.AspNetCore.Mvc;

namespace AluguelDeCarros.Controllers
{
    public class AluguelController : ControllerBase
    {
        public IActionResult Alugar()
        {
            return Ok("Alugado sua bicha");
        }

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

    }
}
