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
using UI;

namespace provedor_de_identidade.v001.UI
{
    public partial class UIRegistoLogin : Form
    {
        public UIRegistoLogin()
        {
            InitializeComponent();
        }
        #region Registar Login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            bllLogin controlo = new bllLogin();


            if (txtUsername.Text == "" || txtSenha.Text == "")
            {
                MessageBox.Show("Login ou Senha Incorretos", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Text = "";
                txtSenha.Text = "";

            }
            else
            {
                string senha = bllGeral.Criptografar(txtSenha.Text);
                modelLogin loginDados = new modelLogin()
                {
                    Email = txtUsername.Text,
                    Senha = senha,

                };

                string mensagem = controlo.Registar(loginDados, senha);

                if (controlo.tem) // mensagem de sucesso
                {
                    MessageBox.Show(mensagem, "Registo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUsername.Text = "";
                    txtSenha.Text = "";

                }
                else
                {
                    MessageBox.Show(controlo.mensagem); //mensagem de erro

                    txtSenha.Text = "";
                    txtSenha.Focus();
                }
            }
        }
        #endregion

        private void btnRegistar_Click(object sender, EventArgs e)
        {
            UILogin login = new UILogin();
            login.Show();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
