
using ToDoList.Domain.Entities;

namespace ToDoList.Domain.Interfaces
{
    public interface ITarefaRepository
    {
        IEnumerable<Tarefa> GetAll();
        Tarefa GetById(int id);
        void Create(Tarefa tarefa);
        void Edit(Tarefa tarefa);
        void Delete(int id);

    }
}
