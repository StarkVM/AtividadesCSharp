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

namespace Loja
{
    public partial class F_TelaCadastroUsuario : Form
    {

        string stringConnection = "server=localhost;database=loja;uid=root;pwd=";

        string Nome;
        int Id;
        public F_TelaCadastroUsuario()
        {
            InitializeComponent();
        }
        public F_TelaCadastroUsuario(string nome, int id)
        {
            InitializeComponent();
            Nome = nome;
            Id = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text)
                )
            {
                MessageBox.Show("Nenhum dos campos pode estar vazio");
                return;
            }

            try
            {
                using (MySqlConnection conexao = new MySqlConnection(stringConnection))
                {

                    string sql = $"INSERT INTO usuario (nome, email, senha) VALUES (@nome, @login,@senha );";

                    MySqlCommand comando = new MySqlCommand(sql, conexao);

                    comando.Parameters.AddWithValue("@nome", textBox1.Text);
                    comando.Parameters.AddWithValue("@login", textBox2.Text);
                    comando.Parameters.AddWithValue("@senha", textBox3.Text.Hash());

                    conexao.Open();

                    comando.ExecuteNonQuery();

                    MessageBox.Show("Cadastro edetuado com sucesso!");

                    textBox1.Clear();

                    textBox2.Clear();

                    textBox3.Clear();

                    conexao.Close();

                    Listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar: {ex.Message}");
            }
        }

        private void Listar()
        {
            var sql = "SELECT id, nome, email FROM usuario;";

            try
            {
                using (var da = new MySqlDataAdapter(sql, stringConnection))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex}");
            }

        }

        private void F_TelaCadastroUsuario_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
			this.Hide();
			var f = new F_TelaPrincipal();
			f.ShowDialog();
			this.Close();
		}
    }
}
