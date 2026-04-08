using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estruturas
{
    internal class Listas
    {
        private List<string> Nomes;

        public Listas()
        {
            Nomes = new List<string>()
            {
                "Maria",
				"Joao",
				"Pedro",
				"Paulo"
			};
        }

		public void Menu()
		{
			while (true)
			{
				Console.Clear();
				Console.WriteLine("----------------");
				MostrarLista();
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
					case "3": RemoverPosicao(); break;
					case "4": LimparLista(); break;
					case "5": OrdenarLista(); break;
					case "6": InverterLista(); break;
					case "7": BuscarNome(); break;
					case "8": BuscarPosicao(); break;

					default: Console.WriteLine("Erro"); break;
				}
			}
		}

		private void MostrarLista()
		{
			foreach (string nome in Nomes)
			{
				Console.WriteLine(nome);
			}
		}

		private void AdicionarNome()
		{
			Console.Write("Digite um nome: ");
			string n = Console.ReadLine();
			Nomes.Add(n);
			Console.Clear();
			Console.WriteLine("Nome adicionado");
			Console.ReadKey();
		}

		private void RemoverNome()
		{
			Console.WriteLine("Digite o nome que deseja Remover");
			string n = Console.ReadLine();

			if (Nomes.Contains(n))
			{
				Nomes.Remove(n);
				Console.WriteLine("Nome Removido");
			}
			else 
			{
				Console.WriteLine();
			}
			Console.ReadKey();
		}

		private void RemoverPosicao()
		{
			int posicao = int.Parse(Console.ReadLine());
			Nomes.RemoveAt(posicao);
			Console.WriteLine("Nome Removido!");
			Console.ReadKey();
		}

		private void LimparLista() 
		{
			Nomes.Clear();
		}

		private void OrdenarLista()
		{
			Nomes.Sort();
		}

		private void InverterLista()
		{
			Nomes.Reverse();
		}

		private void BuscarNome()
		{
			Console.WriteLine("Digite o nome: ");
			string n = Console.ReadLine();

			if (Nomes.Contains(n))
			{
				Console.WriteLine("Esse nome existe");
			}
			else 
			{
				Console.WriteLine("Esse nao nome existe");
			}
		}

		private void BuscarPosicao()
		{
			Console.WriteLine("Digite a posicao: ");
			string n = Console.ReadLine();

			int p = Nomes.IndexOf(n);
			Console.Clear();
			if (p != -1)
			{
				Console.WriteLine($"{n} esta na posicao {p}");
			}
			else
			{
				Console.WriteLine("Posicao inexistente");
			}
			Console.ReadKey();
		}
	}
}
