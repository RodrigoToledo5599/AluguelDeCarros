using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AluguelDeCarros.Enum;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace AluguelDeCarros.Models
{
    public class Usuario : IdentityUser
    {
        [Required]
        [MaxLength(127)]
        // the column that you are actually gonna use as a name for the user since in Identity the name column is just a copy of the Email
        public string RealName { get; set; } 
        public ICollection<Carros>? Carros { get; set; }


        
    }
}
