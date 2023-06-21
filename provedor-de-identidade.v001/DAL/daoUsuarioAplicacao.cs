using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using provedor_de_identidade.v001.MODEL;

namespace provedor_de_identidade.v001.DAL
{
    public class daoUsuarioAplicacao
    {
        public bool tem = false;
        public string mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao conexao = new Conexao();
        SqlDataReader dr = null;
         

        #region Lista de Usuario/Aplicações
        public DataTable Listar_UsuarioAplicacao()
        {
            cmd.CommandText = "SELECT  u.NomeUsuario AS NOME,a.NomeAplicacao AS APLICAÇÃO, " +
                "CASE WHEN ua.EstadoUsuarioApp = 1 THEN 'Activo' WHEN ua.EstadoUsuarioApp = 0 " +
                "THEN 'Bloqueado' END AS ESTADO FROM TbUsuario u JOIN TbUsuarioAplicacao ua " +
                "JOIN TbAplicacao a ON ua.IdAplicacao = a.IdAplicacao ON ua.IdUsuario = u.IdUsuario";
            DataTable dt = new DataTable();
            cmd.Connection = conexao.Conectar();
            SqlDataReader rdr = cmd.ExecuteReader();
            dt.Load(rdr);
            return dt;
        }
        #endregion

        #region Registar Usuario/Aplicação
        public string Registar_UserApp(modelUsuarioAplicacao modelo)
        {
 
             // comandos para inserir no bd
                cmd.CommandText = "INSERT INTO TbUsuarioAplicacao VALUES (@idUsuario, @idApp, @estado)";
                cmd.Parameters.AddWithValue("@idUsuario", modelo.IdUsuario);
                cmd.Parameters.AddWithValue("@idApp", modelo.IdAplicacao);
                cmd.Parameters.AddWithValue("@estado", modelo.EstadoUsuarioApp);

                try
                {
                    cmd.Connection = conexao.Conectar();
                    cmd.ExecuteNonQuery();
                    conexao.Desconectar();
                    this.mensagem = "Registado com Sucesso!";
                    tem = true;

                }
                catch (SqlException)
                {

                    this.mensagem = "Erro com Banco de Dados";
                }
            
            return mensagem;
        }
        #endregion

        #region Lista de Usuario
        public DataTable Listar_Usuario()
        {
            cmd.CommandText = "SELECT IdUsuario, NomeUsuario FROM TbUsuario";
            DataTable dt = new DataTable();
            cmd.Connection = conexao.Conectar();
            SqlDataReader rdr = cmd.ExecuteReader();
            dt.Load(rdr);
            return dt;
        }
        #endregion


        #region Lista de Aplicação
        public DataTable Listar_Aplicacao()
        {
            cmd.CommandText = "SELECT IdAplicacao, NomeAplicacao FROM TbAplicacao";
            DataTable dt = new DataTable();
            cmd.Connection = conexao.Conectar();
            SqlDataReader rdr = cmd.ExecuteReader();
            dt.Load(rdr);
            return dt;
        }
        #endregion
    }
}
