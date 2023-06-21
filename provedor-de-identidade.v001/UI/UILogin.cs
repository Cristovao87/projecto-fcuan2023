using provedor_de_identidade.v001.BLL;
using provedor_de_identidade.v001.MODEL;
using provedor_de_identidade.v001.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class UILogin : Form
    {
        public UILogin()
        {
            InitializeComponent();
        }
        
        #region Entrar_sistema
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string senha = bllGeral.Criptografar(txtSenha.Text);
            modelLogin loginDados = new modelLogin()
            {
                Email = txtUsername.Text,
                Senha = senha,

            };

            bllLogin controlo = new bllLogin();
            controlo.Acessar(loginDados);
            if (controlo.mensagem.Equals(""))
            {
                if (controlo.tem)
                {
                    MessageBox.Show("Logado com Sucesso", "Entrando no Sistema...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   UIPrincipal principal = new UIPrincipal();
                    principal.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Utilizador não encontrado, verifica o Email ou a Senha", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Text = "";
                    txtSenha.Text = "";
                    txtUsername.Select();
                }
            }
            else
            {
                MessageBox.Show(controlo.mensagem);
            }

        }
        #endregion

        private void btnRegistar_Click(object sender, EventArgs e)
        {
           UIRegistoLogin login = new UIRegistoLogin();
            login.Show();
            this.Hide();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
