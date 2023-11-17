

using AluguelDeCarros.Data.DTO.Carros;
using AluguelDeCarros.Data.Repo.IRepo;
using AluguelDeCarros.Models;
using AutoMapper;

namespace AluguelDeCarros.Services.RemapingServices
{
    public class CarroDtoFullyRemap
    {
        private readonly IUnitOfWork _db;
        private readonly IMapper _mapper;

        public Carros Carro { get; set; }

        public CarroDtoFullyRemap(IUnitOfWork db, Carros carro, IMapper mapper)
        {
            _db = db;
            Carro = carro;
            _mapper = mapper;
        }

        /*
        public CarrosDto FullRemapCarrosDto() 
        {
            CarrosDto carrosDto = new CarrosDto();
            carrosDto = _mapper.Map<CarrosDto>(Carro);

        }
        */



    }
}
