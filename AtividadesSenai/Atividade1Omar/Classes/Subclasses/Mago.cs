using Atividade1Omar.Classes.Superclasses;

namespace Atividade1Omar.Classes.Subclasses;

public class Mago : Personagem
{
    public string Name { get; private set; }
    public string Classe {get; private set;} = "Mago";
    public int Forca { get; private set; } = 2;

    public int Mana { get; private set; } = 10;

    public Mago(string name) : base(name)
    {
        Name = name;
    }

    public override void Pular()
    {
        Console.Write(Name+" Pulando Com magia...");
    }

    public override void Abaixar()
    {
        Console.Write(Name+" Abaixando Com cautela...");
    }
    public override void Andar()
    {
        Console.Write(Name+" Andando Com magia...");
    }
    public override void Correr()
    {
        Console.Write(Name+" Correndo Bufado..");
    }
    
    public override void Atacar()
    {
        if (Mana > 0)
        {
            Mana--;
            Console.WriteLine($"{Name} Atacou... Mana restante {Mana}");
        }
        else
        {
            Console.Write("Sua mana acabou.");
        }
        
    }
}