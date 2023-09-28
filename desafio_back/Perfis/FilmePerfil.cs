using AutoMapper;
using desafio_back.Data.Dtos;
using desafio_back.Models;

namespace desafio_back.Perfis
{
    public class FilmePerfil : Profile
    {
        public FilmePerfil() 
        {
            CreateMap<CreateProdutoDto, Produto>();
            CreateMap<AtualizarProdutoDto, Produto>();
            CreateMap<Produto, AtualizarProdutoDto>();
        }
    }
}
