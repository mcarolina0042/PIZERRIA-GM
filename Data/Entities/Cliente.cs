using System.ComponentModel.DataAnnotations;

namespace PIZERRIAGM.Data.Entities
{
    // Clase Cliente
    public class Cliente
        {
            [Key]
            public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; } = null!;
        }

    
}
