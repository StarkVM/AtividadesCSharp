using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceitosPOO_Aula2.Classes
{
    abstract class Cliente
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public int Documento { get; set; }

        public abstract void TipoCliente();
        public abstract double CalcularDesconto();
        public virtual void ExibirDados()
        {
            Console.WriteLine($"Codigo: {Codigo}");
			Console.WriteLine($"Nome: {Nome}");
			Console.WriteLine($"Documento: {Documento}");
			Console.WriteLine($"Valor do Pacote final do pacote: {CalcularDesconto()}");

		}
	}
}
