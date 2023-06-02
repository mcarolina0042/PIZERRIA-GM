using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PIZERRIAGM.Data.Response
{
    public class PizzaResponse
    {
		[Key]
		public int Id { get; set; }
		public string Nombre { get; set; } = null!;

        [Required]
        public int Tamaño { get; set; }

        [Required, Column(TypeName = "decimal(18,2)")]
        public decimal Precio { get; set; }
    }
}
