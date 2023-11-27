using System.Collections.Generic;
using System.Linq;
using LasPisadas.Models;

namespace LasPisadas.Services
{
    public class TallaService
    {
        private readonly LasPisadasDbContext _context;

        public TallaService(LasPisadasDbContext context)
        {
            _context = context;
        }

        public List<Tallas> GetAllTallas()
        {
            return _context.Tallas.ToList();
        }

        public void CreateTalla(Tallas nuevaTalla)
        {
            _context.Tallas.Add(nuevaTalla);
            _context.SaveChanges();
        }

        public void UpdateTalla(Tallas tallaActualizada)
        {
            _context.Tallas.Update(tallaActualizada);
            _context.SaveChanges();
        }

        public Tallas GetTallaById(int id)
        {
            return _context.Tallas.FirstOrDefault(t => t.IdTalla == id);
        }
    }
}
