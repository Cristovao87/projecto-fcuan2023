using provedor_de_identidade.v001.DAL;
using provedor_de_identidade.v001.MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provedor_de_identidade.v001.BLL
{
    internal class bllAplicacao
    {
        public bool tem;
        public string mensagem = "";
        daoAplicacao app = new daoAplicacao();


        #region Listagem das Aplicações
        public DataTable Listar_Aplicacao()
        {
            return app.Listar_Aplicacao();
        }
        #endregion

        #region Registar Novas Aplicações no Sistema
        public string Registar_Aplicacao(modelAplicacao modelo)
        {
            this.mensagem = app.Registar_Aplicacao(modelo);
            return mensagem;
        }
        #endregion

        #region Eliminar Aplicações do Sistema
        public int Eliminar_Aplicacao(modelAplicacao modelo)
        {
            return app.Eliminar_Aplicacao(modelo);
        }
        #endregion

        #region Actualizar Dados da Aplicacao
        public string Actualizar_Aplicacao(modelAplicacao modelo)
        {
            return app.Actualizar_Aplicacao(modelo);
        }

        #endregion
    }
}
