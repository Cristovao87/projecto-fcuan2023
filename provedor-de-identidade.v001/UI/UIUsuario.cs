using provedor_de_identidade.v001.BLL;
using provedor_de_identidade.v001.DAL;
using provedor_de_identidade.v001.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace provedor_de_identidade.v001.UI
{
    public partial class UIUsuario : Form
    {
        bllUsuario usuario = new bllUsuario();
        bllUsuario perfil = new bllUsuario();
        bllUsuarioAplicacao usApp = new bllUsuarioAplicacao();

        public UIUsuario()
        {
            InitializeComponent();
            Listar_Usuario();
            Listar_perfis();
            //Listar_UsuarioAplicacao();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Limpardados()
        {
            txtID.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
           txtConfPass.Clear();
        }

        #region Registo de Usuario
        private void btnRegistar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Preencha o campo 'Nome'", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Preencha o campo 'Email'", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                else if (txtSenha.Text == "")
                {
                    MessageBox.Show("Preencha o campo 'Senha'", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtConfPass.Text == "")
                {
                    MessageBox.Show("Preencha o campo 'Confirmar Senha'", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (cbCategoria.Text == "")
                {
                    MessageBox.Show("Preencha o campo 'Categoria'", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (cbEstado.Text == "")
                {
                    MessageBox.Show("Preencha o campo 'Estado'", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
           else { 
                bool estado = true;
            if (cbEstado.Text == "Bloqueado")
                estado = false;

            string password = bllGeral.Criptografar(txtSenha.Text);
            string confPassword = bllGeral.Criptografar(txtConfPass.Text);
            modelUsuario modeloUsuario = new modelUsuario()
            {

                NomeUsuario = txtNome.Text,
                Username = txtEmail.Text,
                Senha = password,
                IdPerfil = Convert.ToInt32(cbCategoria.SelectedValue),
                EstadoUsuario = estado
            };
            //DAO dao = new DAO();
            bllUsuario usuario = new bllUsuario();
            string mensagem = usuario.Registar_Usaurio(modeloUsuario, confPassword);
            MessageBox.Show(mensagem); //mensagem de erro
            Limpardados();
            Listar_Usuario();
                }
            
        
    }
        #endregion

        #region Lista de Usuário
        public void Listar_Usuario()
        {
            DGUsuario.DataSource = usuario.Listar_Usuario();
        }

        #endregion
       
        #region Lista de perfis
        public void Listar_perfis()
        {
            cbCategoria.DataSource = usuario.Listar_perfis();
            cbCategoria.DisplayMember = "DescricaoPerfil";
            cbCategoria.ValueMember = "IdPerfil";
        }

        #endregion

        #region Carregar_CaixasTexto
        public void Carregar_CaixasTexto()
        {
            try
            {
                txtID.Text = DGUsuario.CurrentRow.Cells[0].Value.ToString();
                txtNome.Text = DGUsuario.CurrentRow.Cells[1].Value.ToString();
                txtEmail.Text = DGUsuario.CurrentRow.Cells[2].Value.ToString();
                txtSenha.Text = DGUsuario.CurrentRow.Cells[3].Value.ToString();
                //cbCategoria.Text = DGUsuario.CurrentRow.Cells[4].Value.ToString();
                //cbCategoria.Text = DGUsuario.CurrentRow.Cells[5].Value.ToString();
                cbEstado.Text = DGUsuario.CurrentRow.Cells[4].Value.ToString();
            }

            catch (SqlException ex)
            {
                MessageBox.Show("Houve um erro ao processar o seu pedido " + ex.Message);
            }





        }


        #endregion

        #region Eliminar Usuario
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Deve selecionar um registo para eliminar", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            modelUsuario modeloUsuario = new modelUsuario()
            {

                IdUsuario = Convert.ToInt32(txtID.Text),
            };
            usuario.Eliminar_Usuario(modeloUsuario);
            Limpardados();
            Listar_Usuario();
        }
        #endregion

        #region Actualizar Usuario
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Deve selecionar um registo para editar", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string password = bllGeral.Criptografar(txtSenha.Text);
            string confPassword = bllGeral.Criptografar(txtConfPass.Text);

            bool estado = true;
            if (cbEstado.Text == "Bloqueado")
                estado = false;

            modelUsuario modeloUsuario = new modelUsuario()
            {
                IdUsuario = Convert.ToInt32(txtID.Text),
                NomeUsuario = txtNome.Text,
                Username = txtEmail.Text,
                Senha = password,
                IdPerfil = Convert.ToInt32(cbCategoria.SelectedValue),
                EstadoUsuario = estado
            };
           
            bllUsuario usuario = new bllUsuario();
            string mensagem = usuario.Actualizar_Usuario(modeloUsuario, confPassword);
          MessageBox.Show(mensagem); 
            Limpardados();
            Listar_Usuario();
        }
        #endregion

        #region Lista de Usuário/Aplicacações
        //public void Listar_UsuarioAplicacao()
        //{
        //    DGUsuarioApp.DataSource = usApp.Listar_UsuarioAplicacao();
        //}

        #endregion

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void DGUsuarioApp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGUsuario_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Carregar_CaixasTexto();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
