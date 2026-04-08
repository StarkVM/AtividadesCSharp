using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavegadorFake
{
    public partial class Form1 : Form
    {
        private Stack<string> _pilhaHistorico;
        private Stack<string> _pilhaAvancar;
		private Stack<string> _pilhaVoltar;
		public Form1()
        {
            InitializeComponent();
            _pilhaHistorico = new Stack<string>();
            _pilhaHistorico.Push("google.com");
            lblSiteAtual.Text = _pilhaHistorico.Peek();
			_pilhaAvancar = new Stack<string>();
			_pilhaVoltar = new Stack<string>();
		}

        private void btnIr_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPesquisa.Text)) 
            {
				MessageBox.Show("O campo de pesquisa nao pode estar vazio", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			_pilhaAvancar.Clear();
            _pilhaVoltar.Push(_pilhaHistorico.Peek());
            _pilhaHistorico.Push(txtPesquisa.Text);
            lblSiteAtual.Text = _pilhaHistorico.Peek();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if (_pilhaVoltar.Count() == 0) 
            {
                return;
            }
			
			string site = _pilhaVoltar.Pop();
            _pilhaAvancar.Push(_pilhaHistorico.Peek());
			_pilhaHistorico.Push(site);
			lblSiteAtual.Text = site;
		}

        private void btnAvancar_Click(object sender, EventArgs e)
        {
			if (_pilhaAvancar.Count() == 0)
			{
				return;
			}

			string site = _pilhaAvancar.Pop();
			_pilhaVoltar.Push(_pilhaHistorico.Peek());
			_pilhaHistorico.Push(site);
			lblSiteAtual.Text = site;
		}

        private void btnHistorico_Click(object sender, EventArgs e)
        {
			bool exist = false;
          
			foreach (string p in _pilhaHistorico)
			{
				if (!string.IsNullOrWhiteSpace(p))
                {
					listBox.Items.Add(p);
					exist = true;
				}
			}
			if (!exist)
			{
				MessageBox.Show("Sem sites para exibir", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			pnlHistorico.Visible = true;
		}

        private void btnFechar_Click(object sender, EventArgs e)
        {
			pnlHistorico.Visible = false;
			listBox.Items.Clear();
		}
    }
}
