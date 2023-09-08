using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace AluguelDeCarros.Models
{
    public class Usuario : IdentityUser
    {

        
        


        public ICollection<Carros>? Carros { get; set; }

    }
}
