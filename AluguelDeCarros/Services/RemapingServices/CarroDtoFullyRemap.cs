

using AluguelDeCarros.Data.DTO.Carros;
using AluguelDeCarros.Data.Repo.IRepo;
using AluguelDeCarros.Models;
using AutoMapper;

namespace AluguelDeCarros.Services.RemapingServices
{
    public class CarroDtoFullyRemap
    {
 
        private readonly IMapper _mapper;

        public Carros Carro { get; set; }

        public CarroDtoFullyRemap(Carros carro, IMapper mapper)
        {
            Carro = carro;
            _mapper = mapper;
        }

        

    }

}
