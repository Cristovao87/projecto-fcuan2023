using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provedor_de_identidade.v001.DAL
{
   public class daoSessao
    {
        public bool tem = false;
        public string mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao conexao = new Conexao();
        SqlDataReader dr = null;

        #region Aplicação mais usadas

        public DataTable AplicacaoMaisUsada() 
        {

            cmd.CommandText = "SELECT a.NomeAplicacao AS Aplicação, COUNT(s.IdAplicacao) as rank" +
                    "FROM TbSessao s JOIN TbAplicacao a ON s.IdAplicacao = a.IdAplicacao" +
                    "GROUP BY a.NomeAplicacao" +
                    "ORDER BY a.NomeAplicacao DESC";

            DataTable dt = new DataTable();
            cmd.Connection = conexao.Conectar();
            SqlDataReader rdr = cmd.ExecuteReader();
            dt.Load(rdr);
            return dt;
        }

        #endregion
    }
}
