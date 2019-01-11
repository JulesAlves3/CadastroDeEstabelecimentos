using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstabCadastros.Repositorio.Interfaces
{
    public interface IRepositorioCategorias<C> where C : class
    {
        string Salvar(C entidade);

        string Deletar(C entidade);

        string Atualizar(C entidade);

        C BuscarId(int id);

        string ListarTodos(E entidade);
    }
}
