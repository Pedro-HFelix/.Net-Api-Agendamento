using Agenda.Models;
using Agenda.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Agenda.ContextDB
{
    public class TarefaContext:DbContext
    {
        public TarefaContext(DbContextOptions<TarefaContext>options) : base(options) { }
        public DbSet<Tarefa> Tarefa { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tarefa>()
                .Property(e => e.status)
                .HasConversion(
                    new EnumToStringConverter<EnumStatusTarefa>()
                );
        }
    }
}
