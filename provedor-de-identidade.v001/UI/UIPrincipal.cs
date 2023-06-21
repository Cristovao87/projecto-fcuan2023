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
    public partial class UIPrincipal : Form
    {
        public UIPrincipal()
        {
            InitializeComponent();
           MostrarFormLogo();
           
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
          
            UIDashboard dashboard = new UIDashboard();
            dashboard.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEmPanel(dashboard);
        }
        
        // METODOS PARA FECHAR,MAXIMIZAR, MINIMIZAR FORMULARIO ------------------------------------------------------
        int lx, ly;
        int sw, sh;

        private void btnMinimo_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (panelMenu.Width == 230)
            {
                this.tmContraerMenu.Start();
            }
            else if (panelMenu.Width == 55)
            {
                this.tmExpandirMenu.Start();
            }
        }

        //METODOS PARA EXPANDIR E CONTRAER MENU --

        private void tmExpandirMenu_Tick(object sender, EventArgs e)
        {
            if (panelMenu.Width >= 230)
                this.tmExpandirMenu.Stop();
            else
                panelMenu.Width = panelMenu.Width + 5;

        }

        private void tmContraerMenu_Tick(object sender, EventArgs e)
        {
            if (panelMenu.Width <= 55)
                this.tmContraerMenu.Stop();
            else
                panelMenu.Width = panelMenu.Width - 5;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseja Realmente Sair do Sistema?", "Alerta!!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
                new UILogin().Show();
                this.Hide();
            }
        }

        private void bntMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            btnMaximizar.Visible = true;
          
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            UIUsuario usuario = new UIUsuario();
            usuario.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEmPanel(usuario);
            
        }

        private void btnAplicacao_Click(object sender, EventArgs e)
        {
            UIAplicacao aplicacao = new UIAplicacao();
            aplicacao.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEmPanel(aplicacao);
        }

        //METODO PARA ABRIR FORM DENTRO DE PANEL-----------------------------------------------------
        private void AbrirFormEmPanel(object formHijo)
        {
            if (this.panelPrincipal.Controls.Count > 0)
                this.panelPrincipal.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(fh);
            this.panelPrincipal.Tag = fh;
            fh.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
          
        }

        //METODO PARA HORA E DATA ACTUAL ----------------------------------------------------------

        private void tmFechaHora_Tick(object sender, EventArgs e)
        {
            lbData.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToString("HH:mm:ssss");
        }

        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUserApp_Click(object sender, EventArgs e)
        {
            UIUsuarioAplicacao userApp = new UIUsuarioAplicacao();
            userApp.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEmPanel(userApp);
        }

        //METODO PARA MOSTRAR FORMULARIO DE LOGO AO INICIAR ----------------------------------------------------------
        private void MostrarFormLogo()
        {
            AbrirFormEmPanel(new UILogo());
        }

        private void MostrarFormLogoAlCerrarForms(object sender, FormClosedEventArgs e)
        {
            MostrarFormLogo();
        }

    }
}
