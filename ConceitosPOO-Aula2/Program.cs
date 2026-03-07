using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ConceitosPOO_Aula2.Classes;

namespace ConceitosPOO_Aula2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica pf = new PessoaFisica();

            pf.Codigo = 123;
            pf.Nome = "Gilmar das Candongas";
            pf.Documento = 171171;

            pf.TipoCliente();
            pf.ExibirDados();

            Console.WriteLine("\n##############################\n");

            PessoaJuridica pj = new PessoaJuridica();
            pj.Codigo = 555;
            pj.Nome = "Carlos Antonio";
            pj.Documento = 111111;
            pj.TipoCliente();
            pj.ExibirDados();

            Console.ReadLine();
        }
    }
}
