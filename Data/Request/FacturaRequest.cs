using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PIZERRIAGM.Data.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using PIZERRIAGM.Data.Response;

namespace PIZERRIAGM.Data.Request
{
    public class FacturaRequest
    {
        public int Id { get; set; }

        [Required]
        public int ClienteId { get; set; }

        [ForeignKey("ClienteId")]
        public Cliente Cliente { get; set; } = null!;

        [Required]
        [StringLength(50)]
        public string Referencia { get; set; } = null!;

        public string Extra { get; set; } = null!;

        [Required, Column(TypeName = "decimal(18,2)")]
        public decimal SubTotal { get; set; }

        [Required, Column(TypeName = "decimal(18,2)")]
        public decimal Descuento { get; set; }

        [Required, Column(TypeName = "decimal(18,2)")]
        public decimal ITBIS { get; set; }

        [Required, Column(TypeName = "decimal(18,2)")]
        public decimal Total { get; set; }

        public ICollection<DetalleFactura> Detalles { get; set; }
    }
}
