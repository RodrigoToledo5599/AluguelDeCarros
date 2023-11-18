using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AluguelDeCarros.Enum;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace AluguelDeCarros.Models
{
    public class Usuario : IdentityUser
    {
        
        public ICollection<Carros>? Carros { get; set; }


        
    }
}
