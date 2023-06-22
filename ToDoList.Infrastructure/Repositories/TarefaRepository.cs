﻿using ToDoList.Domain.Entities;
using ToDoList.Domain.IRepositories;
using ToDoList.Infrastructure.Context;
using ToDoList.Infrastructure.Repositories.@base;

namespace ToDoList.Infrastructure.Repositories
{
    public class TarefaRepository : Repository<Tarefa>, ITarefaRepository
    {
        public readonly AppDbContext _context;
        public TarefaRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

    }
}
