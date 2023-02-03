using AngularPeliculasAPI.DTOs;
using AngularPeliculasAPI.Entidades;
using AutoMapper;

namespace AngularPeliculasAPI.Utilidades
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Genero, GeneroDTO>().ReverseMap();
            CreateMap<GeneroCreacionDTO, Genero>();
        }
    }
}
