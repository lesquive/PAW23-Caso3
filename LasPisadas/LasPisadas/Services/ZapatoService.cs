using System.Collections.Generic;
using System.Linq;
using LasPisadas.Models;

namespace LasPisadas.Services
{
    public class ZapatoService
    {
        private readonly LasPisadasDbContext _context;

        public ZapatoService(LasPisadasDbContext context)
        {
            _context = context;
        }

        public List<Zapato> GetAllZapatos()
        {
            return _context.Zapatos.ToList();
        }

        public void CreateZapato(Zapato nuevoZapato)
        {
            _context.Zapatos.Add(nuevoZapato);
            _context.SaveChanges();
        }

        public void UpdateZapato(Zapato zapatoActualizado)
        {
            _context.Zapatos.Update(zapatoActualizado);
            _context.SaveChanges();
        }

        public Zapato GetZapatoById(int id)
        {
            return _context.Zapatos.FirstOrDefault(z => z.IdZapato == id);
        }

    }
}
