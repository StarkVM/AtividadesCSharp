using Atividade1Omar.Classes.Superclasses;

namespace Atividade1Omar.Classes.Subclasses;

public class Cavaleiro : Personagem
{
    public string Name { get; private set; }
    public string Classe {get; private set;} = "Cavaleiro";

    public int Forca { get; private set; } = 10;

    public int Mana { get; private set; } = 2;

    public Cavaleiro(string name) : base(name)
    {
        Name = name;
    }

    public override void Pular()
    {
        Console.Write(Name+" Pulando Baixo...");
    }

    public override void Abaixar()
    {
        Console.Write(Name+" Abaixando Lento...");
    }
    public override void Andar()
    {
        Console.Write(Name+" Andando Cuidadoso...");
    }
    public override void Correr()
    {
        Console.Write(Name+" Correndo Duro..");
    }

    public override void Atacar()
    {
        if (Forca > 0)
        {
            Forca--;
            Console.WriteLine($"{Name} Atacou... Forca restante {Forca}");
        }
        else
        {
            Console.Write("Sua forca acabou.");
        }
        
    }
}