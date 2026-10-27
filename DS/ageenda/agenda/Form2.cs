using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace agenda
{
    public partial class Form2 : Form
    {
        MySqlConnection Conexao;
        public string IdSelecionado { get; private set; }
        public string NomeSelecionado { get; private set; }
        public string EmailSelecionado { get; private set; }
        public string TelefoneSelecionado { get; private set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void CarregarDados()
        {
            try
            {
                string data_source = "datasource=localhost; username=root; password=; database=db_agenda";
                Conexao = new MySqlConnection(data_source);
                string sql = "select * from contato";
                MySqlDataAdapter adaptador = new MySqlDataAdapter(sql, Conexao);
                DataTable tabela = new DataTable();
                adaptador.Fill(tabela);
                dgvContatos.DataSource = tabela;
            }
            catch (Exception ex)
            {
                MessageBox.Show("deu erro pra carrega pai" + ex.Message, "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void buttUPD_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void buttExcluir_Click(object sender, EventArgs e)
        {
            if (dgvContatos.CurrentRow == null)
            {
                MessageBox.Show("Selecione um registro para excluir", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult confirmacao = MessageBox.Show("deseja realmente excluir o contato selecionado?", "confirmar exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacao == DialogResult.Yes)
            {
                try
                {
                    string idSelecionado = dgvContatos.CurrentRow.Cells["id"].Value.ToString();
                    string data_source = "datasource=localhost; username=root; password=; database=db_agenda";
                    Conexao = new MySqlConnection(data_source);
                    string sql = "delete from contato where id = " + idSelecionado;
                    MySqlCommand comando = new MySqlCommand(sql, Conexao);

                    Conexao.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("contato excluido com sucesso", "sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarDados();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("erro ao excluir contato: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (Conexao != null && Conexao.State == ConnectionState.Open)
                    {
                        Conexao.Close();
                    }
                }
            }
        }

        private void dgvContatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                IdSelecionado = dgvContatos.Rows[e.RowIndex].Cells["id"].Value.ToString();
                NomeSelecionado = dgvContatos.Rows[e.RowIndex].Cells["nome"].Value.ToString();
                EmailSelecionado = dgvContatos.Rows[e.RowIndex].Cells["email"].Value.ToString();
                TelefoneSelecionado = dgvContatos.Rows[e.RowIndex].Cells["telefone"].Value.ToString();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
