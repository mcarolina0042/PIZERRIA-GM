using PIZERRIAGM.Data.Request;
using PIZERRIAGM.Data.Response;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PIZERRIAGM.Data.Entities
{
    // Clase Pizza
    public class Pizza
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; } = null!;

<<<<<<< HEAD
        [Required]
        public int Tamaño { get; set; }

        [Required, Column(TypeName = "decimal(18,2)")]
        public decimal Precio { get; set; }
        public static Pizza Crear(PizzaRequest pizza)
             => new Pizza()
             {
                 Nombre = pizza.Nombre,
                 Tamaño = pizza.Tamaño,
                 Precio = pizza.Precio,

             };
        public bool Modificar(PizzaRequest pizza)
        {
            var cambio = false;
            if (Nombre != pizza.Nombre)
            {
                Nombre = pizza.Nombre;
                cambio = true;
            }
            if (Tamaño != pizza.Tamaño)
            {
                Tamaño = pizza.Tamaño;
                cambio = true;
            }
            if (Precio != pizza.Precio)
            {
                Precio = pizza.Precio;
                cambio = true;
            }

            return cambio;

        }

        public PizzaResponse ToResponse()
        {
            return new PizzaResponse
            {
                Nombre = Nombre,
                Tamaño = Tamaño,
                Precio = Precio,

            };
        }

    }

=======
            [Required]
            public int Tamaño { get; set; } 

        [Required,Column(TypeName ="decimal(18,2)")]
            public decimal Precio { get; set; }
        public static PizzaRequest Crear(PizzaRequest pizza)
             => new PizzaRequest()
             {
                 Nombre = pizza.Nombre,
                 Tamaño = pizza.Tamaño,
                 Precio = pizza.Precio,
                 
             };
        public bool Modificar(PizzaRequest pizza)
        {
            var cambio = false;
            if (Nombre != pizza.Nombre)
            {
                Nombre = pizza.Nombre;
                cambio = true;
            }
            if (Tamaño != pizza.Tamaño)
            {
                Tamaño = pizza.Tamaño;
                cambio = true;
            }
            if (Precio != pizza.Precio)
            {
                Precio = pizza.Precio;
                cambio = true;
            }
            
            return cambio;

        }

        public PizzaResponse ToResponse
        => new PizzaResponse()
        {
            Nombre = Nombre,
            Tamaño = Tamaño,
            Precio = Precio,
            
        };
    }

    
>>>>>>> 2cdf0b53abded4d0bad7ed0d2ff8def3a84b9de8
}
