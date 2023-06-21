using provedor_de_identidade.v001.MODEL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provedor_de_identidade.v001.DAL
{
    public class daoLogin
    {
        public bool tem = false;
        public string mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao conexao = new Conexao();
        SqlDataReader dr = null;

        #region Verificar_login
        public bool VerificarLogin(modelLogin login)
        {

            //procurar no banco esse login e senha
            cmd.CommandText = "SELECT Username, Senha  FROM TbUsuario  WHERE Username = @email and Senha = @senha  and IdPerfil = 13 ";
            cmd.Parameters.AddWithValue("@email", login.Email);
            cmd.Parameters.AddWithValue("@senha", login.Senha);

            try
            {
                cmd.Connection = conexao.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = true;
                }
                conexao.Desconectar();
                dr.Close();
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com Banco de Dados";

            }

            return tem;
        }
        #endregion

        #region Registar_login
        public string Registar(modelLogin login, string confSenha)
        {
            tem = false;

            if (login.Senha.Equals(confSenha))
            { // comandos para inserir no bd
                cmd.CommandText = "INSERT INTO TbLogin VALUES (@email, @senha)";
                cmd.Parameters.AddWithValue("@email", login.Email);
                cmd.Parameters.AddWithValue("@senha", login.Senha);

                try
                {
                    cmd.Connection = conexao.Conectar();
                    cmd.ExecuteNonQuery();
                    conexao.Desconectar();
                    this.mensagem = "Registado com Sucesso!";
                    tem = true;

                }
                catch (SqlException ex)
                {

                    this.mensagem = "Erro com Banco de Dados" +ex.Message;
                }
            }
            else
            {
                this.mensagem = "Senhas não Correspondem!";
            }
            return mensagem;
        }
        #endregion
    }
}

