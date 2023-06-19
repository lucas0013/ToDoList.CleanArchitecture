using AutoMapper;
using ToDoList.Application.DTOs;
using ToDoList.Application.Interfaces;
using ToDoList.Domain.Entities;
using ToDoList.Domain.Interfaces;

namespace ToDoList.Application.Services
{
    public class TarefaService : ITarefaService
    {
        public readonly ITarefaRepository _tarefaRepository;
        public readonly IMapper _mapper;
        public TarefaService(ITarefaRepository tarefaRepository, IMapper mapper) {
            _tarefaRepository = tarefaRepository;
            _mapper = mapper;
        }

        public IEnumerable<TarefaDTO> GetAll()
        {
            return _mapper.Map<IEnumerable<TarefaDTO>>(_tarefaRepository.GetAll());
        }
        public TarefaDTO GetById(int id)
        {
            return _mapper.Map<TarefaDTO>(_tarefaRepository.GetById(id));
        }
        
        public void Create(TarefaDTO tarefa)
        {
            _tarefaRepository.Create(_mapper.Map<Tarefa>(tarefa));
        }

        public void Edit(TarefaDTO tarefa)
        {
            _tarefaRepository.Edit(_mapper.Map<Tarefa>(tarefa));
        }
        public void Delete(int id)
        {
            _tarefaRepository.Delete(id);
        }
    }
}
