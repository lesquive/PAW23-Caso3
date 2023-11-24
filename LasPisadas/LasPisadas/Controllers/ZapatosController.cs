using Microsoft.AspNetCore.Mvc;
using LasPisadas.Models; 
using LasPisadas.Services; 

namespace LasPisadas.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ZapatosController : ControllerBase
    {
        private readonly ZapatoService _zapatoService;

        public ZapatosController(ZapatoService zapatoService)
        {
            _zapatoService = zapatoService;
        }

        [HttpGet]
        public IActionResult GetAllZapatos()
        {
            var zapatos = _zapatoService.GetAllZapatos();
            return Ok(zapatos);
        }

        [HttpPost]
        public IActionResult CreateZapato(Zapato nuevoZapato)
        {
            _zapatoService.CreateZapato(nuevoZapato);
            return CreatedAtAction(nameof(GetAllZapatos), new { id = nuevoZapato.IdZapato }, nuevoZapato);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateZapato(int id, Zapato zapatoActualizado)
        {
            if (id != zapatoActualizado.IdZapato)
            {
                return BadRequest();
            }

            _zapatoService.UpdateZapato(zapatoActualizado);
            return NoContent();
        }

        [HttpGet("{id}")]
        public IActionResult GetZapatoById(int id)
        {
            var zapato = _zapatoService.GetZapatoById(id);
            if (zapato == null)
            {
                return NotFound();
            }

            return Ok(zapato);
        }

    }
}
