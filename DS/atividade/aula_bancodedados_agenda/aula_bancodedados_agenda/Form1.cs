//Importa Biblioteca para usar o Banco de Dados//
using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace aula_bancodedados_agenda
{
    public partial class Form1 : Form
    {
        //Criar variavel para conexão
        MySqlConnection conexao;
        string id_Contato_Selecionado = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TAREFA 3 - Validação ANTES de abrir a conexão com o banco
            if (string.IsNullOrWhiteSpace(txt_nome.Text) ||
                string.IsNullOrWhiteSpace(txt_email.Text) ||
                string.IsNullOrWhiteSpace(txt_telefone.Text))
            {
                MessageBox.Show("Preencha todos os campos (nome, e-mail e telefone).",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // interrompe o envio
            }

            // TAREFA 4 - try / catch / finally
            try
            {
                string data_source = "datasource=localhost; username=root; password=; database=db_agenda";
                conexao = new MySqlConnection(data_source);

                string sql = "";

                if (string.IsNullOrEmpty(id_Contato_Selecionado))
                {
                    // TAREFA 2 - INSERT com parâmetros
                    sql = "INSERT INTO contato (nome, email, telefone) VALUES (@nome, @email, @telefone)";
                }
                else
                {
                    // TAREFA 2 - UPDATE com parâmetros
                    sql = "UPDATE contato SET nome = @nome, email = @email, telefone = @telefone WHERE id = @id";
                }

                MySqlCommand comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@nome", txt_nome.Text);
                comando.Parameters.AddWithValue("@email", txt_email.Text);
                comando.Parameters.AddWithValue("@telefone", txt_telefone.Text);

                if (!string.IsNullOrEmpty(id_Contato_Selecionado))
                {
                    comando.Parameters.AddWithValue("@id", id_Contato_Selecionado);
                }

                conexao.Open();
                comando.ExecuteNonQuery(); // ExecuteNonQuery é o correto para INSERT/UPDATE

                MessageBox.Show("Inserido/Atualizado com sucesso");
                id_Contato_Selecionado = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                // TAREFA 4 - fechamento obrigatório no finally
                if (conexao != null && conexao.State == ConnectionState.Open)
                {
                    conexao.Close();
                }
            }
        }

        private void btn_abrirconsulta_Click(object sender, EventArgs e)
        {
            Lista_consulta telaconsulta = new Lista_consulta();

            if (telaconsulta.ShowDialog() == DialogResult.OK)
            {
                id_Contato_Selecionado = telaconsulta.id_Selecionado;
                txt_nome.Text = telaconsulta.nome_Selecionado;
                txt_email.Text = telaconsulta.email_Selecionado;
                txt_telefone.Text = telaconsulta.telefone_Selecionado;
            }
        }
    }
}
