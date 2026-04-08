using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estruturas
{
    internal class Pilha
    {
        private Stack<string> pilha;
        public Pilha()
        {
            pilha = new Stack<string>();
            pilha.Push("Pedido 1");
			pilha.Push("Pedido 2");
			pilha.Push("Pedido 3");
		}

		public void Menu()
		{
			while (true)
			{
				Console.Clear();
				Console.WriteLine("----------------");
				MostrarPilha();
				Console.WriteLine("----------------");

				Console.WriteLine("Escolha:");
				Console.WriteLine("1- Adicionar Pedido(Push)");
				Console.WriteLine("2- Remover Pedido(POP)");
				Console.WriteLine("3- Mostrar Pedido");
				Console.WriteLine("4- Buscar Pedido(CONTAINS)");
				Console.WriteLine("5- Limpar Pilha");
				Console.WriteLine("Opcao:");
				string op = Console.ReadLine();

				Console.Clear();

				switch (op)
				{
					case "1": PushItem(); break;
					case "2": PopItem(); break;
					case "3": PeekItem(); break;
					case "4": ContainsItem(); break;
					case "5": ClearItem(); break;

					default: Console.WriteLine("Erro"); break;
				}
			}
		}

		private void MostrarPilha()
		{
			if (pilha.Count == 0)
			{
				Console.WriteLine("Pilha vazia!");
				return;
			}

			foreach (string item in pilha)
			{
				Console.WriteLine(item);
			}
		}

		private void PopItem()// remove o valor do topo da pilha
		{
			if (pilha.Count > 0)
			{
				string removido = pilha.Pop();
				Console.WriteLine($"Removido: {removido}");
			}
			else 
			{
				Console.WriteLine("Pilha vazia");
			}
		}

		private void PeekItem() // Retorna o valor do topo da pilha
		{
			if (pilha.Count > 0)
			{
				string pedido = pilha.Peek();
				Console.WriteLine($"O item do topo é: {pedido}");
			}
			else
			{
				Console.WriteLine("Pilha vazia");
			}
		}

		private void ContainsItem() 
		{
			Console.WriteLine("Digite um pedido: ");
			string pedido = Console.ReadLine();

			if (pilha.Contains(pedido))
			{
				Console.WriteLine("Esse pedido existe");
			}
			else 
			{
				Console.WriteLine("Esse pedido nao existe");
			}
		}

		private void PushItem()
		{
			Console.Write("Digite um pedido: ");
			string pedido = Console.ReadLine();

			pilha.Push(pedido);
		}

		private void ClearItem()
		{
			pilha.Clear();
		}
	}
}
