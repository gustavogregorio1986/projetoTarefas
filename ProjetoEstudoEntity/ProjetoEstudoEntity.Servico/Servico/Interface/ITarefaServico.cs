using ProjetoEstudoEntity.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstudoEntity.Servico.Servico.Interface
{
    public interface ITarefaServico
    {
        void Adicionar();

        void Atuaizar(Tarefa tarefa);

        void Deletar(int id);

        Tarefa BusraPorId(int id);

        void BuscarPorTitulo(string titulo);
    }
}
