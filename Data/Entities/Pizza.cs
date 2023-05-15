using System.ComponentModel.DataAnnotations;

namespace PIZERRIAGM.Data.Entities
{
    // Clase Pizza
    public class Pizza
        {
            [Key]
            public int Id { get; set; }

            [Required]
            [StringLength(50)]
            public string Nombre { get; set; }

            [Required]
            public int Tamaño { get; set; }

            [Required]
            public decimal Precio { get; set; }
        }

    
}
