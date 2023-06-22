using AutoMapper;
using ToDoList.Application.DTOs;
using ToDoList.Application.Interfaces;
using ToDoList.Domain.Entities;
using ToDoList.Domain.Interfaces;
using ToDoList.Domain.IRepositories;

namespace ToDoList.Application.Services
{
    public class TarefaService : ITarefaService
    {
        public readonly ITarefaRepository _tarefaRepository;
        public readonly IUnitOfWork _unitOfWork;
        public readonly IMapper _mapper;
        public TarefaService(ITarefaRepository tarefaRepository, IMapper mapper, IUnitOfWork unitOfWork) {
            _tarefaRepository = tarefaRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public IEnumerable<TarefaDTO> GetAll()
        {
            return _mapper.Map<IEnumerable<TarefaDTO>>(_unitOfWork.TarefaRepository.Get());
        }
        public TarefaDTO GetById(int id)
        {
            return _mapper.Map<TarefaDTO>(_unitOfWork.TarefaRepository.GetById(p => p.Id == id));
        }
        
        public void Create(TarefaDTO tarefa)
        {
            _unitOfWork.TarefaRepository.Add(_mapper.Map<Tarefa>(tarefa));
            _unitOfWork.Commit();
        }

        public void Edit(TarefaDTO tarefa)
        {
            _unitOfWork.TarefaRepository.Update(_mapper.Map<Tarefa>(tarefa));
            _unitOfWork.Commit();
        }
        public void Delete(int id)
        {
            var tarefa = _unitOfWork.TarefaRepository.GetById(p => p.Id == id);

            if (tarefa == null)
            {
                return;
            }

            _unitOfWork.TarefaRepository.Delete(tarefa);
            _unitOfWork.Commit();
        }
    }
}
