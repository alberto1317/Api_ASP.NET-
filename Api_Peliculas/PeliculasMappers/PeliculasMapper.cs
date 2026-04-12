using Api_Peliculas.Modelos;
using Api_Peliculas.Modelos.Dtos;
using AutoMapper;

namespace Api_Peliculas.PeliculasMapper
{
    public class PeliculasMapper :Profile
    {
        public PeliculasMapper()
        {
            CreateMap<Categoria, CategoriaDto>().ReverseMap();
            CreateMap<Categoria, CrearCategoriaDto>().ReverseMap();
            CreateMap<Pelicula, PeliculaDto>().ReverseMap();
            CreateMap<Pelicula, CreaerPeliculaDto>().ReverseMap();
        }
    }
}
