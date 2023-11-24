using System.Collections.Generic;
using LasPisadas.Models;
using LasPisadas.Services;
using Microsoft.AspNetCore.Mvc;

namespace LasPisadas.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ZapatoCategoriaController : ControllerBase
    {
        private readonly ZapatoCategoriaService _zapatoCategoriaService;

        public ZapatoCategoriaController(ZapatoCategoriaService zapatoCategoriaService)
        {
            _zapatoCategoriaService = zapatoCategoriaService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ZapatoCategoria>> Get()
        {
            var categorias = _zapatoCategoriaService.GetAllZapatoCategorias();
            return Ok(categorias);
        }

        [HttpPost]
        public IActionResult Post([FromBody] ZapatoCategoria nuevaCategoria)
        {
            if (ModelState.IsValid)
            {
                _zapatoCategoriaService.CreateZapatoCategoria(nuevaCategoria);
                return CreatedAtAction(nameof(Get), new { id = nuevaCategoria.IdCategoria }, nuevaCategoria);
            }
            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] ZapatoCategoria categoriaEditada)
        {
            if (id != categoriaEditada.IdCategoria)
            {
                return BadRequest();
            }

            _zapatoCategoriaService.EditZapatoCategoria(categoriaEditada);
            return NoContent();
        }
    }
}
