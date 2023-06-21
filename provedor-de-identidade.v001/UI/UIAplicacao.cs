using provedor_de_identidade.v001.BLL;
using provedor_de_identidade.v001.MODEL;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace provedor_de_identidade.v001.UI
{
    public partial class UIAplicacao : Form
    {
        bllAplicacao app = new bllAplicacao();

        public UIAplicacao()
        {
            InitializeComponent();
            Listar_Aplicacao();
        }

        private void UIAplicacao_Load(object sender, EventArgs e)
        {

        }

        public void Limpardados()
        {
            txtID.Clear();
            txtNome.Clear();
        }

        #region Lista de Aplicações
        public void Listar_Aplicacao()
        {
            DGAplicacao.DataSource = app.Listar_Aplicacao();
        }
        #endregion

        #region Registar aplicações
        private void btnRegistar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" )
            {
                MessageBox.Show("Preencha o campo 'Nome da Aplicação'", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cbEstado.Text == "")
            {
                MessageBox.Show("Preencha o campo 'Estado'", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else { 
            bool estado = true;
            if (cbEstado.Text == "Bloqueado")
                estado = false;

            modelAplicacao modeloAplicacao = new modelAplicacao()
            {

                NomeAplicacao = txtNome.Text,
                EstadoAplicacao = estado
            };

            
            string mensagem = app.Registar_Aplicacao(modeloAplicacao);
            MessageBox.Show(mensagem); //mensagem de erro
            Limpardados();
            Listar_Aplicacao();

            }
        }
        #endregion

        #region Carregar_CaixasTexto
        public void Carregar_CaixasTexto()
        {
            try
            {
                txtID.Text = DGAplicacao.CurrentRow.Cells[0].Value.ToString();
                txtNome.Text = DGAplicacao.CurrentRow.Cells[1].Value.ToString();
                cbEstado.Text = DGAplicacao.CurrentRow.Cells[2].Value.ToString();
            }

            catch (SqlException ex)
            {
                MessageBox.Show("Houve um erro ao processar o seu pedido " + ex.Message);
            }

        }


        #endregion

       

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Actualizar Aplicaçao
        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Deve Selecionar um Registo para Actualizar", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool estado = true;
            if (cbEstado.Text == "Bloqueado")
                estado = false;

            modelAplicacao modelo = new modelAplicacao()
            {
                IdAplicacao = Convert.ToInt32(txtID.Text),
                NomeAplicacao = txtNome.Text,
                EstadoAplicacao = estado
            };

            bllAplicacao app = new bllAplicacao();
            string mensagem = app.Actualizar_Aplicacao(modelo);
            MessageBox.Show(mensagem);
            Limpardados();
            Listar_Aplicacao();
        }
        #endregion

        #region Eliminar Aplicação
        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Deve Selecionar um Registo para Actualizar", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            modelAplicacao modelo = new modelAplicacao()
            {
                IdAplicacao = Convert.ToInt32(txtID.Text),
            };
            app.Eliminar_Aplicacao(modelo);
            Limpardados();
            Listar_Aplicacao();
        }
        #endregion

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void DGAplicacao_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Carregar_CaixasTexto();
        }
    }
}
