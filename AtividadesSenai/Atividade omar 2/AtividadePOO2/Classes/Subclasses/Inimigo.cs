using AtividadePOO2.Classes.Superclasses;

namespace AtividadePOO2.Classes.Subclasses;

public class Inimigo  : Personagem
{
    private double Peso { get; set; }

    public void Rugir()
    {
        Console.Write($"{Nome} Rugiu...");
    }
    public void Morder()
    {
        Console.Write($"{Nome} Mordeu...");
    }

}    