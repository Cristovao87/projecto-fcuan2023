using provedor_de_identidade.v001.MODEL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace provedor_de_identidade.v001.DAL
{
    public class daoAplicacao
    {
        public bool tem = false;
        public string mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao conexao = new Conexao();
        SqlDataReader dr = null;

        #region Listagem das Aplicações
        public DataTable Listar_Aplicacao()
        {
            cmd.CommandText = "SELECT IdAplicacao AS ID, NomeAplicacao AS APLICAÇÃO," +
                "CASE WHEN EstadoAplicacao = 1 THEN 'Activo' WHEN EstadoAplicacao = 0 " +
                "THEN 'Bloqueado' END AS ESTADO FROM TbAplicacao";
            DataTable dt = new DataTable();
            cmd.Connection = conexao.Conectar();
            SqlDataReader rdr = cmd.ExecuteReader();
            dt.Load(rdr);
            return dt;
        }
        #endregion

        #region Registar Novas Aplicações no Sistema
        public string Registar_Aplicacao(modelAplicacao modelo)
        {
                cmd.CommandText = "INSERT INTO TbAplicacao VALUES (@nome, @estado)";
                cmd.Parameters.AddWithValue("@nome", modelo.NomeAplicacao);
                cmd.Parameters.AddWithValue("@estado", modelo.EstadoAplicacao);

                try
                {
                    cmd.Connection = conexao.Conectar();
                    cmd.ExecuteNonQuery();
                    conexao.Desconectar();
                    this.mensagem = "Aplicação Registado com Sucesso!";
                    tem = true;

                }
                catch (SqlException ex)
                {

                    this.mensagem = "Erro com Banco de Dados" + ex.Message;
                }
       
            return mensagem;
        }
        #endregion

        #region Eliminar Aplicações do Sistema
        public int Eliminar_Aplicacao(modelAplicacao modelo)
        {
            if (MessageBox.Show("¿Deseja Realmente Eliminar este Registo?", "Alerta!!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                cmd.CommandText = "DELETE FROM TbAplicacao WHERE IdAplicacao = @id";
                cmd.Parameters.AddWithValue("@Id", modelo.IdAplicacao);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Aplicação foi Eliminado com Sucesso !", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Registo não Eliminado" + ex.Message);
                }
            }
            return 0;
        }
        #endregion

        #region Actualizar dados da Aplicação
        public string Actualizar_Aplicacao(modelAplicacao modelo)
        {
            try
            {
                cmd.CommandText = "UPDATE TbAplicacao SET NomeAplicacao = @nome, EstadoAplicacao = @estado WHERE IdAplicacao = @id";
                cmd.Parameters.AddWithValue("@nome", modelo.NomeAplicacao);
                cmd.Parameters.AddWithValue("@estado", modelo.EstadoAplicacao);
                cmd.Parameters.AddWithValue("@id", modelo.IdAplicacao);

                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
                this.mensagem = "Registo Actualizado com Sucesso";
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Registo não Actualizado" + ex.Message);
            }
            return mensagem;
        }
        #endregion

    }
}
