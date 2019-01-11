using System;
using System.Linq;
using Dapper;
using EstabCadastros.Dominio.Entidades;
using System.Linq.Expressions;
using System.Data.SqlClient;
using EstabCadastros.Repositorio.Interfaces;
using System.Collections.Generic;
using System.Data;

namespace EstabCadastros.Repositorio.Repositorios
{
    public class RepositorioEstabelecimentos : Contexto, IRepositorioEstabelecimentos<EntidadeEstabelecimentos>
    {

        public string Inserir(EntidadeEstabelecimentos entidade)
        {
        try
            {
                LimparParamentros();
                AddParametros("@RazaoSocial", entidade.RazaoSocial);
                AddParametros("@NomeFantasia", entidade.NomeFantasia);
                AddParametros("@CNPJ", entidade.CNPJ);
                AddParametros("@Email", entidade.Email);
                AddParametros("@Endereco", entidade.Endereco);
                AddParametros("@Numero", entidade.Numero);
                AddParametros("@Complemento", entidade.Complemento);
                AddParametros("@Bairro", entidade.Bairro);
                AddParametros("@Cidade", entidade.Cidade);
                AddParametros("@CEP", entidade.CEP);
                AddParametros("@Estado", entidade.Estado);
                AddParametros("@Telefone", entidade.Telefone);
                AddParametros("@Agencia", entidade.Agencia);
                AddParametros("@ContaBancaria", entidade.ContaBancaria);
                AddParametros("@Ativo", entidade.Ativo);
                AddParametros("@IdCategoria", entidade.IdCategorias);
                AddParametros("@DataDeCadastro", entidade.DataDeCadastro);
                string retorno = ExecutarComando(CommandType.StoredProcedure, "uspEstabelecimentosInserir").ToString();
                return retorno;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Atualizar(EntidadeEstabelecimentos entidade)
        {
            throw new NotImplementedException();
        }

        public EntidadeEstabelecimentos BuscarId(int id)
        {
            throw new NotImplementedException();
        }

        public string Deletar(EntidadeEstabelecimentos entidade)
        {
            throw new NotImplementedException();
        }

        public string Salvar(EntidadeEstabelecimentos entidade)
        {
            string retorno = "";

            if(entidade.Id<=0)
            {
                retorno = Inserir(entidade);
            }
            if(entidade.Id>0)
            {
                retorno = Atualizar(entidade);
            }

            return retorno;
        }

        public IEnumerable<EntidadeEstabelecimentos> ListarNomes(string param)
        {
            try
            {
                LimparParamentros();
                AddParametros("@RazaoSocial", param);
                DataTable dtEstabelecimentos = new DataTable();
                IList<EntidadeEstabelecimentos> Estab = new List<EntidadeEstabelecimentos>();
                dtEstabelecimentos = ExecutarConsulta(CommandType.StoredProcedure, "upsEstabelecimentosListarNome");
                foreach (DataRow linha in dtEstabelecimentos.Rows)
                {
                    EntidadeEstabelecimentos EntiEstab = new EntidadeEstabelecimentos();
                    EntiEstab.Id = Convert.ToInt32(linha["id"]);
                    EntiEstab.RazaoSocial = linha["RazaoSocial"].ToString();
                    EntiEstab.NomeFantasia = linha["NomeFantasia"].ToString();
                    EntiEstab.CNPJ = linha["CNPJ"].ToString();
                    EntiEstab.Email = linha["Email"].ToString();
                    EntiEstab.Endereco = linha["Endereco"].ToString();
                    EntiEstab.Numero = linha["Numero"].ToString();
                    EntiEstab.Complemento = linha["Complemento"].ToString();
                    EntiEstab.Bairro = linha["Bairro"].ToString();
                    EntiEstab.Cidade = linha["Cidade"].ToString();
                    EntiEstab.CEP = linha["CEP"].ToString();
                    EntiEstab.Estado = linha["Estado"].ToString();
                    EntiEstab.Telefone = linha["Telefone"].ToString();
                    EntiEstab.Agencia = linha["Agencia"].ToString();
                    EntiEstab.ContaBancaria= linha["ContaBancaria"].ToString();
                    EntiEstab.IdCategorias = Convert.ToInt32(linha["idCategorias"]);
                    EntiEstab.Ativo = Convert.ToBoolean(linha["Ativo"]);
                    EntiEstab.DataDeCadastro = Convert.ToDateTime(linha["DataDeCadastro"]);

                    Estab.Add(EntiEstab);
                }

                return Estab;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<EntidadeEstabelecimentos> ListarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
