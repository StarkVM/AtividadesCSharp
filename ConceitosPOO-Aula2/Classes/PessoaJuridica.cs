using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceitosPOO_Aula2.Classes
{
    internal class PessoaJuridica : Cliente
    {
        private int tipoCliente;
        private double valorPacote = 100;

        public override double CalcularDesconto()
        {
            return valorPacote -= 50;
        }

        public override void TipoCliente()
        {
            tipoCliente = 5;
        }

        public override void ExibirDados()
        {
            Console.WriteLine("Tipo: Cliente Pessoa Juridica");
            base.ExibirDados();
        }
    }
}
