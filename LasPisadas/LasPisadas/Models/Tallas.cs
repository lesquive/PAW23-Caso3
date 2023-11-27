using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LasPisadas.Models
{
	public class Tallas
	{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTalla { get; set; }
        public string Nombre { get; set; }
    }
}

