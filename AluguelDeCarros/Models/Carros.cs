using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AluguelDeCarros.Enum;

namespace AluguelDeCarros.Models
{
    public class Carros
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(127)]
        public string Name { get; set; }        
        
        public int MarcaId { get; set; }
        [ForeignKey("MarcaId")]
        public DmMarcas DmMarcas { get; set; }

        public bool Alugado { get; set; }

        [Required]
        public int ValorDia { get; set; }

    }

}
