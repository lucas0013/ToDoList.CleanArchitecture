using ToDoList.Application.DTOs;

namespace ToDoList.Application.Interfaces
{
    public interface ITarefaService
    {
        IEnumerable<TarefaDTO> GetAll();
        TarefaDTO GetById(int id);
        void Create(TarefaDTO tarefa);
        void Edit(TarefaDTO tarefa);
        void Delete(int id);
    }
}
