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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Loja
{
    public partial class F_TelaAtualizarProduto : Form
    {
        string stringConnection = "server=localhost;database=loja_celulares_db;uid=root;pwd=";
        int? productId;
        public F_TelaAtualizarProduto()
        {
            InitializeComponent();
            Listar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Atualizar();
        }

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int indexRow = e.RowIndex;

			foreach (DataGridViewRow row in dataGridView1.Rows)
			{
				if (row.Index == indexRow)
				{

					textBox1.Text = row.Cells["tipo"].Value.ToString();


					textBox4.Text = row.Cells["cor"].Value.ToString();

					textBox5.Text = row.Cells["tamanho_cm"].Value.ToString();


					textBox7.Text = row.Cells["marca"].Value.ToString();

					textBox3.Text = row.Cells["valor"].Value.ToString();

					textBox2.Text = row.Cells["quantidade_estoque"].Value.ToString();

					textBox6.Text = row.Cells["quantidade_minima"].Value.ToString();

					productId = Convert.ToInt32(row.Cells["id"].Value);
				}
			}
		}

		private void Atualizar()
        {
			if (string.IsNullOrWhiteSpace(textBox1.Text) ||
				string.IsNullOrWhiteSpace(textBox4.Text) ||
				string.IsNullOrWhiteSpace(textBox5.Text) ||
				string.IsNullOrWhiteSpace(textBox3.Text) ||

				string.IsNullOrWhiteSpace(textBox7.Text) ||
				string.IsNullOrWhiteSpace(textBox6.Text) ||
				string.IsNullOrWhiteSpace(textBox2.Text)
				)
			{
				MessageBox.Show("Nenhum campo pode estar  vazio");
				return;
			}
			if (int.TryParse(textBox6.Text, out int i) && int.TryParse(textBox2.Text, out int j))
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
			if (decimal.TryParse(textBox3.Text, out decimal y))
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
			try
            {
                using (MySqlConnection conexao = new MySqlConnection(stringConnection))
                {

                    string sql = $"UPDATE celulares " +
                        $"SET tipo = @tipo ,tamanho_cm = @tamanho_cm, cor = @cor, marca = @marca, valor = @valor, quantidade_minima = @quantidade_minimale " +
                        $"WHERE id = @id";

                    MySqlCommand comando = new MySqlCommand(sql, conexao);

					comando.Parameters.AddWithValue("@id", productId);
					comando.Parameters.AddWithValue("@tipo", textBox1.Text);
					comando.Parameters.AddWithValue("@tamanho_cm", textBox5.Text);
					comando.Parameters.AddWithValue("@cor", textBox4.Text);
					comando.Parameters.AddWithValue("@marca", textBox7.Text);
					comando.Parameters.AddWithValue("@valor", textBox3.Text);
					comando.Parameters.AddWithValue("@quantidade_minima", textBox6.Text);


					conexao.Open();

                    comando.ExecuteNonQuery();

                    MessageBox.Show("Atualizacao efetuada com sucesso!");
                    productId = null;

                    textBox1.Clear();

                    textBox2.Clear();

                    textBox3.Clear();

                    conexao.Close();

                    Listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar: {ex.Message}");
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

       
    }
}
