using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PIZERRIAGM.Data.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PIZERRIAGM.Data.Response
{
    public class DetalleFacturaResponse
    {
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

        [Required, Column(TypeName = "decimal(18,2)")]
        public decimal Precio { get; set; }
    }
}
