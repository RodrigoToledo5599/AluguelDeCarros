using AluguelDeCarros.Data.DTO.Carros;
using AluguelDeCarros.Data.DTO.Usuario;
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

            CreateMap<UsuarioSignInDTO, UsuarioDTO>();
            CreateMap<UsuarioDTO, UsuarioSignInDTO>();

            CreateMap<UsuarioSignInDTO, Usuario>();
            CreateMap<Usuario, UsuarioSignInDTO>();

            CreateMap<Usuario, UsuarioDTO>();
            CreateMap<UsuarioDTO, Usuario>();

        }
    }
}
