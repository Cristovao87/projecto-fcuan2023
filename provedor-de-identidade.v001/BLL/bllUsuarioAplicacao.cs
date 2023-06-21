using provedor_de_identidade.v001.DAL;
using provedor_de_identidade.v001.MODEL;
using provedor_de_identidade.v001.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provedor_de_identidade.v001.BLL
{
    public class bllUsuarioAplicacao
    {
        public bool tem;
        public string mensagem = "";
        daoUsuarioAplicacao usuarioAplicacao = new daoUsuarioAplicacao();

        #region Lista de Usuario/Aplicações
        public DataTable Listar_UsuarioAplicacao()
        {
            return usuarioAplicacao.Listar_UsuarioAplicacao();
        }
        #endregion

        #region Registo de Usuario/Aplicacao
        public string Registar_UserApp(modelUsuarioAplicacao modelo)
        {
            this.mensagem = usuarioAplicacao.Registar_UserApp(modelo);
            return mensagem;
        }
        #endregion

        #region Lista de Usuario
        public DataTable Listar_Usuario()
        {
            daoUsuarioAplicacao lista = new daoUsuarioAplicacao();
            return lista.Listar_Usuario();
        }
        #endregion

        #region Lista de Aplicação
        public DataTable Listar_Aplicacao()
        {
            daoUsuarioAplicacao lista = new daoUsuarioAplicacao();
            return lista.Listar_Aplicacao();
        }
        #endregion
    }
}
