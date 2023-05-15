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
            public string Nombre { get; set; }

            [Required]
            [StringLength(100)]
            [EmailAddress]
            public string Email { get; set; }

            [Required]
            [StringLength(50)]
            public string Contraseña { get; set; }

            [Required]
            [StringLength(10)]
            public string Sexo { get; set; }
        }

    
}
