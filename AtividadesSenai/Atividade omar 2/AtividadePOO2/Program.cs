using AtividadePOO2.Classes.Superclasses;
using AtividadePOO2.Classes.Subclasses;

using System;

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
            Console.Write("Escolha uma classe para o personagem 1- Assassino 2-Cavaleiro: ");
            classe = Console.ReadLine();

            Console.Clear();
        }

        Jogar(nome, classe);

    }

    static void Jogar(string nome, string classe)
    {
        Personagem personagem;

        if (classe == "1")
        {
            personagem = new Assassino();
            personagem.Nome = nome;
            personagem.Tipo = "Assassino";
        }
        else
        {
            personagem = new Guerreiro();
            personagem.Nome = nome;
            personagem.Tipo = "Guerreiro";
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
            Console.WriteLine("\n0 - INTERAGIR\n");
            Console.WriteLine("Esc - EXIT");
            var escolha = Console.ReadKey();

            Console.Clear();

            switch (escolha.Key)
            {
                case ConsoleKey.W:
                    personagem.Pular();
                    Console.ReadKey();
                    break;
                case ConsoleKey.A:
                    personagem.Rolar();
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
                case ConsoleKey.D0:
                    MenuInteracao(personagem);
                    break;
                case ConsoleKey.F:
                    Console.Clear();
                    Console.Write("Encerrando...");
                    Console.ReadKey();
                    return;
                default:
                    Console.Write("Tente novamente.");
                    Console.ReadKey();
                    break;

            }

        }

    }

    static void MenuInteracao(Personagem personagem)
    {
        while (true)
        {
            Console.Clear();

            Console.WriteLine("Escolha uma interacao: ");
            Console.WriteLine("1 - NPC");
            Console.WriteLine("2 - INIMIGO");
            Console.WriteLine("3 - NINGUEM");
            var escolha = Console.ReadKey();

            Console.Clear();

            switch (escolha.Key)
            {
                case ConsoleKey.D1:
                    InteragirNpc(personagem);
                    break;
                case ConsoleKey.D2:
                    InteragirInimigo(personagem);
                    break;
                case ConsoleKey.D3:
                    return;
                default:
                    Console.Write("Tente novamente.");
                    Console.ReadKey();
                    break;
            }
        }
    }

    static void InteragirNpc(Personagem personagem)
    {
        Npc npc = new Npc("Konoha");
        
        while (true)
        {
            Console.Clear();
            npc.Falar(personagem.Nome);
            Console.WriteLine("1 - Comprar");
            Console.WriteLine("2 - Vender");
            Console.WriteLine("Esc - EXIT");
            var escolha = Console.ReadKey();
            
            Console.Clear();

            switch (escolha.Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("Boa escolha...");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Tenho otimos precos para voce...");
                    Console.ReadKey();
                    Console.Clear();
                    npc.Comprar();
                    Console.ReadKey();
                    return;
                case ConsoleKey.D2:
                    Console.WriteLine("Boa escolha...");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Tenho otimas ofertas para te oferecer...");
                    Console.ReadKey();
                    Console.Clear();
                    npc.Vender();
                    Console.ReadKey();
                    return;
                case ConsoleKey.F:
                    return;
                default:
                    Console.Write("Tente novamente.");
                    Console.ReadKey();
                    break;
            }
            
        }
    }

    static void InteragirInimigo(Personagem personagem)
    {
        Inimigo inimigo = new Inimigo();
        inimigo.Nome = "Inimigo";
        while (true)
        {
            Console.Clear();

            Console.WriteLine("Digite a acao");
            Console.WriteLine("W - PULAR");
            Console.WriteLine("A - ANDAR");
            Console.WriteLine("S - ABAIXAR");
            Console.WriteLine("D - CORRER");
            Console.WriteLine("E - ATACAR");
            Console.WriteLine("\nQ - ATAQUE INIMIGO\n");
            Console.WriteLine("Esc - FUGIR");
            var escolha = Console.ReadKey();

            Console.Clear();

            switch (escolha.Key)
            {
                case ConsoleKey.W:
                    personagem.Pular();
                    Console.ReadKey();
                    break;
                case ConsoleKey.A:
                    personagem.Rolar();
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
                    inimigo.Atacar();
                    Console.ReadKey();
                    break;
                case ConsoleKey.F:
                    Console.Clear();
                    Console.Write("Fugindo...");
                    Console.ReadKey();
                    return;
                default:
                    Console.Write("Tente novamente.");
                    Console.ReadKey();
                    break;

            }
        }
    }
}
