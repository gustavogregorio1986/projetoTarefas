using Microsoft.EntityFrameworkCore;
using ProjetoEstudoEntity.Dominio.Dominio;
using ProjetoEstudoEntity.Infraestrutura.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstudoEntity.Infraestrutura.Contexto
{
    public class ProjetoEstudoEntityContexto : DbContext
    {
        public ProjetoEstudoEntityContexto(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Tarefa> Tarefas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Apply the entity configuration for Tarefa
            modelBuilder.ApplyConfiguration(new TarefaMap());


            base.OnModelCreating(modelBuilder);
        }

        internal Task<List<Tarefa>> ToListAsync()
        {
            throw new NotImplementedException();
        }
    }
}
