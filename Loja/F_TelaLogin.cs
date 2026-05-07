using MySql.Data.MySqlClient;

namespace Loja
{
	public partial class F_TelaLogin : Form
	{
		string stringConnection = "server=localhost;database=loja;uid=root;pwd=";
		public F_TelaLogin()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Login();
		}

		private void Login()
		{
			try
			{
				string sql = "SELECT id, nome , senha FROM usuario WHERE email = @login;";

				string nome = "", senhaHash = "", id = "";

				using (MySqlConnection con = new MySqlConnection(stringConnection))
				{
					con.Open();

					MySqlCommand command = new MySqlCommand(sql, con);

					command.Parameters.AddWithValue("@login", textBox1.Text.Trim());

					using (MySqlDataReader reader = command.ExecuteReader())
					{
						if (reader.HasRows)
						{
							reader.Read();
							nome = reader["nome"].ToString();
							senhaHash = reader["senha"].ToString();
							id = reader["id"].ToString();

							if (Hasher.Verify(textBox2.Text.Trim(), senhaHash!))
							{
								int userId = int.Parse(id);
								Repositorio.Id = userId;
								Repositorio.Username = nome;
								this.Hide();
								var f = new F_TelaPrincipal();
								f.ShowDialog();
								this.Close();
								return;
							}
						}

						MessageBox.Show("Login ou senha incorretos");
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex}");
			}
		}

		private void Tela_Inicial_Load(object sender, EventArgs e)
		{

		}
	}
}
