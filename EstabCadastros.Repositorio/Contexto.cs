using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace EstabCadastros.Repositorio
{
    public class Contexto
    {
        private SqlConnection Conexao;

        private SqlConnection CriarConexao()
        {
            Conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["strConexao"].ConnectionString);
            return Conexao;
        }

        private SqlParameterCollection sqlParameterCollection = new SqlCommand().Parameters;

        private SqlCommand CriarComando(CommandType cmdType, string nomeProcedure)
        {
            Conexao = CriarConexao();
            Conexao.Open();
            SqlCommand cmd = Conexao.CreateCommand();
            cmd.CommandType = cmdType;
            cmd.CommandText = nomeProcedure;
            cmd.CommandTimeout = 7200;
            foreach (SqlParameter sqlParameter in sqlParameterCollection)
            {
                cmd.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
            }

            return cmd;
        }

        protected void AddParametros(string NomeParamentro, object ValorParametro)
        {
            sqlParameterCollection.AddWithValue(NomeParamentro, ValorParametro);
        }

        protected void LimparParamentros()
        {
            sqlParameterCollection.Clear();
        }

        //Método que executa o CRUD no BD
        protected object ExecutarComando(CommandType cmdType, string nomeProcedure)
        {
            try
            {
                SqlCommand cmd = CriarComando(cmdType, nomeProcedure);
                return cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }

        //Método que executa a consulta no BD
        protected DataTable ExecutarConsulta(CommandType cmdType, string nomeProcedure)
        {
            try
            {
                SqlCommand cmd = CriarComando(cmdType, nomeProcedure);
                DataTable dt = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                sqlDataAdapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }
    }

}
