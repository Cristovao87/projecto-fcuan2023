using provedor_de_identidade.v001.DAL;
using provedor_de_identidade.v001.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provedor_de_identidade.v001.BLL
{
    public class bllLogin
    {
        public bool tem;
        public string mensagem = "";
        daoLogin logindao = new daoLogin();

        #region login
        public bool Acessar(modelLogin loginDados)
        {
            tem = logindao.VerificarLogin(loginDados);
            if (!logindao.mensagem.Equals(""))
            {
                this.mensagem = logindao.mensagem;
            }

            return tem;
        }
        #endregion

        #region Registar_login
        public string Registar(modelLogin login, string confSenha)
        {
            this.mensagem = logindao.Registar(login, confSenha);
            if (logindao.tem)
            {
                this.tem = true;
            }
            return mensagem;
        }

        #endregion
    }
}
