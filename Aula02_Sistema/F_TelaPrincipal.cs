using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula02_Sistema
{
    public partial class F_TelaPrincipal : Form
    {
		private string[] Nomes = new string[10];
		private string[] Cidades = new string[10];
		private string[] Bairros = new string[10];
		private string[] Estados = new string[10];
        private string Login = "cadastro errado";
		private string Senha = "cadastro errado";


		int Indice = 0;

        public F_TelaPrincipal()
        {
            InitializeComponent();
        }

        public F_TelaPrincipal(string login, string senha)
        {
            InitializeComponent();
            Login = login;
			Senha = senha;
			logar();
            
        }

		public F_TelaPrincipal(string login)
		{
			InitializeComponent();
			Login = login;
			logar();
		}
		public F_TelaPrincipal(string[] nomes, string[] cidades, string[] bairros, string[] estados, int indice, string login, string senha)
        {
			InitializeComponent();
			Nomes = nomes;
            Cidades = cidades;
            Bairros = bairros;
            Estados = estados;
            Indice = indice;
            Login = login;
            Senha = senha;
            logar();
        }

        public void logar()
        {
			lblMensagem.Text = $"Logado como: {Login}";
		}


		private void btnLogOff_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1(Login , Senha);
            form.ShowDialog();
            this.Close();
        }

        private void cadastrarUsuario()
        {
            if (Indice > 9)
            {
                MessageBox.Show("Limite de cadastros atingidos", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(txtBairro.Text) ||
                string.IsNullOrWhiteSpace(txtCidade.Text) ||
                string.IsNullOrWhiteSpace(cbEstado.Text)
                )
            {
                MessageBox.Show("Nenhum dos campos pode estar vazio!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                if (int.TryParse(txtNome.Text, out int f1))
                {
					MessageBox.Show("Nome invalido!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
				if (int.TryParse(txtBairro.Text, out int f2))
				{
					MessageBox.Show("Bairro invalido!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
				if (int.TryParse(txtCidade.Text, out int f3))
				{
					MessageBox.Show("Cidade invalida!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
				if (int.TryParse(cbEstado.Text, out int f4))
				{
					MessageBox.Show("Estado invalido!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}

				Nomes[Indice] = txtNome.Text;
                Bairros[Indice] = txtBairro.Text;
                Cidades[Indice] = txtCidade.Text;
                Estados[Indice] = cbEstado.Text;

                Indice++;
                MessageBox.Show("Cadastro Efetuado", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                limpar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado", ex.Message);
            }

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            cadastrarUsuario();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void limpar()
        {
            txtNome.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            cbEstado.Text = "";
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            if (Indice == 0)
            {
				MessageBox.Show("Nenhum Cadastro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
            }
            this.Hide();
            ExibirUsuarios exibir = new ExibirUsuarios(Nomes, Cidades, Bairros, Estados, Indice, Login, Senha);
            exibir.ShowDialog();

        }
    }
}
