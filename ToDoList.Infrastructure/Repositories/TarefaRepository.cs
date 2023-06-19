using ToDoList.Domain.Entities;
using ToDoList.Domain.Interfaces;
using ToDoList.Infrastructure.Context;

namespace ToDoList.Infrastructure.Repositories
{
    public class TarefaRepository : ITarefaRepository
    {
        public readonly AppDbContext _context;
        public TarefaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Tarefa> GetAll(){
            return _context.Tarefas.ToList();
        }

        public Tarefa GetById(int id)
        {
            return _context.Tarefas.FirstOrDefault(t => t.Id == id);
        }

        public void Create(Tarefa tarefa)
        {
            _context.Tarefas.Add(tarefa);
            _context.SaveChanges();
        }
        public void Edit(Tarefa tarefa)
        {
            _context.Tarefas.Update(tarefa);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var tarefa = _context.Tarefas.FirstOrDefault(t => t.Id == id);
            if (tarefa != null) { 
                _context.Tarefas.Remove(tarefa);
            }
            _context.SaveChanges();
        }
    }
}
