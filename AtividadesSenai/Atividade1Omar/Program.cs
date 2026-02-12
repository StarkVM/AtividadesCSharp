using Atividade1Omar.Classes.Superclasses;
using Atividade1Omar.Classes.Subclasses;

using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
            Console.Clear();
            
            Console.Write("Digite o nome do personagem: ");
            string nome = Console.ReadLine();
            
            Console.Clear();

            var classe = "0";
            while (classe != "1" && classe != "2")
            {
                Console.Write("Escolha uma classe para o personagem 1- Mago 2-Cavaleiro: ");
                classe = Console.ReadLine();
            
                Console.Clear();
            }
            
            Jogar(nome,classe);
    }

    static void Jogar(string nome, string classe)
    {
        Personagem personagem;
        
        if (classe == "1")
        {
            personagem = new Mago(nome);
        }
        else if (classe == "2")
        {
            personagem = new Cavaleiro(nome);
        }
        else
        {
            return;
        }

        while (true)
        {
            Console.Clear();
            
            Console.WriteLine("Digite a acao");
            Console.WriteLine("W - PULAR");
            Console.WriteLine("A - ANDAR");
            Console.WriteLine("S - ABAIXAR");
            Console.WriteLine("D - CORRER");
            Console.WriteLine("E - ATACAR");
            Console.WriteLine("Q - EXIT");
            var escolha = Console.ReadKey();
            
            Console.Clear();

            switch (escolha.Key)
            {
                case ConsoleKey.W:
                    personagem.Pular();
                    Console.ReadKey();
                    break;
                case ConsoleKey.A:
                    personagem.Andar();
                    Console.ReadKey();
                    break;
                case ConsoleKey.S:
                    personagem.Abaixar();
                    Console.ReadKey();
                    break;
                case ConsoleKey.D:
                    personagem.Correr();
                    Console.ReadKey();
                    break;
                case ConsoleKey.E:
                    personagem.Atacar();
                    Console.ReadKey();
                    break;
                case ConsoleKey.Q:
                    Console.Clear();
                    Console.Write("Encerrando...");
                    Console.ReadKey();
                    return; 
                break;
                default:
                    Console.Write("Tente novamente.");
                    Console.ReadKey();
                    break;
                    
            }

        }
        
        
    }
}
