using System.ComponentModel.DataAnnotations;

namespace PIZERRIAGM.Data.Request
{
    public class UsuarioRequest
    {
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
    }
}
