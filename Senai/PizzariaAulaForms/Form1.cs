using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace PizzariaAulaForms
{
    public partial class Form1 : Form
    {
        private List<string> Pedidos;
		private List<string> Atendidos;
        public Form1()
        {
            InitializeComponent();
			Pedidos = new List<string>();
			Atendidos = new List<string>();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
			try
			{
				string valor = Interaction.InputBox("Digite o nome do pedido que deseja adicionar", "Digitar nome", "", 300, 300);


				if (string.IsNullOrEmpty(valor) || double.TryParse(valor, out double v))
				{
					MessageBox.Show("Esse pedido é invalido", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				if (Pedidos.Contains(valor)) 
				{
					MessageBox.Show("Esse nome de pedido ja foi cadastrado", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				
				Pedidos.Add(valor);
				MessageBox.Show("Pedido Adicionado", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;

			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro inesperado", ex.Message);
			}
		}

        private void btnAtender_Click(object sender, EventArgs e)
        {
			string valor = Interaction.InputBox("Digite o nome do pedido que deseja atender e preparar",
				"Digitar numero", "", 300, 300);

			Atender(valor);
		}

		private void Atender(string valor) 
		{
			if (string.IsNullOrEmpty(valor) || int.TryParse(valor, out int v))
			{
				MessageBox.Show("Esse nome é invalido", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (Pedidos.Contains(valor))
			{
				Pedidos.Remove(valor);
				Atendidos.Add(valor);
				MessageBox.Show("Pedido Atendido", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				fechar();
				return;
			}

			MessageBox.Show("Pedido Nao encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

        private void btnRemover_Click(object sender, EventArgs e)
        {
			var valor = Interaction.InputBox("Digite o nome do pedido que deseja remover",
				"Digitar numero", "", 300, 300);

			if (string.IsNullOrEmpty(valor) || int.TryParse(valor, out int v))
			{
				MessageBox.Show("Esse nome é invalido", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (Pedidos.Contains(valor))
			{
				Pedidos.Remove(valor);
				MessageBox.Show("Pedido removido", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}

			MessageBox.Show("Pedido Nao encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

        private void btnPosicao_Click(object sender, EventArgs e)
        {
			string valor = Interaction.InputBox("Digite o nome do pedido que deseja pesquisar",
				"Digitar Nome", "", 300, 300);

			if (string.IsNullOrEmpty(valor) || double.TryParse(valor, out double v))
			{
				MessageBox.Show("Esse nome é invalido", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			
			if (Pedidos.Contains(valor))
			{
				int n = Pedidos.IndexOf(valor);

				MessageBox.Show($"O pedido {valor}, esta na posicao {n}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}

			MessageBox.Show("Pedido Nao encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
			Pedidos.Sort();
        }

        private void btnInverter_Click(object sender, EventArgs e)
        {
			Pedidos.Reverse();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
			Pedidos.Clear();
			Atendidos.Clear();
        }

        private void btnAtendidos_Click(object sender, EventArgs e)
        {
			bool exist = false;
			foreach (string a in Atendidos)
			{
				if (!string.IsNullOrWhiteSpace(a))
				{
					listBox.Items.Add($"{a}, pedido atendido.");
					exist = true;
				}
			}
			if (!exist)
			{
				MessageBox.Show("Sem Atendimentos", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			pnlExibir.Visible = true;
		}

		private void btnPedidos_Click(object sender, EventArgs e)
		{
			ExibirPedidos();
		}

		private void ExibirPedidos() 
		{
			bool exist = false;
			foreach (string p in Pedidos)
			{
				if (!string.IsNullOrWhiteSpace(p))
				{
					int n = Pedidos.IndexOf(p);
					listBox.Items.Add($"{p}, pedido {n}");
					exist = true;
				}
			}
			if (!exist)
			{
				MessageBox.Show("Sem pedidos", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			pnlExibir.Visible = true;
		}

		private void ExibirPedidosAtendimento()
		{
			bool exist = false;
			foreach (string p in Pedidos)
			{
				if (!string.IsNullOrWhiteSpace(p))
				{
					listBox.Items.Add(p);
					exist = true;
				}
			}
			if (!exist)
			{
				MessageBox.Show("Sem pedidos", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			pnlExibir.Visible = true;
		}

		private void fechar() 
		{
			pnlExibir.Visible = false;
			listBox.Items.Clear();
		}
		private void btnFechar_Click(object sender, EventArgs e)
        {
			fechar();
		}

        private void listBox_DoubleClick(object sender, EventArgs e)
        {
			var pedido = listBox.SelectedItem.ToString();

			Atender(pedido);
		}

        private void btnAtendimento_Click(object sender, EventArgs e)
        {
			ExibirPedidosAtendimento();
        }
    }
}
