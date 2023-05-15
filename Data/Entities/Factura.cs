using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PIZERRIAGM.Data.Entities
{
    // Clase Factura
    public class Factura
        {
            [Key]
            public int Id { get; set; }

            [Required]
            public int ClienteId { get; set; }

            [ForeignKey("ClienteId")]
            public Cliente Cliente { get; set; }

            [Required]
            [StringLength(50)]
            public string Referencia { get; set; }

            public string Extra { get; set; }

            [Required]
            public decimal SubTotal { get; set; }

            [Required]
            public decimal Descuento { get; set; }

            [Required]
            public decimal ITBIS { get; set; }

            [Required]
            public decimal Total { get; set; }

            public ICollection<DetalleFactura> Detalles { get; set; }
        }

    
}
