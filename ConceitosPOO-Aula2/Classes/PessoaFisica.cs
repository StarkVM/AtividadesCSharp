using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceitosPOO_Aula2.Classes
{
    internal class PessoaFisica : Cliente
    {
        private int tipoCliente;
        private string pacote;
        private double valorPacote = 100.0;
        public override double CalcularDesconto()
        {
            if (tipoCliente == 1)
            {
                valorPacote -= 5;
            }
            else if (tipoCliente == 2)
            {
                valorPacote -= 10;
            }
            else
            {
                valorPacote -= 20;
            }

            return valorPacote;
        }

        public override void TipoCliente()
        {
            Console.WriteLine("Selecione o tipo de conta: ");
            Console.WriteLine("1 - Universitaria ");
			Console.WriteLine("2 - Essencial ");
			Console.WriteLine("3 - Prime ");
            Console.Write("Escolha: ");
            tipoCliente = int.Parse(Console.ReadLine());
			switch (tipoCliente)
			{
				case 1:
                    pacote = "Universitario";
                    break;
				case 2:
					pacote = "Essencial";
				    break;
				case 3:
					pacote = "Prime";
			        break;

			}
			Console.Clear();
		}

        public override void ExibirDados()
        {

			Console.WriteLine($"Tipo: Cliente {pacote}");

			base.ExibirDados();

        }
    }
}
