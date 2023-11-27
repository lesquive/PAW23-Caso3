using System.Collections.Generic;
using LasPisadas.Models;
using LasPisadas.Services;
using Microsoft.AspNetCore.Mvc;

namespace LasPisadas.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TallaController : ControllerBase
    {
        private readonly TallaService _tallaService;

        public TallaController(TallaService tallaService)
        {
            _tallaService = tallaService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Tallas>> Get()
        {
            var tallas = _tallaService.GetAllTallas();
            return Ok(tallas);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Tallas nuevaTalla)
        {
            if (ModelState.IsValid)
            {
                _tallaService.CreateTalla(nuevaTalla);
                return CreatedAtAction(nameof(Get), new { id = nuevaTalla.IdTalla }, nuevaTalla);
            }
            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Tallas tallaEditada)
        {
            if (id != tallaEditada.IdTalla)
            {
                return BadRequest();
            }

            _tallaService.UpdateTalla(tallaEditada);
            return NoContent();
        }
    }
}
