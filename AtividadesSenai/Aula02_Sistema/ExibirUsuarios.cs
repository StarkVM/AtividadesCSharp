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
    public partial class ExibirUsuarios : Form
    {
        private string[] Nomes;
		private string[] Bairros;
		private string[] Cidades;
		private string[] Estados;
		private int Indice;
		private int Posicao;
		private string Login;
		private string Senha;
		public ExibirUsuarios()
        {
            InitializeComponent();
        }
		public ExibirUsuarios(string[] nomes, string[] cidades,string[] bairros, string[] estados, int indice,string login, string senha)
		{
			InitializeComponent();
			Nomes = nomes;
			Bairros = bairros;
			Cidades = cidades;
			Estados = estados;
			Indice = indice;
			Login = login;
			Senha = senha;
			Posicao = 0;
			Exibir();
		}

		private void Exibir()
		{
			lblNome.Text = Nomes[Posicao].ToUpper();
			lblCidade.Text = Cidades[Posicao].ToUpper();
			lblBairro.Text = Bairros[Posicao].ToUpper();
			lblEstado.Text = Estados[Posicao].ToUpper();
			lblContagem.Text = (Posicao + 1).ToString();
		}

        private void btnBack_Click(object sender, EventArgs e)
        {
			this.Hide();
			F_TelaPrincipal f_TelaPrincipal = new F_TelaPrincipal(Nomes, Cidades, Bairros, Estados, Indice, Login, Senha);
			f_TelaPrincipal.ShowDialog();
			this.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
			if (Posicao > 0)
			{
				Posicao --;
				Exibir ();
				return;
			}
			MessageBox.Show("Voce ja esta na posicao 1", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

        private void btnAvancar_Click(object sender, EventArgs e)
        {
			if (Posicao < 9 && Posicao < Indice-1)
			{
				Posicao ++;
				Exibir();
				return;
			}
			MessageBox.Show("Voce ja esta na ultima posicao", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
