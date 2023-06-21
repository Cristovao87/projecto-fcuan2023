using provedor_de_identidade.v001.BLL;
using provedor_de_identidade.v001.DAL;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace provedor_de_identidade.v001.UI
{
    public partial class UIDashboard : Form
    {
        bllDashboard dash = new bllDashboard();
        bllSessao sessao = new bllSessao();
       
        public UIDashboard()
        {
            InitializeComponent();
            
            LoadData();
        }

        #region Carregar dados no Dashboard
        private void LoadData()
        {
            
               lblNumAplicacao.Text = dash.NumeroAplicacao().ToString();
               lblNumUsuario.Text = dash.NumeroUsuario().ToString();
          
            dgvUsApp.DataSource = dash.Listar_UsuarioAplicacao();
            
        }

        #endregion

        #region Gerar gráfico
        private void btnGerarGrafico_Click(object sender, EventArgs e)
        {
            GerarGraficoColuna();
        }

        private void GerarGraficoColuna()
        {
            Title title = new Title();
            title.Font = new Font("Century Gothic", 10, FontStyle.Bold);
            title.ForeColor = Color.SteelBlue;
            //title.Text = "Aplicações";
            chart1.Titles.Add(title);

            // Query
            DataTable dt = new DataTable();
            //SqlCommand cmd = new SqlCommand();
            SqlConnection con = new SqlConnection("Data Source=jCRISTOVAO\\SQLEXPRESS;Initial Catalog=DbSGI;Integrated Security=True");
            //Conexao con = new Conexao();
            //con.Conectar();
            con.Open();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select a.NomeAplicacao as Aplicação, Count(s.IdAplicacao) as Rank \r\nfrom TbSessao s join TbAplicacao a on s.IdAplicacao = a.IdAplicacao\r\nGroup By a.NomeAplicacao\r\norder by a.NomeAplicacao Desc", con);

                da.Fill(dt);
                chart1.DataSource = dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro com a Base de Dados" + ex.Message);
            }
            
            //con.Desconectar();
            con.Close();

            //Aplicações registadas

            chart1.Series.Add("Aplicações");
            chart1.Series["Aplicações"].LegendText = "Aplicações";
            chart1.Series["Aplicações"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            chart1.Series["Aplicações"].BorderWidth = 3;

            chart1.Series["Aplicações"].XValueMember = "Aplicação";
            chart1.Series["Aplicações"].YValueMembers = "Rank";
        }
        #endregion

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
