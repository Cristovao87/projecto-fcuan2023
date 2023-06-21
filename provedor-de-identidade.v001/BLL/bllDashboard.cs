using provedor_de_identidade.v001.DAL;
using System;
using System.Data;

namespace provedor_de_identidade.v001.BLL
{


    public class bllDashboard
    {
        daoDashboard dash = new daoDashboard();
        public bool data;
        public string mensagem = "";
        public bool tem;
        public int NumUsuario { get; private set; }
        public int NumApp { get; private set; }

        #region Retorna Nº de Usuario
        public int NumeroUsuario()
        {
           NumUsuario = dash.NumeroUsuario();
            return NumUsuario;
           
        }
        #endregion

        #region Retorna o Nº de App
        public int NumeroAplicacao()
        {
            NumApp = dash.NumeroAplicacao();
            return NumApp;

        }
        #endregion

        #region Lista de Usuario/Aplicações
        public DataTable Listar_UsuarioAplicacao()
            {
                return dash.Listar_UsuarioAplicacao();
            }
            #endregion
        }
    }
    
    

