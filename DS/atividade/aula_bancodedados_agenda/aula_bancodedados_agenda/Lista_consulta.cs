using System;
using System.Data;
using System.Windows.Forms;

//Biblioteca do MySQL
using MySql.Data.MySqlClient;

namespace aula_bancodedados_agenda
{
    public partial class Lista_consulta : Form
    {
        MySqlConnection conexao;

        // Variaveis para enviar dados para outra tela
        public string id_Selecionado { get; private set; }
        public string nome_Selecionado { get; private set; }
        public string email_Selecionado { get; private set; }
        public string telefone_Selecionado { get; private set; }

        public Lista_consulta()
        {
            InitializeComponent();
        }

        private void CarregarDados()
        {
            // TAREFA 4 - try / catch / finally
            try
            {
                string data_source = "datasource=localhost; username=root; password=; database=db_agenda";
                conexao = new MySqlConnection(data_source);

                // Sem concatenação (não há entrada do usuário nesta consulta)
                string sql = "SELECT * FROM contato";

                MySqlDataAdapter adaptador = new MySqlDataAdapter(sql, conexao);
                DataTable tabela = new DataTable();
                adaptador.Fill(tabela);

                dgv_contato.DataSource = tabela;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conexao != null && conexao.State == ConnectionState.Open)
                {
                    conexao.Close();
                }
            }
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void Lista_consulta_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Verificar se o usuário selecionou algum registro
            if (dgv_contato.CurrentRow == null)
            {
                MessageBox.Show("Selecione um registro para excluir", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "Tem certeza que deseja excluir o registro selecionado?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    string idSelecionado = dgv_contato.CurrentRow.Cells["id"].Value.ToString();
                    string data_source = "datasource=localhost; username=root; password=; database=db_agenda";
                    conexao = new MySqlConnection(data_source);

                    // TAREFA 2 - DELETE com parâmetro
                    string sql = "DELETE FROM contato WHERE id = @id";

                    MySqlCommand comando = new MySqlCommand(sql, conexao);
                    comando.Parameters.AddWithValue("@id", idSelecionado);

                    conexao.Open();
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Registro excluído com sucesso!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarDados();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir registro: " + ex.Message, "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // TAREFA 4 - fechamento no finally (único ponto de fechamento)
                    if (conexao != null && conexao.State == ConnectionState.Open)
                    {
                        conexao.Close();
                    }
                }
            }
        }

        private void dgv_contato_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                id_Selecionado = dgv_contato.Rows[e.RowIndex].Cells["id"].Value.ToString();
                nome_Selecionado = dgv_contato.Rows[e.RowIndex].Cells["nome"].Value.ToString();
                email_Selecionado = dgv_contato.Rows[e.RowIndex].Cells["email"].Value.ToString();
                telefone_Selecionado = dgv_contato.Rows[e.RowIndex].Cells["telefone"].Value.ToString();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
