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
    public partial class DeletarCelulares : Form
    {
		string stringConnection = "server=localhost;database=loja_celulares_db;uid=root;pwd=";
		public DeletarCelulares()
        {
            InitializeComponent();
			Listar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new F_TelaPrincipal();
            f.ShowDialog();
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Index == indexRow)
                {
					int id = Convert.ToInt32(row.Cells["id"].Value);

					Deletar(id);
				}
            }
        }

		private void Deletar(int id) 
		{
			var result = MessageBox.Show("Deseja realmente deletar esse celular?", "Avioso", MessageBoxButtons.YesNo);

			if (result == DialogResult.Yes) 
			{
				try
				{
					using (MySqlConnection conexao = new MySqlConnection(stringConnection))
					{

						string sql = $"DELETE FROM celulares WHERE id = @id;";


						 MySqlCommand comando = new MySqlCommand(sql, conexao);

						comando.Parameters.AddWithValue("@id", id);

						string sql2 = $"DELETE FROM movimentacoes WHERE id_celular = @id;";

						MySqlCommand comando2 = new MySqlCommand(sql2, conexao);

						comando2.Parameters.AddWithValue("@id", id);

						conexao.Open();

						comando2.ExecuteNonQuery();

						int resultado = comando.ExecuteNonQuery();

						if (resultado < 0) 
						{
							MessageBox.Show("Erro ao Deletar");
							return;
						}

						MessageBox.Show("Celular deletado com sucesso!");

						conexao.Close();

						Listar();
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Erro ao deletar: {ex.Message}");
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


		private void DeletarCelulares_Load(object sender, EventArgs e)
        {

        }
    }
}
