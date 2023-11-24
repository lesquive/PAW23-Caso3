using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LasPisadas.Models
{
	public class Zapato
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdZapato { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string DescripcionCorta { get; set; }
        public string DescripcionDetallada { get; set; }
        public decimal Precio { get; set; }

        public List<ZapatoCategoria> CategoriasZapato { get; set; }
    }
}

