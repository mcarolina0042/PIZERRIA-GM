using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PIZERRIAGM.Data.Entities
{
    // Clase DetalleFactura
    public class DetalleFactura
        {
            [Key]
            public int Id { get; set; }

            [Required]
            public int FacturaId { get; set; }

            [ForeignKey("FacturaId")]
            public Factura Factura { get; set; }

            [Required]
            public int PizzaId { get; set; }

            [ForeignKey("PizzaId")]
            public Pizza Pizza { get; set; }

            [Required]
            public int Cantidad { get; set; }

            [Required]
            public decimal Precio { get; set; }
        }

    
}
