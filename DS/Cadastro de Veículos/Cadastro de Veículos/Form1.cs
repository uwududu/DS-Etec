//PARA EU CONSEGUIR USAR A BIBLIOTECA COM BANCO DE DADOS

using MySql.Data.MySqlClient;

namespace Cadastro_de_Veículos
{
    public partial class Form1 : Form
    {
        //CRIAR VARIAVEL DE CONEXAO 
        MySqlConnection Conexao;
        public Form1()
        {
            InitializeComponent();
        }

        private void btCadastro_Click(object sender, EventArgs e)
        {
            //TENTAR FAZER A CONEXAO COM BANCO 
            try
            {
                // CRIAR VARIAVEL PARA RECEBE OS DADOS DO BANCO 
                string data_source = "datasource=localhost; username=root; password =; database = db_oficina";
                // Criar conexão com MySQL 
                Conexao = new MySqlConnection(data_source);
                //INSERIR AS INFORMAÇOES NO BANCO 
                string sql = "INSERT INTO tb_veiculo (placa, modelo, marca, ano, cor) VALUES ('" + txtPlaca.Text + "', '" + txtModelo.Text + "', '" + txtMarca.Text + "', '" + txtAno.Text + "', '" + txtCor.Text + "')";
                //executa a conexão e abre com banco de dados 
                MySqlCommand comando = new MySqlCommand(sql, Conexao);
                Conexao.Open();
                comando.ExecuteReader();
                //menssagem de inserido com sucesso 
                MessageBox.Show("Inserido com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }

        private void btnAbrirConsulta_Click(object sender, EventArgs e)
        {
            // CRIA UMA INSTÂNCIA DA TELA DE CONSULTA

            Form2 telaConsulta = new Form2();


            // ABRE A TELA DE FORMA MODAL (SOBREPOSTA)

            telaConsulta.ShowDialog();
        }
    }
}
