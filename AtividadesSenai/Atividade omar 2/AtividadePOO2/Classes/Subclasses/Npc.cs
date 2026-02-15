using AtividadePOO2.Classes.Superclasses;

namespace AtividadePOO2.Classes.Subclasses;

public class Npc  : Personagem
{
    private string _Localizacao { get; set; }

    public Npc(string localizacao)
    {
        _Localizacao = localizacao;
    }

    public void Falar(string nome)
    {
        Console.WriteLine($"Ola {nome}, o que deseja fazer?\n");
    }
    public void Vender()
    {
        Console.Write("Vendeu para voce...");
    }
    public void Comprar()
    {
        Console.Write("Comprou de voce...");
    }
}