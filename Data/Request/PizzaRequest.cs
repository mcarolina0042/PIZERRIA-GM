using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PIZERRIAGM.Data.Request
{
    public class PizzaRequest
    {
        public string Nombre { get; set; } = null!;

        [Required]
        public int Tamaño { get; set; }

        [Required, Column(TypeName = "decimal(18,2)")]
        public decimal Precio { get; set; }
    }
}
