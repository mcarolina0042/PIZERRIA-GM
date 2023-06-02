using PIZERRIAGM.Data.Request;
using PIZERRIAGM.Data.Response;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PIZERRIAGM.Data.Entities
{
    // Clase Factura
    public class Factura
    {
        public Factura()
        {
            Cliente = new Cliente();
            Detalles = new List<DetalleFactura>();
        }
        [Key]
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
        public static FacturaRequest Crear(FacturaRequest factura)
             => new FacturaRequest()
             {
                 ClienteId = factura.ClienteId,
                 Cliente = factura.Cliente,
                 Referencia = factura.Referencia,
                 Extra = factura.Extra,
                 SubTotal = factura.SubTotal,
                 ITBIS = factura.ITBIS,
                 Total = factura.Total,

             };
        public bool Modificar(FacturaRequest factura)
        {
            var cambio = false;
            if (ClienteId != factura.ClienteId)
            {
                ClienteId = factura.ClienteId;
                cambio = true;
            }
            if (Cliente != factura.Cliente)
            {
                Cliente = factura.Cliente;
                cambio = true;
            }
            if (Referencia != factura.Referencia)
            {
                Referencia = factura.Referencia;
                cambio = true;
            }
            if (Extra != factura.Extra)
            {
                Extra = factura.Extra;
                cambio = true;
            }
            if (SubTotal != factura.SubTotal)
            {
                SubTotal = factura.SubTotal;
                cambio = true;
            }
            if (ITBIS != factura.ITBIS)
            {
                ITBIS = factura.ITBIS;
                cambio = true;
            }
            if (Total != factura.Total)
            {
                Total = factura.Total;
                cambio = true;
            }
            return cambio;

        }

        public FacturaResponse ToResponse
        => new FacturaResponse()
        {
            ClienteId = ClienteId,
            Cliente = Cliente,
            Referencia = Referencia,
            Extra = Extra,
            SubTotal = SubTotal,
            ITBIS = ITBIS,
            Total = Total
        };
    
}


}
