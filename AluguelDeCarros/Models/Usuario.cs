using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AluguelDeCarros.Enum;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace AluguelDeCarros.Models
{
    public class Usuario 
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [StringLength(127)]
        public string Name { get; set; }

        [Required]
        [StringLength(127)]
        public string Email { get; set; }

        [Required]
        [StringLength(127)]
        public string Senha { get; set; }

        public Roles? Role { get; set; }

        [StringLength(11)]
        public string? Cpf { get; set; }

        public ICollection<Carros>? Carros { get; set; }


        
    }
}
