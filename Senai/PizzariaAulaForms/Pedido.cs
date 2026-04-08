using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaAulaForms
{
    internal class Pedido
    {
        public string Nome {get; set;}
        public int Numero {get; set;}
        public string Comanda {get; set;}
        public Pedido(string nome, int numero, string comanda)
        {
            Comanda = comanda;
            Nome = nome;
            Numero = numero;
        }
    }
}
