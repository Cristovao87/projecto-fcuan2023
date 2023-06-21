using provedor_de_identidade.v001.BLL;
using provedor_de_identidade.v001.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace provedor_de_identidade.v001.UI
{
    public partial class UIUsuarioAplicacao : Form
    {
        bllUsuarioAplicacao usuarioApp = new bllUsuarioAplicacao();
        public UIUsuarioAplicacao()
        {
            InitializeComponent();
            Listar_Aplicacao();
            Listar_Usuario();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {

        }

        private void BtnFechar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        #region Lista de Usuário
        public void Listar_Usuario()
        {
            cbUtilizador.DataSource = usuarioApp.Listar_Usuario();
            cbUtilizador.DisplayMember = "NomeUsuario";
            cbUtilizador.ValueMember = "IdUsuario";
        }

        #endregion

        #region Lista de Aplicação
        public void Listar_Aplicacao()
        {
            cbAplicacao.DataSource = usuarioApp.Listar_Aplicacao();
            cbAplicacao.DisplayMember = "NomeAplicacao";
            cbAplicacao.ValueMember = "IdAplicacao";
        }

        #endregion

        #region Registar Utilizador/Aplicacao

        private void btnRegistar_Click(object sender, EventArgs e)
        {
            if (cbUtilizador.Text == "")
            {
                MessageBox.Show("Preencha por favor o campo 'Utilizador'", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cbAplicacao.Text == "")
            {
                MessageBox.Show("Preencha por favor o campo 'Aplicação'", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cbEstado.Text == "")
            {
                MessageBox.Show("Preencha por favor o campo 'Estado'", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool estado = true;
                if (cbEstado.Text == "Bloqueado")
                    estado = false;

                modelUsuarioAplicacao modeloUsuarioApp = new modelUsuarioAplicacao()
                {

                    IdUsuario = Convert.ToInt32(cbUtilizador.SelectedValue),
                    IdAplicacao = Convert.ToInt32(cbAplicacao.SelectedValue),
                    EstadoUsuarioApp = estado
                };
                
                bllUsuarioAplicacao usuarioApp = new bllUsuarioAplicacao();
                string mensagem = usuarioApp.Registar_UserApp(modeloUsuarioApp);
                MessageBox.Show(mensagem); //mensagem de erro
                usuarioApp.Listar_UsuarioAplicacao();
            }


        }
        #endregion

    }
}

