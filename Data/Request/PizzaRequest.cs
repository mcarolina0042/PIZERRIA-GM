using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PIZERRIAGM.Data.Request
{
    public class PizzaRequest
    {
<<<<<<< HEAD
		[Key]
		public int Id { get; set; }
		public string Nombre { get; set; } = null!;
=======
        public string Nombre { get; set; } = null!;
>>>>>>> 2cdf0b53abded4d0bad7ed0d2ff8def3a84b9de8

        [Required]
        public int Tamaño { get; set; }

        [Required, Column(TypeName = "decimal(18,2)")]
        public decimal Precio { get; set; }
    }
}
