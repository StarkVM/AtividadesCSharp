using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeListObjectsForms
{
    public partial class Form1 : Form
    {
        private List<Usuario> Usuarios = new List<Usuario>();
        public Form1()
        {
            InitializeComponent();
            Usuario user = new Usuario(new Guid(),"Adm1" ,"adm", "adm","111111" ,true);
			Usuarios.Add(user);
        }
		public Form1(List<Usuario> usuarios)
		{
			InitializeComponent();
			Usuarios = usuarios;
		}

		private void btnEntrar_Click(object sender, EventArgs e)
        {
			logar();
        }

		private void loginLimpar()
		{
			txtLogin.Text = "Digite o login";
			txtLogin.ForeColor = Color.Silver;

		}
		private void senhaLimpar()
		{
			txtSenha.Text = "Digite a senha";
			txtSenha.ForeColor = Color.Silver;
			txtSenha.UseSystemPasswordChar = false;

		}

        private void txtLogin_Leave_1(object sender, EventArgs e)
        {
			if (txtLogin.Text == string.Empty)
			{
				loginLimpar();
			}
		}

        private void txtLogin_Enter_1(object sender, EventArgs e)
        {
			if (txtLogin.Text == "Digite o login")
			{
				txtLogin.Text = string.Empty;
				txtLogin.ForeColor = Color.Black;
			}
		}

        private void txtSenha_Leave_1(object sender, EventArgs e)
        {
			if (txtSenha.Text == string.Empty)
			{
				senhaLimpar();
			}
		}

        private void txtSenha_Enter_1(object sender, EventArgs e)
        {
			if (txtSenha.Text == "Digite a senha")
			{
				txtSenha.Text = string.Empty;
				txtSenha.ForeColor = Color.Black;
				txtSenha.UseSystemPasswordChar = true;
			}
		}

		private void logar() 
		{
			{
				try
				{
					if (txtLogin.Text == "Digite o login" || string.IsNullOrWhiteSpace(txtLogin.Text)) 
					{
						MessageBox.Show("Login invalido", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
						return;
					}
					if (txtLogin.Text == "Digite a senha" || string.IsNullOrWhiteSpace(txtSenha.Text))
					{
						MessageBox.Show("Senha invalida", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
						return;
					}

					foreach (var u in Usuarios) 
					{
						if (u.Login == txtLogin.Text && u.Senha == txtSenha.Text) 
						{
							MessageBox.Show("Login Bem Sucedido", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
							F_Logado f = new F_Logado(u, Usuarios);
							loginLimpar();
							senhaLimpar();
							this.Hide();
							f.Closed += (s, args) => this.Close();
							f.Show();
							return;
						}
					}
					
					MessageBox.Show("Login invalido", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
					
				}
				catch
				{
					MessageBox.Show("Login Invalido", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

        private void btnCadastro_Click(object sender, EventArgs e)
        {
			this.Hide();
			F_Cadastro f = new F_Cadastro(Usuarios);
			f.Closed += (s, args) => this.Close();
			f.Show();
		}
    }
}
