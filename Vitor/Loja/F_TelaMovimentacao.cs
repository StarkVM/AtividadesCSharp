using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Loja
{
    public partial class F_TelaMovimentacao : Form
    {

        private int UserId;
        private string UserName;
        string stringConnection = "server=localhost;database=loja_celulares_db;uid=root;pwd=";
		public F_TelaMovimentacao()
        {
            InitializeComponent();
            Listar();
            UserName = Repositorio.Username;
            UserId = Repositorio.Id;
        }
        public F_TelaMovimentacao(string nome, int id)
        {
            InitializeComponent();
            Listar();
            UserName = nome;
            UserId = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Movimentacao();
        }

        private void Movimentacao()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Nenum dos campos pode estar vazio");
                return;
            }
            if (int.TryParse(textBox2.Text, out int i))
            {
                if (i < 0)
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
            string quantidadeMinima = string.Empty;
            string estoqueAtual = string.Empty;
            try
            {
                var sql = "SELECT quantidade_minima, quantidade_estoque FROM celulares WHERE id = @id";
                using (var connection = new MySqlConnection(stringConnection))
                using (var command = new MySqlCommand(sql, connection))
                {
                    connection.Open();

                    command.Parameters.AddWithValue("@id", textBox1.Text);

                    var reader = command.ExecuteReader();

                    if (!reader.HasRows)
                    {
                        MessageBox.Show("Nenhum produto com esse ID cadastrado no banco");
                        return;
                    }

                    reader.Read();

                    quantidadeMinima = reader["quantidade_minima"].ToString();
                    estoqueAtual = reader["quantidade_estoque"].ToString();

                    connection.Close();

                    if (!int.TryParse(quantidadeMinima, out int y) || !int.TryParse(estoqueAtual, out int j))
                    {
                        MessageBox.Show("Erro, quantidade e estoque devem ser numeros inteiros");
                        return;
                    }

                    int.TryParse(quantidadeMinima, out int quantidade);

                    int.TryParse(estoqueAtual, out int estoque);

                    string tipo = "";
                    int quantidadeMov = int.Parse(textBox2.Text);
                    if (radioButton1.Checked == true)
                    {
                        estoque -= quantidadeMov;
                        if (estoque < 0)
                        {
                            MessageBox.Show("O valor de saida nao pode ser maior que o de estoque!");
                            return;
                        }
                        if (estoque < quantidade)
                        {
                            MessageBox.Show("O estoque esta na taxa minima!");
                        }
                        tipo = "Saida";
                    }
                    else if (radioButton2.Checked == true)
                    {
                        estoque += quantidadeMov;
                        if (estoque <= quantidade)
                        {
                            MessageBox.Show("Ainda abaixo da quantidade minima!");
                        }
                        tipo = "Entrada";
                    }
                    else
                    {
                        MessageBox.Show("Voce deve selecionar uma acao");
                        return;
                    }

                    int.TryParse(textBox1.Text, out int produtoId);

                    Atualizar(produtoId, UserId, estoque, tipo, quantidadeMov);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex}");
            }


        }

        private void Atualizar(int produtoId, int userId, int estoque, string tipo, int quantidade)
        {
            using (MySqlConnection conexao = new MySqlConnection(stringConnection))
            {
                conexao.Open();
                MySqlTransaction transacao = conexao.BeginTransaction();
                try
                {

                    string cmdUpdate = $"UPDATE celulares SET quantidade_estoque = @estoque WHERE id = @id";
                    string cmdInsert = "INSERT INTO movimentacoes (id_usuario, id_celular, tipo, quantidade, data_movimentacao) VALUES" +
                        " (@id_usuario,@id_celular, @tipo, @quantidade, @data_movimentacao)";



                    MySqlCommand comando = new MySqlCommand(cmdUpdate, conexao, transacao);
                    comando.Parameters.AddWithValue("@id", produtoId);
                    comando.Parameters.AddWithValue("@estoque", estoque);
                    comando.ExecuteNonQuery();


                    MySqlCommand comando2 = new MySqlCommand(cmdInsert, conexao, transacao);
                    comando2.Parameters.AddWithValue("@id_celular", produtoId);
                    comando2.Parameters.AddWithValue("@id_usuario", userId);
                    comando2.Parameters.AddWithValue("@tipo", tipo);
                    comando2.Parameters.AddWithValue("@quantidade", quantidade);
					comando2.Parameters.AddWithValue("@data_movimentacao", dateTimePicker1.Value.Date);
					comando2.ExecuteNonQuery();

                    transacao.Commit();

                    MessageBox.Show("Movimentacao efetuada com sucesso!");
                    Listar();

                    textBox1.Clear();

                    textBox2.Clear();

                    conexao.Close();
                }

                catch (Exception ex)
                {
                    transacao.Rollback();
                    MessageBox.Show($"Erro ao Movimentar: {ex.Message}");
                }
            }
        }

        /*private void CadastrarMovimentacao()
		{

			using (MySqlConnection conn = new MySqlConnection(stringConexao))
			{
				conn.Open();

				MySqlTransaction transacao = conn.BeginTransaction(); //criando a transaÃ§Ã£o

				try
				{
					string insert = @"INSERT INTO movimentacao 
                              (id_usuario, id_produto, tipo, quantidade)
                              VALUES (@usuario, @id_local_produto, @tipo, @qtd)";

					MySqlCommand cmdInsert = new MySqlCommand(insert, conn, transacao);
					cmdInsert.Parameters.AddWithValue("@usuario", UsuarioLogado.Id);
					cmdInsert.Parameters.AddWithValue("@id_local_produto", idProduto);
					cmdInsert.Parameters.AddWithValue("@tipo", tipo);
					cmdInsert.Parameters.AddWithValue("@qtd", qtdProduto);
					cmdInsert.ExecuteNonQuery();

					string operador = tipo == rdbEntrada.Text.ToString() ? "+" : "-";

					string update = $"UPDATE produto SET estoque_atual = estoque_atual {operador} @qtd WHERE id = @id_local_produto";

					MySqlCommand cmdUpdate = new MySqlCommand(update, conn, transacao);
					cmdUpdate.Parameters.AddWithValue("@qtd", qtdProduto);
					cmdUpdate.Parameters.AddWithValue("@id_local_produto", idProduto);
					cmdUpdate.ExecuteNonQuery();

					transacao.Commit();

					MessageBox.Show("Movimentação realizada!");
					CarregarDados();
				}
				catch (Exception ex)
				{
					transacao.Rollback();
					MessageBox.Show("Erro: " + ex.Message);
				}
			}
		}*/

        private void Listar()
        {
            var sql = @"SELECT
                        m.id AS 'ID Mov.',
                        u.nome AS 'Usuario',
                        p.id AS 'Produto',
                        m.tipo AS 'Operacao',
                        m.quantidade AS 'Qtd',
                        m.data_movimentacao AS 'Data'
                        FROM movimentacoes m
                        INNER JOIN usuarios u ON m.id_usuario = u.id
                        INNER JOIN celulares p ON m.id_celular = p.id;";

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

        private void FiltrarProduto()
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) //Filtrar
        {
            Filtrar();
        }
        private void Filtrar()
        {

            DataTable dt = new DataTable();
            if (radioButton3.Checked)
            {
                Listar();
                return;
            }
            if (radioButton4.Checked)
            {

                var sql = @"SELECT
                        m.id AS 'ID Mov.',
                        u.nome AS 'Usuario',
                        p.id AS 'Produto',
                        m.tipo AS 'Operacao',
                        m.quantidade AS 'Qtd',
                        m.data_movimentacao AS 'Data'
                        FROM movimentacoes m
                        INNER JOIN usuarios u ON m.id_usuario = u.id
                        INNER JOIN celulares p ON m.id_celular = p.id
                        WHERE m.tipo = 'Entrada';";

                try
                {
                    using (var da = new MySqlDataAdapter(sql, stringConnection))
                    {
                        da.Fill(dt);

                        dataGridView1.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro: {ex}");
                }
            }
            if (radioButton5.Checked)
            {

                var sql = @"SELECT
                        m.id AS 'ID Mov.',
                        u.nome AS 'Usuario',
                        p.id AS 'Produto',
                        m.tipo AS 'Operacao',
                        m.quantidade AS 'Qtd',
                        m.data_movimentacao AS 'Data'
                        FROM movimentacoes m
                        INNER JOIN usuarios u ON m.id_usuario = u.id
                        INNER JOIN celulares p ON m.id_celular = p.id
                        WHERE m.tipo = 'Saida';";

				try
                {
                    using (var da = new MySqlDataAdapter(sql, stringConnection))
                    {
                        da.Fill(dt);

                        dataGridView1.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro: {ex}");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
			this.Hide();
			var f = new F_TelaPrincipal();
			f.ShowDialog();
			this.Close();
		}
    }
}
