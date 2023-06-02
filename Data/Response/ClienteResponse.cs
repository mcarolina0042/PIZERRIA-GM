using System.ComponentModel.DataAnnotations;

namespace PIZERRIAGM.Data.Response
{
    public class ClienteResponse
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; } = null!;

    }
}
