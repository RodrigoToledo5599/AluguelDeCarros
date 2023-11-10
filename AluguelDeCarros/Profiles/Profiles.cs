using AluguelDeCarros.Data.DTO.Carros;
using AluguelDeCarros.Models;
using AutoMapper;

namespace AluguelDeCarros.Profiles
{
    public class Profiles : Profile
    {
        public Profiles()
        {
            CreateMap<Carros, CarrosDto>();       
            CreateMap<CarrosDto, Carros>();     
            


        }
    }
}
