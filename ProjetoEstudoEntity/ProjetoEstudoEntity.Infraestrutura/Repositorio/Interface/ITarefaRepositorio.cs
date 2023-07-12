using ProjetoEstudoEntity.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstudoEntity.Infraestrutura.Repositorio.Interface
{
    public interface ITarefaRepositorio
    {
        Task<Tarefa> Adicionar(Tarefa tarefa);

        Task<List<Tarefa>> ListarTodasTarefas();

        Task<Tarefa> BuscarPorId(int id);

        Task<Tarefa> BuscarPorTitulo(string titulo);

        Task<Tarefa> Atualizar(Tarefa tarefa, int id);


    }
}
