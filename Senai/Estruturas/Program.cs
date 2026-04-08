using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estruturas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pedido> list = new List<Pedido>();

            for (int i = 0; i < 3; i++) 
            {
                Pedido p = new Pedido();

                Console.WriteLine("Digite o codigo do pedido: ");
                p.Codigo = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o nome do cliente: ");
                p.NomeCliente = Console.ReadLine();

				Console.WriteLine("Digite o produto: ");
                p.Produto = Console.ReadLine();

                list.Add(p);
			}

            foreach (var p in list) 
            {
                Console.WriteLine($"- Codigo: {p.Codigo}");
				Console.WriteLine($"- Cliente: {p.NomeCliente}");
				Console.WriteLine($"- Produto: {p.Produto}");
			}
        }
    }
}
