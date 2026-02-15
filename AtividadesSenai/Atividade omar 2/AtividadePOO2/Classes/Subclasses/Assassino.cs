using AtividadePOO2.Classes.Superclasses;

namespace AtividadePOO2.Classes.Subclasses;

public class Assassino : Personagem
{
    public int Furtividade  { get; set; }
    
    public void AtaqueFurtivo()
    {
        Console.WriteLine($"{Nome} Atacou Furtivamente...");
    }
}