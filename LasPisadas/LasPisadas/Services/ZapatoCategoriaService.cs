using System.Collections.Generic;
using System.Linq;
using LasPisadas.Models;

namespace LasPisadas.Services
{
    public class ZapatoCategoriaService
    {
        private readonly LasPisadasDbContext _context;

        public ZapatoCategoriaService(LasPisadasDbContext context)
        {
            _context = context;
        }

        public List<ZapatoCategoria> GetAllZapatoCategorias()
        {
            return _context.ZapatoCategorias.ToList();
        }

        public void CreateZapatoCategoria(ZapatoCategoria nuevaCategoria)
        {
            _context.ZapatoCategorias.Add(nuevaCategoria);
            _context.SaveChanges();
        }

        public void EditZapatoCategoria(ZapatoCategoria categoriaEditada)
        {
            var existingCategoria = _context.ZapatoCategorias.Find(categoriaEditada.IdCategoria);

            if (existingCategoria != null)
            {
                existingCategoria.Nombre = categoriaEditada.Nombre;
                _context.SaveChanges();
            }
        }
    }
}
