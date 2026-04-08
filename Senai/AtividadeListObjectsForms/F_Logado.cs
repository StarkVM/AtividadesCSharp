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
    public partial class F_Logado : Form
    {
        private List<Usuario> Usuarios;

        private Usuario User;

        public F_Logado()
        {
            InitializeComponent();
        }
		public F_Logado(Usuario user,List<Usuario> usuarios)
		{
			InitializeComponent();
            Usuarios = usuarios;
            User = user;
            lblNome.Text = user.Name;
            pnlAdmin.Visible = user.IsAdmin;
		}

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1(Usuarios);
			this.Hide();
			f.Closed += (s, args) => this.Close();
			f.Show();
		}

		private void fechar()
		{
			pnlExibir.Visible = false;
			listBox.Items.Clear();
		}

        private void DeletarUsuario(string userId)
        {
            foreach (var u in Usuarios) 
            {
                if (userId == u.Id.ToString()) 
                {
                    Usuarios.Remove(u);
                }
            }
        }

		private void listBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
			var userId = listBox.SelectedItem.ToString();

            DeletarUsuario(userId);
		}

        private void btnFechar_Click(object sender, EventArgs e)
        {
            fechar();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ListarExibir();
        }

		private void ListarExibir()
		{
			pnlExibir.Visible = true;

			foreach (var u in Usuarios)
			{
				if (u.Login != User.Login)
				{
					listBox.Items.Add($"Eh Admin: {u.IsAdmin}");
					listBox.Items.Add($"Id: {u.Id}");
					listBox.Items.Add($"Nome: {u.Name}");
					listBox.Items.Add($"Numero: {u.Numero}");
					listBox.Items.Add($"Login: {u.Login}");
					listBox.Items.Add($"Eh Admin: {u.IsAdmin}");
					
				}
			}
		}
		private void Listar() 
        {
			pnlExibir.Visible = true;

            foreach (var u in Usuarios) 
            {
                if (u.Login != User.Login) 
                {
                    listBox.Items.Add(u.Id);
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
			Listar();
		}
    }
}

