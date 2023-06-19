using AutoMapper;
using ToDoList.Application.DTOs;
using ToDoList.Domain.Entities;

namespace Catalogo.Application.Mappings
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile()
        {
            CreateMap<Tarefa, TarefaDTO>().ReverseMap();
        }
    }
}
