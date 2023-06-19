using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ToDoList.Domain.Entities;

namespace ToDoList.Infrastructure.EntitiesConfiguration
{
    public class TarefaConfig : IEntityTypeConfiguration<Tarefa>
    {
        public void Configure(EntityTypeBuilder<Tarefa> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(p => p.Titulo).IsRequired();
            builder.Property(p => p.Descricao);
            builder.Property(p => p.Concluida).IsRequired();
        }
    }
}
