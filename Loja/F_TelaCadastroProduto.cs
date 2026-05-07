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

    public partial class F_TelaCadastroProduto : Form
    {
        int Id;
        string Nome;


        string stringConnection = "server=localhost;database=loja;uid=root;pwd=";
        public F_TelaCadastroProduto()
        {
            InitializeComponent();
            Listar();
        }
        public F_TelaCadastroProduto(string nome, int id)
        {
            InitializeComponent();
            Listar();
            Nome = nome;
            Id = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cadastrar();
        }

        private void Cadastrar()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("O nome nao pode estar vazio");
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Nenhuma quantidade pode ser vazia");
                return;
            }
            if (int.TryParse(textBox2.Text, out int i) && int.TryParse(textBox3.Text, out int j))
            {
                if (i < 0 || j < 0)
                {
                    MessageBox.Show("As quantidades devem ser numeros inteiros positivos");
                    return;
                }
            }
            else
            {
                MessageBox.Show("As quantidades devem ser numeros inteiros");
                return;
            }

            try
            {
                using (MySqlConnection conexao = new MySqlConnection(stringConnection))
                {

                    string sql = $"INSERT INTO produto (nome, estoque_atual, estoque_minimo) VALUES (@nome, @estoque_atual,@estoque_minimo );";

                    MySqlCommand comando = new MySqlCommand(sql, conexao);

                    comando.Parameters.AddWithValue("@nome", textBox1.Text);
                    comando.Parameters.AddWithValue("@estoque_atual", textBox2.Text);
                    comando.Parameters.AddWithValue("@estoque_minimo", textBox3.Text);

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
            var sql = "SELECT id, nome, estoque_atual, estoque_minimo FROM produto;";

            try
            {
                using (var da = new MySqlDataAdapter(sql, stringConnection))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;

                    bool aviso = false;

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        int estoqueAtual = Convert.ToInt32(row.Cells["estoque_atual"].Value);
                        int estoqueMinimo = Convert.ToInt32(row.Cells["estoque_minimo"].Value);

                        if (estoqueAtual < estoqueMinimo)
                        {
                            aviso = true;
                            row.DefaultCellStyle.BackColor = Color.Red;
                            row.DefaultCellStyle.ForeColor = Color.White;
                        }
                    }

                    if (aviso)
                    {
                        MessageBox.Show("Alguns produtos atingiram o estoque minimo", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex}");
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void F_TelaCadastroProduto_Load(object sender, EventArgs e)
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
