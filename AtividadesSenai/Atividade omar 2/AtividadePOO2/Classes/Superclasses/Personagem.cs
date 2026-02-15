namespace AtividadePOO2.Classes.Superclasses;

public class Personagem
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Tipo { get; set; }

    public void Correr()
    {
        Console.WriteLine($"{Nome} Correu...");
    }
    public void Abaixar()
    {
        Console.Write($"{Nome} Abaixou...");
    }
    public void Pular()
    {
        Console.Write($"{Nome} Pulou...");
    }
    public void Rolar()
    {
        Console.Write($"{Nome} Rolou...");
    }
    public void Atacar()
    {
        Console.Write($"{Nome} Atacou...");
    }
    
}