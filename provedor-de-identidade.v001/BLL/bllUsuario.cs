using provedor_de_identidade.v001.DAL;
using provedor_de_identidade.v001.MODEL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace provedor_de_identidade.v001.BLL
{
    
    public class bllUsuario
    {
        public bool tem;
        public string mensagem = "";
        daoUsuario usuario = new daoUsuario();


        #region Lista de Usuario
        public DataTable Listar_Usuario()
        {
           return usuario.Listar_Usuario();
        }
        #endregion

        #region Lista de Perfil
        public DataTable Listar_perfis()
        {
            daoUsuario perfil = new daoUsuario();
            return perfil.Listar_perfis();
        }
        #endregion

        #region Registo de Usuario
        public string Registar_Usaurio(modelUsuario modelo, string confSenha)
        {
            this.mensagem = usuario.Registar_Usaurio(modelo, confSenha);
            return mensagem;
        }
        #endregion

        #region Eliminação de Usuário
        public int Eliminar_Usuario(modelUsuario modelo)
        {
            return usuario.Eliminar_Usuario(modelo);
        }
        #endregion

        #region Actualização de Usuario
        public string Actualizar_Usuario(modelUsuario modelo, string confSenha)
        {
            return usuario.Actualizar_Usuario(modelo, confSenha);      }

        #endregion
    }
}
