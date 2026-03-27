using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estruturas
{
	internal class Vetor
	{
		private string[] nomes;

		public Vetor()
		{
			nomes = new string[10]
			{
				"Andre",
				"Joao",
				"Marcos",
				"Maria",
				"Paula",
				"Zeca",
				null,
				null,
				null,
				null
			};
		}

		public void Menu()
		{
			while (true)
			{
				Console.Clear();
				Console.WriteLine("----------------");
				MostrarNomes();
				Console.WriteLine("----------------");

				Console.WriteLine("Escolha:");
				Console.WriteLine("1- Adicionar Nome");
				Console.WriteLine("2- Remover pelo Nome");
				Console.WriteLine("3- Remover pelo Indice");
				Console.WriteLine("4- Limpar Vetor");
				Console.WriteLine("5- Ordenar Vetor");
				Console.WriteLine("6- Inverter Nome");
				Console.WriteLine("7- Pesquisar Nome");
				Console.WriteLine("8- Pesquisar Indice");
				Console.WriteLine("Opcao:");
				string op = Console.ReadLine();

				Console.Clear();

				switch (op)
				{
					case "1": AdicionarNome(); break;
					case "2": RemoverNome(); break;
					case "3": RemoverIndice(); break;
					case "4": LimparVetor(); break;
					case "5": OrdenarVetor(); break;
					case "6": InverterNomes(); break;
					case "7": PesquisarNomes(); break;
					case "8": BuscarIndice(); break;

					default: Console.WriteLine("Erro"); break;
				}
			}
		}

		private void MostrarNomes()
		{
			for (int i = 0; i < nomes.Length; i++)
			{
				if (nomes[i] != null)
				{
					Console.WriteLine(nomes[i]);
				}
			}
		}

		private void AdicionarNome()
		{
			int posiccaoVazia = Array.IndexOf(nomes, null);

			if (posiccaoVazia == -1)
			{
				Console.WriteLine("Vetor Cheio!");
				return;
			}

			Console.Write("Digite o nome:");
			nomes[posiccaoVazia] = Console.ReadLine();
			Console.WriteLine("\nNome adicionado");

		}

		private void RemoverNome()
		{
			Console.Write("Digite o Nome: ");
			string n = Console.ReadLine();

			int posicao = Array.IndexOf(nomes, n.ToUpper());

			if (posicao == -1)
			{
				Console.WriteLine("Nao encontrado, noob!");
				return;
			}
			nomes[posicao] = null;
			Console.WriteLine("Nome removido!");
		}

		private void RemoverIndice()
		{
			Console.WriteLine("Digite o indice para remover: ");
			string p = Console.ReadLine();

			if (int.TryParse(p, out int posicao))
			{
				nomes[posicao] = null;
				Console.WriteLine("Indice Removido");
			}
		}

		private void LimparVetor()
		{
			Array.Clear(nomes, 0, nomes.Length); //(nome do vetor, indice inicial, total elem.)
			Console.WriteLine("O vetor foi limpo");
		}

		private void OrdenarVetor()
		{
			Array.Sort(nomes);
		}
		private void InverterNomes()
		{
			Array.Reverse(nomes);
		}

		private void PesquisarNomes()
		{
			Console.WriteLine("Digite um nome");
			string n = Console.ReadLine();

			/*int posicao = Array.IndexOf(nomes, n);

			if (posicao == -1)
			{
				Console.WriteLine("Nao encontrado, noob!");
				return;
			}*/
			for (int i = 0; i < n.Length; i++)
			{
				if (nomes[i].Equals(n))
				{
					Console.WriteLine(nomes[i]);
				}
			}
		}

		private void BuscarIndice()
		{
			Console.WriteLine("digite o nome para acar o indice: ");
			string n = Console.ReadLine();
			int posicao = Array.IndexOf(nomes, n);

			if (posicao != -1)
			{
				Console.WriteLine($"Encontrado na posicao: {posicao}");
			}
			else
			{
				Console.WriteLine("Nome nao encontrado");
			}
			Console.ReadKey();
		}
	}
}
