using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Loja
{

    public partial class F_TelaCadastroCelulares : Form
    {
        int Id;
		int? IdProduto;
		string Nome;


        string stringConnection = "server=localhost;database=loja_celulares_db;uid=root;pwd=";
        public F_TelaCadastroCelulares()
        {
            InitializeComponent();
            Listar();
			Nome = Repositorio.Username;
			Id = Repositorio.Id;
            BuscarId();
		}
        public F_TelaCadastroCelulares(string nome, int id)
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


            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox5.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||

                string.IsNullOrWhiteSpace(textBox7.Text) ||
                string.IsNullOrWhiteSpace(textBox6.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text)
                )
            {
                MessageBox.Show("Nenhum campo pode estar  vazio");
                return;
            }
            if (int.TryParse(textBox6.Text, out int i) && int.TryParse(textBox7.Text, out int j))
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
            if (decimal.TryParse(textBox4.Text, out decimal y))
            {
                if (y < 0)
                {
                    MessageBox.Show("O valor deve ser um numero inteiro e positivo");
                    return;
                }
            }
            else
            {
                MessageBox.Show("O valor deve ser um numero positivo");

                return;
            }
            using (MySqlConnection conexao = new MySqlConnection(stringConnection))
            {
				conexao.Open();
				MySqlTransaction transacao = conexao.BeginTransaction();
                try
                {

                    string sql = $"INSERT INTO celulares (id ,tipo ,tamanho_cm, cor, marca, valor, quantidade_estoque, quantidade_minima) " +
                        $"VALUES (@id, @tipo ,@tamanho_cm, @cor, @marca, @valor, @quantidade_estoque, @quantidade_minima);";

                    MySqlCommand comando = new MySqlCommand(sql, conexao, transacao);

                    comando.Parameters.AddWithValue("@id", IdProduto);
                    comando.Parameters.AddWithValue("@tipo", textBox1.Text);
                    comando.Parameters.AddWithValue("@tamanho_cm", textBox2.Text);
                    comando.Parameters.AddWithValue("@cor", textBox5.Text);
                    comando.Parameters.AddWithValue("@marca", textBox3.Text);
                    comando.Parameters.AddWithValue("@valor", textBox4.Text);
                    comando.Parameters.AddWithValue("@quantidade_estoque", textBox7.Text);
                    comando.Parameters.AddWithValue("@quantidade_minima", textBox6.Text);
                    comando.ExecuteNonQuery();

                    

                    string sql2 = "INSERT INTO movimentacoes (id_usuario, id_celular, tipo, quantidade, data_movimentacao) VALUES" +
						" (@id_usuario,@id_produto, @tipo, @quantidade, @data_movimentacao)";

					MySqlCommand comando2 = new MySqlCommand(sql2, conexao, transacao);
					comando2.Parameters.AddWithValue("@id_produto", IdProduto);
					comando2.Parameters.AddWithValue("@id_usuario", Id);
					comando2.Parameters.AddWithValue("@tipo", "Entrada");
					comando2.Parameters.AddWithValue("@quantidade", textBox7.Text);
					comando2.Parameters.AddWithValue("@data_movimentacao", dateTimePicker1.Value.Date);
					comando2.ExecuteNonQuery();

					transacao.Commit();

					MessageBox.Show("Cadastro efetuado com sucesso!");

                    textBox1.Clear();

                    textBox2.Clear();

                    textBox3.Clear();

                    textBox5.Clear();

                    textBox4.Clear();

                    textBox7.Clear();

                    textBox6.Clear();

                    conexao.Close();

                    Listar();
                    BuscarId();
                }
                catch (Exception ex)
                {
                    transacao.Rollback();
                    MessageBox.Show($"Erro ao cadastrar: {ex.Message}");
                }
            }
        }

        private void BuscarId() 
        {
			var sql = "SELECT MAX(id) FROM celulares;";

			using (MySqlConnection con = new MySqlConnection(stringConnection)) 
            {
                try
                {
					MySqlCommand command = new MySqlCommand(sql, con);

                    con.Open();

                    var reader = command.ExecuteReader();

					reader.Read();

					IdProduto = int.Parse(reader[0].ToString()) + 1;

                    con.Close();
				}
                catch (Exception ex)
                {
					MessageBox.Show($"Erro: {ex.Message}");
				}
            }
        }
        private void Listar()
        {
            var sql = "SELECT * FROM celulares;";

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
                        int estoqueAtual = Convert.ToInt32(row.Cells["quantidade_estoque"].Value);
                        int estoqueMinimo = Convert.ToInt32(row.Cells["quantidade_minima"].Value);

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

        private void button3_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void Buscar()
        {

            if (string.IsNullOrWhiteSpace(textBox8.Text))
            {

            }
            if (int.TryParse(textBox8.Text, out int i))
            {
                if (i < 0)
                {
                    MessageBox.Show("O id deve ser um numero inteiro e positivo");
                    return;
                }
            }
            else
            {
                MessageBox.Show("O id deve ser um numero inteiro e positivo");
                return;
            }
            var sql = "SELECT * FROM celulares WHERE id = @id;";

            MySqlConnection con = new MySqlConnection(stringConnection);

            MySqlCommand command = new MySqlCommand(sql, con);

            command.Parameters.AddWithValue("@id", textBox8.Text.Trim());

            DataTable dt = new DataTable();

            using (MySqlDataAdapter adapter = new MySqlDataAdapter())
            {
                try
                {
                    con.Open();

                    adapter.SelectCommand = command;

                    adapter.Fill(dt);


                    dataGridView1.DataSource = dt;

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        int estoqueAtual = Convert.ToInt32(row.Cells["quantidade_estoque"].Value);
                        int estoqueMinimo = Convert.ToInt32(row.Cells["quantidade_minima"].Value);

                        if (estoqueAtual < estoqueMinimo)
                        {

                            row.DefaultCellStyle.BackColor = Color.Red;
                            row.DefaultCellStyle.ForeColor = Color.White;
                        }
                    }

                }
                catch (Exception ex)
                {
                    {
                        MessageBox.Show($"ERRO: {ex.Message}");
                    }

                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Listar();
        }
    }
}
