using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstabCadastros.Repositorio.Interfaces;
using EstabCadastros.Dominio.Entidades;
using Dapper;

namespace EstabCadastros.Repositorio.Repositorios
{
    public class RepositorioCategorias : Contexto, IRepositorioCategorias<RepositorioCategorias>
    {

        public string Inserir(EntidadeCategorias entidade)
        {
            return null;
        }

        public string Atualizar(RepositorioCategorias entidade)
        {
            throw new NotImplementedException();
        }

        public RepositorioCategorias BuscarId(int id)
        {
            throw new NotImplementedException();
        }

        public string Deletar(RepositorioCategorias entidade)
        {
            throw new NotImplementedException();
        }

        public string Salvar(RepositorioCategorias entidade)
        {
            throw new NotImplementedException();
        }

        public string ListarTodos(RepositorioEstabelecimentos entidade)
        {
            throw new NotImplementedException();
        }
    }
}
