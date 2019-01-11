using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstabCadastros.Repositorio.Interfaces
{
    public interface IRepositorioEstabelecimentos<E> where E: class
    {
        string Salvar(E entidade);

        string Deletar(E entidade);

        string Atualizar(E entidade);

        E BuscarId(int id);

        IEnumerable<E> ListarTodos();
    }
}
