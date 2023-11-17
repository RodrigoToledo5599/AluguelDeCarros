using System.ComponentModel.DataAnnotations;
using AluguelDeCarros.Enum;

namespace AluguelDeCarros.Models
{
    public class DmMarcas
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(127)]
        public string Name { get; set; }
        [Required]
        public Brand Marca { get; set; }



    }
}
