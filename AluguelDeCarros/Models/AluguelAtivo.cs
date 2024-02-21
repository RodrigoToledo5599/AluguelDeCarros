using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AluguelDeCarros.Models
{
    public class AluguelAtivo
    {
        [Key]
        public int Id { get; set; }



        [Required]
        public int CarroId { get; set; }
        [ForeignKey("CarroId")]
        public Carros Carros { get; set; }



        [Required]
        public string UsuarioId { get; set; }

        [ForeignKey("UsuarioId")]
        public Usuario Usuario { get; set; }



        [Required]
        public DateTime CarroPego { get; set; }

        [Required]
        public DateTime DataDeEntrega { get; set; }

        public bool Finalizado { get; set; }
        
    }
}
