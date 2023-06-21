using provedor_de_identidade.v001.MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace provedor_de_identidade.v001.DAL
{
    public class daoUsuario
    {
        public bool tem = false;
        public string mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao conexao = new Conexao();
        SqlDataReader dr = null;

        #region Lista de Usuario
        public DataTable Listar_Usuario()
        {
            cmd.CommandText = "SELECT u.IdUsuario AS ID, u.NomeUsuario AS NOME,u.Username AS EMAIL,p.DescricaoPerfil AS PERFIL, " +
                "CASE WHEN u.EstadoUsuario=1 THEN 'Activo' WHEN u.EstadoUsuario=0 " +
                "THEN 'Bloqueado' END AS ESTADO FROM TbUsuario u JOIN TbPerfil p ON p.IdPerfil = u.IdPerfil";
            DataTable dt = new DataTable();
            cmd.Connection = conexao.Conectar();
            SqlDataReader rdr = cmd.ExecuteReader();
            dt.Load(rdr);
            return dt;
        }
        #endregion

        #region Registo de Usuario   
        public string Registar_Usaurio(modelUsuario modelo, string confSenha)
        {

            if (modelo.Senha.Equals(confSenha))
            { // comandos para inserir no bd
                cmd.CommandText = "INSERT INTO TbUsuario VALUES (@nome, @username, @senha, @idPerfil,@estado)";
                cmd.Parameters.AddWithValue("@nome", modelo.NomeUsuario);
                cmd.Parameters.AddWithValue("@username", modelo.Username);
                cmd.Parameters.AddWithValue("@senha", modelo.Senha);
                cmd.Parameters.AddWithValue("@idPerfil", modelo.IdPerfil);
                cmd.Parameters.AddWithValue("@estado", modelo.EstadoUsuario);

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
            }
            else
            {
                this.mensagem = "Senhas não Correspondem!";
            }
            return mensagem;
        }
        #endregion

        #region Lista de Perfil de Usuario
        public DataTable Listar_perfis()
        {
            cmd.CommandText = "SELECT IdPerfil, DescricaoPerfil FROM TbPerfil";
            DataTable dt = new DataTable();
            cmd.Connection = conexao.Conectar();
            SqlDataReader rdr = cmd.ExecuteReader();
            dt.Load(rdr);
            return dt;
        }
        #endregion

        #region Eliminação de Usuario
        public int Eliminar_Usuario(modelUsuario modelo)
        {
            if (MessageBox.Show("¿Deseja realmente eliminar este Registo?", "Alerta!!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                cmd.CommandText = "DELETE FROM TbUsuario WHERE IdUsuario = @id";
                cmd.Parameters.AddWithValue("@Id", modelo.IdUsuario);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("O registo foi eliminado com sucesso !", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Registo não eliminado" + ex.Message);
                }
            }
            return 0;
        }
        #endregion

        #region Actualização de Usuario
        public string Actualizar_Usuario(modelUsuario modelo, string confSenha)
        {
           
            try
            {
                cmd.CommandText = "UPDATE TbUsuario SET NomeUsuario = @nome, Username = @username,Senha = @senha, " +
                    "IdPerfil =  @idPerfil, EstadoUsuario = @estado WHERE IdUsuario = @id";
                cmd.Parameters.AddWithValue("@nome", modelo.NomeUsuario);
                cmd.Parameters.AddWithValue("@username", modelo.Username);
                cmd.Parameters.AddWithValue("@senha", modelo.Senha);
                cmd.Parameters.AddWithValue("@idPerfil", modelo.IdPerfil);
                cmd.Parameters.AddWithValue("@estado", modelo.EstadoUsuario);
                cmd.Parameters.AddWithValue("@id", modelo.IdUsuario);

                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
                this.mensagem = "Actualizado com Sucesso";
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Registo não actualizado" + ex.Message);
            }
            return mensagem;
        }
        #endregion

    }

}
