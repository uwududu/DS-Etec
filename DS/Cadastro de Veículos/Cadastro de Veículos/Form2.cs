using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Biblioteca do MYSQL
using MySql.Data.MySqlClient;

namespace Cadastro_de_Veículos
{
    public partial class Form2 : Form
    {
        // Variavel de Conexao
        MySqlConnection Conexao;
        public Form2()
        {
            InitializeComponent();
        }

        private void CarregarDados()
        {
            try
            {
                //  DADOS DE CONEXÃO COM O BANCO DE DADOS
                string data_source = "datasource=localhost; username=root; password=; database=db_oficina";

                Conexao = new MySqlConnection(data_source);

                string sql = "SELECT * FROM tb_veiculo";
                MySqlDataAdapter adaptador = new MySqlDataAdapter(sql, Conexao);

                // GUARDAR OS RESULTADOS
                DataTable tabela = new DataTable();

                // PREENCHE A TABELA COM OS REGISTROS OS BANCO DE DADOS
                adaptador.Fill(tabela);

                // EXIBIR AO DATAGRIDVIEW
                dgvContatos.DataSource = tabela;
            }
            catch (Exception ex)
            {
                // EXIBE O ERRO CASO OCORRER
                MessageBox.Show("Erro ao carregar os dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }
    }
}
