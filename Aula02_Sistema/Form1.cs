using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace Aula02_Sistema
{
	public partial class Form1 : Form
	{
		private string loginAux, senhaAux;

		public Form1()
		{
			InitializeComponent();
		}

		public Form1(string login, string senha)
		{
			InitializeComponent();
			this.loginAux = login;
			this.senhaAux = senha;
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void txtLogin_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtSenha_TextChanged(object sender, EventArgs e)
		{

		}



		//metodos para apresentar o placeholder
		/////////////////////////////////////////////
		private void txtLogin_Enter(object sender, EventArgs e)
		{
			if (txtLogin.Text == "Digite o e-mail")
			{
				txtLogin.Text = string.Empty;
				txtLogin.ForeColor = Color.Black;
			}
		}

		private void txtLogin_Leave(object sender, EventArgs e)
		{
			if (txtLogin.Text == string.Empty)
			{
				loginLimpar();
			}
		}

		private void txtSenha_Enter(object sender, EventArgs e)
		{
			if (txtSenha.Text == "Digite a senha")
			{
				txtSenha.Text = string.Empty;
				txtSenha.ForeColor = Color.Black;
				txtSenha.UseSystemPasswordChar = true;
			}
		}

		private void txtSenha_Leave(object sender, EventArgs e)
		{
			if (txtSenha.Text == string.Empty)
			{
				senhaLimpar();
			}
		}

		private void loginLimpar()
		{
			txtLogin.Text = "Digite o e-mail";
			txtLogin.ForeColor = Color.Silver;

		}
		private void senhaLimpar()
		{
			txtSenha.Text = "Digite a senha";
			txtSenha.ForeColor = Color.Silver;
			txtSenha.UseSystemPasswordChar = false;

		}
		private void loginCadLimpar()
		{
			txtCadLogin.Text = "Digite o e-mail";
			txtCadLogin.ForeColor = Color.Silver;
		}
		private void senhaCadLimpar()
		{
			txtCadSenha.Text = "Digite a senha";
			txtCadSenha.ForeColor = Color.Silver;
			txtCadSenha.UseSystemPasswordChar = false;
		}

		private void txtCadLogin_Enter(object sender, EventArgs e)
		{
			if (txtCadLogin.Text == "Digite o e-mail")
			{
				txtCadLogin.Text = string.Empty;
				txtCadLogin.ForeColor = Color.Black;
			}
		}

		private void txtCadLogin_Leave(object sender, EventArgs e)
		{
			if (txtCadLogin.Text == string.Empty)
			{
				loginCadLimpar();
			}
		}

		private void txtCadSenha_Enter(object sender, EventArgs e)
		{
			if (txtCadSenha.Text == "Digite a senha")
			{
				txtCadSenha.Text = string.Empty;
				txtCadSenha.ForeColor = Color.Black;
				txtCadSenha.UseSystemPasswordChar = true;
			}
		}

		private void txtCadSenha_Leave(object sender, EventArgs e)
		{
			if (txtCadSenha.Text == string.Empty)
			{
				senhaCadLimpar();
			}
		}
		///////////////////////////////////////////////////////////
		///

		//MÉTODOS LIGADO AO LOGIN

		private void logarMetodo1()
		{
			if (txtLogin.Text.Contains("@") && txtLogin.Text.Contains("."))
			{
				MessageBox.Show("Login Valido", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Login Invalido", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void logarMetodo2()
		{
			if (txtLogin.Text.Contains("@") && txtLogin.Text.Contains(".")
				&& !txtLogin.Text.StartsWith("@") && !txtLogin.Text.EndsWith("@"))
			{
				MessageBox.Show("Login Valido", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Login Invalido", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private bool login()
		{
			if (txtLogin.Text == loginAux && txtSenha.Text == senhaAux)
			{
				return true;
			}
			return false;
		}

		private void logarMetodo3()
		{
			try
			{
				MailAddress m = new MailAddress(txtLogin.Text);

				if (login())
				{
					MessageBox.Show("Login Bem Sucedido", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
					F_TelaPrincipal f_TelaPrincipal = new F_TelaPrincipal(loginAux, senhaAux);
					loginLimpar();
					senhaLimpar();
					this.Hide();
					f_TelaPrincipal.ShowDialog();
				}
				else if (txtLogin.Text == loginAux)

				{
					MessageBox.Show("Senha Incorreta", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("Usuario nao encontrado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}


			}
			catch
			{
				MessageBox.Show("Login Invalido", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		//Botoes
		/// ////////////////////////////////////////////////////////////////
		/// 

		private void btnSair_Click(object sender, EventArgs e)
		{
			if (pnlCadastrar.Visible == true)
			{
				MessageBox.Show("Erro ao sair", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				Application.Exit();
			}

		}

		private void btnCliqueAqui_Click(object sender, EventArgs e)
		{
			pnlCadastrar.Visible = true;

			loginLimpar();
			senhaLimpar();

		}

		private void btnEntrar_Click(object sender, EventArgs e)
		{
			logarMetodo3();
		}




		private void btnFechar_Click(object sender, EventArgs e)
		{
			FecharPnl();
		}

		private void FecharPnl()
		{
			txtCadLogin.Text = string.Empty;
			txtCadSenha.Text = string.Empty;
			pnlCadastrar.Visible = false;
			senhaCadLimpar();
			loginCadLimpar();
		}


		private void btnCadUsuario_Click(object sender, EventArgs e)
		{
			cadastrarMetodo();
		}
		/////////////////////////////////////////////////////////////

		//cadastro
		///////////////////////////////////////////////////////////

		private void cadastrarMetodo()
		{
			try
			{
				MailAddress m = new MailAddress(txtCadLogin.Text);

				if (txtCadSenha.Text == string.Empty || txtCadSenha.Text == "Digite a senha")
				{
					MessageBox.Show("Senha Invalida", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					MessageBox.Show("Usuario Cadastrado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
					loginAux = txtCadLogin.Text;
					senhaAux = txtCadSenha.Text;

					FecharPnl();
				}

			}
			catch
			{
				MessageBox.Show("Login Invalido", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void lblErro_Click(object sender, EventArgs e)
		{

		}

		/// <summary>
		/// ////////////////////////////////////////////////////////
		/// </summary>
		private void loginFinal()
		{
			lblErro.Visible = false;//Limpando o componente

			if (string.IsNullOrWhiteSpace(txtLogin.Text))//verifica login invalido
			{
				lblErro.Text = "Login Inexistente";
				lblErro.Visible = true;
				return;
			}
			if (string.IsNullOrWhiteSpace(txtSenha.Text))//verifica senha valida
			{
				lblErro.Text = "Senha Incorreta";
				lblErro.Visible = true;
				return;
			}
			if (!txtLogin.Text.Contains("@") || !txtLogin.Text.Contains(".")) //testa se o campo de email possui carateres obrigatorios
			{
				lblErro.Text = "Formato do e-mail invalido";
				lblErro.Visible = true;
				return;
			}
			//testa se login e senha senha sao iguais
			if (txtLogin.Text == loginAux && txtSenha.Text == senhaAux)
			{
				F_TelaPrincipal f_TelaPrincipal = new F_TelaPrincipal();
				this.Hide();
				f_TelaPrincipal.ShowDialog();
			}
			else
			{
				if (txtLogin.Text != loginAux)
				{
					lblErro.Text = "Login Invalido";
					lblErro.Visible = true;
					return;
				}
				else
				{
					lblErro.Text = "Senha Invalida";
					lblErro.Visible = true;
				}
				
			}
		}

		////////////////////////////////////////////////////////////////////////////////
	}
}
