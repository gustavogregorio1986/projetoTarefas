using Microsoft.EntityFrameworkCore;
using ProjetoEstudoEntity.Dominio.Dominio;
using ProjetoEstudoEntity.Infraestrutura.Contexto;
using ProjetoEstudoEntity.Infraestrutura.Repositorio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstudoEntity.Infraestrutura.Repositorio
{
    public class TarefaRepositorio : ITarefaRepositorio
    {
        private readonly ProjetoEstudoEntityContexto _dbContext;

        public TarefaRepositorio(ProjetoEstudoEntityContexto projetoEstudoEntityContexto)
        {
            this._dbContext = projetoEstudoEntityContexto; 
        }

        public async Task<Tarefa> Adicionar(Tarefa tarefa)
        {
            await _dbContext.Tarefas.AddAsync(tarefa);
            await _dbContext.SaveChangesAsync();
            return tarefa;
        }

        public async Task<Tarefa> Atualizar(Tarefa tarefa, int id)
        {
            var tarefaPorId = await BuscarPorId(id);
            tarefaPorId.Titulo = tarefa.Titulo;
            tarefaPorId.DataInicio = tarefa.DataInicio;
            tarefaPorId.DataFim = tarefa.DataFim;
            tarefaPorId.Descricao = tarefa.Descricao;
            _dbContext.Tarefas.Update(tarefa);
            await _dbContext.SaveChangesAsync();

            return tarefaPorId;
        }

        public async Task<Tarefa> BuscarPorId(int id)
        {

          return  await _dbContext.Tarefas.FirstOrDefaultAsync(x => x.Id == id);
            
        }

        public async Task<Tarefa> BuscarPorTitulo(string titulo)
        {
            return await _dbContext.Tarefas.FirstOrDefaultAsync(x => x.Titulo == titulo);
        }

        public async Task<List<Tarefa>> ListarTodasTarefas()
        {
            return await _dbContext.ToListAsync();
        }
    }
}
