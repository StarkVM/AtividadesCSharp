using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace AulaEstruturaForms
{
    public partial class Form1 : Form
    {
        private string[] Nomes = new string[20];
		public Form1()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            string[] nomes = Nomes;
            bool exist = false;
			for (int i = 0; i < nomes.Length; i++)
			{
                if (!string.IsNullOrWhiteSpace(nomes[i])) { listBox.Items.Add(nomes[i]); exist = true; }

			}
            if (!exist)
            {
				MessageBox.Show("Vetor Vazio", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
            }
			pnlExibir.Visible = true;

		}

        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string valor = Interaction.InputBox("Digite o nome que deseja adicionar", "Digitar nome", "", 300, 300);
				int indice = Array.IndexOf(Nomes, null);
                if (indice == -1)
                {
					MessageBox.Show("Vetor Cheio", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
				}
				if (!string.IsNullOrEmpty(valor) && !double.TryParse(valor, out double v))
                {
                    Nomes[indice] = valor;
                    MessageBox.Show("Adicionado", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

				MessageBox.Show("Esse nome é invalido", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
            catch (Exception ex)
            {
				MessageBox.Show("Erro inesperado", ex.Message);
			}
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
			Array.Clear(Nomes, 0, Nomes.Length);
			MessageBox.Show("Vetor Limpo", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            Array.Sort(Nomes);
			MessageBox.Show("Vetor Ordenado", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

        private void btnInverter_Click(object sender, EventArgs e)
        {
			Array.Reverse(Nomes);
			MessageBox.Show("Vetor Invertido", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            
			string n = Interaction.InputBox("Digite o nome que deseja pesquisar", "Digitar nome", "", 300, 300);

            if (string.IsNullOrWhiteSpace(n) || !double.TryParse(n, out double nn))
            {
				MessageBox.Show("Esse nome nao é valido", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
            }


            bool exist = false;
			for (int i = 0; i < n.Length; i++)
			{
				if (n.Equals(Nomes[i]))
				{
                    if (!string.IsNullOrWhiteSpace(Nomes[i])) 
                    {
						listBox.Items.Add(Nomes[i]);
						exist = true;
					}
				}
			}

			if (!exist)
			{
				MessageBox.Show("Nome nao encontrado", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}



			pnlExibir.Visible = true;
		}

        private void btnFechar_Click(object sender, EventArgs e)
        {
			pnlExibir.Visible = false;
			listBox.Items.Clear();    
		}
    }
}
