using MySql.Data.MySqlClient;

namespace Loja
{
	public partial class F_TelaLogin : Form
	{
		string stringConnection = "server=localhost;database=loja_celulares_db;uid=root;pwd=";
		public F_TelaLogin()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Login(textBox1.Text, textBox2.Text);
		}

		public bool Login(string login, string senha)
		{
			try
			{
				string sql = "SELECT id, nome , senha FROM usuarios WHERE login = @login;";

				if (string.IsNullOrWhiteSpace(login)) 
				{
					MessageBox.Show("Login nao pode ser nulo ou vazio");
				}
				if (string.IsNullOrWhiteSpace(senha))
				{
					MessageBox.Show("Senha nao pode ser nuloa ou vazia");
				}

				string nome = "", senhaHash = "", id = "";

				using (MySqlConnection con = new MySqlConnection(stringConnection))
				{
					con.Open();

					MySqlCommand command = new MySqlCommand(sql, con);

					command.Parameters.AddWithValue("@login", login.Trim());

					using (MySqlDataReader reader = command.ExecuteReader())
					{
						if (reader.HasRows)
						{
							reader.Read();
							nome = reader["nome"].ToString();
							senhaHash = reader["senha"].ToString();
							id = reader["id"].ToString();

							if (Hasher.Verify(senha.Trim(), senhaHash!))
							{
								int userId = int.Parse(id);
								Repositorio.Id = userId;
								Repositorio.Username = nome;
								this.Hide();
								var f = new F_TelaPrincipal();
								f.ShowDialog();
								this.Close();
								return true;
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

			return false;
		}

		private void Tela_Inicial_Load(object sender, EventArgs e)
		{

		}
	}
}
