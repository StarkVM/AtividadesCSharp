using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeListObjectsForms
{
    public partial class F_Cadastro : Form
    {
        List<Usuario> Usuarios = new List<Usuario>();
        public F_Cadastro()
        {
            InitializeComponent();
        }

		public F_Cadastro(List<Usuario> usuarios)
		{
			InitializeComponent();
            Usuarios = usuarios;
		}

        private void btnVoltar_Click(object sender, EventArgs e)
        {
			this.Hide();
			Form1 f = new Form1(Usuarios);
			f.Closed += (s, args) => this.Close();
			f.Show();
		}

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            foreach (var x in Usuarios) 
            {
                if (x.Login == txtLogin.Text) 
                {
					MessageBox.Show("Esse login ja existe", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}
            }

            if (string.IsNullOrWhiteSpace(txtLogin.Text) ||
                string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(txtNumero.Text) ||
                string.IsNullOrWhiteSpace(txtSenha.Text) ||
                string.IsNullOrWhiteSpace(cbbTipo.Text)
                ) 
            {
				MessageBox.Show("Nenhum dos campos pode estar vazio", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
			}

			if (txtSenha.Text.Length < 6)
			{
				MessageBox.Show("Senha muito curta", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			if (txtSenha.Text != txtConformarSenha.Text) 
            {
				MessageBox.Show("Senhas incompativeis", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

            bool isAdmin = false;

            if (cbbTipo.Text == "Admin") 
            {
                isAdmin = true;
            }
            var id = new Guid();

			Usuario user = new Usuario(id, txtNome.Text, txtLogin.Text, txtSenha.Text, txtNumero.Text, isAdmin);

			MessageBox.Show($"{user.Id}", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
			
			Usuarios.Add(user);

            txtNumero.Clear(); txtSenha.Clear(); txtConformarSenha.Clear(); txtLogin.Clear(); txtNome.Clear();
			MessageBox.Show("Cadastro concluido", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
    }
}
