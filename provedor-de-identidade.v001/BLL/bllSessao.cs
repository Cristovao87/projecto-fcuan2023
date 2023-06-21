using provedor_de_identidade.v001.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provedor_de_identidade.v001.BLL
{
    public class bllSessao
    {
        public bool tem;
        public string mensagem = "";
       daoSessao sessao = new daoSessao();

        public DataTable AplicacaoMaisUsada()
        {
            return sessao.AplicacaoMaisUsada();
        }
    }
}
