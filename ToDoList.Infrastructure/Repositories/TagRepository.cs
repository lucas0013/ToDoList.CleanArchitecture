using ToDoList.Domain.Entities;
using ToDoList.Domain.IRepositories;
using ToDoList.Infrastructure.Context;
using ToDoList.Infrastructure.Repositories.@base;

namespace ToDoList.Infrastructure.Repositories
{
    public class TagRepository : Repository<Tag>, ITagRepository
    {
        public readonly AppDbContext _context;
        public TagRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
    }
}