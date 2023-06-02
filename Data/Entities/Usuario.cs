using PIZERRIAGM.Data.Request;
using PIZERRIAGM.Data.Response;
using System.ComponentModel.DataAnnotations;

namespace PIZERRIAGM.Data.Entities
{

    // Clase Usuario
    public class Usuario
        {
            [Key]
            public int Id { get; set; }

            [Required]
            [StringLength(50)]
            public string Nombre { get; set; } = null!;

        [Required]
            [StringLength(100)]
            [EmailAddress]
            public string Email { get; set; } = null!;

        [Required]
            [StringLength(50)]
            public string Contraseña { get; set; } = null!;

        [Required]
            [StringLength(10)]
            public string Sexo { get; set; } = null!;
        public static Usuario Crear(UsuarioRequest usuario)
           => new Usuario()
           {
               Nombre = usuario.Nombre,
               Email = usuario.Email,
               Contraseña = usuario.Contraseña,
               Sexo = usuario.Sexo,  
           };
        public bool Modificar(UsuarioRequest usuario)
        {
            var cambio = false;
            if (Nombre !=  usuario.Nombre)
            {
                Nombre = usuario.Nombre;
                cambio = true;
            }
            if (Email != usuario.Email)
            {
                Email = usuario.Email;
                cambio = true;
            }
            if (Contraseña != usuario.Contraseña)
            {
                Contraseña = usuario.Contraseña;
                cambio = true;
            }
            if (Sexo != usuario.Sexo)
            {
                Sexo = usuario.Sexo;
                cambio = true;
            }
            
            return cambio;
        }

        public UsuarioResponse ToResponse
        => new UsuarioResponse()
        {
            Nombre = Nombre,
            Email = Email,
            Contraseña = Contraseña,
            Sexo = Sexo,
            
        };
    }

    
}
