using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja
{
    public partial class F_TelaPrincipal : Form
    {
        string Nome;
        int Id;
    

        public F_TelaPrincipal()
        {
            InitializeComponent();
            Nome = Repositorio.Username;
            Id = Repositorio.Id;
            label2.Text = Nome;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var f = new F_TelaCadastroUsuario();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var f = new F_TelaCadastroProduto();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
			var f = new F_TelaMovimentacao();
			this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void F_TelaPrincipal_Load(object sender, EventArgs e)
        {
            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new F_TelaLogin();
            f.ShowDialog();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
