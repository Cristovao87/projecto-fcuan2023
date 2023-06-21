using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provedor_de_identidade.v001.DAL
{
    public class daoDashboard
    {
       
        public int NumUsuario { get; private set; }
        public int NumApp { get; private set; }
        public int NumComputador { get; private set; }
        public int NumLogin { get; set; }
        public string mensagem;
       

        SqlCommand cmd = new SqlCommand();
        Conexao conexao = new Conexao();
        SqlDataReader dr = null;


        #region Retorna o Número de Usuario registado
        public int NumeroUsuario()
        {
            try
            {

            cmd.Connection = conexao.Conectar();
            cmd.CommandText = "SELECT COUNT (IdUsuario) FROM TbUsuario";
            NumUsuario = (int)cmd.ExecuteScalar();
            conexao.Desconectar();

            }
            catch (SqlException)
            {
                this.mensagem = "Erro com Banco de Dados";
            }
            return NumUsuario;
        }
        #endregion

        #region Retorna o Número de Aplicações registado
        public int NumeroAplicacao()
        {
            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.CommandText = "SELECT COUNT (IdAplicacao) FROM TbAplicacao";
                NumApp = (int)cmd.ExecuteScalar();
                conexao.Desconectar();
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com banco de dados";
            }
            
            return NumApp;
        }
        #endregion

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
    }
}
