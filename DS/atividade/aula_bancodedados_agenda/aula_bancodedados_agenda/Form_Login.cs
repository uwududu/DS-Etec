using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace aula_bancodedados_agenda
{
    public partial class Form_Login : Form
    {
        MySqlConnection conexao;
        public Form_Login()
        {
            InitializeComponent();
        }

        private void btn_logar_Click(object sender, EventArgs e)
        {
            // TAREFA 3 - Validação ANTES de abrir a conexão
            if (string.IsNullOrWhiteSpace(txt_usuario.Text) ||
                string.IsNullOrWhiteSpace(txt_senha.Text))
            {
                MessageBox.Show("Preencha usuário e senha.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // TAREFA 4 - try / catch / finally
            try
            {
                string data_source = "datasource=localhost; username=root; password=; database=db_agenda";
                conexao = new MySqlConnection(data_source);

                // TAREFA 1 - compara com o hash MD5 gravado no banco
                // TAREFA 2 - parâmetros em vez de concatenação
                string sql = "SELECT * FROM usuario WHERE login = @login AND senha = MD5(@senha)";

                MySqlCommand comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@login", txt_usuario.Text);
                comando.Parameters.AddWithValue("@senha", txt_senha.Text);

                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                DataTable tabela = new DataTable();
                adaptador.Fill(tabela);

                if (tabela.Rows.Count > 0)
                {
                    MessageBox.Show("Login realizado com sucesso!", "Bem-vindo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form1 formAgenda = new Form1();
                    this.Hide();
                    formAgenda.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos.", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_senha.Clear();
                    txt_usuario.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar com o banco de dados: " + ex.Message);
            }
            finally
            {
                if (conexao != null && conexao.State == ConnectionState.Open)
                {
                    conexao.Close();
                }
            }
        }

        // ------------------------------------------------------------------
        // EXEMPLO de CADASTRO de usuário (use no seu form de cadastro, se houver)
        // Tarefa 1: grava a senha já em MD5 | Tarefa 2: parâmetros
        // Tarefa 3: validação | Tarefa 4: try/catch/finally
        // ------------------------------------------------------------------
        private void CadastrarUsuario(string login, string senha)
        {
            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Preencha login e senha.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string data_source = "datasource=localhost; username=root; password=; database=db_agenda";
                conexao = new MySqlConnection(data_source);

                string sql = "INSERT INTO usuario (login, senha) VALUES (@login, MD5(@senha))";
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@login", login);
                comando.Parameters.AddWithValue("@senha", senha);

                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Usuário cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar: " + ex.Message);
            }
            finally
            {
                if (conexao != null && conexao.State == ConnectionState.Open)
                {
                    conexao.Close();
                }
            }
        }
    }
}
