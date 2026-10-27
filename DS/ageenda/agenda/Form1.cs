using MySql.Data.MySqlClient;
using System.Linq.Expressions;
namespace agenda
{
    public partial class Form1 : Form
    {
        MySqlConnection Conexao;
        string idContatoSelecionado = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string data_source = "datasource=localhost; username=root; password=; database=db_agenda";
                Conexao = new MySqlConnection(data_source);
                string sql = "";
               if (string.IsNullOrEmpty(idContatoSelecionado))
                {
                    sql = "INSERT INTO contato (nome, email, telefone) VALUES ('" + txtName.Text + "', '" + txtEmail.Text + "', '" + txtTele.Text + "')";
                }
               else
                {
                    sql ="UPDATE contato SET nome = '" + txtName.Text + "', email = '" + txtEmail.Text + "', telefone = '" + txtTele.Text + "' WHERE id = " + idContatoSelecionado;
                }
                MySqlCommand comando = new MySqlCommand(sql, Conexao);
                Conexao.Open();
                comando.ExecuteReader();
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
            idContatoSelecionado = "";
        }

        private void buttConsulta_Click(object sender, EventArgs e)
        {
            Form2 telaConsulta = new Form2();
            if (telaConsulta.ShowDialog() == DialogResult.OK)
            {
                idContatoSelecionado = telaConsulta.IdSelecionado;
                txtName.Text = telaConsulta.NomeSelecionado;
                txtEmail.Text = telaConsulta.EmailSelecionado;
                txtTele.Text = telaConsulta.TelefoneSelecionado;
            }
        }
    }
}
