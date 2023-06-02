using PIZERRIAGM.Data.Entities;
using System.ComponentModel.DataAnnotations;

namespace PIZERRIAGM.Data.Request
{
    public class ClienteRequest
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; } = null!;

    }
}
