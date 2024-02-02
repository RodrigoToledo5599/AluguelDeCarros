using System.ComponentModel.DataAnnotations.Schema;
using AluguelDeCarros.Data.Repo.IRepo;
using AluguelDeCarros.Enum;
using AluguelDeCarros.Models;

namespace AluguelDeCarros.Data.DTO.Carros
{
    public class CarrosDto
    {

        //public int Id { get; set; }
        public string Name { get; set; }
        [NotMapped]

        public string? Marca { get; set; }
        public bool Alugado { get; set; }
        public int ValorDia { get; set; }
        




    }
}
