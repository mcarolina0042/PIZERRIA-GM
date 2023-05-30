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

            [Required]
            public int Tamaño { get; set; }

            [Required,Column(TypeName ="decimal(18,2)")]
            public decimal Precio { get; set; }
        }

    
}
