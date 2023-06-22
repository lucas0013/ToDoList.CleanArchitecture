using Catalogo.Application.Mappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ToDoList.Application.Interfaces;
using ToDoList.Application.Services;
using ToDoList.Domain.Interfaces;
using ToDoList.Domain.IRepositories;
using ToDoList.Infrastructure.Context;
using ToDoList.Infrastructure.Repositories;

namespace ToDoList.CrossCutting.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services,
            IConfiguration configuration)
        {            
            services.AddDbContext<AppDbContext>(options =>
                                options.UseSqlite(configuration.GetConnectionString("DefaultConnection")));


            services.AddScoped<ITarefaRepository, TarefaRepository>();
            services.AddScoped<ITarefaService, TarefaService>();
            
            services.AddScoped<ITagRepository, TagRepository>();
            services.AddScoped<ITagService, TagService>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddAutoMapper(typeof(DomainToDTOMappingProfile));

            /*  Aqui vai ficar as interfaces e também os automappers, por exemplo:
                       services.AddScoped<ICategoriaRepository, CategoriaRepository>();
                services.AddScoped<IProdutoRepository, ProdutoRepository>();
                services.AddScoped<IProdutoService, ProdutoService>();
                services.AddScoped<ICategoriaService, CategoriaService>();

                services.AddAutoMapper(typeof(DomainToDTOMappingProfile));*/

            return services;
        }
    }
}
