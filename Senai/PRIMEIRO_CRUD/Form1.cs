using System.Data;
using MySql.Data.MySqlClient;

namespace PRIMEIRO_CRUD
{
    public partial class Form1 : Form
    {
        string stringConexao = "server=localhost;database=empresa;uid=root;pwd=;";
        public Form1()
        {
            InitializeComponent();
        }

        private void CadastrarCliente()
        {
            MySqlConnection conexao = new MySqlConnection(stringConexao);

            string sql = $"INSERT INTO cliente (nome, cpf) VALUES ('{txtNome.Text}', '{mktTxtCpf.Text}');";

            //string sql = @"INSERT INTO (nome, cpf) VALUES ('" + txtNome.Text + "','" + mktTxtCpf.Text + "')";

            conexao.Open();

            MySqlCommand comando = new MySqlCommand(sql, conexao);

            comando.ExecuteNonQuery();

            MessageBox.Show("Cadastro Efetuado!");

            conexao.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastrarSeguro();

        }
        private void CadastrarSeguro()
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(stringConexao))
                {
                    if (string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(mktTxtCpf.Text))
                    {
                        return;
                    }

                    string sql = $"INSERT INTO cliente (nome, cpf) VALUES (@nome, @cpf);";

                    MySqlCommand comando = new MySqlCommand(sql, conexao);

                    comando.Parameters.AddWithValue("@nome", txtNome.Text);
                    comando.Parameters.AddWithValue("@cpf", mktTxtCpf.Text);

                    conexao.Open();

                    comando.ExecuteNonQuery();

                    MessageBox.Show("Cadastro edetuado com sucesso!");

                    txtNome.Clear();
                    mktTxtCpf.Clear();

                    conexao.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar: ", ex.Message);
            }
        }

        private void ListarCliente()
        {
            string sql = "SELECT * FROM cliente;";

            try
            {
                using (MySqlDataAdapter da = new MySqlDataAdapter(sql, stringConexao))
                {
                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    dtgDados.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao puxar dados: ", ex.Message);
            }

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ListarCliente();
        }

        private void BuscarCliente()
        {
            string sql = "SELECT * FROM cliente WHERE codigo = @codigo;";

            try
            {
                using (MySqlDataAdapter da = new MySqlDataAdapter(sql, stringConexao))
                {
                    da.SelectCommand.Parameters.AddWithValue("@codigo", txtCodigo.Text);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    dtgDados.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao puxar dados: ", ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarCliente();
        }
    }
}
