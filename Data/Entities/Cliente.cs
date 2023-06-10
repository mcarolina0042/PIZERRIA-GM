using PIZERRIAGM.Data.Request;
using PIZERRIAGM.Data.Response;
using System.ComponentModel.DataAnnotations;

namespace PIZERRIAGM.Data.Entities
{
    // Clase Cliente
    public class Cliente
<<<<<<< HEAD
    {
        [Key]
=======
        {
            [Key]
>>>>>>> 2cdf0b53abded4d0bad7ed0d2ff8def3a84b9de8
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; } = null!;

        public static Cliente Crear(ClienteRequest cliente)
           => new Cliente()
           {
               Nombre = cliente.Nombre,
           };
        public bool Modificar(ClienteRequest cliente)
        {
            var cambio = false;
            if (Nombre != cliente.Nombre)
            {
                Nombre = cliente.Nombre;
                cambio = true;
            }
            return cambio;
        }

<<<<<<< HEAD
        public ClienteResponse ToResponse()
        {
            return new ClienteResponse
            {
                Id = Id,
                Nombre = Nombre,


            };
        }

    }
=======
        public ClienteResponse ToResponse
        => new ClienteResponse()
        {
            Nombre = Nombre

        };
    }


>>>>>>> 2cdf0b53abded4d0bad7ed0d2ff8def3a84b9de8
    
}
