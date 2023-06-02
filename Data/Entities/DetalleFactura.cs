using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using PIZERRIAGM.Data.Request;
using PIZERRIAGM.Data.Response;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PIZERRIAGM.Data.Entities
{
    // Clase DetalleFactura
    public class DetalleFactura
        {
        public DetalleFactura()
        {
            Factura = new Factura();
            Pizza = new Pizza();
        }
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

        [Required, Column(TypeName = "decimal(18,2)")]
        public decimal Precio { get; set; }

        public static DetalleFactura Crear(DetalleFacturaRequest detalleFactura)
           => new DetalleFactura()
           {
               FacturaId = detalleFactura.FacturaId,
               Factura = detalleFactura.Factura,
               PizzaId = detalleFactura.PizzaId,
               Pizza = detalleFactura.Pizza,
               Cantidad = detalleFactura.Cantidad,
               Precio = detalleFactura.Precio,
           };
        public bool Modificar(DetalleFacturaRequest detalleFactura)
        {
            var cambio = false;
            if (FacturaId != detalleFactura.FacturaId)
            {
                FacturaId = detalleFactura.FacturaId;
                cambio = true;
            }
            if (Factura != detalleFactura.Factura)
            {
                Factura = detalleFactura.Factura;
                cambio = true;
            }
            if (PizzaId != detalleFactura.PizzaId)
            {
                PizzaId = detalleFactura.PizzaId;
                cambio = true;
            }
            if (Pizza != detalleFactura.Pizza)
            {
                Pizza = detalleFactura.Pizza;
                cambio = true;
            }
            if (Cantidad != detalleFactura.Cantidad)
            {
                Cantidad = detalleFactura.Cantidad;
                cambio = true;
            }
            if (Precio != detalleFactura.Precio)
            {
                Precio = detalleFactura.Precio;
                cambio = true;
            }
            return cambio;
        }

        public DetalleFacturaResponse ToResponse
        => new DetalleFacturaResponse()
        {
            FacturaId = FacturaId,
            Factura = Factura,
            PizzaId = PizzaId,
            Pizza = Pizza,
            Cantidad = Cantidad,
            Precio = Precio
        };
    }

    
}
